Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<MyClass>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var Product = new MyClass();

    Console.WriteLine("Enter the value for ");
    CatFood = Console.ReadLine();

    recordList.Add(Product);
}