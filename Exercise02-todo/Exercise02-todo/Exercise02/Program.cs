
using Exercise02;

List<Product> itemlist = new List<Product>
            {
           new Product { Id = 1,  Name = "Biscuit  " },
           new Product { Id = 2,  Name = "Chocolate" },
           new Product { Id = 3,  Name = "Butter   " },
           new Product { Id = 4,  Name = "Brade    " },
           new Product { Id = 5,  Name = "Honey    " }
            };

List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvoiceNo=100, ProductId = 3,  Quantity = 800 },
           new Purchase { InvoiceNo=101, ProductId = 5,  Quantity = 650 },
           new Purchase { InvoiceNo=102, ProductId = 3,  Quantity = 900 },
           new Purchase { InvoiceNo=103, ProductId = 4,  Quantity = 700 },
           new Purchase { InvoiceNo=104, ProductId = 3,  Quantity = 900 },
           new Purchase { InvoiceNo=105, ProductId = 4,  Quantity = 650 },
           new Purchase { InvoiceNo=106, ProductId = 1,  Quantity = 458 }
            };

Console.Write("\nSample : Generate a Right Join between two data sets : \n");
Console.Write("\n--------------------------------------------------\n");

Console.Write("Here is the Product List :\n ");

itemlist.ForEach(i => Console.WriteLine($"\nProduct Id: {i.Id}   Product Name: {i.Name}\n"));
Console.WriteLine("-------------------------------------------------------");

Console.Write("\nHere is the Purchase List :\n");

purchlist.ForEach(p => Console.WriteLine($"\ninvoiceNO: {p.InvoiceNo}   productId: {p.ProductId}   quantity: {p.Quantity} \n"));
Console.WriteLine("-------------------------------------------------------");


Console.Write("\nHere is the list after joining  : \n\n");


var joinList = itemlist.Join(purchlist, t => t.Id, i => i.ProductId, (t, i) => new
{
    t.Id,
    t.Name,
    i.Quantity
}).ToList();

Console.WriteLine("Product ID\tProduct Name\tPurchase Quantity");
Console.WriteLine("-------------------------------------------------------");

joinList.ForEach(item => Console.WriteLine($"{item.Id}\t\t{item.Name}\t\t{item.Quantity}\n"));

Console.ReadLine();


//Thanks to you