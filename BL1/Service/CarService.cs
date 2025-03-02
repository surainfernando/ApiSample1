using BL1.Contracts;
using BL1.DbContext;
using BL1.DbContext2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL1.Service
{
    public class CarService : ICarService
    {
        private readonly AppDbContext1 _appDbContext1;
        public CarService(AppDbContext1 appDbContext1)
        {
            _appDbContext1 = appDbContext1;
        }
        public async  Task<int> Get1()
        {
            /*var r= await _appDbContext1.Cars.FirstOrDefaultAsync();
             var rr= await _appDbContext1.Cars.FirstOrDefaultAsync(o=>o.Id==3);
             var rty = await _appDbContext1.Cars.ToListAsync();

             var x = new Car() { 
             Name="Toyota"
             };

             await _appDbContext1.Cars.AddAsync(x);
             await _appDbContext1.SaveChangesAsync();

             r.Name = "asdasdsd";
             _appDbContext1.Cars.Update(r);
             await _appDbContext1.SaveChangesAsync();

             _appDbContext1.Cars.Remove(r);
             await _appDbContext1.SaveChangesAsync();

             IQueryable<Car> query = _appDbContext1.Cars;
             int age = 45;
             string name = "OYO";*/

            IQueryable<Car> query = _appDbContext1.Cars;
            int age = 45;
            string name = "OYO";

            if (age != null)
            {
                query = query.Where(o=>o.Id>45);
            }

            if (age != null)
            {
                query = query.Where(o => o.Name.Contains(name));
            }

            var listofCars = await query.ToListAsync();


            return  123;
        }
    }
}
