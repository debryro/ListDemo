// Week 01 Example Program, Arrays and Lists
// Roger deBry
// Jan 1, 2025

// Declare an array of integers and initialize it with an initializer list
int[ ] sampleData = {2, 4, 6, 8, 10, 12, 14, 16, 18, 20};

// display the values in the array using a foreach loop
Console.WriteLine("Data from the array");
Console.Write("{ ");
foreach (int value in sampleData ) {
    Console.Write($"{value} ");
}
Console.WriteLine("}");

// Declare a dynamic array (List) of integers
List<int> dataList = new List<int>();

// iterate through the array and copy each element into the List
// each now value is added to the end of the List
// use a foreach loop
foreach (int value in sampleData)
{
    dataList.Add(value);
}

// Display the value from the List
// Use a for loop. Notice that we can use [ ] just like an array
// The number of values in the list is in the List property "Count"
Console.WriteLine("\nData from the List");
Console.Write("[ ");
for (int i = 0; i < dataList.Count; i++)
{
    Console.Write($"{dataList[i]} ");
}
Console.WriteLine("]");
