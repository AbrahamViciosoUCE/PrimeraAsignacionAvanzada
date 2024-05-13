Console.Write("Ingresa el numero que deseas: ");

if (int.TryParse(Console.ReadLine(), out int multiplicador))
{
    for (int i = 1; i <= 12; i++)
    {
        Console.WriteLine($"{i} x {multiplicador} = {i * multiplicador}");
    }
}
else
{
    Console.WriteLine("Error de conversion");
}