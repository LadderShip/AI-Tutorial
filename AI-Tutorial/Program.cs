// See https://aka.ms/new-console-template for more information
var Result = 0.3; //abstract AI event
var Timer = 10;  //timer  
while (true) 
{
    if (double.TryParse(Console.ReadLine(), out var request))
    {
        Timer++;
        //big data logic here
        Timer %= 10;
        for (int i = 0; i < Timer * Result; i++) //sync
        {
            Result = Result * request;  //updating AI event
        }
    }
    Console.WriteLine(Result);

}
