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
            string address = AddressGenerator.NewAddress();

            var patient = new Patient()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Address = address
            };
            patient.Visitations = GenerateVisitations(patient);
            patient.Diagnoses = GenerateDiagnoses(patient);

            return patient;
        }

        private static Diagnose[] GenerateDiagnoses(Patient patient)
        {
            var diagnoseNames = new string[]
            {
                "Lung Cancer",
                "Heart Attack",
                "Strock",
                "Covid",
                "HIV"
            };

            int diagnoseCount = random.Next(1, 4);
            var diagnoses = new Diagnose[diagnoseCount];
            for (int i = 0; i < diagnoseCount; i++)
            {
                string diagnoseName = diagnoseNames[random.Next(diagnoseNames.Length)];

                var diagnose = new Diagnose()
                {
                    Name = diagnoseName,
                    Patient = patient
                };

                diagnoses[i] = diagnose;
            }

            return diagnoses;
        }

        private static Visitation[] GenerateVisitations(Patient patient)
        {
            int visitationCount = random.Next(1, 5);

            var visitations = new Visitation[visitationCount];

            for (int i = 0; i < visitationCount; i++)
            {
                var visitationDate = RandomDay(2005);

                var visitation = new Visitation()
                {
                    Date = visitationDate,
                    Patient = patient
                };

                visitations[i] = visitation;
            }

            return visitations;
        }

        private static DateTime RandomDay(int startYear)
        {
            DateTime start = new DateTime(startYear, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }
    }
}