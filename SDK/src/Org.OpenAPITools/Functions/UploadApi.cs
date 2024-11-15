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
    public partial class UploadApi
    { 
        [FunctionName("UploadApi_GetAsyncUploadStatus")]
        public async Task<ActionResult<GotomaxxAsyncOutgoingRestStatus>> _GetAsyncUploadStatus([HttpTrigger(AuthorizationLevel.Anonymous, "Put", Route = "rechnungsportal/service/rest/outgoingasyncuploadstatus/{token}")]HttpRequest req, ExecutionContext context, string token)
        {
            var method = this.GetType().GetMethod("GetAsyncUploadStatus");
            return method != null
                ? (await ((Task<GotomaxxAsyncOutgoingRestStatus>)method.Invoke(this, new object[] { req, context, token })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("UploadApi_JsonUpload")]
        public async Task<ActionResult<PdfUpload200Response>> _JsonUpload([HttpTrigger(AuthorizationLevel.Anonymous, "Post", Route = "rechnungsportal/service/rest/outgoingjson")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("JsonUpload");
            return method != null
                ? (await ((Task<PdfUpload200Response>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("UploadApi_PdfUpload")]
        public async Task<ActionResult<PdfUpload200Response>> _PdfUpload([HttpTrigger(AuthorizationLevel.Anonymous, "Post", Route = "rechnungsportal/service/rest/outgoingpdf")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("PdfUpload");
            return method != null
                ? (await ((Task<PdfUpload200Response>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("UploadApi_XRechnungUpload")]
        public async Task<ActionResult<PdfUpload200Response>> _XRechnungUpload([HttpTrigger(AuthorizationLevel.Anonymous, "Post", Route = "rechnungsportal/service/rest/outgoingxrechnung")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("XRechnungUpload");
            return method != null
                ? (await ((Task<PdfUpload200Response>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("UploadApi_XmlUpload")]
        public async Task<ActionResult<PdfUpload200Response>> _XmlUpload([HttpTrigger(AuthorizationLevel.Anonymous, "Post", Route = "rechnungsportal/service/rest/outgoingxml")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("XmlUpload");
            return method != null
                ? (await ((Task<PdfUpload200Response>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }

        [FunctionName("UploadApi_ZUGFeRDUpload")]
        public async Task<ActionResult<PdfUpload200Response>> _ZUGFeRDUpload([HttpTrigger(AuthorizationLevel.Anonymous, "Post", Route = "rechnungsportal/service/rest/outgoingzugferd")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("ZUGFeRDUpload");
            return method != null
                ? (await ((Task<PdfUpload200Response>)method.Invoke(this, new object[] { req, context })).ConfigureAwait(false))
                : new StatusCodeResult((int)HttpStatusCode.NotImplemented);
        }
    }
}
