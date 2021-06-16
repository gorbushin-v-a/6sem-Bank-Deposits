using sharps_ent.Entity;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IBranchService
    {
        void CreateBranch(Branch Branch);
        void DeleteBranch(Branch Branch);
        Branch GetBranchById(int id);
        IEnumerable<Branch> GetBranches();
        void UpdateBranch(Branch Branch);
    }
}
