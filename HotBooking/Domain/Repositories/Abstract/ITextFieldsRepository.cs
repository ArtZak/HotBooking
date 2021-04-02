using HotBooking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotBooking.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetAll();
        TextField GetById(Guid id);
        void Save(TextField entity);
        void Delete(Guid id);
        List<String> GetDataNames();
        List<String> GetData(TextField entity);
        Type GetEntityType();
        TextField GetTextFieldByCodeWord(string codeWord);
    }
}
