using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Repository.IRepository;

namespace MagicVilla_VillaAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;
        private string _secretKey;
        public UserRepository(ApplicationDbContext db,IConfiguration configuration)
        {
            _db = db;
            _secretKey = configuration.GetValue<string>("ApiSettings:Secret");
        }
        // Check User Name is Unique or Not
        public bool IsUniqueUser(string username)
        {
            var user = _db.LocalUsers.FirstOrDefault(x => x.UserName == username);
            if (user == null)
            {
                return true;
            }
            return false;
        }

        // When we log in user we have to generate a token to validate that user & send that back
        public async Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto)
        {
            // Check username & password available in table
            var user = _db.LocalUsers.FirstOrDefault(u => u.UserName.ToLower() == loginRequestDto.UserName.ToLower()
            && u.Password == loginRequestDto.Password);
            // If Not Found return Null
            if (user == null)
            {
                return null;
            }
            // If user was found generate JWT token

        }

        // Add New Local User in Our Database
        public async Task<LocalUser> Register(RegistrationRequestDto registrationRequestDto)
        {
            LocalUser user = new LocalUser()
            {
                // This is Manual Mapping we can use AutoMapper here
                UserName = registrationRequestDto.UserName,
                Password = registrationRequestDto.Password,
                Name = registrationRequestDto.Name,
                Role = registrationRequestDto.Role
            };
            _db.LocalUsers.Add(user); // Add USer in LocalUsers table
            await _db.SaveChangesAsync();
            user.Password = ""; //  Make sure before return password is empty
            return user;
        }
    }
}
