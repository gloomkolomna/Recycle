using System.Collections.Generic;

namespace Recycle.Mapper.Interfaces
{
    public interface IRecyclePoint
    {
        int Id { get; set; }
        ILocation Location { get; set; }
        IEnumerable<IRecycleType> Types { get; set; }
        ICompany Company { get; set; }
    }
}