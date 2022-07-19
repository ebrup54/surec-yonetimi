using Abp.Domain.Repositories;
using Acme.SimpleTaskApp.Projeler;
using Acme.SimpleTaskApp.Projeler.Customers.CustomersDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Projeler.Customers
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly IRepository<Customer> _repository;
        public CustomerAppService(IRepository<Customer> repository)
        {
            _repository = repository;
        }
        public async Task<List<CustomerDto>> MusteriListesi()
        {
            var entitylist = await _repository.GetAllListAsync();
            return entitylist.Select(e => new CustomerDto
            {
                CustomerId = e.Id,
                CustomerName = e.CustomerName,
                Description = e.Description,
                CustomerContact = e.CustomerContact,
                UserId = e.UserId,
            }).ToList();
        }
        public async Task MusteriEkle(CustomerEkleDto input)
        {
            var entity = new Customer
            {
                CustomerName = input.CustomerName,
                Description = input.Description,
                CustomerContact = input.CustomerContact,
            };
            await _repository.InsertAsync(entity);
        }
        
        public async Task MusteriGuncelle(CustomerGuncelleDto input)
        {
            //if (!input.CustomerId.HasValue || input.CustomerId == 0)
            //{
            //    throw new System.Exception("Proje Bulunamadı");
            //}
            if (string.IsNullOrEmpty(input.CustomerName))
            {
                throw new System.Exception("Proje Adı Boş Olamaz");
            }
            if (!input.CustomerId.HasValue || input.CustomerId == 0)
            {
                throw new System.Exception("Müşteri Bulunamadı");
            }

            var entity = await _repository.GetAsync(input.CustomerId.Value);
            entity.CustomerName = input.CustomerName;
            entity.Description = input.Description;
            entity.CustomerContact = input.CustomerContact;         

            await _repository.UpdateAsync(entity);
        }
        public async Task DeleteCustomer(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
