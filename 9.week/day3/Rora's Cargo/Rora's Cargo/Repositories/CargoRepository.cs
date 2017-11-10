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

        public void AddCargo(Cargo cargo)
        {
            CargoContext.Cargos.Add(cargo);
            CargoContext.SaveChanges();
        }
    }
}
