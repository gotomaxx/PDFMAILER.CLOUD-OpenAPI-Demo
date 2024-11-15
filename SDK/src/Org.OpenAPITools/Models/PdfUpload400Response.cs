/*
 * Outgoing file RESTful service
 *
 * The methods are restricted to portal user that have the permission for sending documents. Different API versions work differently - be sure  you know what you're doing, before you set an API version. The portal may define a minimum API version that can't be overridden.  Before you can use the REST API for your portal, you need to accept the DSGVO AVV once. Also, the REST API is currently restricted to customers  that bought a PDFMAILER (non-Pure) license from gotomaxx directly, or are coming from XRechnung.new or ZUGFeRD.new.  If you don't know how to get your personal Bearer token (which is required to call any API method), please contact our technical support.  In case your REST client doesn't support OAuth2 or Bearer token, there are other possibilities for authentication:  - Use basic http authentication with your user credentials - Send a valid session ID as value in the parameter (GET or POST) `__sid` with every request  Please ask our technical staff for instructions how to create a valid session ID that can be used with this REST API.  __NOTE__: Boolean parameter values should be given as `1` (`true`) or `0` (`false`).  __NOTE__: The XRechnung API functionality requires a separate license and user permission.
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Org.OpenAPITools.Converters;

namespace Org.OpenAPITools.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class PdfUpload400Response : IEquatable<PdfUpload400Response>
    {
        /// <summary>
        /// Debug record ID  If you contact our technical support staff regarding a failed upload, please include this ID in your support request.  __NOTE__: The ID is zero, if the test succeed and debugging is disabled.
        /// </summary>
        /// <value>Debug record ID  If you contact our technical support staff regarding a failed upload, please include this ID in your support request.  __NOTE__: The ID is zero, if the test succeed and debugging is disabled.</value>
        [Required]
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Was this a test upload?  The value will be &#x60;true&#x60;, if you used one of the REST APIs test methods to perform the upload. If you used a real document upload method,  the value will be &#x60;false&#x60;.
        /// </summary>
        /// <value>Was this a test upload?  The value will be &#x60;true&#x60;, if you used one of the REST APIs test methods to perform the upload. If you used a real document upload method,  the value will be &#x60;false&#x60;.</value>
        [Required]
        [DataMember(Name="test", EmitDefaultValue=false)]
        public bool Test { get; set; }

        /// <summary>
        /// General processing error
        /// </summary>
        /// <value>General processing error</value>
        [Required]
        [DataMember(Name="error", EmitDefaultValue=true)]
        public string Error { get; set; }

        /// <summary>
        /// Upload valid?
        /// </summary>
        /// <value>Upload valid?</value>
        [Required]
        [DataMember(Name="valid", EmitDefaultValue=false)]
        public bool Valid { get; set; }


        /// <summary>
        /// Upload type  This describes the upload origin source data format, which you've sent to a REST method.
        /// </summary>
        /// <value>Upload type  This describes the upload origin source data format, which you've sent to a REST method.</value>
        [TypeConverter(typeof(CustomEnumConverter<TypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum JSONEnum for JSON
            /// </summary>
            [EnumMember(Value = "JSON")]
            JSONEnum = 1,
            
            /// <summary>
            /// Enum XMLEnum for XML
            /// </summary>
            [EnumMember(Value = "XML")]
            XMLEnum = 2,
            
            /// <summary>
            /// Enum XRechnungEnum for XRechnung
            /// </summary>
            [EnumMember(Value = "XRechnung")]
            XRechnungEnum = 3,
            
            /// <summary>
            /// Enum ZUGFeRDEnum for ZUGFeRD
            /// </summary>
            [EnumMember(Value = "ZUGFeRD")]
            ZUGFeRDEnum = 4
        }

        /// <summary>
        /// Upload type  This describes the upload origin source data format, which you&#39;ve sent to a REST method.
        /// </summary>
        /// <value>Upload type  This describes the upload origin source data format, which you&#39;ve sent to a REST method.</value>
        [Required]
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Used target transformation  This describes the target document data format, which you may have defined within your request to a REST method, or which has been chosen  by the processor.
        /// </summary>
        /// <value>Used target transformation  This describes the target document data format, which you may have defined within your request to a REST method, or which has been chosen  by the processor.</value>
        [TypeConverter(typeof(CustomEnumConverter<TargetEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TargetEnum
        {
            
            /// <summary>
            /// Enum XRechnung3CIIEnum for XRechnung3CII
            /// </summary>
            [EnumMember(Value = "XRechnung3CII")]
            XRechnung3CIIEnum = 1,
            
            /// <summary>
            /// Enum ZUGFeRD2ComfortEnum for ZUGFeRD2Comfort
            /// </summary>
            [EnumMember(Value = "ZUGFeRD2Comfort")]
            ZUGFeRD2ComfortEnum = 2
        }

        /// <summary>
        /// Used target transformation  This describes the target document data format, which you may have defined within your request to a REST method, or which has been chosen  by the processor.
        /// </summary>
        /// <value>Used target transformation  This describes the target document data format, which you may have defined within your request to a REST method, or which has been chosen  by the processor.</value>
        [Required]
        [DataMember(Name="target", EmitDefaultValue=true)]
        public TargetEnum? Target { get; set; }

        /// <summary>
        /// XRechnung XML  The given or produced XRechnung XML.
        /// </summary>
        /// <value>XRechnung XML  The given or produced XRechnung XML.</value>
        [Required]
        [DataMember(Name="xrechnung", EmitDefaultValue=true)]
        public string Xrechnung { get; set; }

        /// <summary>
        /// ZUGFeRD XML  The given or produced ZUGFeRD XML.
        /// </summary>
        /// <value>ZUGFeRD XML  The given or produced ZUGFeRD XML.</value>
        [Required]
        [DataMember(Name="zugferd", EmitDefaultValue=true)]
        public string Zugferd { get; set; }

        /// <summary>
        /// gotomaxx XML  The given or produced gotomaxx XML.
        /// </summary>
        /// <value>gotomaxx XML  The given or produced gotomaxx XML.</value>
        [Required]
        [DataMember(Name="xml", EmitDefaultValue=true)]
        public string Xml { get; set; }

        /// <summary>
        /// JSON document  The given JSON document.
        /// </summary>
        /// <value>JSON document  The given JSON document.</value>
        [Required]
        [DataMember(Name="json", EmitDefaultValue=true)]
        public string Json { get; set; }

        /// <summary>
        /// Processed JSON document  The processed JSON document, which may contain auto-completed values.
        /// </summary>
        /// <value>Processed JSON document  The processed JSON document, which may contain auto-completed values.</value>
        [Required]
        [DataMember(Name="jsonProcessed", EmitDefaultValue=true)]
        public string JsonProcessed { get; set; }

        /// <summary>
        /// Created invalid PDF file  The contents of the produced PDF file which is invalid for use as the final PDF document.
        /// </summary>
        /// <value>Created invalid PDF file  The contents of the produced PDF file which is invalid for use as the final PDF document.</value>
        [Required]
        [DataMember(Name="pdf", EmitDefaultValue=true)]
        public string Pdf { get; set; }

        /// <summary>
        /// Created HTML  The HTML code that was created from the XRechnung or ZUGFeRD XML, which is the base for rendering a PDF file.
        /// </summary>
        /// <value>Created HTML  The HTML code that was created from the XRechnung or ZUGFeRD XML, which is the base for rendering a PDF file.</value>
        [Required]
        [DataMember(Name="html", EmitDefaultValue=true)]
        public string Html { get; set; }

        /// <summary>
        /// Used PDFMAILER configuration
        /// </summary>
        /// <value>Used PDFMAILER configuration</value>
        [Required]
        [DataMember(Name="pdfmailerConfig", EmitDefaultValue=true)]
        public string PdfmailerConfig { get; set; }

        /// <summary>
        /// XRechnung processing error
        /// </summary>
        /// <value>XRechnung processing error</value>
        [Required]
        [DataMember(Name="xrechnungError", EmitDefaultValue=true)]
        public string XrechnungError { get; set; }

        /// <summary>
        /// ZUGFeRD processing error
        /// </summary>
        /// <value>ZUGFeRD processing error</value>
        [Required]
        [DataMember(Name="zugferdError", EmitDefaultValue=true)]
        public string ZugferdError { get; set; }

        /// <summary>
        /// gotomaxx XML processing error
        /// </summary>
        /// <value>gotomaxx XML processing error</value>
        [Required]
        [DataMember(Name="xmlError", EmitDefaultValue=true)]
        public string XmlError { get; set; }

        /// <summary>
        /// JSON processing error
        /// </summary>
        /// <value>JSON processing error</value>
        [Required]
        [DataMember(Name="jsonError", EmitDefaultValue=true)]
        public string JsonError { get; set; }

        /// <summary>
        /// PDF processing error
        /// </summary>
        /// <value>PDF processing error</value>
        [Required]
        [DataMember(Name="pdfError", EmitDefaultValue=true)]
        public string PdfError { get; set; }

        /// <summary>
        /// HTML processing error
        /// </summary>
        /// <value>HTML processing error</value>
        [Required]
        [DataMember(Name="htmlError", EmitDefaultValue=true)]
        public string HtmlError { get; set; }

        /// <summary>
        /// Runtime in seconds
        /// </summary>
        /// <value>Runtime in seconds</value>
        [Required]
        [DataMember(Name="runtime", EmitDefaultValue=false)]
        public int Runtime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PdfUpload400Response {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Test: ").Append(Test).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Xrechnung: ").Append(Xrechnung).Append("\n");
            sb.Append("  Zugferd: ").Append(Zugferd).Append("\n");
            sb.Append("  Xml: ").Append(Xml).Append("\n");
            sb.Append("  Json: ").Append(Json).Append("\n");
            sb.Append("  JsonProcessed: ").Append(JsonProcessed).Append("\n");
            sb.Append("  Pdf: ").Append(Pdf).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  PdfmailerConfig: ").Append(PdfmailerConfig).Append("\n");
            sb.Append("  XrechnungError: ").Append(XrechnungError).Append("\n");
            sb.Append("  ZugferdError: ").Append(ZugferdError).Append("\n");
            sb.Append("  XmlError: ").Append(XmlError).Append("\n");
            sb.Append("  JsonError: ").Append(JsonError).Append("\n");
            sb.Append("  PdfError: ").Append(PdfError).Append("\n");
            sb.Append("  HtmlError: ").Append(HtmlError).Append("\n");
            sb.Append("  Runtime: ").Append(Runtime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((PdfUpload400Response)obj);
        }

        /// <summary>
        /// Returns true if PdfUpload400Response instances are equal
        /// </summary>
        /// <param name="other">Instance of PdfUpload400Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PdfUpload400Response other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    
                    Id.Equals(other.Id)
                ) && 
                (
                    Test == other.Test ||
                    
                    Test.Equals(other.Test)
                ) && 
                (
                    Error == other.Error ||
                    Error != null &&
                    Error.Equals(other.Error)
                ) && 
                (
                    Valid == other.Valid ||
                    
                    Valid.Equals(other.Valid)
                ) && 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    Target == other.Target ||
                    
                    Target.Equals(other.Target)
                ) && 
                (
                    Xrechnung == other.Xrechnung ||
                    Xrechnung != null &&
                    Xrechnung.Equals(other.Xrechnung)
                ) && 
                (
                    Zugferd == other.Zugferd ||
                    Zugferd != null &&
                    Zugferd.Equals(other.Zugferd)
                ) && 
                (
                    Xml == other.Xml ||
                    Xml != null &&
                    Xml.Equals(other.Xml)
                ) && 
                (
                    Json == other.Json ||
                    Json != null &&
                    Json.Equals(other.Json)
                ) && 
                (
                    JsonProcessed == other.JsonProcessed ||
                    JsonProcessed != null &&
                    JsonProcessed.Equals(other.JsonProcessed)
                ) && 
                (
                    Pdf == other.Pdf ||
                    Pdf != null &&
                    Pdf.Equals(other.Pdf)
                ) && 
                (
                    Html == other.Html ||
                    Html != null &&
                    Html.Equals(other.Html)
                ) && 
                (
                    PdfmailerConfig == other.PdfmailerConfig ||
                    PdfmailerConfig != null &&
                    PdfmailerConfig.Equals(other.PdfmailerConfig)
                ) && 
                (
                    XrechnungError == other.XrechnungError ||
                    XrechnungError != null &&
                    XrechnungError.Equals(other.XrechnungError)
                ) && 
                (
                    ZugferdError == other.ZugferdError ||
                    ZugferdError != null &&
                    ZugferdError.Equals(other.ZugferdError)
                ) && 
                (
                    XmlError == other.XmlError ||
                    XmlError != null &&
                    XmlError.Equals(other.XmlError)
                ) && 
                (
                    JsonError == other.JsonError ||
                    JsonError != null &&
                    JsonError.Equals(other.JsonError)
                ) && 
                (
                    PdfError == other.PdfError ||
                    PdfError != null &&
                    PdfError.Equals(other.PdfError)
                ) && 
                (
                    HtmlError == other.HtmlError ||
                    HtmlError != null &&
                    HtmlError.Equals(other.HtmlError)
                ) && 
                (
                    Runtime == other.Runtime ||
                    
                    Runtime.Equals(other.Runtime)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    
                    hashCode = hashCode * 59 + Test.GetHashCode();
                    if (Error != null)
                    hashCode = hashCode * 59 + Error.GetHashCode();
                    
                    hashCode = hashCode * 59 + Valid.GetHashCode();
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    
                    hashCode = hashCode * 59 + Target.GetHashCode();
                    if (Xrechnung != null)
                    hashCode = hashCode * 59 + Xrechnung.GetHashCode();
                    if (Zugferd != null)
                    hashCode = hashCode * 59 + Zugferd.GetHashCode();
                    if (Xml != null)
                    hashCode = hashCode * 59 + Xml.GetHashCode();
                    if (Json != null)
                    hashCode = hashCode * 59 + Json.GetHashCode();
                    if (JsonProcessed != null)
                    hashCode = hashCode * 59 + JsonProcessed.GetHashCode();
                    if (Pdf != null)
                    hashCode = hashCode * 59 + Pdf.GetHashCode();
                    if (Html != null)
                    hashCode = hashCode * 59 + Html.GetHashCode();
                    if (PdfmailerConfig != null)
                    hashCode = hashCode * 59 + PdfmailerConfig.GetHashCode();
                    if (XrechnungError != null)
                    hashCode = hashCode * 59 + XrechnungError.GetHashCode();
                    if (ZugferdError != null)
                    hashCode = hashCode * 59 + ZugferdError.GetHashCode();
                    if (XmlError != null)
                    hashCode = hashCode * 59 + XmlError.GetHashCode();
                    if (JsonError != null)
                    hashCode = hashCode * 59 + JsonError.GetHashCode();
                    if (PdfError != null)
                    hashCode = hashCode * 59 + PdfError.GetHashCode();
                    if (HtmlError != null)
                    hashCode = hashCode * 59 + HtmlError.GetHashCode();
                    
                    hashCode = hashCode * 59 + Runtime.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PdfUpload400Response left, PdfUpload400Response right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PdfUpload400Response left, PdfUpload400Response right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
