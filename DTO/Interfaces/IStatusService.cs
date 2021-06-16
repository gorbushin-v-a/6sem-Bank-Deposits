using sharps_ent.Entity;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IStatusService
    {
        void CreateStatus(Status Status);
        void DeleteStatus(Status Status);
        Status GetStatusById(int id);
        IEnumerable<Status> GetStatuses();
        void UpdateStatus(Status Status);
    }
}
