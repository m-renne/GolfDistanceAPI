using GolfDistanceAPI.Models.SwingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfDistanceAPI.Repositories
{
    public interface ISwingRepository
    {
        Swing Get(int roundId, int swingId);
        void Put(int roundId, Swing swing);
        int Post(int roundId, Swing swing);
        void Delete(int roundId, int swingId);

    }
}
