namespace ZAExtentions_Example.Models
{
    public class ExampleModel
    {
        public ExampleModel() { }
        public ExampleModel(int _id, string _name)
        {
            Id = _id;
            Name = _name; 
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}