
Console.WriteLine("Enter the number of words: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the words ");

string[] str = new string[num];

for(int i  = 0; i < num ; i++)
{
    str[i] = Console.ReadLine();
}

string shortest = str[0];

foreach (string str3 in str)
{
    if(str3.Length < shortest.Length)
    {
        shortest = str3;
    }
}

Console.WriteLine();
Console.WriteLine("The shortest word is "+shortest);
Console.WriteLine();

Console.WriteLine("Enter a word to search");
string search = Console.ReadLine();

bool found = false;

foreach (string str4 in str)
{
    if (str4 == search)
    {
       found = true;
        break;
    }
}
if (found)
{
    Console.WriteLine("The word is present in the list ");
}
else
{
    Console.WriteLine("Word is not present in the list ");
}

Console.WriteLine();
Array.Sort(str);
Console.WriteLine("The sorted array is :");
foreach (string str5 in str)
{
    Console.WriteLine(str5);
}

int count = 0;
string ch = "";
foreach (string str6 in str)
{
    string rev = "";
    int length = str6.Length;

    for (int i = length-1; i >= 0; i--)
    {
        rev += str6[i];
        
    }
    if (rev ==str6)
    {
        count++;
        ch  = ch + str6+ " "; 
    }
}
Console.WriteLine();    
Console.WriteLine("The number of palindromes in the string :"+count);
Console.WriteLine(ch);