using System;

class Program {
private static double CM_IN_INCH = 2.54;
  
  public static void Main (string[] args) {
    int inches; 

    inches = 15994;


    Console.WriteLine(inches + " inches");
    Console.WriteLine(inches * CM_IN_INCH + " centimeters");

  }
}