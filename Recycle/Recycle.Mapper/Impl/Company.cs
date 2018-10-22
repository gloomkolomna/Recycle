using System.Collections.Generic;
using Recycle.Mapper.Interfaces;

namespace Recycle.Mapper.Impl
{
    internal class Company : ICompany
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IContact Contact { get; set; }
        public IEnumerable<IRecycleType> RecycleTypes { get; set; }
    }
}