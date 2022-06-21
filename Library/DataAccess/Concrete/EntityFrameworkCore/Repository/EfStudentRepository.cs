﻿using KUSYSDemo.DataAccess.Concrete.EntityFrameworkCore.Context;
using KUSYSDemo.DataAccess.Interfaces;
using KUSYSDemo.Entities.Concrete;

namespace KUSYSDemo.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class EfStudentRepository : EfGenericRepository<Student>, IStudentDal
    {
        public EfStudentRepository(PiccusCareContext context) : base(context)
        {
        }
    }
}
