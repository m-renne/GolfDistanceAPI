using GolfDistanceAPI.Domain.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfDistanceAPI.Infrastructure.Repositories
{
    public class CoursesRepository
    {
        public CoursesRepository()
        {

        }

        public Course Get(int courseId)
        {
            //using (var conn = new SqlConnection(Configuration.ConnectionString))
            //using (var cmd = new SqlCommand("dbo.GetPlayers", conn))
            //{
            //cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.Add("@NBATeamId", SqlDbType.Int).Value = criteria.TeamId;

            //conn.Open();

            //var reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    players.Add(

            //}
            //return players;
            //}
            return new Course();
        }

        public List<Course> Get()
        {
            return new List<Course>();
        }

        public void Update(Course course)
        {

        }

        public int Create(Course course)
        {
            return 1;
        }
    }
}
