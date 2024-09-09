using CustomerDetailsSample.Domain;

namespace CustomerDetailsSample.Application
{
    public interface ICustomer 
    {
        Task<IEnumerable<CustomerDetails>> GetAll();
        Task<CustomerDetails> Create(CustomerDetails customerDetails);

        Task<CustomerDetails> Update(Guid Id,CustomerDetails customerDetails);
        Task<CustomerDetails> Delete(Guid Id);
        Task<CustomerDetails> GetById(Guid Id);
    }
}
