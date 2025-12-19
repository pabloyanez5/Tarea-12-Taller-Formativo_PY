using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DeberAutomoviles.Models;

namespace DeberAutomoviles.Decorators
{
    public class DefaultPropertiesDecorator : VehicleDecorator
    {
        public int Year { get; set; }

        public DefaultPropertiesDecorator(Vehicle vehicle) : base(vehicle)
        {
            Year = DateTime.Now.Year;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} - Year: {Year}";
        }
    }
}
