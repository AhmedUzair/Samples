using Microsoft.EntityFrameworkCore.Storage;
using ShopingCart.Infrastructure;
using ShoppingCart.Persistance.Repositories;

namespace ShoppingCart.Persistance
{
    public class UnitOfWork
    {
        private readonly ShoppingCartContext _dbContext;
        private IDbContextTransaction? _currentTransaction;
        private readonly CartRepository _cartRepository;
        private readonly CheckoutRepository _checkoutRepository;
        private readonly InventoryRepository _inventoryRepository;

        public UnitOfWork(ShoppingCartContext context,
            CartRepository cartRepository,
            CheckoutRepository checkoutRepository,
            InventoryRepository inventoryRepository)
        {
            _dbContext = context;
            _cartRepository = cartRepository;
            _checkoutRepository = checkoutRepository;
            _inventoryRepository = inventoryRepository;
        }


        public async Task BeginTransactionAsync()
        {
            if (_currentTransaction != null)
            {
                return;
            }

            _currentTransaction = await _dbContext.Database.BeginTransactionAsync();
        }

        public void RollbackTransaction()
        {
            try
            {
                _currentTransaction?.Rollback();
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }
        }

        public Task CommitTransactionAsync()
        {
            try
            {
                _currentTransaction?.Commit();
            }
            catch
            {
                RollbackTransaction();
                throw;
            }
            finally
            {
                if (_currentTransaction != null)
                {
                    _currentTransaction.Dispose();
                    _currentTransaction = null;
                }
            }

            return Task.CompletedTask;
        }
    }
}
