using DataModel;
using EfDataLayer;

var context = new EfDataLayer.SQLiteDataContext();
context.Database.EnsureDeleted();
context.Database.EnsureCreated();

Console.WriteLine("Create objects");
var b = new B() { x = 10 };
var r = new R() { Value = 80 };
var c = new C() { X = 20, R = r };

var pump = new ComponentClass() { Id = Guid.NewGuid(), Name = "Pump" };
var inlet = new ComponentClassPort()
{ 
    Id = Guid.NewGuid(), Name = "Inlet", 
    Component = pump, ComponentId = pump.Id
};


// ComponentClass with no ports
var junction = new ComponentClass() { Id = Guid.NewGuid(), Name = "Junction" };

context.Add(b);
context.Add(c);
context.Add(r);
context.Add(junction);
context.Add(pump);
pump.Ports.Add(inlet);

Console.WriteLine("C.X = " + c.X.ToString());
context.SaveChanges();
c.X = 30;
r.Value = 90;
Console.WriteLine("After changes");
context.SaveChanges();
Console.WriteLine("C.X = " + c.X.ToString());

context.SaveChanges();


