using Recycle.Mapper.Interfaces;

namespace Recycle.Mapper.Impl
{
    internal class RecycleType : IRecycleType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}