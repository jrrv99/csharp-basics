using System;

namespace _Custom
{
  abstract class Custom
  {
    public static void clear()
    {
      Console.Clear();
    }

    public static void write(object statement)
    {
      Console.Write (statement);
    }

    public static void writeLine(object statement)
    {
      Console.WriteLine (statement);
    }

    public static void pause(string message)
    {
      write (message);
      Console.ReadLine();
      clear();
    }
  } //abstract class Custom
}
