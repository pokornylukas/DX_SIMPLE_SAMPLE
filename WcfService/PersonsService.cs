using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EntityFramework.BulkInsert.Extensions;

namespace WcfService
{    
    public class PersonsService : IPersonsService
    {
        public void BulkInsert10000Records()
        {
            using (PraetorTestEntities db = new PraetorTestEntities())
            {
                List<Person> data = new List<Person>();
                Random rnd = new Random();
                Guid guid;
                for(int i = 0; i<=10000;i++)
                {
                    guid = Guid.NewGuid();
                    data.Add(new Person { FirstName = guid.ToString().Substring(0, 8), LastName = guid.ToString().Substring(9, 8), BirthDate = DateTime.Now.AddDays(-rnd.Next(1, 10000)) });
                }
                db.BulkInsert<Person>(data);
                db.SaveChanges();
            }            
        }

        public List<Person> GetPersons()
        {
            using (PraetorTestEntities db = new PraetorTestEntities())
            {
                return db.Person.ToList();
            }
        }

        public DataModificationResult UpdatePerson(Person person)
        {
            try
            {
                using (PraetorTestEntities db = new PraetorTestEntities())
                {
                    db.Person.Attach(person);
                    db.Entry(person).State = EntityState.Modified;
                    db.SaveChanges();
                    return new DataModificationResult() { Result = DataModificationResult.Results.Ok };
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return new DataModificationResult()
                {
                    Result = DataModificationResult.Results.OptimisticConcurrencyException,
                    ExceptionMessage = ex.Message
                };
            }
            catch (Exception ex)
            {
                return new DataModificationResult()
                {
                    Result = DataModificationResult.Results.OptimisticConcurrencyException,
                    ExceptionMessage = ex.Message
                };
            }
        }

        public DataModificationResult DeletePerson(Person person)
        {
            try
            {
                using (PraetorTestEntities db = new PraetorTestEntities())
                {
                    db.Person.Attach(person);
                    db.Person.Remove(person);
                    db.SaveChanges();
                    return new DataModificationResult() { Result = DataModificationResult.Results.Ok };
                }
            }
            catch (DbUpdateConcurrencyException ex)
            {
                return new DataModificationResult() 
                {
                    Result = DataModificationResult.Results.OptimisticConcurrencyException,
                    ExceptionMessage = ex.Message
                };
            }
            catch (Exception ex)
            {
                return new DataModificationResult()
                {
                    Result = DataModificationResult.Results.OptimisticConcurrencyException,
                    ExceptionMessage = ex.Message
                };
            }
        }
    }
}
