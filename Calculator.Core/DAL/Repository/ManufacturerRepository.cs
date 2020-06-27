using Calculator.Core.DAL.Context;
using Calculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Core.DAL.Repository
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        public readonly CalculationOfFlooringDbContext calculationOfFlooringDbContext;

        public ManufacturerRepository(CalculationOfFlooringDbContext calculationOfFlooringDbContext)
        {
            this.calculationOfFlooringDbContext = calculationOfFlooringDbContext;
        }

        public void AddManufacturer(Manufacturer manufacturer)
        {
            throw new NotImplementedException();
        }

        public Manufacturer GetManufacturer(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manufacturer> GetManufacturers()
        {
            throw new NotImplementedException();
        }

        public void RemoveManufacturer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
