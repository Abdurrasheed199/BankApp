using BankingApp.Context;
using BankingApp.Entities;
using BankingApp.Interface.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace BankingApp.Implementation.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationContext _dbContext;
        public AccountRepository(ApplicationContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<Account> Delete(Account account, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (account == null) throw new ArgumentNullException(null);
            _dbContext.Accounts.Remove(account);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return account;
        }

        public async Task<Account> GetAccount(Expression<Func<Account, bool>> expression, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var account = await _dbContext.Accounts
                 .Include(sc => sc.Customer)
                 .Include(c => c.TransactionHistory)
                .SingleOrDefaultAsync(expression, cancellationToken);
            return account;
        }

        public async Task<Account> GetAccountById(int accountId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (int.IsNullOrEmpty(accountId)) throw new ArgumentNullException(nameof(cartId));
            cancellationToken.ThrowIfCancellationRequested();
            var cart = await _dbContext.Carts
                 .Include(sc => sc.ProductCarts)
                .SingleOrDefaultAsync(c => c.Id == cartId, cancellationToken);
            return cart;
        }

        public Task<Account> GetAccountByName(string name, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Account>> GetAllAccounts(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Account> Update(Account account, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
