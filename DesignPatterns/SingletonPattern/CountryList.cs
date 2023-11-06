using SingletonPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern;

public class CountryList
{
    private static CountryList instance = null;
    public static CountryList Instance => instance ??= new CountryList();
    //{
    //    get => instance ?? (instance = new CountryList());
    //}
    private List<Country> Countries { get; set; }

    private CountryList()
    {
        Task.Delay(2000).GetAwaiter().GetResult();
        Countries = new List<Country>()
                {
                    new Country(){Name="Türkiye"},
                    new Country(){Name="Belçika"}
                };
    }
    public List<Country> GetCountries() => Countries;
}
