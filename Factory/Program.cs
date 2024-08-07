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
                int id = i;
                tasks.Add(Task.Run(async () =>
                {
                    while (true)
                    {
                        Console.WriteLine($"Machine {id} is delivering parts...");
                        await factory.DeliverAsync(id);
                        Console.WriteLine($"Machine {id} delivered parts. Total parts: {factory.Parts}");

                        await Task.Delay(new Random().Next(60));
                    }
                }));
            }

            for (int i = 1; i <= 100; i++)
            {
                int id = i;
                tasks.Add(Task.Run(async () =>
                {
                    while (true)
                    {
                        Console.WriteLine($"Machine {id} is picking up products...");
                        await factory.PickupAsync(id);
                        Console.WriteLine($"Machine {id} picked up products. Remaining products: {factory.Products}");

                        await Task.Delay(new Random().Next(60));
                    }
                }));
            }

            tasks.Add(factory.ProcessAsync());

            await Task.WhenAll(tasks);
        }
    }
}
