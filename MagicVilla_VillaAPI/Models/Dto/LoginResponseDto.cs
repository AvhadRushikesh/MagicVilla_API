namespace MagicVilla_VillaAPI.Models.Dto
{
    public class LoginResponseDto
    {
        public UserDto User { get; set; }
        public string Role { get; set; }    //  To Store the Role
        public string Token { get; set; }
    }
}
