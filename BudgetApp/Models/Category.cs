namespace BudgetApp.Models
{
    internal class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }

        //Parameterless Constructor
        public Category() {}

        public Category(string categoryName, string tag)
        {
            Name = categoryName;
            Tag = tag;
        }   
    }
}
