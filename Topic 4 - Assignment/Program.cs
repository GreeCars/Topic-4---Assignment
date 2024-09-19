// See https://aka.ms/new-console-template for more information
// Carsen
using System.Diagnostics;

string name, firstName, lastName, login, item1, item2;
int age, grade, studentID, age2;
double salary, average, number1, number2, number3, item1Price, item2Price, totalPrice, discount, tax, subtotal;

//Console.WriteLine("Hello. What is your name?");
//name = Console.ReadLine();
//Console.WriteLine("Hello " + name + ". How old are you?");
//age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(age + "? That's not very old. What's your salary, " + name + "?");
//Double.TryParse(Console.ReadLine(), out salary);
//Console.WriteLine(salary.ToString("C") + "? I certainly hope that's not per year.");
Console.WriteLine();

//Console.WriteLine("Please enter the following information.");
//Console.Write("First name: ");
//firstName = Console.ReadLine();
//Console.Write("Last name: ");
//lastName = Console.ReadLine();
//Console.Write("Grade (9-12): ");
//grade = Convert.ToInt32(Console.ReadLine());
//Console.Write("Student ID: ");
//studentID = Convert.ToInt32(Console.ReadLine());
//Console.Write("Login: ");
//login = Console.ReadLine();
//Console.Write("Average: ");
//Double.TryParse(Console.ReadLine(), out average);

//Console.WriteLine("Your information: ");
//Console.WriteLine("Login: \t\t" + login);
//Console.WriteLine("ID: \t\t" + studentID);
//Console.WriteLine("Name: \t\t" + lastName + ", " + firstName);
//Console.WriteLine("Average: \t" + Math.Round(average, 1) + "%");
//Console.WriteLine("Grade: \t\t" + grade);
Console.WriteLine();

//Console.WriteLine("Hello. What is your name?");
//name = Console.ReadLine();
//Console.WriteLine("Hi, " + name + "! How old are you?");
//age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Did you know that in five years you will be " + (age + 5) + " years old? And five years ago you were " + (age - 5) + " years old.");
Console.WriteLine();

//Console.WriteLine("Please enter a number:");
//Double.TryParse(Console.ReadLine(), out number1);
//Console.WriteLine("Please enter another number:");
//Double.TryParse(Console.ReadLine(), out number2);
//Console.WriteLine("Please enter a final number:");
//Double.TryParse(Console.ReadLine(), out number3);
//Console.WriteLine("Your selected numbers, when added together and divided by 2, equal to " + ((number1 + number2 + number3) / 2) + ".");
Console.WriteLine();

Console.WriteLine("Please state the name of an item.");
item1 = Console.ReadLine();
Console.WriteLine("Please state the item's price.");
Double.TryParse(Console.ReadLine(), out item1Price);
Console.WriteLine("Please state the name of another item.");
item2 = Console.ReadLine();
Console.WriteLine("Please state the item's price.");
Double.TryParse(Console.ReadLine(), out item2Price);
totalPrice = (item1Price + item2Price);
discount = (0.2 * totalPrice);
subtotal = (totalPrice - discount);
tax = ((totalPrice - discount) * 0.13);
Console.WriteLine();

Console.WriteLine("Sales Receipt");
Console.WriteLine();
Console.WriteLine("Item 1: " + item1);
Console.WriteLine("Price: " + item1Price.ToString("C"));
Console.WriteLine("Item 2: " + item2);
Console.WriteLine("Price: " + item2Price.ToString("C"));
Console.WriteLine("=====");
Console.WriteLine("Total: " + totalPrice.ToString("C"));
Console.WriteLine("Discount (20%): " + discount.ToString("C"));
Console.WriteLine("Subtotal: " + subtotal.ToString("C"));
Console.WriteLine("Tax (13%): " + tax.ToString("C"));
Console.WriteLine("=====");
Console.WriteLine("Total Owed: " + (subtotal + tax).ToString("C"));