﻿using AutoFacWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacWeb.Repository
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person Get(int id);
        Person Add(Person item);
        bool Update(Person item);
        bool Delete(int id);

    }
}