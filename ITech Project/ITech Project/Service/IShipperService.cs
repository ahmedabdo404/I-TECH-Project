using ITech_Project.Models;
using System.Collections.Generic;

namespace ITech_Project.Service

{
    public interface IShipperService
    {

        void Create(Shipper shipper);
        void Delete(int id);
        List<Shipper> GetAll();
        Shipper GetById(int id);
        Shipper GetByName(string name);
        void Update(Shipper shipper);
    }
}
