using MongoDB.Driver;
using TestMongoDb.Common;
using TestMongoDb.Models;

namespace TestMongoDb.Services.User
{
    public class UserService : BaseService<Entities.User>, IUserService
    {
        //services.AddSingleton<IUserServices, UserServices>();
        public UserService(MongoSettings settings , IMongoClient client) : base(settings , client)
        {
        }
    }
}
