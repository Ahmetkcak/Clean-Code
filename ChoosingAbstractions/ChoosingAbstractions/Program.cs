//Interface -> Aggreement:Sözleşme - CanAbleTo:Yapabilme
//Interace içine static metot yazılabilir

using ChoosingAbstractions;

var sqlDb = new SqlServerDb();
sqlDb.ExecuteSql("");

//var baseDb = new BaseDb();

var car = new Car();
car.Go();
car.Stop();