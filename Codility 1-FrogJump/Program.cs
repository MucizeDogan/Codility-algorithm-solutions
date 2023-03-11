Console.WriteLine("X değerini giriniz: ");
decimal location = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Y değerini giriniz: ");
decimal distance = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Enter the value of D: ");
decimal jump = Convert.ToDecimal(Console.ReadLine());
if (location < 1000000000 && distance < 1000000000 && jump < 1000000000)
{
    if (location > distance)
    {
        Console.WriteLine("Must be greater than X'Y !!!");
    }
    else
    {
        decimal numberOfJumps = Math.Ceiling((distance - location) / d);
        Console.WriteLine("Total number of skips= " + numberOfJumps);
    }

}
else
{
    Console.WriteLine("Please enter a value less than 1000000000");
}