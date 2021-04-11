using HotBooking.Domain.Entities;
using HotBooking.Domain.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.EntityFramwork
{
    public class EFRoomRoomFacilitiesRepository : IRoomRoomFacilityRepository
    {
        private readonly AppDbContext context;
        public EFRoomRoomFacilitiesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<RoomRoomFacility> GetAll()
        {
            return context.RoomRoomFacilities;
        }

        public RoomRoomFacility GetById(Guid roomId, Guid facilityId)
        {
            return context.RoomRoomFacilities.Find(roomId, facilityId);
        }

        public void Save(RoomRoomFacility entity)
        {
            if (context.RoomRoomFacilities.Any(r => r.RoomId == entity.RoomId && r.RoomFacilityId == r.RoomFacilityId))
            {
                return;
            }
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Save(IEnumerable<RoomRoomFacility> entities)
        {
            foreach (var entity in entities)
            {
                if (context.RoomRoomFacilities.Any(r => r.RoomId == entity.RoomId && r.RoomFacilityId == r.RoomFacilityId))
                {
                    continue;
                }
                context.Entry(entity).State = EntityState.Added;
            }
            context.SaveChanges();
        }

        public void Delete(Guid hotelId, Guid facilityId)
        {
            context.RoomRoomFacilities.Remove(context.RoomRoomFacilities.Single(r => r.RoomId == hotelId && r.RoomFacilityId == facilityId));
            context.SaveChanges();
        }

        public void Delete(List<(Guid, Guid)> idPairs)
        {
            foreach (var item in idPairs)
            {
                context.RoomRoomFacilities.Remove(context.RoomRoomFacilities.Single(r => r.RoomId == item.Item1 && r.RoomFacilityId == item.Item2));
            }
            context.SaveChanges();
        }

        public List<String> GetDataNames()
        {
            var list = new List<String>() { "Room Id", "Facility Id" };
            return list;
        }

        public List<String> GetData(RoomRoomFacility entity)
        {
            var list = new List<String>();

            list.Add(entity.RoomId.ToString());
            list.Add(entity.RoomFacilityId.ToString());

            return list;
        }

        public Type GetEntityType()
        {
            return typeof(RoomRoomFacility);
        }
    }
}
