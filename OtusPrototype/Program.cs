// See https://aka.ms/new-console-template for more information
using OtusPrototype.Classes;

ElectricCar original = new ElectricCar(1, "Prius", 300, BaseEntity.FuelType.Gasoline, 5, 600, 100, 500);

ElectricCar cloned = (ElectricCar)original.Clone();

Console.WriteLine("Original:");
Console.WriteLine($"Id: {original.Id}, " +
    $"Name: {original.Name}, " +
    $"MaxSpeed: {original.MaxSpeed}, " +
    $"FuelType: {original.FuelType}, " +
    $"NumberOfDoors: {original.NumberOfDoors}, " +
    $"TrunkSize: {original.CarTrunkSize}, " +
    $"BatteryCapacity: {original.BatteryCapacity}, " +
    $"Range: {original.DistanceRange}");

Console.WriteLine("Cloned:");
Console.WriteLine($"Id: {cloned.Id}, " +
    $"Name: {cloned.Name}, " +
    $"MaxSpeed: {cloned.MaxSpeed}, " +
    $"FuelType: {cloned.FuelType}, " +
    $"NumberOfDoors: {cloned.NumberOfDoors}, " +
    $"TrunkSize: {cloned.CarTrunkSize}, " +
    $"BatteryCapacity: {cloned.BatteryCapacity}, " +
    $"Range: {cloned.DistanceRange}");

