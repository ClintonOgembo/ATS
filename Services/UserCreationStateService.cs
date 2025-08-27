namespace AttainTaskSupportSystem.Services
{
    public class UserCreationStateService
    {
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Role { get; set; } = "";

        public void SetInitialData(string fullName, string email, string role)
        {
            FullName = fullName;
            Email = email;
            Role = role;
        }

        public void ClearData()
        {
            FullName = "";
            Email = "";
            Role = "";
        }

        public bool HasData()
        {
            return !string.IsNullOrEmpty(FullName) && !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Role);
        }
    }
}
