
using DummyData.data;
using DummyData.Interface;
using DummyData.Models;
using System.IO;
using System.Text.Json;

namespace DummyData.Services
{
    public class UserService : IUserService
    {
        public async Task<List<User>> GetUsers()
        {
            var jsonString = await File.ReadAllTextAsync(DataPaths.USER_DATA_PATH);
            var users = JsonSerializer.Deserialize<List<User>>(jsonString);
            return users;
        }
    }
}
