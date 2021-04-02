using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.EntityFramwork
{
    public class EFHotelFacilitiesRepository : IHotelFacilitiesRepository
    {
        private readonly AppDbContext context;
        public EFHotelFacilitiesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<HotelFacility> GetAll()
        {
            return context.HotelFacilities;
        }

        public HotelFacility GetById(Guid id)
        {
            return context.HotelFacilities.FirstOrDefault(x => x.Id == id);
        }

        public void Save(HotelFacility entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            context.HotelFacilities.Remove(new HotelFacility() { Id = id });
            context.SaveChanges();
        }

        public List<String> GetDataNames()
        {
            var list = new List<String>() { "Title", "Subtitle", "Text", "Title image path", "Date added" };
            return list;
        }

        public List<String> GetData(HotelFacility entity)
        {
            var list = new List<String>();

            list.Add(entity.Title.ToString());
            list.Add(entity.Subtitle.ToString());
            list.Add(entity.Text.ToString());
            list.Add(entity.TitleImagePath?.ToString());
            list.Add(entity.DateAdded.ToString());

            return list;
        }

        public Type GetEntityType()
        {
            return typeof(HotelFacility);
        }
    }
}
