using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DeberAutomoviles.Models;

namespace DeberAutomoviles.Factories
{
    public class MustangFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle()
        {
            return new Mustang();
        }
    }
}
