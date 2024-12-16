using Shared.DataTransferObjects;
using Entities.Models;
using Shared.RequestFeatures;
using Entities.LinkModels;

namespace Service.Contracts
{
    public interface IEmployeeService
    {
        Task<(LinkResponse linkResponse, MetaData metaData)> GetEmployeesAsync(Guid companyId, LinkParameters linkParameters, bool trackChanges);
        Task<EmployeeDto> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges);
        Task<EmployeeDto> CreateEmployeeAsync(Guid companyId, EmployeeForCreationDto employee, bool trackChanges);
        Task DeleteEmployeeAsync(Guid companyId, Guid id, bool trackChanges);
        Task UpdateEmployeeAsync(Guid companyId, Guid id, EmployeeForUpdateDto employee, bool compTrackChanges, bool empTrackChanges);        
        Task<(EmployeeForUpdateDto employeeToPatch, Employee employeeEntity)> GetEmployeeForPatchAsync(Guid companyId, Guid id, bool compTrackChanges, bool empTrackChanges);
        Task SaveChangesForPatchAsync(EmployeeForUpdateDto employeeToPatch, Employee employeeEntity);
    }
}
