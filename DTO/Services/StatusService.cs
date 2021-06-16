using BLL.Interfaces;
using sharps_ent.Entity;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace BLL.Services
{
    public class StatusService : IStatusService
    {
        private IRepository<Status> StatusRepository;

        public StatusService(IRepository<Status> StatusRepository)
        {
            this.StatusRepository = StatusRepository;
        }

        public void CreateStatus(Status Status)
        {
            StatusRepository.Add(Status);
        }

        public void DeleteStatus(Status Status)
        {
            StatusRepository.Remove(Status);
        }
        public Status GetStatusById(int id)
        {
            return StatusRepository.Get(id);
        }

        public IEnumerable<Status> GetStatuses()
        {
            return StatusRepository.Get();
        }

        public void UpdateStatus(Status Status)
        {
            StatusRepository.Update(Status);
        }
    }
}
