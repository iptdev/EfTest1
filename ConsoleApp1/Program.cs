using DataModel;
using EfDataLayer;
using Microsoft.EntityFrameworkCore;

var context = new EfDataLayer.SQLiteDataContext();

Console.WriteLine("Load objects");
var a1 = context.As.Find(1);
var a2 = context.As.Find(2);
Console.WriteLine("a1.X = " + a1.X.ToString());
Console.WriteLine("a2.X = " + a2.X.ToString());

// Fetch pump with its ports
var pump = context.Components.FirstOrDefault(c => c.Name == "Pump");
Console.WriteLine("Pump found: " + pump.Name);
var inlet = pump.Ports.FirstOrDefault(p => p.Name == "Inlet");
Console.WriteLine("Inlet found: " + inlet.Name);
var junction = context.Components.FirstOrDefault(c => c.Name == "Junction");
Console.WriteLine("Junction found: " + junction.Name);
foreach (var port in pump.Ports)
{
    Console.WriteLine("Pump port: " + port.Name);
}
foreach (var port in junction.Ports)
{
    Console.WriteLine("Junction port: " + port.Name);
}