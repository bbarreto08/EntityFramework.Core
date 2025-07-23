using QueringDatabase;

var appDbContext = new AppDbContext();

var clients = appDbContext.Client.ToList();

foreach (var client in clients)
{
    Console.WriteLine($"Id: {client.ClientId}, Nome: {client.Name}");
}

Console.ReadLine();