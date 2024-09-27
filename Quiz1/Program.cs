// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quiz Friday!");

string _var1 = "Hello";
int _var2 = 10;
decimal _var3;
float _var4 = 10F;

_var3 = 23M;

Console.WriteLine("Enter price");
string _sinput = Console.ReadLine();
decimal _dinput = decimal.Parse(_sinput);

_dinput *= 10;
string s = $"The price is {_dinput} Sek";
System.Console.WriteLine(s);


int i = int.MaxValue;
System.Console.WriteLine(i);

i++;
System.Console.WriteLine(i);

i++;
System.Console.WriteLine(i);


//Implicit type casting
int a = 3;
long l = a;
l = int.MaxValue;
System.Console.WriteLine(l);

//Explicit type casting
long b = long.MaxValue;
int c = (int) b;

System.Console.WriteLine(c);


string s1 = "3";
int i1 = int.Parse(s1);