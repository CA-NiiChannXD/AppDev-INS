using System;
					
public class MyCsharp
{
	public static void Main(string[] args)
	{
		MyCsharp pin = new MyCsharp();
		pin.printName("Clarisse Andal");
	}
	
	public void printName(string name)
	{
		Console.WriteLine("Hello! My name is " + name + "!");
	}
}
