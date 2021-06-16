using sharps_ent.Entity;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IDepositService
    {
        void CreateDeposit(Deposit Deposit);
        void DeleteDeposit(Deposit Deposit);
        Deposit GetDepositById(int id);
        IEnumerable<Deposit> GetDeposits();
        void UpdateDeposit(Deposit Deposit);
    }
}
