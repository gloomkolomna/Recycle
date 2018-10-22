using System.Collections.Generic;
using Recycle.Mapper.Interfaces;

namespace Recycle.Mapper.Impl
{
    internal class RecyclePoint : IRecyclePoint
    {
        public int Id { get; set; }
        public ILocation Location { get; set; }
        public IEnumerable<IRecycleType> Types { get; set; }
        public ICompany Company { get; set; }
    }
}