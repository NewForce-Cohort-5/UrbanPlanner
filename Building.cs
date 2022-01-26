using System;

namespace urbanPlanner
{
    public class Building
    {
        public Building(string addressParam)
        {
            _address = addressParam;
        }
        public void Address(string addressParam2)
        {
            _address = addressParam2;
        }
        private string _designer = "T Spur and Associates";
        private string _address { get; set; }
        private string _owner { get; set; }
        private DateTime _dateConstructed { get; set; }

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string ownerParam)
        {
            _owner = ownerParam;
        }

        public void getInfo()
        {
            Console.WriteLine(_address);
            Console.WriteLine("-------------");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"{_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }

    }
}