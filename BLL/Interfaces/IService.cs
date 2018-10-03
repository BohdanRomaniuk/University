using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IService<TModel>
    {
        TModel Get(int id);
        IEnumerable<TModel> Get();
        void Add(TModel dto);
        void Remove(int id);
        void Update(TModel dto);
    }
}
