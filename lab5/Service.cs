namespace lab5
{
    internal class Service : BaseInform
    {
        public string Provider { get; set; }
        public int Duration { get; set; }
        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Provider: {Provider}, Duration: {Duration}, Is Available: {IsAvailable}";
        }
    }
}