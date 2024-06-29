// See https://aka.ms/new-console-template for more information
var Result = 0.3; //AI event
var Timer = 10;  //AI atomic clock  
while (true)
{
    if (double.TryParse(Console.ReadLine(), out var request))
    {
        Timer++;
        Timer %= 10;
        for (int i = 0; i < Timer * Result; i++) //sync time and events
        {
            Result = Result * request;
        }
    }
    Console.WriteLine(Result);

}
