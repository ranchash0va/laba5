namespace lab5
{
    using System;

    internal class Logistics : BaseInform
    {
        public string TransportType { get; set; }
        public string Destination { get; set; }
        public DateTime DeliveryDate { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Transport Type: {TransportType}, Destination: {Destination}, Delivery Date: {DeliveryDate}";
        }
    }
}