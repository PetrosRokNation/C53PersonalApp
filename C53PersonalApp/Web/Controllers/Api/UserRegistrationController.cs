using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace C53PersonalApp.Web.Controllers.Api
{
   // [RoutePrefix("api/user-registration")]
    public class UserRegistrationController : ApiController
    {
        //[Route, HttpPost]
        //public HttpResponseMessage UserRegistration(UserRegistrationAddRequest model)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            UserRegistrationService svc = new UserRegistrationService();
        //            int id = svc.Insert(model);
        //            ItemResponse<int> resp = new ItemResponse<int>();
        //            resp.Item = id;

        //            return Request.CreateResponse(HttpStatusCode.OK, resp);
        //        }
        //        else
        //        {
        //            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}
    }
}
