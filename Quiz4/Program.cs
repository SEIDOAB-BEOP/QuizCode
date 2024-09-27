namespace Quiz4;

class Program
{
    #region Question 3
    struct structB
    {
        public static int myStaticInt;
        public int myInt;
    }
    #endregion

    #region Question 8
    public struct stA
    {
        public int myVal; 
    }
    public class csA
    {
        public int myVal;
    }
    #endregion

    static void Main(string[] args)
    {   
        #region Question 1
        Console.WriteLine("\nQuestion 1");
        int[] my_ints = { 7, 8, 55, -1, 0, 9, 7 };

        int _maxVal = int.MinValue; //if you do not know first value
        //int _maxVal = my_ints[0]; //if you know the first value
        for (int i = 0; i < my_ints.Length; i++)
        {
            if (my_ints[i] > _maxVal)
            {
                _maxVal = my_ints[i];
            }
        }
        Console.WriteLine($"Largest int: {_maxVal}");
        #endregion

        #region Question 3
        Console.WriteLine("\nQuestion 3");

        structB sb1 = new structB { myInt = 8 };
        structB sb2 = new structB { myInt = 10 };
        structB.myStaticInt = sb1.myInt + sb2.myInt;

        Console.WriteLine(sb1.myInt);
        Console.WriteLine(sb2.myInt);
        Console.WriteLine(structB.myStaticInt);

        sb2.myInt = 15;
        Console.WriteLine(sb2.myInt);
        Console.WriteLine(structB.myStaticInt);

        #endregion

        #region Question 4
        Console.WriteLine("\nQuestion 4");
        int? myInt = null;

        var anotherInt = myInt ?? 10;
        Console.WriteLine(anotherInt);

        myInt = 5;
        anotherInt = myInt ?? 10;
        Console.WriteLine(anotherInt);
        #endregion

        #region Question 5
        Console.WriteLine("\nQuestion 5");
        string myString = "3 30 50 Hello 65 80";
        string[] myStringArray = myString.Split(' ');

        int?[] myIntArray = new int?[6];
        List<int?> myIntList = new List<int?>();

        int n = 0;
        foreach (var item in myStringArray)
        {
            int temp;
            if (int.TryParse(item, out temp))
            {
                myIntList.Add(temp);

                myIntArray[n] = temp;
                n++;
            }
        }

        foreach (var item in myIntArray)
        {
            Console.Write($"{item,4}");
        }

        foreach (var item in myIntList)
        {
            Console.Write($"{item,4}");
        }
        #endregion

        #region Question 6

        Console.WriteLine("\nQuestion 6");
        int aNumber = 30;
        aNumber = AddFive(aNumber);

        Console.WriteLine(aNumber);
        Console.WriteLine(aNumber);

        #endregion

        #region Question 7
        Console.WriteLine("\nQuestion 7");
        int[][] matrix1 = { new int[] {5,10,-2,13},
                            new int[] {42,15,46,17,-8,-9},    
                            new int[] {100,131}};

        int[,] matrix2 =  {{5,-1,12},         
                           {32,24,15},
                           {61,72,18}};

        //matrix1
        for (int row = 0; row < matrix1.Length; row++)
        {
            for (int col = 0; col < matrix1[row].Length; col++)
            {
                Console.Write($"{matrix1[row][col]}, ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");

        //matrix2
        for (int row = 0; row < matrix2.GetLength(0); row++)
        {
            for (int col = 0; col < matrix2.GetLength(1); col++)
            {
                Console.Write($"{matrix2[row,col]}, ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Question 8
        Console.WriteLine("\nQuestion 8");
        var a = new stA();
        a.myVal = 10;

        var b = a;
        b.myVal = 20;

        Console.WriteLine(a.myVal);
        Console.WriteLine(b.myVal);

        var c = new csA();
        c.myVal = 10;

        var d = c;
        d.myVal = 20;

        Console.WriteLine(c.myVal);
        Console.WriteLine(d.myVal);
        #endregion

        #region Question 9
        Console.WriteLine("\nQuestion 9");
        var e = new stA();
        e.myVal = 5;
        AddFive_st(e);
        Console.WriteLine(e.myVal);

        var f = new csA();
        f.myVal = 5;
        AddFive_cs(f);
        Console.WriteLine(f.myVal);
        #endregion

    }

    #region Question 6
    public static int AddFive(int aNumber)
    {
        aNumber += 5;
        return aNumber;
    }
    #endregion


    #region Question 9
    public static void AddFive_st(stA aStructParameter)
    {
        aStructParameter.myVal += 5;
    }
    public static void AddFive_cs(csA aClassParameter)
    {
        aClassParameter.myVal += 5;
    }

    #endregion
}

