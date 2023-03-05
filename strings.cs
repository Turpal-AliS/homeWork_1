/*
// 1.1 

string word = "hello";
char firstLetter = char.ToUpper(word[0]);
word = word.Replace(word[0], firstLetter);
Console.WriteLine(word);
 */

/*
// 1.2

string str = "This morning I get up at a half past six o’clock. It’s still dark. I feel tired.";
int counter = 0;
for(int i = 0; i < str.Length; i++)
{
    if(str[i] == ' ')
    {
        counter++;
    }
}
Console.WriteLine(counter);
 */

// 2

//string history = "History is always written by the winners! When two cultures clash, the loser is obliterated, and the winner writes the history books - books which glorify their own cause and disparage the conquered foe. As Napoleon once said, 'What is history, but a fable agreed upon?";

/*
// 2.2

string[] words = history.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int counter = 0;

foreach (string s in words)
{
    counter++;
}

Console.WriteLine(counter);
*/

/*
// 2.3

Console.WriteLine(history.Length);
*/

/*
// 2.4

int counter = 0;

for(int i = 0; i < history.Length; i++)
{
    counter++;

    if(history[i] == ' ')
    {
        counter--;
    }
}

Console.WriteLine(counter);
*/

/*
// 3

string upLetter = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string lowLetter = "abcdefghijklmnopqrstuvwxyz";
string str = "Aa Bb cc";
int upCounter = 0;
int lowCounter = 0;
for(int i = 0; i < str.Length; i++)
{
    for(int j = 0; j < upLetter.Length; j++)
    {
        if (str[i] == upLetter[j])
        {
            upCounter++;
        }
        else if(str[i] == lowLetter[j])
        {
            lowCounter++;
        }
    }
}
Console.WriteLine(upCounter);
Console.WriteLine(lowCounter); 
*/

/*
// 4

static void Palindrome(string input)
{
    input = input.ToLower().Replace(" ", "");

    for(int i = 0; i < input.Length / 2; i++)
    {
        if(input[i] != input[input.Length - i -1])
        {
            Console.WriteLine("Данная строка или слова не яв-ся палиндромом");
            return;
        }
    }

    Console.WriteLine("Данная строка или слова яв-ся палиндромом");
}

Palindrome("А роза упала на лапу Азора"); 
*/

/*
// 5

static void FuncCase(string str)
{
    char[] chars = str.ToCharArray();

    for(int i = 0; i < chars.Length; i++)
    {
        if(!Char.IsLetter(chars[i]))
        {
            continue;
        }

        if (i % 2 == 0)
        {
            chars[i] = Char.ToUpper(chars[i]);
        }
        else
        {
            chars[i] = Char.ToLower(chars[i]);
        }
    }

    string outStr = "";
    for (int i = 0; i < chars.Length; ++i)
    {
        outStr += chars[i];
    }
    Console.WriteLine(outStr);
}

FuncCase("Привет, Мир!"); 
*/