
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Q1");

int i = 3;
string s = "hello";
//string s1 = 5;
string s1 = "5";

Console.WriteLine("Q2");
string s2 = $"varible i: {i} s: {s}";
System.Console.WriteLine(s2);

stA a1 = new stA() { val = 10};
System.Console.WriteLine($"varible a1: {a1}");

Console.WriteLine("Q3");
if (a1.val == 3)
{
    System.Console.WriteLine("Yes");
}
else if (a1.val == 5) 
{
    System.Console.WriteLine("Alright");
}
else if (a1.val == 7) 
{
    System.Console.WriteLine("Perfect");
}
else
{
    System.Console.WriteLine("No");
}

//System.Console.WriteLine("No");

Console.WriteLine("Q4");
string[] strings= { "Max", "Charlie", "Cooper", "Milo", "Rocky", "Wanda"};
string s3 = strings[3];
System.Console.WriteLine(s3);

foreach (var item in strings.Reverse())
{
    System.Console.Write($"{item,-10}");
}

System.Console.WriteLine();
for (int k = 0; k < strings.Length; k++)
{
    System.Console.Write($"{strings[k],-10}");
}


Console.WriteLine("\n\nQ5");
for (enSeasons l = enSeasons.Winter; l <= enSeasons.Fall; l++)
{
    System.Console.Write($"{l,-10}");
}
System.Console.WriteLine();
foreach (var item in typeof(enSeasons).GetEnumValues())
{
    System.Console.Write($"{item,-10}");
}


Console.WriteLine("\n\nQ6");

System.Console.WriteLine("Value type");
stA v1 = new stA() { val = 10};
stA v2 = v1;
v2.val = 20;
System.Console.WriteLine($"v1.val: {v1.val}\tv2.val: {v2.val}");

System.Console.WriteLine("Reference type");
csA r1 = new csA() { val = 10};
csA r2 = r1;
r2.val = 20;
System.Console.WriteLine($"r1.val: {r1.val}\tr2.val: {r2.val}");

Console.WriteLine("\n\nQ7");
{
    int n = 5;
    {        
        int m = 10;
        System.Console.WriteLine(n);
        System.Console.WriteLine(m);        
        {
            int o = 20;
            System.Console.WriteLine(n);
            System.Console.WriteLine(m);        
            System.Console.WriteLine(o);        
        }

        System.Console.WriteLine(n);
        System.Console.WriteLine(m);        
        //System.Console.WriteLine(o);        
    }

    System.Console.WriteLine(n);
//    System.Console.WriteLine(m);        
//    System.Console.WriteLine(o);        
}

Console.WriteLine("\n\nQ8");
string[] _petnames= { "Max", "Charlie", "Cooper", "Milo", "Rocky", "Wanda"};
for (int o = 0; o < _petnames.Length; o++)
{
    if (o == 3 || o == 5)
    {
        System.Console.WriteLine(_petnames[o]);
    }
}





public struct stA {
    public int val {get; set;}

    public override string ToString() {return $"val: {val}";}
}
public class csA {
    public int val {get; set;}

    public override string ToString() {return $"val: {val}";}
}

public enum enSeasons {Winter=1, Spring, Summer, Fall}


