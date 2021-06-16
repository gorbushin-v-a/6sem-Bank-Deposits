using BLL.Interfaces;
using sharps_ent.Entity;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace BLL.Services
{
    public class BranchService : IBranchService
    {
        private IRepository<Branch> BranchRepository;

        public BranchService(IRepository<Branch> BranchRepository)
        {
            this.BranchRepository = BranchRepository;
        }

        public void CreateBranch(Branch Branch)
        {
            BranchRepository.Add(Branch);
        }

        public void DeleteBranch(Branch Branch)
        {
            BranchRepository.Remove(Branch);
        }
        public Branch GetBranchById(int id)
        {
            return BranchRepository.Get(id);
        }

        public IEnumerable<Branch> GetBranches()
        {
            return BranchRepository.Get();
        }

        public void UpdateBranch(Branch Branch)
        {
            BranchRepository.Update(Branch);
        }
    }
}
