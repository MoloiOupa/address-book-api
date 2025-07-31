namespace AddressBookAPI.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string CoverLetter { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ProfileWebsite { get; set; }
        public string ProfilePicture { get; set; }

        public Profile()
        {
            FirstName = string.Empty;
            Surname = string.Empty;
            CoverLetter = string.Empty;
            Email = string.Empty;
            Phone = string.Empty;
            ProfileWebsite = string.Empty;
            ProfilePicture = string.Empty;
        }
    }

}
