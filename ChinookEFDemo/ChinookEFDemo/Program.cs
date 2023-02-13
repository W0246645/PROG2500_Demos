// See https://aka.ms/new-console-template for more information
using ChinookEFDemo;
using ChinookEFDemo.Models;


//Customer cust = new Customer();

//cust.FirstName = "Matt";
//cust.LastName = "Covey";
//cust.Email = "email@email.com";

using ChinookContext context = new ChinookContext();
//context.Add(cust);
//context.SaveChanges();

foreach (Customer c in context.Customers)
{
    Console.WriteLine(c.FirstAndLastName);
}
