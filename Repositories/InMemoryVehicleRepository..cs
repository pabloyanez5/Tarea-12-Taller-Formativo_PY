using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DeberAutomoviles.Models;
using System.Collections.Generic;
using DeberAutomoviles.Services;

namespace DeberAutomoviles.Repositories
{
    public class InMemoryVehicleRepository : Services.IVehicleRepository
    {
        private readonly List<Vehicle> _vehicles = new();

        public void Add(Vehicle vehicle)
        {
            _vehicles.Add(vehicle);
        }

        public List<Vehicle> GetAll()
        {
            return _vehicles;
        }

        IEnumerable<object> IVehicleRepository.GetAll()
        {
            return GetAll();
        }
    }
}
