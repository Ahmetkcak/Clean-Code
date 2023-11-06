#region Explanation
//**Pros
//-Ensure single instance(can be use memory caching)
//-Global access
//-Created only when requested

//**Cons
//-Difficult to UnitTest(mocking)
//-In multithreading word, threads cannot create its own instance
#endregion


using SingletonPattern;

Console.WriteLine(DateTime.Now.ToLongTimeString());
var countryList = CountryList.Instance.GetCountries();
foreach (var country in countryList)
{
    Console.WriteLine(country.Name);
}

//Another service
var countryList1 = CountryList.Instance.GetCountries();
Console.WriteLine(DateTime.Now.ToLongTimeString());