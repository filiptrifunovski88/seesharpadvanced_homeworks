using homework2.app.Models;

#region task1
// Write a program to create an interface Searchable with a method Search(string word) that searches for a given keyword in a text document. Create two classes Document and WebPage that implement the Searchable interface and provide their own implementations of the Search() method.
Document doc = new Document("This is an example of a text document.");
Console.WriteLine(doc.Search("example"));
Console.WriteLine(doc.Search("document"));
Console.WriteLine(doc.Search("Filip"));
Console.WriteLine("==============================");
WebPage page = new WebPage("<html><body>Welcome to our website. Here you can find various resources and articles.</body></html>");
Console.WriteLine(page.Search("Here"));
Console.WriteLine(page.Search("Filip"));
Console.WriteLine(page.Search("can"));
Console.WriteLine("==============================");
#endregion

#region task2,task3
// Write a program to create an interface Shape with the GetArea() method. Create three classes Rectangle, Circle, and Triangle that implement the Shape interface. Implement the GetArea() method for each of the three classes.
Circle circle = new Circle(20);
Console.WriteLine(circle.CalculateArea());
Console.WriteLine(circle.CalculatePerimeter());
Console.WriteLine("==============================");
Triangle triangle = new Triangle(3, 4, 5, 2.4);
Console.WriteLine(triangle.CalculateArea());
Console.WriteLine(triangle.CalculatePerimeter());
Console.WriteLine("==============================");
#endregion

#region task4
// Write a program to create an abstract class Employee with abstract methods CalculateSalary() and DisplayInfo(). Create subclasses Manager and Programmer that extend the Employee class and implement the respective methods to calculate salary and display information for each role.
Manager manager = new Manager("Filip", 2, 142);
manager.DisplayInfo();
Console.WriteLine("==============================");
Programmer programmer = new("Mihail", 4, 8, 20);
programmer.DisplayInfo();
#endregion