using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DeberAutomoviles.Decorators;
using DeberAutomoviles.Factories;
using DeberAutomoviles.Models;
using DeberAutomoviles.Repositories;

namespace DeberAutomoviles.Services
{
    public class VehicleService
    {
        private readonly IVehicleRepository _repository;

        public VehicleService(IVehicleRepository repository)
        {
            _repository = repository;
        }

        public void AddVehicle(IVehicleFactory factory)
        {
            var vehicle = factory.CreateVehicle();
            vehicle = new DefaultPropertiesDecorator(vehicle);
            _repository.Add(vehicle);
        }
    }

    public interface IVehicleRepository
    {
        void Add(Vehicle vehicle);
        IEnumerable<object> GetAll();
    }
}
