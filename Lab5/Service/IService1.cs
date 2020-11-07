using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        DataTable GetData();

        [OperationContract]
        DataTable FillFIO();

        [OperationContract]
        DataTable FillAvto();

        [OperationContract]
        void NewRec(string ID_FIO, string ID_AVTO, string Data_vzitia, string Data_zdachi);
    }
}
