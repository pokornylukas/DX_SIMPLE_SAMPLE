using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WcfService
{
    [DataContract]
    public class DataModificationResult
    {
        public enum Results
        { 
            Ok,
            OptimisticConcurrencyException,
            GeneralException
        }

        [DataMember]
        public Results Result
        { get; set; }

        [DataMember]
        public string ExceptionMessage
        { get; set; }
    }
}