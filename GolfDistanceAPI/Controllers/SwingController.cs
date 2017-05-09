using GolfDistanceAPI.Models.SwingModels;
using GolfDistanceAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GolfDistanceAPI.Controllers
{
    public class SwingController : ApiController
    {
        public ISwingService SwingService { get; set; }

        public SwingController(ISwingService swingService)
        {
            SwingService = swingService;
        }

        [Route("rounds/{roundId:int}/swings")]
        public HttpResponseMessage PostSwing(int roundId, Swing swing)
        {
            var savedSwing = SwingService.Post(roundId, swing);

            return Request.CreateResponse(HttpStatusCode.Created, savedSwing);
        }

        [Route("rounds/{roundId:int}/swings/{swingId:int}")]
        public HttpResponseMessage GetSwing(int roundId, int swingId)
        {
            var swing = SwingService.Get(roundId, swingId);

            return Request.CreateResponse(HttpStatusCode.OK, swing);
        }

        [Route("rounds/{roundId:int}/swings/{swingId:int}")]
        public HttpResponseMessage PutSwing(int roundId, int swingId, Swing swing)
        {
            if(swingId != swing.Id)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Invalid swing id");
            }

            var updatedSwing = SwingService.Put(roundId, swing);

            return Request.CreateResponse(HttpStatusCode.OK, updatedSwing);
        }

        [Route("rounds/{roundId:int}/swings/{swingId:int}")]
        public HttpResponseMessage DeleteSwing(int roundId, int swingId)
        {
            SwingService.Delete(roundId, swingId);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
