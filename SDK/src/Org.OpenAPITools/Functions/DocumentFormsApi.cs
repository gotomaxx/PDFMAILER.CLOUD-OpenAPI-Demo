using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Functions
{ 
    public partial class DocumentFormsApi
    { 
        [FunctionName("DocumentFormsApi_GetForm")]
        public async Task<ActionResult<GotomaxxDocumentFormRestResponse>> _GetForm([HttpTrigger(AuthorizationLevel.Anonymous, "Get", Route = "rechnungsportal/service/rest/outgoingform/{id}")]HttpRequest req, ExecutionContext context, int id)
        {
            var method = this.GetType().GetMethod("GetForm");
            return method != null
                ? (await ((Task<GotomaxxDocumentFormRestResponse>)method.Invoke(this, new object[] { req, context, id })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }
    }
}
