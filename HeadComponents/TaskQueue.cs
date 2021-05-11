using System;
using System.Threading;
using System.Threading.Tasks;

namespace HeadComponents
{
    internal class TaskQueue
    {
        private SemaphoreSlim _semaphore;

        public TaskQueue()
        {
            _semaphore = new SemaphoreSlim(1);
        }

        public async Task<T> Enqueue<T>(Func<Task<T>> taskGenerator)
        {
            await _semaphore.WaitAsync();
            try
            {
                return await taskGenerator();
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task<T> Enqueue<T>(Func<ValueTask<T>> taskGenerator)
        {
            await _semaphore.WaitAsync();
            try
            {
                return await taskGenerator();
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task Enqueue(Func<Task> taskGenerator)
        {
            await _semaphore.WaitAsync();
            try
            {
                await taskGenerator();
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public async Task Enqueue(Func<ValueTask> taskGenerator)
        {
            await _semaphore.WaitAsync();
            try
            {
                await taskGenerator();
            }
            finally
            {
                _semaphore.Release();
            }
        }
    }
}
