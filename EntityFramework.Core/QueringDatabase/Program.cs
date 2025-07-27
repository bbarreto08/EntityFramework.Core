using QueringDatabase;
using QueringDatabase.Models;

var appDbContext = new AppDbContext();

Console.WriteLine("Starting query");
QueryClients();
Console.WriteLine("Query ended!");

Console.WriteLine("Starting insert");
InsertClient();
Console.WriteLine("Insert ended!");

Console.WriteLine("Starting update");
UpdateClient();
Console.WriteLine("Update ended!");


void QueryClients()
{
    var clients = appDbContext.Client.ToList();

    foreach (var client in clients)
    {
        Console.WriteLine($"Id: {client.ClientId}, Nome: {client.Name}");
    }
}

void InsertClient()
{
    var client = new Client
    {
        Name = "New Client"
    };

    appDbContext.Client.Add(client);
    appDbContext.SaveChanges();
}

void UpdateClient()
{
    var client = appDbContext.Client.FirstOrDefault(c => c.Name == "New Client");
    
    if (client != null)
    {
        client.Name = "Name Updated";
        appDbContext.SaveChanges();
    }
}