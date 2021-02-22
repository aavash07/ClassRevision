using Class_revison.data.Entinities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_revison.data.Services
{
    public class CollegeServices : ICollegeServices
    {
        private readonly MyDbContext _dbContext;
        public CollegeServices(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddCollege(College college)
        {
            _dbContext.College.Add(college);
            _dbContext.SaveChanges();
        }

        public void DeleteCollege(int id)
        {
            College college = _dbContext.College.FirstOrDefault(x => x.Id == id);
            if (college != null)
            {
                _dbContext.College.Remove(college);
            }
            _dbContext.SaveChanges();
        }

        public College GetCollegeById(int id)
        {
            return _dbContext.College.FirstOrDefault(x => x.Id == id);
        }

        public List<College> GetColleges()
        {
            return _dbContext.College.Select(x => new College
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Address = x.Address
            }).ToList();
        }

        public void UpdateCollege(College college)
        {
            var dbCollege = _dbContext.College.FirstOrDefault(x => x.Id == college.Id);
            if (dbCollege != null)
            {
                dbCollege.Name = college.Name;
                dbCollege.Address = college.Address;
                dbCollege.Email = college.Email;
                _dbContext.College.Update(dbCollege);
                _dbContext.SaveChanges();
            }

        }
    }
    }
}
