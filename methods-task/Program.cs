
bool isTerminate = false;
while (!isTerminate)
{

    Console.WriteLine("Plase enter user data");

    string firstName;
    while (true)
    {
        Console.WriteLine();
        Console.Write("Enter first name: ");
        firstName = Console.ReadLine();

        if (!NameLengthChecker(firstName) ||
            !OnlyStringChecker(firstName) ||
            !isCapitalLetterChecker(firstName))
        {
            continue;
        }
        else
        {
            break;
        }
    }

    string lastName;
    while (true)
    {
        Console.Write("Enter lastname: ");
        lastName = Console.ReadLine();

        if (!LastNameLengthChecker(lastName) ||
        !isCapitalLetterChecker(lastName) ||
        !OnlyStringChecker(lastName))
        {
            continue;
        }
        else
        {
            break;
        }

    }

    string fatherName;
    while (true)
    {
        Console.Write("Enter father name: ");

        fatherName = Console.ReadLine();


        if (
        !NameLengthChecker(fatherName) ||
        !OnlyStringChecker(fatherName) ||
        !isCapitalLetterChecker(fatherName))
        {
            continue;

        }
        else
        {
            break;
        }

    }

    int age;
    while (true)
    {

        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());

        if (!AgeChecker(age))
        {
            continue;
        }
        else
        {
            break;
        }

    }

    string finCode;
    while (true)
    {
        Console.Write("Enter FIN code: ");

        finCode = Console.ReadLine();
        if (!FinCodeChecker(finCode))
        {
            continue;
        }
        else
        {
            break;
        }


    }


    string phoneNumber;
    while (true)
    {
        Console.Write("Enter phone number: ");
        phoneNumber = Console.ReadLine();

        if (!PhoneNumberChecker(phoneNumber))
        {

            continue;
        }
        else
        {
            break;
        }
    }

    string position;
    while (true)
    {
        Console.Write("Enter position:");
        position = Console.ReadLine();
        if (!PositionChecker(position))
        {
            continue;
        }
        else
        {
            break;
        }



    }


    decimal salary;
    while (true)
    {
        Console.Write("Enter salary: ");
        salary = decimal.Parse(Console.ReadLine());

        if (!SalaryChecker(salary))
        {
            continue;
        }
        else
        {
            break;
        }


    }

    Console.WriteLine("First name: " + firstName + "  " + "Last name: " + lastName + "  " + "Father name: " + fatherName + "  " + "Age: " + age + "  " + "FIN code: " + finCode + "  " + "Phone number: " + phoneNumber + "  " + "Postion: " + position + "  " + "Salary: " + salary);
    Console.WriteLine("Do you want exit ?  (Y/N)?");
    string exit = Console.ReadLine();

    if (ConvertToLowerText(exit) == "y")
    {
        TerminateApp();
        isTerminate = true;

    }
    else
    {
        isTerminate = false;
    }

}


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
    if (age < 18 || age > 65)
    {
        Console.WriteLine("Age shoulde be greater 18 and less 65");
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
            Console.WriteLine("First letter should be capitalized");
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
    if (str.Length != 7)
    {
        Console.WriteLine("Length of FIN code should be 7 charracters");
        return false;
    }

    foreach (char chr in str)
    {
        if (!isCapitalCharChecker(chr) && !IsDigitChecker(chr))
        {
            Console.WriteLine("FIN code should contains only uppercase letters and digits");
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

    string correctNumberCode = "+994";
    string emptyString = "";

    for (int i = 0; i < 4; i++)
    {
        emptyString += str[i];
    }
    if (correctNumberCode != emptyString)
    {
        Console.WriteLine("Number should start with +994");
    }


    return true;

}
static bool SalaryChecker(decimal salary)
{
    if (!(salary <= 5000 && salary >= 1500))
    {
        Console.WriteLine("Salaray range shold be 1500-5000");
        return false;
    }
    return true;
}
static bool PositionChecker(string str)
{
    ConvertToLowerText(str);

    if (str != "hr" && str != "engineer" && str != "audit")
    {
        Console.WriteLine("Available positions are - HR , Audit, Engineer");
        return false;
    }
    return true;
}
static void TerminateApp()
{
    Console.WriteLine("App was closed");
}
