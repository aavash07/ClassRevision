using Class_revison.data.Entinities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_revison.data.Services
{
    public interface ICollegeServices
    {
        List<College> GetColleges();
        College GetCollegeById(int id);
        void AddCollege(College college);
        void UpdateCollege(College college);
        void DeleteCollege(int id);
        
    }
}
