using BLL.Interfaces;
using sharps_ent.Entity;
using sharps_ent.Repository.Interface;
using System.Collections.Generic;

namespace BLL.Services
{
    public class TypeOperationService : ITypeOperationService
    {
        private IRepository<TypeOperation> TypeOperationRepository;

        public TypeOperationService(IRepository<TypeOperation> TypeOperationRepository)
        {
            this.TypeOperationRepository = TypeOperationRepository;
        }

        public void CreateTypeOperation(TypeOperation TypeOperation)
        {
            TypeOperationRepository.Add(TypeOperation);
        }

        public void DeleteTypeOperation(TypeOperation TypeOperation)
        {
            TypeOperationRepository.Remove(TypeOperation);
        }
        public TypeOperation GetTypeOperationById(int id)
        {
            return TypeOperationRepository.Get(id);
        }

        public IEnumerable<TypeOperation> GetTypeOperations()
        {
            return TypeOperationRepository.Get();
        }

        public void UpdateTypeOperation(TypeOperation TypeOperation)
        {
            TypeOperationRepository.Update(TypeOperation);
        }
    }
}
