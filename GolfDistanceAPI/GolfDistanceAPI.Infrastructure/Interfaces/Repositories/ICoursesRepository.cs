using GolfDistanceAPI.Domain.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfDistanceAPI.Infrastructure.Interfaces.Repositories
{
    public interface ICoursesRepository
    {
        Course Get(int courseId);

        List<Course> Get();

        void Update(Course course);

        int Create(Course course);
    }
}
