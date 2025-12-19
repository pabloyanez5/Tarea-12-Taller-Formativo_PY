using DeberAutomoviles.Factories;
using DeberAutomoviles.Repositories;
using DeberAutomoviles.Services;
using DeberAutomoviles.Models; // Asegúrate de que este using apunte al namespace donde está IVehicle

IVehicleRepository repository = new InMemoryVehicleRepository();
VehicleService service = new VehicleService(repository);

service.AddVehicle(new MustangFactory());
service.AddVehicle(new ExplorerFactory());
service.AddVehicle(new EscapeFactory());

foreach (var vehicle in repository.GetAll().Cast<IVehicle>())
{
    Console.WriteLine(vehicle.GetDescription());
}

Console.ReadLine();
