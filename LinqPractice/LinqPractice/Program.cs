using LinqPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = GenerateListPeople();
            List<Classroom> listClassRoom = GenerateListClassroom();
            //Where
            /*
             * SQL : Select columns  from Person where age > 20;
             * 
             * LINQ : From variable in List,Collection , Condition => Select
             */

            var peopleAbove30 = listPerson.Where(item => item.Age > 30 ).OrderBy(item => item.Age);

            var peopleAbove30Query = from s in listPerson where s.Age > 30 select s;
            Console.WriteLine(peopleAbove30);
            Console.WriteLine(peopleAbove30Query);

            var JaneObject = listPerson.Where(item => item.Age > 30 && item.FirstName.Equals("Jane"));
            Console.WriteLine(JaneObject);

            //Skip
            var aferThreePeople = listPerson.Skip(3);
            var skipResult = new List<Person>();
            for(var i = 0; i<listPerson.Count; i++)
            {
                if(i > 2)
                {
                    skipResult.Add(listPerson[i]);
                }
            }

            //Take 
            var TakePeoplePeople = listPerson.Take(3);
            var takeResult = new List<Person>();
            for (var i = 0; i < listPerson.Count; i++)
            {
                if (i < 3)
                {
                    takeResult.Add(listPerson[i]);
                }
            }

            //FirstOrDefault  LastOrDefault SingleOrDefault
            var firstThirtyYearOldDefault = listPerson.Where(item => item.Age > 30).FirstOrDefault();
            var person = new Person()
            {
                FirstName = firstThirtyYearOldDefault.FirstName,
                LastName = firstThirtyYearOldDefault.LastName,
                Age = firstThirtyYearOldDefault.Age,
                Occupation = firstThirtyYearOldDefault.Occupation
            };
            //var firstThirtyYearOld = listPerson.Where(item => item.Age > 50).First();
            Console.WriteLine(firstThirtyYearOldDefault);
            //All - Boolean

            bool checkAllDev = listPerson.All(item => item.Occupation.Equals("Dev'"));
            bool checkExistedDev = listPerson.Any(item => item.Occupation.Equals("Dev'"));


            //ToList - ToArray
            var listDev = listPerson.Where(item => item.Occupation.Equals("Dev"));
            var listPeople = new List<Person>();
            foreach(var item in listDev)
            {
                listPeople.Add(item);
            }

            //Join 
            var InnerJoin = listClassRoom.Join(
                    listPerson,
                    classroom => classroom.PersonID,
                    item => item.Id,
                    (classroom, item) => new
                    {
                        personFirstName = item.FirstName,
                        personLastName = item.LastName,
                        personAge = item.Age,
                        Occpation = item.Occupation,
                        ClassName = classroom.Name
                    }
                ).ToList();

            /*
             * Select Person.FirstName, Person.LastName, Person.Age, Person.Occupation, Person.ClassName from 
             * ClassRoom Join Person On Person.Id = ClassRoom.Person.Id
             */

            //Aggregate, Contain, Average

            Console.WriteLine(InnerJoin);

            Console.ReadLine();
        }

        public static List<Person> GenerateListPeople()
        {
            List<Person> listPeople = new List<Person>();

            listPeople.Add(new Person { Id = 1, FirstName = "Eric", LastName = "Fleming", Occupation = "Dev", Age = 24 });
            listPeople.Add(new Person { Id = 2, FirstName = "Steve", LastName = "Smith", Occupation = "Manager", Age = 40 });
            listPeople.Add(new Person { Id = 3, FirstName = "Brendan", LastName = "Enrick", Occupation = "Dev", Age = 30 });
            listPeople.Add(new Person { Id = 4, FirstName = "Jane", LastName = "Doe", Occupation = "Dev", Age = 35 });
            listPeople.Add(new Person { Id = 5, FirstName = "Samantha", LastName = "Jones", Occupation = "Dev", Age = 24 });

            return listPeople;
        }

        public static List<Classroom> GenerateListClassroom()
        {
            List<Classroom> listClassRoom = new List<Classroom>();

            listClassRoom.Add(new Classroom { Id = 1, Name = "ASP.NET", PersonID = 1 });
            listClassRoom.Add(new Classroom { Id = 2, Name = "JAVA", PersonID = 1 });
            listClassRoom.Add(new Classroom { Id = 3, Name = "GO", PersonID = 2 });
            listClassRoom.Add(new Classroom { Id = 4, Name = "JS", PersonID = 3 });

            return listClassRoom;
        }

    }
}
