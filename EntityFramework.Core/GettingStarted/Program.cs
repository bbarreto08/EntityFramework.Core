using GettingStarted;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();
context.Database.OpenConnection();

bool readyToConnect = context.Database.CanConnect();

if(readyToConnect)
{
    Console.WriteLine("Connection to the database was successful.");
}
else
{
    Console.WriteLine("Failed to connect to the database.");
}


Console.ReadKey();