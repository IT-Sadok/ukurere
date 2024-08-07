namespace Factory
{
    public class Factory
    {
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        private int _parts = 0, _products = 0;

        public int Parts
        {
            get { return _parts; }
            private set { _parts = value; }
        }

        public int Products
        {
            get { return _products; }
            private set { _products = value; }
        }

        public async Task DeliverAsync(int id)
        {
            await _semaphore.WaitAsync();
            try
            {
                await Task.Delay(100);
                Parts++;
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task PickupAsync(int id)
        {
            await _semaphore.WaitAsync();
            try
            {
                if (Products > 0)
                {
                    await Task.Delay(100); 
                    Products--;
                }
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task ProcessAsync()
        {
            while (true)
            {
                await Task.Delay(60);
                if (Parts > 0)
                {
                    Parts--;
                    Products++;
                }
            }
        }
    }
}
