namespace UserProject;

internal class User
{
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public readonly DateTime registrationTimestamp;

    public User()
    {
        registrationTimestamp = DateTime.UtcNow;
    }

    public string ShowInfo()
        => $"Info about user {Username}. FirstName: {FirstName}, " +
        $"LastName: {LastName}, Age: {Age}. " +
        $"Registration date: {registrationTimestamp}";
}
