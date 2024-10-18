#region Question 2
Console.WriteLine("\nQuestion 2");
int a = 1;
int[] array = { 1, 1 };
int b = 1;

MethodA(a, array, out b);

Console.WriteLine($"a: {a}, array[0]: {array[0]}, b: {b}");
#endregion

#region Question 4
Console.WriteLine("\nQuestion 4");
int[] myarray1 = null;
int[] myarray2 = new int[10];
int[] myarray3 = new int[] { 1, 2, 3, 4, 5 };
int[] myarray4 = { 6, 5, 8, 9 };

//Console.WriteLine($"{myarray1?.Length} {myarray1?[0]}");
Console.WriteLine($"{myarray1.Length} {myarray1[0]}");
Console.WriteLine($"{myarray2.Length} {myarray2[0]}");
Console.WriteLine($"{myarray3.Length} {myarray3[0]}");
Console.WriteLine($"{myarray4.Length} {myarray4[0]}");
#endregion

#region Question 5
Console.WriteLine("\nQuestion 5");
var myStruct = new StructA();
#endregion



#region Question 2
static void MethodA(int a, int[] array, out int b)
{
    a = 2;
    array[0] = 2;
    b = 2;
}
#endregion

#region Question 5
public struct StructA
{
    DateTime aTime;
}
#endregion
