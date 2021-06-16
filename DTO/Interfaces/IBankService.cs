using sharps_ent.Entity;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IBankService
    {
        void CreateBank(Bank bank);
        void DeleteBank(Bank bank);
        Bank GetBankById(int id);
        IEnumerable<Bank> GetBanks();
        void UpdateBank(Bank bank);
    }
}
