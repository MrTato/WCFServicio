using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        BDServicioEntities1 db = new BDServicioEntities1();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<verClientesActivos_Result> listVerClientesActivos()
        {
            return db.verClientesActivos().ToList();
        }

        public List<verClientes_Result> listVerClientes()
        {
            return db.verClientes().ToList();
        }

        public List<verServicio_Result> listVerServicio()
        {
            return db.verServicio().ToList();
        }
    }
}
