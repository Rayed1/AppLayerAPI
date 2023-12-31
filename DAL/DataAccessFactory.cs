﻿using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Person, int, bool> PersonData()
        {
            return new PersonRepo();
        }
        public static IRepo<News, int, bool> NewsData() 
        {  
            return new NewsRepo(); 
        }
        public static IRepo<Category, int, bool> CategoryData()
        {
            return new CategoryRepo();
        }
    }
}
