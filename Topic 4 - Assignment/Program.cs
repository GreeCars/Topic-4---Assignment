// See https://aka.ms/new-console-template for more information
// Carsen
using System.Diagnostics;

string name, firstName, lastName, login, name2;
int age, grade, studentID, age2;
double salary, average;

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

Console.WriteLine("Hello. What is your name?");
name2 = Console.ReadLine();
Console.WriteLine("Hi, " + name2 + "! How old are you?");
age2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Did you know that in five years you will be " + (age2 + 5) + " years old? And five years ago you were " + (age2 - 5) + " years old.");