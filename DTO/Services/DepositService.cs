using BLL.Interfaces;
using sharps_ent.Entity;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace BLL.Services
{
    public class DepositService : IDepositService
    {
        private IRepository<Deposit> DepositRepository;

        public DepositService(IRepository<Deposit> DepositRepository)
        {
            this.DepositRepository = DepositRepository;
        }

        public void CreateDeposit(Deposit Deposit)
        {
            DepositRepository.Add(Deposit);
        }

        public void DeleteDeposit(Deposit Deposit)
        {
            DepositRepository.Remove(Deposit);
        }
        public Deposit GetDepositById(int id)
        {
            return DepositRepository.Get(id);
        }

        public IEnumerable<Deposit> GetDeposits()
        {
            return DepositRepository.Get();
        }

        public void UpdateDeposit(Deposit Deposit)
        {
            DepositRepository.Update(Deposit);
        }
    }
}
