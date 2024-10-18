#region Question 1
System.Console.WriteLine("\nQuestion 1");

var b1 = true;
var i1 = 5;
var d1 = 10.5M;

var logic_expr1 = ((i1 > 3) || (d1 < 20.5M)) && b1;
var math_expr1 = i1+3;
var math_expr2 = i1++;
var logic_expr2 = (i1++ > 6); 



#endregion

#region Question 2
System.Console.WriteLine("\nQuestion 2");
var book1 = new csBook();
var another_book1 = new csBook();
bool eq1 = book1.Equals(another_book1);
Console.WriteLine(eq1);  // False, referential equality
                            // references are compared

var book2 = new stBook();
var another_book2 = new stBook();
bool eq2 = book2.Equals(another_book2);
Console.WriteLine(eq2);  // True, structual equality
                            // Contents are compared
#endregion

#region Question 5 and 6
Console.WriteLine("\nQuestions 5 and 6");
Ostrich o = new Ostrich();
Console.WriteLine(o.ICanFly);


CanIFly(new Duck());
CanIFly(new Ostrich());
#endregion

#region Question 7
var imbook1 = new imBook() { Title = "The Adventures of Tom Sawyer", Author = "Mark Twain" };
var imbook2 = imbook1.SetAuthor("Katarina").SetTitle("Alfons cyklar");
#endregion

#region Question 10
System.Console.WriteLine("\nQuestion 10");
csBook[] books = new csBook[]
    { new csBook { Title = "The Adventures of Tom Sawyer", Author = "Mark Twain" },
        new csBook { Title = "The Alchemist", Author = "Paulo Coelho" }};

csBook[] booksCopy = new csBook[2];

//Copy 1
/*
booksCopy = books;
booksCopy[0].Title = "Frankenstein";
Console.WriteLine(books[0].Title);

booksCopy[0] = null;
Console.WriteLine(books[0].Title);
*/
//Copy 2
/*
Array.Copy(books, booksCopy, books.Length);
booksCopy[0].Title = "Frankenstein";
Console.WriteLine(books[0].Title);

booksCopy[0] = null;
Console.WriteLine(books[0].Title);
*/

//Copy 3
for (int i = 0; i < books.Length; i++)
{
    booksCopy[i] = new csBook(books[i]);
}
booksCopy[0].Title = "Frankenstein";
Console.WriteLine(books[0].Title);

booksCopy[0] = null;
Console.WriteLine(books[0].Title);
#endregion

#region Question 5 and 6
static void CanIFly(Bird bird)
{
    Console.WriteLine(bird[1, 3]);
    if (bird.ICanFly)
    {
        Console.WriteLine($"Hello, I am a {bird.GetType().Name}. Hurray! I can fly!");
    }
    else
    {
        Console.WriteLine($"Hello, I am a {bird.GetType().Name}. Sadly, I cannot fly!");
    }
}
#endregion

#region Question 5 and 6
public class Bird
{
    //public bool ICanFly { get; } = true; //Question 5
    public virtual bool ICanFly { get; } = true; //Question 6

    public string this[int idx1, int idx2] => $"{idx1}, {idx2}";
}
public class Duck : Bird { }
public class Ostrich : Bird
{
    //public new bool ICanFly { get; } = false; //Question 5
    public override bool ICanFly { get; } = false; //Question 6
}
#endregion

#region Question 7
public class imBook
{
    string _title;
    public string Title { get => _title; init => _title = value; }

    public string Author { get; init; }

    public imBook() { }
    public imBook(imBook org)
    {
        Title = org.Title;
        Author = org.Author;
    }

    #region immutability
    public imBook SetAuthor(string author) => new imBook(this){ Author = author };
    public imBook SetTitle(string title) => new imBook(this){ Title = title };
    #endregion
}
#endregion

#region Question 10
public class csBook
{
    string _title;
    public string Title { get => _title; set => _title = value; }

    public string Author { get; init; }

    public csBook() { }
    public csBook(csBook org)
    {
        Title = org.Title;
        Author = org.Author;
    }
}
public struct stBook
{
    public string Title { get; set; }
    public string Author { get; set; }

    public stBook() { }
    public stBook(csBook org)
    {
        Title = org.Title;
        Author = org.Author;
    }
}
#endregion

public enum enSeason { summer, winter}