using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.EntityFramwork
{
    public class EFHotelHotelFacilitiesRepository : IHotelHotelFacilityRepository
    {
        private readonly AppDbContext context;
        public EFHotelHotelFacilitiesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<HotelHotelFacility> GetAll()
        {
            return context.HotelHotelFacilities;
        }

        public HotelHotelFacility GetById(Guid hotelId, Guid facilityId)
        {
            return context.HotelHotelFacilities.Find(hotelId, facilityId);
        }

        public void Save(HotelHotelFacility entity)
        {
            if(context.HotelHotelFacilities.Any(r => r.HotelId == entity.HotelId && r.HotelFacilityId == r.HotelFacilityId))
            {
                return;
            }
            context.Entry(entity).State = EntityState.Added;         
            context.SaveChanges();
        }

        public void Save(IEnumerable<HotelHotelFacility> entities)
        {
            foreach(var entity in entities)
            {
                if(context.HotelHotelFacilities.Any(r => r.HotelId == entity.HotelId && r.HotelFacilityId == r.HotelFacilityId))
                {
                    continue;
                }
                context.Entry(entity).State = EntityState.Added;
            }
            context.SaveChanges();
        }

        public void Delete(Guid hotelId, Guid facilityId)
        {
            context.HotelHotelFacilities.Remove(context.HotelHotelFacilities.Single(r => r.HotelId == hotelId && r.HotelFacilityId == facilityId));
            context.SaveChanges();
        }

        public void Delete(List<(Guid, Guid)> idPairs)
        {
            foreach (var item in idPairs)
            {
                context.HotelHotelFacilities.Remove(context.HotelHotelFacilities.Single(r => r.HotelId == item.Item1 && r.HotelFacilityId == item.Item2));
            }
            context.SaveChanges();
        }

        public List<String> GetDataNames()
        {
            var list = new List<String>() {"Hotel Id", "Facility Id" };
            return list;
        }

        public List<String> GetData(HotelHotelFacility entity)
        {
            var list = new List<String>();

            list.Add(entity.HotelId.ToString());
            list.Add(entity.HotelFacilityId.ToString());           

            return list;
        }

        public Type GetEntityType()
        {
            return typeof(HotelHotelFacility);
        }
    }
}
