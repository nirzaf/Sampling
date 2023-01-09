// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

using static System.Console;

using static Sampling.RequestNumberHelper;

WriteLine("Printing random strings!");

var sw = Stopwatch.StartNew();

for (int i = 0; i < 1000; i++)
{
  WriteLine(RandomPassword());
}

sw.Stop();

WriteLine($"Elapsed: {sw.ElapsedTicks} ticks");

//Average Time taken per random password 

WriteLine( $"Average Time taken per random password: {sw.ElapsedTicks / 1000} ticks");

ReadLine();

/*
var student1 = new Student
{
  Name = "Jon"
};

var student2 = new Student
{
  Name = "Jon"
};

WriteLine(student1.Equals(student2) ? "Both objects are equal" : "Both objects are not equal");

public class Student
{
  public string Name { get; set; }
}
*/
