// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
string[] firstMassiv = CreateArray();
Console.WriteLine("From an existing array:");
PrintArray(firstMassiv);
Console.WriteLine();
Console.WriteLine("An array in which " +
                "the length of the elements is less than or equal to 3:");
NewArray(firstMassiv);

string[] CreateArray()
{
    Console.WriteLine("Enter the elements of the array separated by a space:");
    string[] array = Console.ReadLine().Split(" ");
    return array;
}
string[] PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    return array;
}
void NewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int size = 3;
        if (array[i].Length <= size)
        {
            Console.Write(array[i] + "\t");
        }
    }
}