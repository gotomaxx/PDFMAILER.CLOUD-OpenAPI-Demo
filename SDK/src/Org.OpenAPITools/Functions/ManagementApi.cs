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
using System.Collections.Generic;

namespace Org.OpenAPITools.Functions
{ 
    public partial class ManagementApi
    { 
        [FunctionName("ManagementApi_DeletePdf")]
        public async Task<ActionResult<int>> _DeletePdf([HttpTrigger(AuthorizationLevel.Anonymous, "Delete", Route = "rechnungsportal/service/rest/outgoingpdf/{ids}")]HttpRequest req, ExecutionContext context, string ids)
        {
            var method = this.GetType().GetMethod("DeletePdf");
            return method != null
                ? (await ((Task<int>)method.Invoke(this, new object[] { req, context, ids })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("ManagementApi_GetFile")]
        public async Task<ActionResult<string>> _GetFile([HttpTrigger(AuthorizationLevel.Anonymous, "Get", Route = "rechnungsportal/service/rest/outgoingfile/{id}")]HttpRequest req, ExecutionContext context, int id)
        {
            var method = this.GetType().GetMethod("GetFile");
            return method != null
                ? (await ((Task<string>)method.Invoke(this, new object[] { req, context, id })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("ManagementApi_GetPdfDetails")]
        public async Task<ActionResult<List<GotomaxxPdfUploadRestResponse>>> _GetPdfDetails([HttpTrigger(AuthorizationLevel.Anonymous, "Get", Route = "rechnungsportal/service/rest/outgoingpdf/{ids}")]HttpRequest req, ExecutionContext context, string ids)
        {
            var method = this.GetType().GetMethod("GetPdfDetails");
            return method != null
                ? (await ((Task<List<GotomaxxPdfUploadRestResponse>>)method.Invoke(this, new object[] { req, context, ids })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("ManagementApi_GetPdfDetailsByAsyncUploadToken")]
        public async Task<ActionResult<GotomaxxPdfUploadRestResponse>> _GetPdfDetailsByAsyncUploadToken([HttpTrigger(AuthorizationLevel.Anonymous, "Get", Route = "rechnungsportal/service/rest/outgoingasyncupload/{token}")]HttpRequest req, ExecutionContext context, string token)
        {
            var method = this.GetType().GetMethod("GetPdfDetailsByAsyncUploadToken");
            return method != null
                ? (await ((Task<GotomaxxPdfUploadRestResponse>)method.Invoke(this, new object[] { req, context, token })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("ManagementApi_GetPdfList")]
        public async Task<ActionResult<List<GotomaxxPdfUploadRestResponse>>> _GetPdfList([HttpTrigger(AuthorizationLevel.Anonymous, "Get", Route = "rechnungsportal/service/rest/outgoingpdf")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("GetPdfList");
            return method != null
                ? (await ((Task<List<GotomaxxPdfUploadRestResponse>>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }
    }
}
