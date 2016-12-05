using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC201612.Models.Module02
{
    public class PersonHelper
    {
        public Person GetPerson() {
            return GetAllPeople()[0];
        }
        public List<Person> GetAllPeople()
        {

            List<Person> lst = new List<Person>();
            lst.Add(new Person() { IdPerson = 1, Name = "x", Country = "y" });
            lst.Add(new Person() { IdPerson = 2, Name = "z", Country = "u" });
            return lst;
        }
        public List<PersonViewModel> GetAllPeopleAsViewModel()
        {
            var lst = GetAllPeople();
            Mapper.Initialize(cfg => cfg.CreateMap<Person, PersonViewModel>());
            List<PersonViewModel> l = Mapper.Map<List<PersonViewModel>>(lst);
            return l;
        }

    }
}