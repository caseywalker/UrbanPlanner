using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner
{
  class Building
  {
    public int Stories { get; set; }
    public double Width { get; set; }
    public double Depth { get; set; }
    public double Volume { get; private set; } 

    private string _designer;
    private DateTime _dateConstructed;
    private string _address;
    private string _owner;

    public Building(string address, int stories = 1, double width = 1, double depth = 1)
    {
      _address = address;
      Stories = stories;
      Width = width;
      Depth = depth;
      Volume = Width * Depth * (3 * Stories);
    }

    public void Test()
    {
      Console.WriteLine(Volume);
    }

    public void GetVolume()
    {
      Volume = Width * Depth * (3 * Stories);
    }

    public void Construct()
    {
      _dateConstructed = DateTime.Now;
      _designer = "C.W Inc";
    }
    
    public void Purchase(string name)
    {
      _owner = name;
      Console.WriteLine($"{_address}--------------------");
      Console.WriteLine($"Designed by {_designer}");
      Console.WriteLine($"Constructed on {_dateConstructed}");
      Console.WriteLine($"Owned by {name}");
      Console.WriteLine($"{Volume} cubic meters of space");
    }

  }
}
