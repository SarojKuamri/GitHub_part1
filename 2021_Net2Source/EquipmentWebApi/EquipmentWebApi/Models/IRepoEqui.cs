using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentWebApi.Models
{
    public interface IRepoEqui
    {
        void Add(EquiModels models);
        IEnumerable<EquiModels> GetAll();
        EquiModels Find(int EquiID);
        EquiModels Remove(int EquiID);
        void Update(EquiModels equi);
        
    }
}
