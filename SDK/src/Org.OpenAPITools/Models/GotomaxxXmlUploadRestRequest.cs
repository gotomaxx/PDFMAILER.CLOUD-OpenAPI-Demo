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
    /// XML upload REST request object template for documentation purposes  For letter delivery it&#39;s required to submit the destination country code, if it&#39;s not a national sending.
    /// </summary>
    [DataContract]
    public partial class GotomaxxXmlUploadRestRequest : IEquatable<GotomaxxXmlUploadRestRequest>
    {
        /// <summary>
        /// gotomaxx XML data (required)
        /// </summary>
        /// <value>gotomaxx XML data (required)</value>
        [Required]
        [MinLength(256)]
        [DataMember(Name="xml", EmitDefaultValue=false)]
        public string Xml { get; set; }

        /// <summary>
        /// When creating a XRechnung document, attach the &#x60;XRechnung.xml&#x60;?
        /// </summary>
        /// <value>When creating a XRechnung document, attach the &#x60;XRechnung.xml&#x60;?</value>
        [DataMember(Name="attach", EmitDefaultValue=false)]
        public bool Attach { get; set; }

        /// <summary>
        /// API version number
        /// </summary>
        /// <value>API version number</value>
        [Range(1, 3)]
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// Customer number
        /// </summary>
        /// <value>Customer number</value>
        [DataMember(Name="customer", EmitDefaultValue=false)]
        public string Customer { get; set; }

        /// <summary>
        /// Recipient email address
        /// </summary>
        /// <value>Recipient email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Email sender ID
        /// </summary>
        /// <value>Email sender ID</value>
        [DataMember(Name="emailSender", EmitDefaultValue=false)]
        public int EmailSender { get; set; }

        /// <summary>
        /// Recipient fax number  Valid formats are:  - 6392995599 - 06392995599 - 496293995599 - 00496392995599 - +496392995599  Delimiters like spaces, braces or a slash may be contained and will be removed for processing. Numbers without a country prefix are assumed to be numers from your home country.
        /// </summary>
        /// <value>Recipient fax number  Valid formats are:  - 6392995599 - 06392995599 - 496293995599 - 00496392995599 - +496392995599  Delimiters like spaces, braces or a slash may be contained and will be removed for processing. Numbers without a country prefix are assumed to be numers from your home country.</value>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }

        /// <summary>
        /// Recipient 2-letter country code  F.e. \&quot;DE\&quot; for Germany.  A value is required for letter sending to any country outside of your home country.
        /// </summary>
        /// <value>Recipient 2-letter country code  F.e. \&quot;DE\&quot; for Germany.  A value is required for letter sending to any country outside of your home country.</value>
        [StringLength(2, MinimumLength=2)]
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// SMS message
        /// </summary>
        /// <value>SMS message</value>
        [DataMember(Name="sms", EmitDefaultValue=false)]
        public string Sms { get; set; }

        /// <summary>
        /// Mobile phone number for SMS delivery  Valid formats are:  - 6392995599 - 06392995599 - 496293995599 - 00496392995599 - +496392995599  Delimiters like spaces, braces or a slash may be contained and will be removed for processing. Numbers without a country prefix are assumed to be numers from your home country.
        /// </summary>
        /// <value>Mobile phone number for SMS delivery  Valid formats are:  - 6392995599 - 06392995599 - 496293995599 - 00496392995599 - +496392995599  Delimiters like spaces, braces or a slash may be contained and will be removed for processing. Numbers without a country prefix are assumed to be numers from your home country.</value>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Source identifier  This may be any value. It&#39;s used to identify from where the PDF upload came from.
        /// </summary>
        /// <value>Source identifier  This may be any value. It&#39;s used to identify from where the PDF upload came from.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public string Source { get; set; }

        /// <summary>
        /// Sending profile ID  Special values:  - &#x60;-2&#x60;: Use the sending profile defined for the known customer (the customer needs to be identified by customer number, email address or fax number), which may be a predefined or a custom sending profile (for a new customer a default sending profile has to be predefined and will be used) - &#x60;-1&#x60;: Use the predefined default sending profile - &#x60;0&#x60;: Use the custom sending profile of the known customer (the customer needs to be identified by customer number, email address or fax number)
        /// </summary>
        /// <value>Sending profile ID  Special values:  - &#x60;-2&#x60;: Use the sending profile defined for the known customer (the customer needs to be identified by customer number, email address or fax number), which may be a predefined or a custom sending profile (for a new customer a default sending profile has to be predefined and will be used) - &#x60;-1&#x60;: Use the predefined default sending profile - &#x60;0&#x60;: Use the custom sending profile of the known customer (the customer needs to be identified by customer number, email address or fax number)</value>
        [DataMember(Name="sendingProfile", EmitDefaultValue=false)]
        public int SendingProfile { get; set; }

        /// <summary>
        /// Customer group ID
        /// </summary>
        /// <value>Customer group ID</value>
        [DataMember(Name="customerGroup", EmitDefaultValue=false)]
        public int CustomerGroup { get; set; }

        /// <summary>
        /// PDF document filename (required)  The filename needs to end with \&quot;.pdf\&quot;.
        /// </summary>
        /// <value>PDF document filename (required)  The filename needs to end with \&quot;.pdf\&quot;.</value>
        [Required]
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }


        /// <summary>
        /// Transform the uploaded PDF file  When using a transformation, it's assumed that the PDF file contains commands, that export the required meta data for the requested transformation.  ## ZUGFeRD  This will create and attach a `factur-x.xml` in the ZUGFeRD 2 Comfort format. The resulting PDF file will match the PDF/A-3B  standard.  ## XRechnung  This will create and attach a `XRechnung.xml` in the XRechnung 2 CII format. Optional the resulting PDF will match the PDF/A-3B standard  (see `pdfa` property).  ## PDFA  This transformation will simply convert the uploaded PDF document to the PDF/A-3B standard, if it's not PDF/A-3B already. This option is  only available when uploading a PDF file.  __NOTE__: The transformation options aren't available when uploading ZUGFeRD or XRechnung. When uploading JSON or XML, the default  transformation is ZUGFeRD, if you don't specify XRechnung. During PDF/A conversion of the uploaded PDF file some features may be removed to  match the PDF/A standard.
        /// </summary>
        /// <value>Transform the uploaded PDF file  When using a transformation, it's assumed that the PDF file contains commands, that export the required meta data for the requested transformation.  ## ZUGFeRD  This will create and attach a `factur-x.xml` in the ZUGFeRD 2 Comfort format. The resulting PDF file will match the PDF/A-3B  standard.  ## XRechnung  This will create and attach a `XRechnung.xml` in the XRechnung 2 CII format. Optional the resulting PDF will match the PDF/A-3B standard  (see `pdfa` property).  ## PDFA  This transformation will simply convert the uploaded PDF document to the PDF/A-3B standard, if it's not PDF/A-3B already. This option is  only available when uploading a PDF file.  __NOTE__: The transformation options aren't available when uploading ZUGFeRD or XRechnung. When uploading JSON or XML, the default  transformation is ZUGFeRD, if you don't specify XRechnung. During PDF/A conversion of the uploaded PDF file some features may be removed to  match the PDF/A standard.</value>
        [TypeConverter(typeof(CustomEnumConverter<TransformEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TransformEnum
        {
            
            /// <summary>
            /// Enum NoneEnum for None
            /// </summary>
            [EnumMember(Value = "None")]
            NoneEnum = 1,
            
            /// <summary>
            /// Enum ZUGFeRDEnum for ZUGFeRD
            /// </summary>
            [EnumMember(Value = "ZUGFeRD")]
            ZUGFeRDEnum = 2,
            
            /// <summary>
            /// Enum XRechnungEnum for XRechnung
            /// </summary>
            [EnumMember(Value = "XRechnung")]
            XRechnungEnum = 3,
            
            /// <summary>
            /// Enum PDFAEnum for PDFA
            /// </summary>
            [EnumMember(Value = "PDFA")]
            PDFAEnum = 4
        }

        /// <summary>
        /// Transform the uploaded PDF file  When using a transformation, it&#39;s assumed that the PDF file contains commands, that export the required meta data for the requested transformation.  ## ZUGFeRD  This will create and attach a &#x60;factur-x.xml&#x60; in the ZUGFeRD 2 Comfort format. The resulting PDF file will match the PDF/A-3B  standard.  ## XRechnung  This will create and attach a &#x60;XRechnung.xml&#x60; in the XRechnung 2 CII format. Optional the resulting PDF will match the PDF/A-3B standard  (see &#x60;pdfa&#x60; property).  ## PDFA  This transformation will simply convert the uploaded PDF document to the PDF/A-3B standard, if it&#39;s not PDF/A-3B already. This option is  only available when uploading a PDF file.  __NOTE__: The transformation options aren&#39;t available when uploading ZUGFeRD or XRechnung. When uploading JSON or XML, the default  transformation is ZUGFeRD, if you don&#39;t specify XRechnung. During PDF/A conversion of the uploaded PDF file some features may be removed to  match the PDF/A standard.
        /// </summary>
        /// <value>Transform the uploaded PDF file  When using a transformation, it&#39;s assumed that the PDF file contains commands, that export the required meta data for the requested transformation.  ## ZUGFeRD  This will create and attach a &#x60;factur-x.xml&#x60; in the ZUGFeRD 2 Comfort format. The resulting PDF file will match the PDF/A-3B  standard.  ## XRechnung  This will create and attach a &#x60;XRechnung.xml&#x60; in the XRechnung 2 CII format. Optional the resulting PDF will match the PDF/A-3B standard  (see &#x60;pdfa&#x60; property).  ## PDFA  This transformation will simply convert the uploaded PDF document to the PDF/A-3B standard, if it&#39;s not PDF/A-3B already. This option is  only available when uploading a PDF file.  __NOTE__: The transformation options aren&#39;t available when uploading ZUGFeRD or XRechnung. When uploading JSON or XML, the default  transformation is ZUGFeRD, if you don&#39;t specify XRechnung. During PDF/A conversion of the uploaded PDF file some features may be removed to  match the PDF/A standard.</value>
        [DataMember(Name="transform", EmitDefaultValue=false)]
        public TransformEnum Transform { get; set; }

        /// <summary>
        /// Create a PDF/A-3B of the transformed PDF file?  __NOTE__: This is always &#x60;TRUE&#x60; when transforming to &#x60;ZUGFeRD&#x60; or &#x60;PDFA&#x60;. This property has only an effect, if the value of &#x60;transform&#x60; is not &#x60;None&#x60;, &#x60;ZUGFeRD&#x60; or &#x60;PDFA&#x60;, or when uploading XRechnung, JSON or XML. During PDF/A conversion of the uploaded PDF file some features  may be removed to match the PDF/A standard.
        /// </summary>
        /// <value>Create a PDF/A-3B of the transformed PDF file?  __NOTE__: This is always &#x60;TRUE&#x60; when transforming to &#x60;ZUGFeRD&#x60; or &#x60;PDFA&#x60;. This property has only an effect, if the value of &#x60;transform&#x60; is not &#x60;None&#x60;, &#x60;ZUGFeRD&#x60; or &#x60;PDFA&#x60;, or when uploading XRechnung, JSON or XML. During PDF/A conversion of the uploaded PDF file some features  may be removed to match the PDF/A standard.</value>
        [DataMember(Name="pdfa", EmitDefaultValue=false)]
        public bool Pdfa { get; set; }

        /// <summary>
        /// Gets or Sets Archive
        /// </summary>
        [DataMember(Name="archive", EmitDefaultValue=false)]
        public GotomaxxOutgoingUploadArchiveOptions Archive { get; set; }

        /// <summary>
        /// Handle the request asynchronous?  When handling a request asynchronous, a request token will be returned. With that request token you can poll the response of the processed request. Once you&#39;ve received a final status (&#x60;Ok&#x60; or &#x60;Error&#x60;), the response data will be deleted and can&#39;t be polled anymore. When you didn&#39;t request the status within one day, it&#39;ll be deleted.  Please have a look at the &#x60;responseWebHook&#x60; property, in case you want the response to be sent with http request to your web hook handler.  If you poll the status that will be sent to a web hook handler, the corresponding status to &#x60;Ok&#x60; and &#x60;Error&#x60; is &#x60;OkHook&#x60; and &#x60;ErrorHook&#x60;.  __NOTE__: Asynchronous requests will be processed in the incoming order. There is no guarantee that your request will be processed within X time. Test uploads won&#39;t be processed asynchronous at all.
        /// </summary>
        /// <value>Handle the request asynchronous?  When handling a request asynchronous, a request token will be returned. With that request token you can poll the response of the processed request. Once you&#39;ve received a final status (&#x60;Ok&#x60; or &#x60;Error&#x60;), the response data will be deleted and can&#39;t be polled anymore. When you didn&#39;t request the status within one day, it&#39;ll be deleted.  Please have a look at the &#x60;responseWebHook&#x60; property, in case you want the response to be sent with http request to your web hook handler.  If you poll the status that will be sent to a web hook handler, the corresponding status to &#x60;Ok&#x60; and &#x60;Error&#x60; is &#x60;OkHook&#x60; and &#x60;ErrorHook&#x60;.  __NOTE__: Asynchronous requests will be processed in the incoming order. There is no guarantee that your request will be processed within X time. Test uploads won&#39;t be processed asynchronous at all.</value>
        [DataMember(Name="asynchronous", EmitDefaultValue=false)]
        public bool Asynchronous { get; set; }

        /// <summary>
        /// Asynchronous request response web hook handler  The web hook handler will receive the response as JSON request body and needs to respond with a http &#x60;200&#x60; response code to confirm a successfully received response.  __NOTE__: If you set a response web hook handler URI, the asynchronous request data won&#39;t be available for polling as soon as the response has been sent with success. If your request handler isn&#39;t responsing with a http &#x60;200&#x60; response code, the response will be sent repeated for  one day. After one day without sending with success, the response handler will give up and delete the data.
        /// </summary>
        /// <value>Asynchronous request response web hook handler  The web hook handler will receive the response as JSON request body and needs to respond with a http &#x60;200&#x60; response code to confirm a successfully received response.  __NOTE__: If you set a response web hook handler URI, the asynchronous request data won&#39;t be available for polling as soon as the response has been sent with success. If your request handler isn&#39;t responsing with a http &#x60;200&#x60; response code, the response will be sent repeated for  one day. After one day without sending with success, the response handler will give up and delete the data.</value>
        [StringLength(1024, MinimumLength=12)]
        [DataMember(Name="responseWebHook", EmitDefaultValue=false)]
        public string ResponseWebHook { get; set; }

        /// <summary>
        /// Request a response object?  If no response object is requested, the ID of the PDF document will be returned instead.
        /// </summary>
        /// <value>Request a response object?  If no response object is requested, the ID of the PDF document will be returned instead.</value>
        [DataMember(Name="getResponse", EmitDefaultValue=false)]
        public bool GetResponse { get; set; }

        /// <summary>
        /// Test the upload only?  __NOTE__: This will test processed transformations, but not the final PDF document import. Tests won&#39;t affect your credits.
        /// </summary>
        /// <value>Test the upload only?  __NOTE__: This will test processed transformations, but not the final PDF document import. Tests won&#39;t affect your credits.</value>
        [DataMember(Name="testUpload", EmitDefaultValue=false)]
        public bool TestUpload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GotomaxxXmlUploadRestRequest {\n");
            sb.Append("  Xml: ").Append(Xml).Append("\n");
            sb.Append("  Attach: ").Append(Attach).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailSender: ").Append(EmailSender).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Sms: ").Append(Sms).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SendingProfile: ").Append(SendingProfile).Append("\n");
            sb.Append("  CustomerGroup: ").Append(CustomerGroup).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Transform: ").Append(Transform).Append("\n");
            sb.Append("  Pdfa: ").Append(Pdfa).Append("\n");
            sb.Append("  Archive: ").Append(Archive).Append("\n");
            sb.Append("  Asynchronous: ").Append(Asynchronous).Append("\n");
            sb.Append("  ResponseWebHook: ").Append(ResponseWebHook).Append("\n");
            sb.Append("  GetResponse: ").Append(GetResponse).Append("\n");
            sb.Append("  TestUpload: ").Append(TestUpload).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GotomaxxXmlUploadRestRequest)obj);
        }

        /// <summary>
        /// Returns true if GotomaxxXmlUploadRestRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of GotomaxxXmlUploadRestRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GotomaxxXmlUploadRestRequest other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Xml == other.Xml ||
                    Xml != null &&
                    Xml.Equals(other.Xml)
                ) && 
                (
                    Attach == other.Attach ||
                    
                    Attach.Equals(other.Attach)
                ) && 
                (
                    VarVersion == other.VarVersion ||
                    
                    VarVersion.Equals(other.VarVersion)
                ) && 
                (
                    Customer == other.Customer ||
                    Customer != null &&
                    Customer.Equals(other.Customer)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    EmailSender == other.EmailSender ||
                    
                    EmailSender.Equals(other.EmailSender)
                ) && 
                (
                    Fax == other.Fax ||
                    Fax != null &&
                    Fax.Equals(other.Fax)
                ) && 
                (
                    Country == other.Country ||
                    Country != null &&
                    Country.Equals(other.Country)
                ) && 
                (
                    Sms == other.Sms ||
                    Sms != null &&
                    Sms.Equals(other.Sms)
                ) && 
                (
                    Phone == other.Phone ||
                    Phone != null &&
                    Phone.Equals(other.Phone)
                ) && 
                (
                    Source == other.Source ||
                    Source != null &&
                    Source.Equals(other.Source)
                ) && 
                (
                    SendingProfile == other.SendingProfile ||
                    
                    SendingProfile.Equals(other.SendingProfile)
                ) && 
                (
                    CustomerGroup == other.CustomerGroup ||
                    
                    CustomerGroup.Equals(other.CustomerGroup)
                ) && 
                (
                    FileName == other.FileName ||
                    FileName != null &&
                    FileName.Equals(other.FileName)
                ) && 
                (
                    Transform == other.Transform ||
                    
                    Transform.Equals(other.Transform)
                ) && 
                (
                    Pdfa == other.Pdfa ||
                    
                    Pdfa.Equals(other.Pdfa)
                ) && 
                (
                    Archive == other.Archive ||
                    Archive != null &&
                    Archive.Equals(other.Archive)
                ) && 
                (
                    Asynchronous == other.Asynchronous ||
                    
                    Asynchronous.Equals(other.Asynchronous)
                ) && 
                (
                    ResponseWebHook == other.ResponseWebHook ||
                    ResponseWebHook != null &&
                    ResponseWebHook.Equals(other.ResponseWebHook)
                ) && 
                (
                    GetResponse == other.GetResponse ||
                    
                    GetResponse.Equals(other.GetResponse)
                ) && 
                (
                    TestUpload == other.TestUpload ||
                    
                    TestUpload.Equals(other.TestUpload)
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
                    if (Xml != null)
                    hashCode = hashCode * 59 + Xml.GetHashCode();
                    
                    hashCode = hashCode * 59 + Attach.GetHashCode();
                    
                    hashCode = hashCode * 59 + VarVersion.GetHashCode();
                    if (Customer != null)
                    hashCode = hashCode * 59 + Customer.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    
                    hashCode = hashCode * 59 + EmailSender.GetHashCode();
                    if (Fax != null)
                    hashCode = hashCode * 59 + Fax.GetHashCode();
                    if (Country != null)
                    hashCode = hashCode * 59 + Country.GetHashCode();
                    if (Sms != null)
                    hashCode = hashCode * 59 + Sms.GetHashCode();
                    if (Phone != null)
                    hashCode = hashCode * 59 + Phone.GetHashCode();
                    if (Source != null)
                    hashCode = hashCode * 59 + Source.GetHashCode();
                    
                    hashCode = hashCode * 59 + SendingProfile.GetHashCode();
                    
                    hashCode = hashCode * 59 + CustomerGroup.GetHashCode();
                    if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                    
                    hashCode = hashCode * 59 + Transform.GetHashCode();
                    
                    hashCode = hashCode * 59 + Pdfa.GetHashCode();
                    if (Archive != null)
                    hashCode = hashCode * 59 + Archive.GetHashCode();
                    
                    hashCode = hashCode * 59 + Asynchronous.GetHashCode();
                    if (ResponseWebHook != null)
                    hashCode = hashCode * 59 + ResponseWebHook.GetHashCode();
                    
                    hashCode = hashCode * 59 + GetResponse.GetHashCode();
                    
                    hashCode = hashCode * 59 + TestUpload.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GotomaxxXmlUploadRestRequest left, GotomaxxXmlUploadRestRequest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GotomaxxXmlUploadRestRequest left, GotomaxxXmlUploadRestRequest right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
