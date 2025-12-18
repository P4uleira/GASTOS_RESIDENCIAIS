using HouseholdExpenses.Domain.Entity;

namespace HouseholdExpenses.Domain.Interfaces.Services
{
    public interface ITransactionService
    {
        Task CreateTransaction(Transaction transaction);
        Task<Transaction> GetTransactionById(Guid idTransaction);
        Task<IEnumerable<Transaction>> GetAllTransactions();
    }
}
