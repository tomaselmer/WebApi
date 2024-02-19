using Entidades.Modelos;

namespace ServiceInterfaces
{
    public interface IUserService
    {
        Task<User> GetUserById(int userId);
        Task<IEnumerable<User>> GetAllUsers();
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(int userId);
    }
}
