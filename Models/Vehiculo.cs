using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeberAutomoviles.Models
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public virtual string GetDescription()
        {
            return $"{Brand} {Model} - Color: {Color}";
        }
    }
}
