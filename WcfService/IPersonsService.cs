using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    [ServiceContract]
    public interface IPersonsService
    {
        [OperationContract]
        void BulkInsert10000Records();

        [OperationContract]
        List<Person> GetPersons();

        [OperationContract]
        DataModificationResult UpdatePerson(Person person);

        [OperationContract]
        DataModificationResult DeletePerson(Person person);
    }
}
