
using System;
using System.Collections;

// Tablo verilerini tutan sınıfımız
public class Table
{
    private ArrayList _data = new ArrayList();
    private ICloneable _prototype;

    public void AddRow(string[] rowData)
    {
        _data.Add(rowData);
    }

    public IIterator CreateIterator()
    {
        return new TableIterator(this);
    }

    // Iterator tasarım deseni için gerekli olan arayüz
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }

    // Tablo verilerine erişmek için kullanacağımız iterator sınıfı
    private class TableIterator : IIterator
    {
        private Table _table;
        private int _index = 0;

        public TableIterator(Table table)
        {
            _table = table;
        }

        public bool HasNext()
        {
            return _index < _table._data.Count;
        }

        public object Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException("No more data");
            }

            object data = _table._data[_index];
            _index++;
            return data;
        }
    }
}

// Kullanım örneği
// public class Program
// {
//     public static void Main()
//     {
//         Table table = new Table();
//         table.AddRow(new string[] { "John", "Doe", "30" });
//         table.AddRow(new string[] { "Jane", "Doe", "25" });
//         table.AddRow(new string[] { "Bob", "Smith", "40" });

//         // Iterator oluşturuyoruz
//         Table.IIterator iterator = table.CreateIterator();

//         // Tüm verilere erişiyoruz
//         while (iterator.HasNext())
//         {
//             object data = iterator.Next();
//             Console.WriteLine(string.Join(", ", (string[])data));
//         }
//     }
// }
