using Calculator.Core.Models;
using System.Collections.Generic;

namespace Calculator.Core.DAL.Repository
{
    public interface IManufacturerRepository
    {
        void AddManufacturer(Manufacturer manufacturer);
        IEnumerable<Manufacturer> GetManufacturers();
        Manufacturer GetManufacturer(int id);
        void RemoveManufacturer(int id);
    }
}
