using sharps_ent.Entity;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface ILogOfOperationsService
    {
        void CreateLogOfOperations(LogOfOperations LogOfOperations);
        void DeleteLogOfOperations(LogOfOperations LogOfOperations);
        LogOfOperations GetLogOfOperationsById(int id);
        IEnumerable<LogOfOperations> GetLogOfOperations();
        void UpdateLogOfOperations(LogOfOperations LogOfOperations);
    }
}
