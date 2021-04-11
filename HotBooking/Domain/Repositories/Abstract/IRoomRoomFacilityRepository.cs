using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IRoomRoomFacilityRepository
    {
        IQueryable<RoomRoomFacility> GetAll();
        RoomRoomFacility GetById(Guid hotelId, Guid facilityId);
        void Save(RoomRoomFacility entity);
        void Save(IEnumerable<RoomRoomFacility> entities);
        void Delete(Guid roomId, Guid facilityId);
        void Delete(List<(Guid, Guid)> idPairs);
        List<String> GetDataNames();
        List<String> GetData(RoomRoomFacility entity);
        Type GetEntityType();
    }
}
