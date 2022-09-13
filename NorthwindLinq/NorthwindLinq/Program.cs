using NorthwindLinq.Models;


NorthwindContext _context = new NorthwindContext();

var orderTotal = (from o in _context.Orders
             join od in _context.OrderDetails
                on o.OrderId equals od.OrderId
             join p in _context.Products
                on od.ProductId equals p.ProductId
             group new {o, od, p} by o.OrderId into grp
             orderby grp.Key
             select new
             {
                 OrderId = grp.Key,
                 OrderTotal = grp.Sum(x => x.od.Quantity * x.p.UnitPrice)
             }).Sum(x=>x.OrderTotal);

//foreach (var o in orders)
//{
//    Console.WriteLine($"{o.OrderId} | {o.OrderTotal,10:C}");
//}

Console.WriteLine($"Total for all orders is: {orderTotal:C}");


/*
var suppliers = from supp in _context.Suppliers
                join prod in _context.Products
                on supp.SupplierId equals prod.SupplierId
                orderby supp.CompanyName, supp.Country
                select new { Supplier = supp.CompanyName, 
                             Product = prod.ProductName,
                             Price = prod.UnitPrice,
                             Units = prod.UnitsInStock,
                             InventoryCost = prod.UnitPrice * prod.UnitsInStock
                };



foreach (var s in suppliers)
{
    Console.WriteLine($" {s.Supplier,-40} | {s.Product,-30} | {s.InventoryCost:C}"); 
}

Console.WriteLine($"Total Inventory Cost : {suppliers.Sum(s => s.InventoryCost),20:C} ");
Console.WriteLine("Northwind with LINQ!");

NorthwindContext _context = new NorthwindContext();

var products = _context.Products.ToList();

products.ForEach(p => Console.WriteLine(p));


var employees = from empl in _context.Employees
                where !empl.Country.ToUpper().Equals("USA".ToUpper())
                orderby empl.LastName
                select empl;

foreach (Employee e in employees)
{
    Console.WriteLine($"{e.EmployeeId} {e.TitleOfCourtesy} {e.FirstName} {e.LastName} | {e.Country}");
}
*/
