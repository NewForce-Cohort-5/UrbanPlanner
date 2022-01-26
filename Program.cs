using System;
using System.Collections.Generic;

namespace urbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building AkisHouse = new Building("512 8th Avenue")
            {
            Stories = 2,
            Width = 150
            };
            AkisHouse.Depth = 180;

            AkisHouse.Construct();

            AkisHouse.Purchase("Aki Endo");

            // AkisHouse.getInfo();

            Building SarahsHouse = new Building("512 8th Avenue")
            {
            Stories = 1,
            Width = 250
            };
            SarahsHouse.Depth = 360;

            SarahsHouse.Construct();

            SarahsHouse.Purchase("Aki Endo");
            Building AndysHouse = new Building("512 8th Avenue")
            {
            Stories = 6,
            Width = 110
            };
           AndysHouse.Depth = 225;

           AndysHouse.Construct();

           AndysHouse.Purchase("Aki Endo");


            List<Building> Neighborhood = new List<Building>(){
                AkisHouse,
                SarahsHouse,
                AndysHouse
            };

            Console.WriteLine(Neighborhood.Count);

            // foreach ( Building house in Neighborhood)
            // {
            //     house.getInfo();
            // }


            Neighborhood.ForEach(house => house.getInfo());
        }
    }
}
