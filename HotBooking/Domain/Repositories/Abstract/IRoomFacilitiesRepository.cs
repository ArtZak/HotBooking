using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface IRoomFacilitiesRepository
    {
        IQueryable<RoomFacility> GetAll();
        RoomFacility GetById(Guid id);
        void Save(RoomFacility entity);
        void Delete(Guid id);
        Type GetEntityType();
    }
}
