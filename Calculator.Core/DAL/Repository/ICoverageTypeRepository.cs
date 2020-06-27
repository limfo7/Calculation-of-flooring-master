using Calculator.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Core.DAL.Repository
{
    public interface ICoverageTypeRepository
    {
        void AddCoverageType(CoverageType coverageType);
        IEnumerable<CoverageType> GetCoverageTypes();
        CoverageType GetCoverageTypeById(int id);
        void DeleteCoverageType(int id);
    }
}
