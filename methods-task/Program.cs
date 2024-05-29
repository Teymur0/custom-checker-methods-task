
//string firstName =Console.ReadLine();
//string lasttName =Console.ReadLine();
//string fathertName =Console.ReadLine();
//int age = int.Parse(Console.ReadLine());
//string finCode=Console.ReadLine();
//int phoneNumber = int.Parse(Console.ReadLine());
//string[] position = { "HR", "AUDIT", "Engineer " };
//int salary = int.Parse(Console.ReadLine());

using System.Xml.Linq;

static bool IsDigitChecker(char chr)
{
    return chr >= 48 && chr <= 57;
}
static bool IsUpperChecker(char chr)
{
    return chr >= 65 && chr <= 90;
}
static bool IsLowerChecker(char chr)
{
    return chr >= 97 && chr <= 122;
}
static string ConvertToUpperText(string str)
{
    string upperCaseStr = "";

    foreach (char chr in str)
    {
        if (IsUpperChecker(chr))
        {
            upperCaseStr += chr;
            continue;
        }
        char upperChr = ConverToUpperChar(chr);
        upperCaseStr += upperChr;
    }
    return upperCaseStr;
}
static char ConverToUpperChar(char chr)
{
    const int lowerAndUpperCharDifference = 32;
    int lowerDigit = (int)chr;
    int upperDigit = chr - lowerAndUpperCharDifference;
    char upperChr = (char)upperDigit;
    return upperChr;
}
static char ConvertToLowerChar(char chr)
{
    const int lowerAndUpperCharDifference = 32;
    int upperDigit = (int)chr;
    int lowerDigit = chr + lowerAndUpperCharDifference;
    char lowerChr = (char)lowerDigit;
    return lowerChr;
}
static string ConvertToLowerText(string str)
{
    string lowerCaseStr = "";
    foreach (char chr in str)
    {
        if (IsLowerChecker(chr))
        {
            lowerCaseStr += chr;
            continue;
        }
        char lowerChr = ConvertToLowerChar(chr);
        lowerCaseStr += lowerChr;
    }
    return lowerCaseStr;
}
static bool AgeChecker(int age)
{
    if (age <= 18 || age >= 65)
    {
        Console.WriteLine("Please enter valid age");
        return false;
    }
    else
    {
        return true;
    }

}
static bool NameLengthChecker(string name)
{
    if (name.Length <= 2)
    {
        Console.WriteLine("Name shoulde be  greater than 2 charracters");
        return false;
    }
    else if (name.Length >= 20)
    {
        Console.WriteLine("Name shoulde be less than 20 characters");
        return false;
    }

    return true;
}
static bool OnlyStringChecker(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if ((str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122))
        {
            continue;
        }
        else
        {
            Console.WriteLine("You should enter only strings");
            return false;
        }
    }
    return true;
}
static bool isCapitalLetterChecker(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (str[0] >= 65 && str[0] <= 90)
        {
            continue;
        }
        else
        {
            return false;

        }
    }
    return true;
}
static bool isCapitalCharChecker(char chr)
{
    return chr >= 65 && chr <= 90;
}
static bool LastNameLengthChecker(string name)
{
    if (name.Length <= 2)
    {
        Console.WriteLine("Name shoulde be  greater than 2 charracters");
        return false;
    }
    else if (name.Length >= 35)
    {
        Console.WriteLine("Name shoulde be less than 20 characters");
        return false;
    }
    return true;
}
static bool FinCodeChecker(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (!isCapitalCharChecker(str[i]) && !IsDigitChecker(str[i]))
        {
            return false;
        }
    }

    return true;
}
static bool PhoneNumberChecker(string str)
{
    if (str.Length != 13)
    {

        Console.WriteLine("Number length should be 13 charracters");
        return false;
    }

    for (int i = 1; i < str.Length; i++)
    {
        if (!IsDigitChecker(str[i]))
        {
            Console.WriteLine("Number must contains only numbers");
            return false;
        }
    }


    for (int i = 0; i < str.Length; i++)
    {

        if (str[0] != '+' && str[1] != '9' && str[2] != '9' && str[i] != '4')
        {

            return false;

        }
    }
    return true;

}
static bool SalaryChecker(decimal salary)
{
    if (!(salary <= 5000 && salary >= 1500))
    {
        return false;
    }
    return true;
}
static bool PositionChecker(string str)
{
    ConvertToLowerText(str);

    if (str != "hr" && str != "engineer" && str != "audit")
    {
        return false;
    }
    return true;
}
