using Hospital.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital.DAL
{
    public class HospitalInitializer
    {
        public static void Seed(HospitalContext context)
        {
            SeedPatients(context, 200);
        }

        public static void SeedPatients(HospitalContext context, int count)
        {
            for(var i = 0; i < count; i++)
            {
                context.Patients.Add(PatientGenerator.NewPatient(context));
            }
            context.SaveChanges();
        }
    }
}