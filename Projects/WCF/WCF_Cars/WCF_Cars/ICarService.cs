using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Cars
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarService" in both code and config file together.

    [ServiceContract]
    public interface ICarService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        [FaultContract(typeof(Fault.DataBaseConnectionFault))]
        List<Car> GetAllCar(string guid);

        [OperationContract]
        [FaultContract(typeof(Fault.DataBaseConnectionFault))]
        void AddCar(Car car, string guid);

        [OperationContract]
        [FaultContract(typeof(Fault.IdNotFoundFault))]
        [FaultContract(typeof(Fault.DataBaseConnectionFault))]
        void DeleteCar(int Id, string guid);

        [OperationContract]
        [FaultContract(typeof(Fault.DataBaseConnectionFault))]
        [FaultContract(typeof(Fault.IdNotFoundFault))]
        Car SearchCarById(int id, string guid);

        [OperationContract]
        [FaultContract(typeof(Fault.DataBaseConnectionFault))]
        Car YoungestCar(string guid);

        [OperationContract]
        [FaultContract(typeof(Fault.DataBaseConnectionFault))]
        Car OldestCar(string guid);

        [OperationContract]
        string Login(string username, string password);

        [OperationContract]
        bool Logout(string client);

        [OperationContract]
        bool GuidHas(string client);

        [OperationContract]
        [FaultContract(typeof(Fault.NotLoggedInFault))]
        string GuidReturn();
        


    }
}
