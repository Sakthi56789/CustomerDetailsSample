using CustomerDetailsSample.Domain;
using CustomerDetailsSample.Infrastructure;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace CustomerDetailsSample.Application
{
    public class CustomerService : ICustomer
    {
        private readonly CustomerDetailsDbContext _dbcontext;
        public CustomerService (CustomerDetailsDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

       public async Task<IEnumerable<CustomerDetails>> GetAll()
        {
            return await _dbcontext.customerdetails.ToListAsync(); 
        }

        public async Task<CustomerDetails> Create(CustomerDetails customerDetails)
        {
            var data = await _dbcontext.customerdetails.AddAsync(customerDetails);
            _dbcontext.SaveChanges();
            return data.Entity;
        }
        public async Task<bool> Update(Guid Id , CustomerDetails customerDetails)
        {
            var data = await _dbcontext.customerdetails.FindAsync(Id);
            if (data == null)
            {
                return false;
            }
            data.CustomerCode = customerDetails.CustomerCode;
            data.CustomerName = customerDetails.CustomerName;
            data.Status = customerDetails.Status;
            data.CustomerType = customerDetails.CustomerType;
            data.ContactTitle = customerDetails.ContactTitle;
            data.ContactPerson = customerDetails.ContactPerson;
            data.Phone = customerDetails.Phone;
            data.MobileNumber = customerDetails.MobileNumber;
            data.EmailAddress = customerDetails.EmailAddress;
            data.Street = customerDetails.Street;
            data.Address = customerDetails.Address;
            data.City = customerDetails.City;   
            data.State = customerDetails.State;
            data.District = customerDetails.District;
            data.Landmark = customerDetails.Landmark;
            data.Country = customerDetails.Country;
            data.TenantId= customerDetails.TenantId;
            data.LastUpdatedDate = customerDetails.LastUpdatedDate;

            await _dbcontext.SaveChangesAsync();
            return true;
        }
        

        public async Task<bool> Delete(Guid Id)
        {
            var data = await _dbcontext.customerdetails.FindAsync(Id);
            if (data == null)
            {
                return false;
            }
            _dbcontext.customerdetails.Remove(data);
            await _dbcontext.SaveChangesAsync();
            return true;
        }

        public async Task<CustomerDetails> GetById(Guid Id)
        {
           return await _dbcontext.customerdetails.FindAsync(Id);
            
        }


    }
}
