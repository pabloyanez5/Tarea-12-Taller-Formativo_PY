using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DeberAutomoviles.Models;

namespace DeberAutomoviles.Decorators
{
    public abstract class VehicleDecorator : Vehicle
    {
        protected Vehicle _vehicle;

        protected VehicleDecorator(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public override string GetDescription()
        {
            return _vehicle.GetDescription();
        }
    }
}

