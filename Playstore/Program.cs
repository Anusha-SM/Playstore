using Playstore;
int x = 10;
int y = x;

Console.WriteLine("My Play Store");
// Creating object / How to create object for class?
User userObj = new User();
Console.WriteLine("My name:" + userObj.Name);
userObj.CreateUser(); // function calling

Categories categories = new Categories(11,"Fashion", "Fashion test");

Console.WriteLine(categories.Id);
Console.WriteLine(categories.Name);
Console.WriteLine(categories.Description);

categories.AddCategory(1, "ABC");
categories.AddCategory(2, "XYZ", "Test");

