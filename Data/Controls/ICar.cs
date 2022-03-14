namespace Data.Controls
{
    public interface ICar
    {
        int Id { get; }
        string Mark { get; }
        string Model { get; }
        int Year { get; }
        string Fuel { get; }
        string Transmition { get; }
        decimal PricePerDay { get; }
    }
}
