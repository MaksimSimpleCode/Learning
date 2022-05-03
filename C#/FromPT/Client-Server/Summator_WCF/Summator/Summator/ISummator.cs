using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Summator
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "ISummator" в коде и файле конфигурации.
    [ServiceContract]
    public interface ISummator
    {
        [OperationContract]
        int GetSum(int x, int y);
    }
}
