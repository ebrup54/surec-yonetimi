using Abp.Domain.Repositories;
using Acme.SimpleTaskApp.Projeler;
using Acme.SimpleTaskApp.Projeler.Projeler.ProjelerDtos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acme.SimpleTaskApp.Projeler.Projeler
{

    public class ProjeAppService : IProjeAppService
    {
        private readonly IRepository<Proje> _repository;
        public ProjeAppService(IRepository<Proje> repository)
        {
            _repository = repository;
        }
        public async Task<List<ProjeDto>> GetProjeList()
        {
            //selam 
            //var entitylist = await _repository.GetAll().Where(a => a.Musteri.FullName == "TEst")
            //    .Take(10).Skip(0).ToListAsync();
            //var toplamCount = await _repository.GetAll().Where(a => a.Musteri.FullName == "TEst").CountAsync();
            var entitylist = await _repository.GetAllListAsync();
            return entitylist.Select(e => new ProjeDto
            {
                ProjeId = e.Id,
                ProjeAdi = e.ProjeAdi,
                Description = e.Description,
                MusteriAdi = e.Musteri.CustomerName,
                BaslamaTarihi = e.BaslamaTarihi,
                Durum= e.Durum,
                BitisTarihi = e.BitisTarihi,




            }).ToList();
        }

        public async Task ProjeEkle(ProjeEkleDto input)
        {

            var entity = new Proje
            {
                ProjeAdi = input.ProjeAdi,
                Description = input.Description,
                MusteriId=input.CustomerId,
            };
            await _repository.InsertAsync(entity);

        }
        public async Task ProjeGuncelle(ProjeGuncelleDto input)
        {
            if (!input.ProjeId.HasValue || input.ProjeId == 0)
            {
                throw new System.Exception("Proje Bulunamadı");
            }
            if (string.IsNullOrEmpty(input.ProjeAdi))
            {
                throw new System.Exception("Proje Adı Boş Olamaz");
            }
            if (!input.CustomerId.HasValue || input.CustomerId == 0)
            {
                throw new System.Exception("Müşteri Bulunamadı");
            }


            var entity = await _repository.GetAsync(input.ProjeId.Value);
            entity.ProjeAdi = input.ProjeAdi;
            entity.Description = input.Description;
            entity.Musteri.CustomerName = input.CustomerName;
            entity.BitisTarihi = input.BitisTarihi;
            entity.Durum = input.Durum;

            await _repository.UpdateAsync(entity);

        }
        public async Task DeleteProje(int id)
        {
            await _repository.DeleteAsync(id);
        }

    }
}
