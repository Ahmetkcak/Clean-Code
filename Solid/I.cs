#region Not Interface Segregation Principle
public class NotJane : INotLiskovTeacher
{
    public void English()
    {
        Console.WriteLine("Jane is teaching English");
    }

    public void Biology()
    {
        Console.WriteLine("Jane is teaching Biology");
    }

    public void Chemistry()
    {
        Console.WriteLine("Jane is teaching Chemistry");
    }

    public void Mathematics()
    {
        Console.WriteLine("Jane is teaching Mathematics");
    }
}
#endregion

#region Interface Segregation Principle

public class Jane : IEnglishTeacher
{
    public void English()
    {
        Console.WriteLine("Jane is teaching English");
    }

    public void Teach()
    {
        Console.WriteLine("Jane is teaching");
    }
}
#endregion


/*
*  Liskov ikame prensibi ile arayüz ayrıştırma prensibini karıştırmayın.
   Benzer görünebilirler ancak tamamen aynı değildirler.

*  Liskov ikame ilkesi bize yeni bir sınıfın mevcut bir sınıfı miras alma ihtiyacı duyduğunda
   bunu yapması gerektiği fikrini verir
   çünkü bu yeni sınıfın mevcut sınıfın sahip olduğu yöntemlere ihtiyacı vardır.

*  Öte yandan, arayüz ayrımı ilkesi, çok sayıda yöntem içeren bir arayüz oluşturmanın
   gereksiz ve mantıksız olduğunu anlamamızı sağlar,
   çünkü bu yöntemlerden bazıları genişletildiğinde belirli bir kullanıcının ihtiyaçlarıyla ilgisiz olabilir.
  

  ? İkisindeki ortak nokta Interface oluşturmak ama interface'i
  ! hangi zaman ve ne amaçla oluşturmamız gerektiği asıl ayrım noktasıdır.
*/
