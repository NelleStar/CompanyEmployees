﻿using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyDto>> GetAllCompaniesAsync(bool trackChanges);
        Task<CompanyDto> GetCompanyAsync(Guid id, bool trackChanges);
        Task<CompanyDto> CreateCompanyAsync(CompanyForCreationDto company);
        Task<IEnumerable<CompanyDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);
        Task<(IEnumerable<CompanyDto> companies, string ids)> CreateCompanyCollectionAsync (IEnumerable<CompanyForCreationDto> companyCollection);
        Task DeleteCompanyAsync(Guid id, bool trackChanges);
        Task UpdateCompanyAsync(Guid id, CompanyForUpdateDto companyForUpdate, bool trackChanges);
    }
}
