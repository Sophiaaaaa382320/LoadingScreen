int totalsteps = 100;
for(int a=1; a <= 100; a++)
{

    Console.WriteLine($"Loading.. Step {a} of {totalsteps}");
    if (a % 3 == 0)
    {
        Console.WriteLine("Checkpoint reached!");
    }
}
Console.WriteLine("\nDungeon is ready. Enter now!");