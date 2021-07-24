using System;

namespace UrbanPlanner
{

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Urban Planner");
      var buildingOne = new Building("902 Wildrose", 1, 100, 80);
      var buildingTwo = new Building("505 Main", 3, 200, 60);
      var buildingThree = new Building("2 Broad", 2, 100, 40);
      var buildingFour = new Building("501 Commerce", 10, 250, 100);

      buildingOne.Construct();
      buildingTwo.Construct();
      buildingThree.Construct();
      buildingFour.Construct();

      buildingOne.Purchase("Casey");
      buildingTwo.Purchase("Ryder");
      buildingThree.Purchase("Tiny");
      buildingFour.Purchase("Mike");

      
    }
  }
}
