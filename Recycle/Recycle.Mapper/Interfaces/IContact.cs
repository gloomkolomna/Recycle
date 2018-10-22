namespace Recycle.Mapper.Interfaces
{
    public interface IContact
    {
        int Id { get; set; }
        string Phone { get; set; }
        string Web { get; set; }
        string Email { get; set; }
        IAddress Address { get; set; }
    }
}