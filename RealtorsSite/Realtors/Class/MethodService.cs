using Realtors.RieltorsService;

namespace Realtors.Class
{
    public class MethodService
    {
        private readonly RieltorsServiceClient _service = new RieltorsServiceClient();
        public UserDto Authorization(string login, string passwordMD5)
        {
            return _service.Authorization(login, passwordMD5);
        }
    }
}