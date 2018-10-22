namespace Recycle.Mapper.Interfaces
{
    public interface IAddress
    {
        int Id { get; set; }
        int Index { get; set; }
        string City { get; set; }
        string Street { get; set; }
        string Home { get; set; }
    }
}