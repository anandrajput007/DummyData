using DummyData.Models;

namespace DummyData.Interface
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
    }
}
