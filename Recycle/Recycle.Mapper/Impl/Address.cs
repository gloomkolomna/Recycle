using Recycle.Mapper.Interfaces;

namespace Recycle.Mapper.Impl
{
    internal class Address : IAddress
    {
        public int Id { get; set; }
        public int Index { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Home { get; set; }
    }
}