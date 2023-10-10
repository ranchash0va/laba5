namespace lab5
{
    internal class BaseInform
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}, Description: {Description}, Price: {Price}, Location: {Location}";
        }
    }
}