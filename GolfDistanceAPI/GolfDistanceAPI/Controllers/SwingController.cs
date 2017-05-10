using GolfDistanceAPI.Application.Interfaces.Services;
using GolfDistanceAPI.Infrastructure.Interfaces.Factories;
using GolfDistanceAPI.ServiceModels.Swings;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GolfDistanceAPI.Controllers
{
    public class SwingController : ApiController
    {
        private IBaseFactory ServiceFactory { get; set; }

        public SwingController(IBaseFactory serviceFactory)
        {
            ServiceFactory = serviceFactory;
        }

        [Route("rounds/{roundId:int}/swings")]
        public HttpResponseMessage PostSwing(int roundId, Swing swing)
        {
            ISwingService service = ServiceFactory.Create<ISwingService>();

            var savedSwing = service.Post(roundId, swing);

            return Request.CreateResponse(HttpStatusCode.Created, savedSwing);
        }

        [Route("rounds/{roundId:int}/swings/{swingId:int}")]
        public HttpResponseMessage GetSwing(int roundId, int swingId)
        {
            ISwingService service = ServiceFactory.Create<ISwingService>();

            Swing swing = service.Get(roundId, swingId);

            return Request.CreateResponse(HttpStatusCode.OK, swing);
        }

        [Route("rounds/{roundId:int}/swings/{swingId:int}")]
        public HttpResponseMessage PutSwing(int roundId, int swingId, Swing swing)
        {
            if(swingId != swing.Id)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Conflict, "Invalid swing id");
            }

            ISwingService service = ServiceFactory.Create<ISwingService>();

            Swing updatedSwing = service.Put(roundId, swing);

            return Request.CreateResponse(HttpStatusCode.OK, updatedSwing);
        }

        [Route("rounds/{roundId:int}/swings/{swingId:int}")]
        public HttpResponseMessage DeleteSwing(int roundId, int swingId)
        {
            ISwingService service = ServiceFactory.Create<ISwingService>();

            service.Delete(roundId, swingId);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
