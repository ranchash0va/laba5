namespace lab5
{

    using System;
    class Program
    {
        static void Main(string[] args)
        {
            BaseInform[] commerceObjects = new BaseInform[10];
            int currentIndex = 0;

            commerceObjects[currentIndex++] = new Goods
            {
                Name = "Smartphone",
                Id = 1,
                Description = "High-end smartphone",
                Price = 699.99,
                Location = "Electronics",
                Category = "Electronics",
                StockQuantity = 50,
                Manufacturer = "Samsung"
            };

            commerceObjects[currentIndex++] = new Service
            {
                Name = "Plumbing Service",
                Id = 2,
                Description = "Plumbing repair service",
                Price = 89.99,
                Location = "Home Services",
                Provider = "ABC Plumbing",
                Duration = 2,
                IsAvailable = true
            };

            commerceObjects[currentIndex++] = new Logistics
            {
                Name = "Express Delivery",
                Id = 3,
                Description = "Fast delivery service",
                Price = 19.99,
                Location = "Logistics",
                TransportType = "Truck",
                Destination = "Customer's Address",
                DeliveryDate = DateTime.Now.AddDays(2)
            };


            Console.WriteLine("Список объектов:");
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine(commerceObjects[i]);
            }


            if (currentIndex > 0)
            {
                commerceObjects[0].Name = "Updated Smartphone";
                Console.WriteLine("\nAfter Update:");
                Console.WriteLine(commerceObjects[0]);
            }


            RemoveElement(1, ref commerceObjects, ref currentIndex);

            Console.WriteLine("\nСписок объектов после удаления:");
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine(commerceObjects[i]);
            }
        }

        static void RemoveElement(int index, ref BaseInform[] array, ref int currentIndex)
        {
            if (index >= 0 && index < currentIndex)
            {
                for (int i = index; i < currentIndex - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                currentIndex--;
                Console.WriteLine($"Элемент с индексом {index} удален успешно.");
            }
            else
            {
                Console.WriteLine("Неверный индекс. Элемент не найден.");
            }
        }
    }
}