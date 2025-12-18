using HouseholdExpenses.Domain.Entity;

namespace HouseholdExpenses.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task CreateUser(User user);
        Task DeleteUser(Guid idUser);
        Task<User> GetUserById(Guid idUser);
        Task<IEnumerable<User>> GetAllUsers();
    }
}
