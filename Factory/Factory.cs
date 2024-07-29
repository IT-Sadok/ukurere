namespace Factory
{
    public class Factory
    {
        private readonly SemaphoreSlim _deliverSemaphore = new SemaphoreSlim(100, 100);
        private readonly SemaphoreSlim _pickupSemaphore = new SemaphoreSlim(100, 100);
        private int _parts = 0, _products = 0;

        public async Task DeliverAsync(int Id)
        {
            await _deliverSemaphore.WaitAsync();
            try
            {
                await Task.Delay(100);
                _parts++;
            }
            finally
            {
                _deliverSemaphore.Release();
            }
        }

        public async Task PickupAsync(int Id)
        {
            await _pickupSemaphore.WaitAsync();
            try
            {
                if (_products > 0)
                {
                    await Task.Delay(100);
                    _products--;
                }
            }
            finally
            {
                _pickupSemaphore.Release();
            }
        }

        public async Task ProcessAsync()
        {
            while (true)
            {
                await Task.Delay(60);
                if (_parts > 0)
                {
                    _parts--;
                    _products++;
                }
            }
        }

        public int GetPartsCount()
        {
            return _parts;
        }

        public int GetProductsCount()
        {
            return _products;
        }
    }
}
