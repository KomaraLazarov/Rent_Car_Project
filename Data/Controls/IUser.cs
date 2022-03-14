using System;

namespace Data.Controls
{
    public interface IUser
    {
        int Id { get; }
        string Username { get; }
        string Password { get; }
        string FirstName { get; }
        string MiddleName { get; }
        string LastName { get; }
        string Email { get; }
        string PhoneNumber { get; }
        DateTime Birthdate { get; }
    }
}
