using BLL.Interfaces;
using sharps_ent.Entity;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace BLL.Services
{
    public class DepositorService : IDepositorService
    {
        private IRepository<Depositor> DepositorRepository;

        public DepositorService(IRepository<Depositor> DepositorRepository)
        {
            this.DepositorRepository = DepositorRepository;
        }

        public void CreateDepositor(Depositor Depositor)
        {
            DepositorRepository.Add(Depositor);
        }

        public void DeleteDepositor(Depositor Depositor)
        {
            DepositorRepository.Remove(Depositor);
        }
        public Depositor GetDepositorById(int id)
        {
            return DepositorRepository.Get(id);
        }

        public IEnumerable<Depositor> GetDepositors()
        {
            return DepositorRepository.Get();
        }

        public void UpdateDepositor(Depositor Depositor)
        {
            DepositorRepository.Update(Depositor);
        }
    }
}
