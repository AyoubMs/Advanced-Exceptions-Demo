



using ConsoleUI;
string name = "";
try
{
    ConsoleUIMethods.DifferentMethod();
    Console.Write("What is your name: ");
    name = Console.ReadLine();
    ConsoleUIMethods.ComplexMethod(name);
    ConsoleUIMethods.SimpleMethod();
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("You should not be calling these methods.");
    Console.WriteLine(ex.Message);
}
catch (NotImplementedException)
{
    Console.WriteLine("You forgot to finish your code!!!");
}
catch (Exception ex) when (name.ToLower() == "tim")
{
    Console.WriteLine("You used Tim's name, didn't you?");
    Console.WriteLine(ex.Message);
    //Environment.Exit(1);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    //Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("I always run");
}

Console.ReadLine();