﻿using Academyems.CoreDbContext;
using Academyems.CoreDbContext.Entities;
using Academyems.Data.DTO;

namespace Academyems.Repositories
{
    public class CourseTypeRepository : ICourseTypeRepository
    {

        private readonly AppDbContext _dbContext;
        public CourseTypeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreateCourseType(CourseType request)
        {
            return 1;
        }

        public List<CourseType> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<CourseTypeDTO> GetByCourseId(int courseId)
        {
            throw new NotImplementedException();
        }

        public List<CourseTypeDTO> GetByCourseTypeID(int id)
        {
            throw new NotImplementedException();
        }

        public CourseTypeDTO GetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
