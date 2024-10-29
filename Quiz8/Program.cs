namespace Quiz8;

class Program
{
    #region Question 6 and 7

    public class csFriend 
    {
        public string Name { get; set; }
    }
    public class ClassB<T> //where T:struct  // Question 7
    {
        public T[] tArray;

        public ClassB(int count)
        {
            tArray = new T[count];
            for (int i = 0; i < tArray.Length; i++)
            {
                tArray[i] = default;
            }
        }
    }
    #endregion

    static void Main(string[] args)
    {
        #region Question 1
        Console.WriteLine(SimplePassword("Hello"));
        Console.WriteLine(SimplePassword(3));
        #endregion
        #region Question 3
        /*
        DateTime[] myDates = new DateTime[100];
        var rnd = new Random();

        int datesWritten = 0;
        for (int i = 0; i < myDates.Length; i++)
        {
            string aRandomDate = $"{rnd.Next(2000, 2021)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}";

            // below will crash on invalid dates
            //myDates[i] = DateTime.Parse(aRandomDate);

            Console.WriteLine(myDates[i]);
            datesWritten++;


        }
        Console.WriteLine(datesWritten);
        */
        Console.WriteLine($"\nDifferent error handling solutions");

        #region Using for-loop with i--

        DateTime[] myDates = new DateTime[100];
        var rnd = new Random();
        /*
        Console.WriteLine("\nUsing for-loop with i--");
        int datesWritten = 0;
        for (int i = 0; i < myDates.Length; i++)
        {
            try
            {
                string aRandomDate = $"{rnd.Next(2000, 2021)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}";
                myDates[i] = DateTime.Parse(aRandomDate);
                Console.WriteLine($"{myDates[i]:d}");
                datesWritten++;
            }
            catch
            {
                i--;
            }
        }
        Console.WriteLine($"Dates written: {datesWritten}");
        */
        #endregion
        #region Using for-loop with try-catch
        /*
        Console.WriteLine("\nUsing for-loop with try-catch");
        int datesWritten = 0;
        for (int i = 0; i < myDates.Length; i++)
        {
            bool ValidDate = false;
            DateTime Date = default;
            while (!ValidDate)
            {
                try
                {
                    string aRandomDate = $"{rnd.Next(2000, 2021)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}";
                    Date = DateTime.Parse(aRandomDate);
                    ValidDate = true;
                }
                catch { }
            }
            myDates[i] = Date;
            Console.WriteLine($"{myDates[i]:d}");
            datesWritten++;
        }
        Console.WriteLine($"Dates written: {datesWritten}");
        */
        #endregion
        #region Using for-loop with TryParse
        /*
        Console.WriteLine("\nUsing for-loop with TryParse");
        datesWritten = 0;
        for (int i = 0; i < myDates.Length; i++)
        {
            bool ValidDate = false;
            DateTime Date = default;
            while (!ValidDate)
            {
                string aRandomDate = $"{rnd.Next(2000, 2021)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}";
                if (DateTime.TryParse(aRandomDate, out Date))
                    ValidDate = true;
            }
            myDates[i] = Date;
            Console.WriteLine($"{myDates[i]:d}");
            datesWritten++;
        }
        Console.WriteLine($"Dates written: {datesWritten}");
        */
        #endregion
        #region Using While-loop with TryParse
        
        Console.WriteLine("\nUsing while-loop with TryParse");
        int datesWritten = 0;
        int c = datesWritten = 0;
        while (c < myDates.Length)
        {
            string aRandomDate = $"{rnd.Next(2000, 2021)}-{rnd.Next(1, 13)}-{rnd.Next(1, 32)}";
            if (DateTime.TryParse(aRandomDate, out myDates[c]))
            {
                Console.WriteLine($"{myDates[c]:d}");
                c++;
                datesWritten++;
            }
        }
        Console.WriteLine($"Dates written: {datesWritten}");
        
        #endregion

        #endregion
        #region Question 6 and 7
        Console.WriteLine("\nQuestions 6 and 7");
        var myClassB1 = new ClassB<int>(10);

        var myClassB2 = new ClassB<csFriend>(10);
        var name = myClassB2.tArray[0]?.Name;

        #endregion
        #region Question 8
        Console.WriteLine("\nQuestion 8");
        string[] sArray = "The quick brown fox catches the rabbit".Split(' ');
        Console.WriteLine(string.Join('-', sArray));
        #endregion
    }

    #region Question 1
    public static string SimplePassword(int Seed) => $"KhPlY{Seed}";                           //A
    public static string SimplePassword(string prefix)                                         //B
    {
        var rnd = new Random();
        return $"{prefix}KhPlY{rnd.Next(0, 10000)}";
    }
    public static string SimplePassword(int Seed, string prefix) => $"{prefix}KhPlY{Seed}";    //C
    #endregion
}
