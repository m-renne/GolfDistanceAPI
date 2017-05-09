using GolfDistanceAPI.Models.SwingModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfDistanceAPI.Services
{
    public interface ISwingService
    {
        Swing Get(int roundId, int swingId);
        Swing Put(int roundId, Swing swing);
        Swing Post(int roundId, Swing swing);
        void Delete(int roundId, int swingId);
    }
}
