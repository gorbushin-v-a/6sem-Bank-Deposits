using sharps_ent.Entity;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IDepositorService
    {
        void CreateDepositor(Depositor Depositor);
        void DeleteDepositor(Depositor Depositor);
        Depositor GetDepositorById(int id);
        IEnumerable<Depositor> GetDepositors();
        void UpdateDepositor(Depositor Depositor);
    }
}
