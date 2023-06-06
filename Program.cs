// See https://aka.ms/new-console-template for more information


//Question 1 (What data type is each of the following?)
//5 is an integer (int) .
//5.0 is a floating datatype(float) .
//5>1 is a boolean(bool) .
//'5' is a character/string(char) .
//5*2 is an integer(int).
//'5'*2 is not valid because one is char and 2 is int.
//'5'+'2' is string.
//5/2 is double.
//5%2 is  integer(int).
//{5,2,1} is array.
//5==3 is boolean.
//Pi(the number )is double datatype.


//Question 2 A And B(Does 'Supercalifragilisticexpialidocious' contain 'ice' as a substring?)


string original_str = "Supercalifragilisticexpialidocious";
Console.WriteLine("String: " + original_str);
Console.WriteLine("String Length: " + original_str.Length);
//Ice ice a substring
if (original_str.Contains("ice") == true)
{
    Console.WriteLine("Yes the word ice is a substring");
}
else
{
    Console.WriteLine("No the word ice is not a substring");
    
}
Console.WriteLine("\n");

//Question 2C(Which of the following words is the longest:)

{
    Console.WriteLine(FindLongestWord("Supercalifragilisticexpialidocious", "Honorificabilitudinitatibus", "Bababadalgharaghtakamminarronnkonn"));
}

static string FindLongestWord(string w1, string w2, string w3)
{
    string longestWord = w1;

    if (w2.Length > longestWord.Length)
    {
        longestWord = w2;
    }
    if (w3.Length > longestWord.Length)
    {
        longestWord = w3;
    }

    return longestWord;
    
}
Console.WriteLine("\n");

//Question 2D (Which composer comes first in the dictionary)

string[] comp = new string[] { "Berlioz", "Borodin", "Brain", "Bartok", "Bellini", "Buxtehude", "Bernstein" };

Array.Sort(comp);

Console.WriteLine("The first composer in dictionary is: " + comp[0]);
Console.WriteLine("The last composer in dictionary is: " + comp[comp.Length - 1]);
Console.WriteLine("\n");


//Question 3

Console.WriteLine(TriangleArea(2, 2, 2));


static double TriangleArea(double a, double b, double c)
{
    double s = (a + b + c) / 2;
    double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    return area;
}
Console.WriteLine("\n");

//Question 4(Write a program in C# Sharp to separate odd and even integers in separate arrays.)

int no = 5;
int[] a = new int[5] { 25, 47, 42, 56, 32 };
int[] odd = new int[no];
int[] even = new int[no];
int q, w, e;

for (q = 0, w = 0, e = 0; q < no; q++)
{
    if ((a[q] % 2) == 0)
    {
        even[w] = a[q];
        w++;
    }
    else
    {
        odd[e] = a[q];
        e++;
    }
}
Console.WriteLine("The Even elements are: ");
for (q = 0; q < w; q++)
{
    Console.Write($"{even[q]} \t");
}
Console.WriteLine();
Console.WriteLine("The Odd elements are: ");
for (q = 0; q < e; q++)
{
    Console.Write($"{odd[q]} \t");
}
Console.WriteLine("\n");

//Question 5

{
    Console.WriteLine(Inside(1, 1, 0, 0, 2, 3));  // True
    Console.WriteLine(Inside(-1, -1, 0, 0, 2, 3));  // False
    Console.ReadLine();
}
Console.WriteLine("\n");

//B

static bool Inside(double x, double y, double x1, double y1, double x2, double y2)
{
    return x >= x1 && x <= x2 && y >= y1 && y <= y2;
}
{
    Console.WriteLine(Inside(1, 1, 0.3, 0.5, 1.1, 0.7) && Inside(1, 1, 0.5, 0.2, 1.1, 2));
    Console.ReadLine();
}

