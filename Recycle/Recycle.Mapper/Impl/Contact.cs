using Recycle.Mapper.Interfaces;

namespace Recycle.Mapper.Impl
{
    internal class Contact : IContact
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public IAddress Address { get; set; }
    }
}