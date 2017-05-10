using GolfDistanceAPI.Domain.Rounds;
using GolfDistanceAPI.Infrastructure.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GolfDistanceAPI.Infrastructure.Repositories
{
    public class RoundsRepository : IRoundsRepository
    {
        public Round Get(int roundId)
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
            return new Round();
        }

        public List<Round> Get()
        {
            return new List<Round>();
        }

        public void Put(Round round)
        {

        }

        public int Post(Round round)
        {
            return 1;
        }
        public void Delete(int roundId)
        {

        }
    }
}