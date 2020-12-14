using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    private static List<Bread> _breadCart = new List<Bread> {};
    
    public string Name { get; set; }
    public int Quantity { get; set; }
    public int Price { get; private set; }
    public Bread(string name, int num)
    {
      Name = name;
      Quantity = num;
      Price = 5;
    }

    public static void BreadDefault()
    {
      Bread rye = new Bread("rye", 0);
      Bread wheat = new Bread("wheat", 0);
      Bread gf = new Bread("gf", 0);
      _breadCart.Add(rye);
      _breadCart.Add(wheat);
      _breadCart.Add(gf);
    }
    public static List<Bread> GetBread()
    {
      return _breadCart;
    }

    public static void ClearBreadCart()
    {
      _breadCart.Clear();
    }

    public static void DisplayBreadList()
    {
      foreach (Bread item in Bread._breadCart)
      {
        Console.Write(item.Name + " " + "$" + item.Price + ", ");
      }
    }

    public static int BreadCount()
    {
      int total = 0;
      for (int i = 0; i < Bread._breadCart.Count; i++)
      {
        total += Bread._breadCart[i].Quantity;
      } 
      return total;
    }

    public static int BreadPrice()
    {
      int total = (Bread.BreadCount() * 5) - ((Bread.BreadCount() / 3) * 5);
      return total;
    } 
  }
}

// public static int BreadPrice()
//     {
//       int total = (Bread.BreadCount() * 5);
//       if (Bread.BreadCount() % 3 == 0)
//       {
//         total -= (Bread.BreadCount() / 3) * 5;
//       }
//       else
//       {
//         total 
//       }
//       return total;
//     }