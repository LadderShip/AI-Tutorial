// See https://aka.ms/new-console-template for more information
var Result = 0.3; //AI event
var Timer = 0.1;  //AI atomic clock  
while (true)
{
    if (double.TryParse(Console.ReadLine(), out var request))
    {
        if (Timer > 0.9)
        {
            Timer = 0.1;
        }
        Timer += 0.1;
        for (int i = 0; i < Timer * Result; i++)
        {
            Result = Result * request;
        }
    }
    Console.WriteLine(Result);

}
