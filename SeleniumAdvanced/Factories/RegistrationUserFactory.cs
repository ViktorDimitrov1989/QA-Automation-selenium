using AutoFixture;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAdvanced.Factories
{
    public static class RegistrationUserFactory
    {
        public static Models.RegistrationUser CreateValidUser()
        {
            return new Models.RegistrationUser
            {
                FirstName = "Pesho",
                LastName = "Gosho",
                Year = "1989",
                Month = "3",
                Date = "3",
                Password = "pass123",
                Gender = "male",
                PostCode = "43244",
                RealFirstName = "Gosho",
                RealLastName = "Peshev",
                Address = "Dolno nanagornishte",
                City = "Sofia",
                State = "Utah",
                Country = "Bulgaria",
                Phone = "088888888",
                Alias = "Suhata Reka"
            };
        }

    }
}
