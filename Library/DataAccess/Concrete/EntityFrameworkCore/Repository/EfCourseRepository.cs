﻿using KUSYSDemo.DataAccess.Concrete.EntityFrameworkCore.Context;
using KUSYSDemo.DataAccess.Interfaces;
using KUSYSDemo.Entities.Concrete;
using System.Linq.Expressions;

namespace KUSYSDemo.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfCourseRepository : EfGenericRepository<Course>, ICourseDal
    {
        public EfCourseRepository(PiccusCareContext context) : base(context)
        {
        }
    }
}
