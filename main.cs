using System;

class MainClass {
  public static void Main (string[] args) {
    int[] celsius = new int[7];
    int[] fahrenheit = new int[7];

    for (int i = 0; i < 7; i++) {
      Console.WriteLine ("Enter temperature in Celsius:");
      int temp = Int32.Parse(Console.ReadLine());
      celsius[i] = temp;
    }

    Console.WriteLine ("Temperature in Fahrenheit:");

    for (int i = 0; i < celsius.Length; i++) {
      int fah = (celsius[i] * (9/5)) + 32;
      fahrenheit[i] = fah;
      Console.WriteLine ("..." + fah);
    }

    int avg = 0;

    for (int i = 0; i < fahrenheit.Length; i++) {
      avg = avg + fahrenheit[i];
    }

    int avgFin = avg/fahrenheit.Length;

    Console.WriteLine ("Average weekly temperature is " + avgFin + " degrees Fahrenheit.");

  }
}