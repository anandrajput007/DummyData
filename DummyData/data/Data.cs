
using System.IO;
namespace DummyData.data
{
    public static class DataPaths
    {
        public static readonly string USER_DATA_PATH = Path.Combine(Directory.GetCurrentDirectory(), "Data", "users.json");
    }
}
