using System;

public class Motorcycle : Vehicle
{
	public Motorcycle()
	{
	}

	public bool HasSideCart { get; set; } = false;

	public override DriveAbstract()
	{
		Console.WriteLine("This Motorcycle is in drive!");
	}
	 public overide DriveVirtual()
	{
		Console.WriteLine($"This {GetType().BaseType.Name}is a{GetType().BaseType.Name} virtually in drive");
	}






}

