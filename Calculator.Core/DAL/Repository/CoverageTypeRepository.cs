using Calculator.Core.DAL.Context;
using Calculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Core.DAL.Repository
{
    public class CoverageTypeRepository : ICoverageTypeRepository
    {
        public readonly CalculationOfFlooringDbContext calculationOfFlooringDbContext;

        public CoverageTypeRepository(CalculationOfFlooringDbContext calculationOfFlooringDbContext)
        {
            this.calculationOfFlooringDbContext = calculationOfFlooringDbContext;
        }

        public void AddCoverageType(CoverageType coverageType)
        {
            throw new NotImplementedException();
        }

        public void DeleteCoverageType(int id)
        {
            throw new NotImplementedException();
        }

        public CoverageType GetCoverageTypeById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CoverageType> GetCoverageTypes()
        {
            throw new NotImplementedException();
        }
    }
}
