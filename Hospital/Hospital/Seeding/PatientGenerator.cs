using Hospital.DAL;
using Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.Seeding
{
    public class PatientGenerator
    {
        private static Random random = new Random();

        public static Patient NewPatient(HospitalContext context)
        {
            string firstName = NameGenerator.FirstName();
            string lastName = NameGenerator.LastName();
            string email = EmailGenerator.GenerateEmail(firstName + lastName);

            var patient = new Patient()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email
            }
        }


    }
}