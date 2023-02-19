// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Please Enter Your Degree");


double degree = double.Parse(Console.ReadLine());



if (degree >= 90)
{
    if (degree <= 100)
    {
        Console.WriteLine("your Grade Is Exllent"); 
    }
       
}
else if (degree >= 70 ) 
{
    if (degree < 90)
    {
      Console.WriteLine("your Grade Is VerryGood");
    }
}
else if (degree < 70)
{
    if (degree >= 50)
    {
       Console.WriteLine("your Grade Is pass");
    }
}
else if (degree < 50)
{
     Console.WriteLine("your Grade Is Fail");

}
Console.ReadKey();


