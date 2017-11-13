using RorasCargo.Entities;
using RorasCargo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RorasCargo.Repositories
{
    public class CargoRepository
    {
        CargoContext CargoContext;

        public CargoRepository(CargoContext cargoContext)
        {
            CargoContext = cargoContext;
        }

        public List<Cargo> GetCargos()
        {
            return CargoContext.Cargos.ToList();
        }

        public void AddCargo(int caliber)
        {
            CargoContext.Cargos.Add(new Cargo { Caliber = caliber });
            CargoContext.SaveChanges();
        }

        public void RemoveCargo(int id)
        {
            var remove = (from cargo in CargoContext.Cargos
                          where cargo.Id == id
                          select cargo).FirstOrDefault();
            CargoContext.Cargos.Remove(remove);
            CargoContext.SaveChanges();
        }
    }
}
