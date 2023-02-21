using EntityFirstDemo.Data;
using EntityFirstDemo.Models;

public class Program
{
    static void Main(string[] args)
    {
        using BoardGamesContext context = new BoardGamesContext();

        Product risk = new Product() { Name = "Risk", Price = 49.99M };
        context.Products.Add(risk);

        Product monopoly = new Product() { Name = "Monopoly", Price = 49.99M };
        context.Products.Add(monopoly);

        Product gameOfLife = new Product() { Name = "Game of Life", Price = 49.99M };
        context.Products.Add(gameOfLife);

        context.SaveChanges();
    }
}
