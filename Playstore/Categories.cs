namespace Playstore
{
    internal class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Constructor:
        //Class name and method name should be same
        //it will trigger automatically when object created.
        public Categories()
        {

        }
        public Categories(int id, string name, string description)
        {
            Id = id; //set method
            Name = name;// property = value
            Description = description;
        }

        public void AddCategory(int id, string name)//method overloading
        {
            Console.WriteLine("Category details: " + id + "," + name);
        }

        public void AddCategory(int id, string name, string description)
        {
            Console.WriteLine("Category details: " + id + "," + name + "," + description);
        }
    }
}
