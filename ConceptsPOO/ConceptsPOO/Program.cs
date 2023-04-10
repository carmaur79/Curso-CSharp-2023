// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("Mauricio Isaza");
Console.WriteLine("==============");

try
{
	Console.WriteLine(new Date(1979, 11, 30));
	Console.WriteLine(new Date(2024, 2, 29));

}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}