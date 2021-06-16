using sharps_ent.Entity;
using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface ITypeOperationService
    {
        void CreateTypeOperation(TypeOperation TypeOperation);
        void DeleteTypeOperation(TypeOperation TypeOperation);
        TypeOperation GetTypeOperationById(int id);
        IEnumerable<TypeOperation> GetTypeOperations();
        void UpdateTypeOperation(TypeOperation TypeOperation);
    }
}
