// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Draw a stack heap visualization diagram for below code sequences
//Sequence 1
int i1 = 10;
int i2 = i1;
i1 = 20;

//Sequence 2
string s2 = "Hello";
string t2 = s2;
s2 = "Goodbye";

//Sequence 3
int[]  ints3 = { 1,2,3,4,5,6,7,8};
int[] ints4 = ints3;
ints3[0] = 15;


//Sequence 4
stA v1 = new stA() { val = 10};
stA v2 = v1;
v2.val = 20;

csA r1 = new csA() { val = 10};
csA r2 = r1;
r2.val = 20;

//Sequence 5
stA[] stAs = new stA[] { v1, v1, v1};
stAs[0].val = 20;
stAs[1].val = 30;
stAs[2].val = 40;

csA[] csAs = new csA[] { r1, r1, r1};
csAs[0].val = 20;
csAs[1].val = 30;
csAs[2].val = 40;



public struct stA {
    public int val {get; set;}
}
public class csA {
    public int val {get; set;}
}
