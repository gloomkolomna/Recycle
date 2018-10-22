using Recycle.Mapper.Interfaces;

namespace Recycle.Mapper.Impl
{
    internal class Location : ILocation
    {
        public int Id { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}