using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryServices
    {
        public static CategoryDTO Get(int id)
        {
            var data = CategoryRepo.Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryDTO>();
            });
            var mapper = new Mapper(config);
            var ret = mapper.Map<CategoryDTO>(data);
            return ret;
        }
        public static void Create(CategoryDTO c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryDTO>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(c);
            CategoryRepo.Create(data);
        }
    }
}
