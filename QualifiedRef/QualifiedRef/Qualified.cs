namespace QualifiedRef
{
	using System;

	public enum VehicleType
	{
		Land,
		Air
	}

	public enum FuelType
	{
		Gasoline,
		Diesel,
		LPG,
		Electricity,
		JetFuel
	}

	public abstract class Vehicle
	{
		protected string Brand { get; set; }
		protected string Model { get; set; }

		protected Vehicle(string brand, string model)
		{
			Brand = brand;
			Model = model;
		}

		public abstract VehicleType GetVehicleType();
		public abstract int GetVehicleRange(FuelType fuelType, int amount);

		public string GetDescription()
		{
			return $"This is {Brand} {Model} which moves on {GetVehicleType()}";
		}
	}

	public abstract class Car : Vehicle
	{
		protected Car(string brand, string model) : base(brand, model)
		{
		}

		public sealed override VehicleType GetVehicleType()
		{
			return VehicleType.Land;
		}
	}

	public abstract class Aircraft : Vehicle
	{
		protected Aircraft(string brand, string model) : base(brand, model)
		{
		}

		public sealed override VehicleType GetVehicleType()
		{
			return VehicleType.Air;
		}
	}

	public class GasolineCar : Car
	{
		private const int GasolineEfficiency = 15;
		private const int LPGEfficiency = 20;

		public GasolineCar(string brand, string model) : base(brand, model)
		{
		}

		public override int GetVehicleRange(FuelType fuelType, int amount)
		{
			switch (fuelType)
			{
				case FuelType.Gasoline:
					return amount * GasolineEfficiency;
				case FuelType.LPG:
					return amount * LPGEfficiency;
				default:
					throw new ArgumentOutOfRangeException(nameof(fuelType), "Invalid fuel type for GasolineCar.");
			}
		}
	}

	public class DieselCar : Car
	{
		private const int DieselEfficiency = 30;

		public DieselCar(string brand, string model) : base(brand, model)
		{
		}

		public override int GetVehicleRange(FuelType fuelType, int amount)
		{
			if (fuelType != FuelType.Diesel)
			{
				throw new ArgumentOutOfRangeException(nameof(fuelType), "Invalid fuel type for DieselCar.");
			}

			return amount * DieselEfficiency;
		}
	}

	public class ElectricCar : Car
	{
		private const int ElectricityEfficiency = 50;

		public ElectricCar(string brand, string model) : base(brand, model)
		{
		}

		public override int GetVehicleRange(FuelType fuelType, int amount)
		{
			if (fuelType != FuelType.Electricity)
			{
				throw new ArgumentOutOfRangeException(nameof(fuelType), "Invalid fuel type for ElectricCar.");
			}

			return amount * ElectricityEfficiency;
		}
	}

	public class Helicopter : Aircraft
	{
		private const int JetFuelEfficiency = 75;

		public Helicopter(string brand, string model) : base(brand, model)
		{
		}

		public override int GetVehicleRange(FuelType fuelType, int amount)
		{
			if (fuelType != FuelType.JetFuel)
			{
				throw new ArgumentOutOfRangeException(nameof(fuelType), "Invalid fuel type for Helicopter.");
			}

			return amount * JetFuelEfficiency;
		}
	}

	public class Airplane : Aircraft
	{
		private const int JetFuelEfficiency = 100;

		public Airplane(string brand, string model) : base(brand, model)
		{
		}
		public override int GetVehicleRange(FuelType fuelType, int amount)
		{
			if (fuelType != FuelType.JetFuel)
			{
				throw new ArgumentOutOfRangeException(nameof(fuelType), "Invalid fuel type for Airplane.");
			}
			return amount * JetFuelEfficiency;
		}
	}
}