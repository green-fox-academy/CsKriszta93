using RorasCargoExercise.Entities;
using RorasCargoExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RorasCargoExercise.Repositories
{
    public class RocketRepository
    {
        RocketContext RocketContext;

        public RocketRepository(RocketContext rocketContext)
        {
            RocketContext = rocketContext;
        }

        public List<Rocket> GetRockets()
        {
            return RocketContext.Rockets.ToList();
        }

        public void AddRocket(int caliber)
        {
            RocketContext.Rockets.Add(new Rocket { Caliber = caliber });
            RocketContext.SaveChanges();
        }
    }
}