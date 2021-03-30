using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EquipmentWebApi.Models;

namespace EquipmentWebApi.Models
{
    public class Repository : IRepoEqui
    {
        private readonly EquiDBContext _equiDBContext;
        public Repository(EquiDBContext equidbcontext)
        {
            _equiDBContext = equidbcontext;
        }
        public void Add(EquiModels models)
        {
            _equiDBContext.models.Add(models);
            _equiDBContext.SaveChanges();
        }
        public EquiModels Find(int EquiID)
        {
            var Equipment = _equiDBContext.models.Find(EquiID);
            return Equipment;
        }
        public IEnumerable<EquiModels> GetAll()
        {
            return _equiDBContext.models.ToList();
        }
        public EquiModels Remove(int EquiID)
        {
            var EquipmentEntity = Find(EquiID);
            _equiDBContext.models.Remove(EquipmentEntity);
            _equiDBContext.SaveChanges();
            return EquipmentEntity;
        }
        public void Update(EquiModels equi)
        {
            _equiDBContext.Entry(equi).State = EntityState.Modified;
            _equiDBContext.SaveChanges();
        }
    }
}
