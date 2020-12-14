using System.Collections.Generic;
using System;

namespace Bakery.Pastry.Models
{
  public class Pastry
  {
    private static List<Pastry> _pastryCart = new List<Pastry> {};
    
    public string Name { get; set; }
    public int Quantity { get; set; }
    public int Price { get; private set; }
    public Pastry(string name, int num)
    {
      Name = name;
      Quantity = num;
      Price = 5;
    }

    public static void PastryDefault()
    {
      Pastry crossant = new Pastry("Crossant", 0);
      Pastry baklava = new Pastry("Baklava", 0);
      Pastry danish = new Pastry("Danish", 0);
      _pastryCart.Add(crossant);
      _pastryCart.Add(baklava);
      _pastryCart.Add(danish);
    }
    public static List<Pastry> GetPastry()
    {
      return _pastryCart;
    }

    public static void ClearPastryCart()
    {
      _pastryCart.Clear();
    }

    public static void DisplayPastryList()
    {
      foreach (Pastry element in Pastry._pastryCart)
      {
        if (element.Quantity > 0)
        {
          Console.Write(element.Name + " x " + element.Quantity + ", ");
        }
      }
    }

    public static int PastryCount()
    {
      int total = 0;
      for (int i = 0; i < Pastry._pastryCart.Count; i++)
      {
        total += Pastry._pastryCart[i].Quantity;
      } 
      return total;
    }

    public static int PastryPrice()
    {
      int total = (Pastry.PastryCount() * 2) - ((Pastry.PastryCount() / 3) * 1);
      return total;
    } 

    public static int PastryIndex(string pastryType)
    {
      int index = 0;
      for (int i = 0; i < Pastry._pastryCart.Count; i++)
      {
        if (Pastry._pastryCart[i].Name == pastryType)
        {
          index += i;
        }
      }
        return index;
    }
  }
}
