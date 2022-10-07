﻿using System;

public abstract class Vehicle
{
	public int Year { get; set; } = 1;
	public string Make { get; set; } = "Default Make";
	public string Model { get; set; } = "Default Mode";

	public abstract void DriveAbstract();

	public virtual void DriveVirtual()
	{
		Console.WriteLine($"This {GetType() .Name} is virtually in drive");
	}
	
	
	
	


	
}
