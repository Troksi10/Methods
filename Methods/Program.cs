
WriteSomething();
WriteSomethingSpecific("I am an argument and am called from a method.");

Console.WriteLine(Add(15,45));
Console.WriteLine(Multiply(10,5));
Console.WriteLine(Divide(100,3));

string friend1 = "Zlatko";
string friend2 = "Martin";
string friend3 = "Angela";

GreetFriend(friend1,friend2,friend3);

Console.WriteLine(Calculate());

// Try , Catch and Finally

Console.WriteLine("Please Enter some number!");
string userInput = Console.ReadLine();

int num1 = 5;
int num2 = 2;
int result;

try
{
    result = num1 / num2;
}
catch (DivideByZeroException)
{

    Console.WriteLine("Can't divide by zero");
}

try
{
    int userInputAsInt = int.Parse(userInput);
}
catch (FormatException)
{
    Console.WriteLine("Format exception,please enter the correct type next time.");
}
catch (OverflowException)
{
    Console.WriteLine("Overflow exception, the number was too long or too short.");
}catch(ArgumentNullException)
{
    Console.WriteLine("ArgumentNullException, the value was empty(null)");
}finally
{
    Console.WriteLine("This is called anyways!");
}

// Operators

int number1 = 5;
int number2 = 15;
int number3;

// unary operators
number3 =  - number1;
Console.WriteLine("num3 is {0} " , number3);

bool isSunny = true;
Console.WriteLine("Is it sunny? {0}",!isSunny);

// increment operators

int someNum = 0;
someNum++;
Console.WriteLine("num is {0}", someNum);
Console.WriteLine("num is {0}", someNum++);

// pre increment
Console.WriteLine("num is {0}", ++someNum);

// decrement 

Console.WriteLine("num is {0}", someNum);
Console.WriteLine("num is {0}", someNum--);

// pre decrement
Console.WriteLine("num is {0}", --someNum);

// relational and type operators

bool isLower;
isLower = num1 < num2;
Console.WriteLine("result of num1 < num2 is {0}",isLower);

// equality operator

bool isEqual;
isEqual = num1 == num2;
Console.WriteLine("result of num1 == num2 is {0}", isEqual);

isEqual = num1 != num2;
Console.WriteLine("result of num1 != num2 is {0}", isEqual);

// conditional operators

bool isLowerAndSunny;

// AND operator
isLowerAndSunny = isLower && isSunny;
Console.WriteLine("result of isLower && isSunny is {0}", isLowerAndSunny);

// OR operator

isLowerAndSunny = isLower || isSunny;
Console.WriteLine("result of isLower || isSunny is {0}", isLowerAndSunny);

Console.ReadLine();

static void WriteSomething()
{
    Console.WriteLine("I am called a method.");
}
static void WriteSomethingSpecific(string myText)
{
    Console.WriteLine(myText);
}

// Methods With Return Value And Parameters
static int Add(int num1,int num2)
{
    return num1 + num2;
}

static int Multiply(int num1,int num2)
{
    return (num1 * num2);
}

static double Divide(double num1,double num2)
{
    return num1 / num2;
}

static void GreetFriend(string friendName,string friendName2,string friendName3)
{
    Console.WriteLine($"Hi {friendName} , my friend.");
    Console.WriteLine($"Hi {friendName2} , my friend.");
    Console.WriteLine($"Hi {friendName3} , my friend.");
}

// Exercise
static int Calculate()
{
    Console.WriteLine("Please enter the first number");
    string numberOneInput = Console.ReadLine();
    Console.WriteLine("Please enter the second number");
    string numberTwoInput = Console.ReadLine();

    int num1 = int.Parse(numberOneInput);
    int num2 = int.Parse(numberTwoInput);
    int result = num1 * num2;

    return result;
}



