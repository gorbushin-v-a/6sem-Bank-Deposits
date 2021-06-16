using BLL.Interfaces;
using sharps_ent.Entity;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace BLL.Services
{
    public class LogOfOperationsService : ILogOfOperationsService
    {
        private IRepository<LogOfOperations> LogOfOperationsRepository;

        public LogOfOperationsService(IRepository<LogOfOperations> LogOfOperationsRepository)
        {
            this.LogOfOperationsRepository = LogOfOperationsRepository;
        }

        public void CreateLogOfOperations(LogOfOperations LogOfOperations)
        {
            LogOfOperationsRepository.Add(LogOfOperations);
        }

        public void DeleteLogOfOperations(LogOfOperations LogOfOperations)
        {
            LogOfOperationsRepository.Remove(LogOfOperations);
        }
        public LogOfOperations GetLogOfOperationsById(int id)
        {
            return LogOfOperationsRepository.Get(id);
        }

        public IEnumerable<LogOfOperations> GetLogOfOperations()
        {
            return LogOfOperationsRepository.Get();
        }

        public void UpdateLogOfOperations(LogOfOperations LogOfOperations)
        {
            LogOfOperationsRepository.Update(LogOfOperations);
        }
    }
}
