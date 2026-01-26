// See https://aka.ms/new-console-template for more information
class Program{
  static void Main(){
        Console.WriteLine("Привет");
        Console.WriteLine("Жанатпаева Динара Мурадымовна");
        Console.WriteLine(DateTime.Now);
        string? text = Console.ReadLine();
        Console.WriteLine($"привет {text}");
        DayOfWeek day = DateTime.Now.DayOfWeek;
        Console.WriteLine(day);
        Console.WriteLine("хотите продолжить? y/n");
        string? w = Console.ReadLine();
        if (w == "y")
    {
      Console.WriteLine("продолжим");
    }
    else if (w == "n")
    {
      Console.WriteLine("удачи");
      
    }

  }
}