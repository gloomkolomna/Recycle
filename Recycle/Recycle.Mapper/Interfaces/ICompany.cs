using System.Collections.Generic;

namespace Recycle.Mapper.Interfaces
{
    public interface ICompany
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        IContact Contact { get; set; }
        IEnumerable<IRecycleType> RecycleTypes { get; set; }
    }
}