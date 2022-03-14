using System;

namespace Data.Controls
{
    public interface IRental
    {
        int Id { get; }
        int UserId { get; }

        int CarId { get; }

        DateTime HireDate { get; }

        DateTime ReturnDate { get; }

        decimal TotalPrice { get; }
    }
}
