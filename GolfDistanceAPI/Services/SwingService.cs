using GolfDistanceAPI.Models.SwingModels;
using GolfDistanceAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfDistanceAPI.Services
{
    public class SwingService : ISwingService
    {
        public ISwingRepository Repository { get; set; }

        public SwingService(ISwingRepository repository)
        {
            Repository = repository;
        }

        public Swing Get(int roundId, int swingId)
        {
            var swing = Repository.Get(roundId, swingId);

            return swing;
        }

        public Swing Put(int roundId, Swing swing)
        {
            Repository.Put(roundId, swing);

            var updateSwing = Get(roundId, swing.Id);

            return updateSwing;
        }

        public Swing Post(int roundId, Swing swing)
        {
            var swingId = Repository.Post(roundId, swing);

            var updateSwing = Get(roundId, swingId);

            return updateSwing;
        }

        public void Delete(int roundId, int swingId)
        {
            Repository.Delete(roundId, swingId);
        }
    }
}