namespace Factory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Factory factory = new Factory();
            List<Task> tasks = new List<Task>();

            for (int i = 1; i <= 100; i++)
            {
                int Id = i;
                tasks.Add(Task.Run(async () =>
                {
                    while (true)
                    {
                        Console.WriteLine($"Machine {Id} is delivering parts...");
                        await factory.DeliverAsync(Id);
                        Console.WriteLine($"Machine {Id} delivered parts. Total parts: {factory.GetPartsCount()}");

                        await Task.Delay(new Random().Next(60));
                    }
                }));
            }

            for (int i = 1; i <= 100; i++)
            {
                int Id = i;
                tasks.Add(Task.Run(async () =>
                {
                    while (true)
                    {
                        Console.WriteLine($"Machine {Id} is picking up products...");
                        await factory.PickupAsync(Id);
                        Console.WriteLine($"Machine {Id} picked up products. Remaining products: {factory.GetProductsCount()}");

                        await Task.Delay(new Random().Next(60));
                    }
                }));
            }

            tasks.Add(factory.ProcessAsync());

            await Task.WhenAll(tasks);
        }
    }
}
