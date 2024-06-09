using Basket.API.Models;
using StackExchange.Redis;
using System.Runtime.CompilerServices;

namespace Basket.API.Data
{
    public class RedisBasketRepository(ILogger<RedisBasketRepository> logger, IConnectionMultiplexer redis) : IBasketRepository
    {
        private readonly IDatabase _database = redis.GetDatabase();

        private static RedisKey BasketKeyPrefix = "/basket/"u8.ToArray();

        public Task<bool> DeleteBasket(string userName, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart> GetBasket(string userName, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCart> StoreBasket(ShoppingCart basket, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
