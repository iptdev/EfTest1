using DataModel;
using EfDataLayer;

var context = new EfDataLayer.SQLiteDataContext();

Console.WriteLine("Load objects");
var a1 = context.As.Find(1);
var a2 = context.As.Find(2);
Console.WriteLine("a1.X = " + a1.X.ToString());
Console.WriteLine("a2.X = " + a2.X.ToString());
