using System;

public class Motorcycle : Vehicle
{
	public Motorcycle()
	{
	}

	public bool HasSideCart { get; set; } = false;
	public bool HasTrunk { get; set; } = false;

	public override void DriveAbstract()
	{
		Console.WriteLine("This Motorcycle is in drive!");
	}
	 public override void DriveVirtual()
	{
		Console.WriteLine($"This {GetType().BaseType.Name}is a{GetType().BaseType.Name} virtually in drive");
	}






}

