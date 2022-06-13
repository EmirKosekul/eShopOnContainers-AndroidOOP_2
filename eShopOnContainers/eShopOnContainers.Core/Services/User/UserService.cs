using eShopOnContainers.Core.Helpers;
using eShopOnContainers.Core.Models.User;
using eShopOnContainers.Core.Services.RequestProvider;
using Firebase.Database;
using System;
using System.Threading.Tasks;
using eShopOnContainers.Core.Models;
using System.Linq;
using Firebase.Database.Query;

namespace eShopOnContainers.Core.Services.User
{


    public class UserService : IUserService
    {
        FirebaseClient client;

        public UserService()
        {
            client = new FirebaseClient("https://oop2-6c2c3-default-rtdb.firebaseio.com/");
        }
        private readonly IRequestProvider _requestProvider;

        public UserService(IRequestProvider requestProvider)
        {
            _requestProvider = requestProvider;
        }

        public async Task<bool> IsUserExists(string uname)
        {
            var user = (await client.Child("Users")
                .OnceAsync<Users>()).Where(u => u.Object.Username == uname).FirstOrDefault();

            return (user != null);
        }
        public async Task<bool> RegisterUser(string uname,string passwd)
        {
            if(await IsUserExists(uname) == false)
            {
                await client.Child("Users")
                    .PostAsync(new Users()
                    {
                        Username = uname,
                        Password = passwd
                    });
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> LoginUser(string uname, string passwd)
        {
            var user = (await client.Child("Users")
                .OnceAsync<Users>()).Where(u => u.Object.Username == uname)
                .Where(u => u.Object.Password == passwd).FirstOrDefault();
            return (user != null);
        }

        public Task<UserInfo> GetUserInfoAsync(string authToken)
        {
            throw new NotImplementedException();
        }

        //private readonly IRequestProvider _requestProvider;

        //public UserService(IRequestProvider requestProvider)
        //{
        //    _requestProvider = requestProvider;
        //}

        //public async Task<UserInfo> GetUserInfoAsync(string authToken)
        //{
        //    var uri = UriHelper.CombineUri(GlobalSetting.Instance.UserInfoEndpoint);

        //    var userInfo = await _requestProvider.GetAsync<UserInfo>(uri, authToken);
        //    return userInfo;
        //}
    }
}