using BLL.Interfaces;
using sharps_ent.Entity;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace BLL.Services
{
    public class BankService : IBankService
    {
        private IRepository<Bank> bankRepository;

        public BankService(IRepository<Bank> bankRepository)
        {
            this.bankRepository = bankRepository;
        }

        public void CreateBank(Bank bank)
        {
            bankRepository.Add(bank);
        }

        public void DeleteBank(Bank bank)
        {
            bankRepository.Remove(bank);
        }
        public Bank GetBankById(int id)
        {
            return bankRepository.Get(id);
        }

        public IEnumerable<Bank> GetBanks()
        {
            return bankRepository.Get();
        }

        public void UpdateBank(Bank bank)
        {
            bankRepository.Update(bank);
        }
    }
}
