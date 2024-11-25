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
    /// JSON data (required)
    /// </summary>
    [DataContract]
    public partial class GotomaxxJsonUploadRestRequestJson : IEquatable<GotomaxxJsonUploadRestRequestJson>
    {
        /// <summary>
        /// Gets or Sets Seller
        /// </summary>
        [DataMember(Name="seller", EmitDefaultValue=false)]
        public GotomaxxJsonDocumentSeller Seller { get; set; }

        /// <summary>
        /// Gets or Sets Buyer
        /// </summary>
        [Required]
        [DataMember(Name="buyer", EmitDefaultValue=false)]
        public GotomaxxJsonDocumentBuyer Buyer { get; set; }

        /// <summary>
        /// Gets or Sets Shipping
        /// </summary>
        [DataMember(Name="shipping", EmitDefaultValue=false)]
        public GotomaxxJsonDocumentShipping Shipping { get; set; }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [Required]
        [DataMember(Name="header", EmitDefaultValue=false)]
        public GotomaxxJsonDocumentHeader Header { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name="payment", EmitDefaultValue=false)]
        public GotomaxxJsonDocumentPayment Payment { get; set; }

        /// <summary>
        /// Items
        /// </summary>
        /// <value>Items</value>
        [Required]
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<GotomaxxJsonDocumentItem> Items { get; set; }

        /// <summary>
        /// Allowance charge
        /// </summary>
        /// <value>Allowance charge</value>
        [DataMember(Name="allowance", EmitDefaultValue=false)]
        public List<GotomaxxJsonDocumentAllowance> Allowance { get; set; }

        /// <summary>
        /// VAT  __NOTE__: Actually this value is required, but can be auto-completed from the items and the allowance charge.
        /// </summary>
        /// <value>VAT  __NOTE__: Actually this value is required, but can be auto-completed from the items and the allowance charge.</value>
        [DataMember(Name="vat", EmitDefaultValue=false)]
        public List<GotomaxxJsonDocumentVat> Vat { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public GotomaxxJsonDocumentSummary Summary { get; set; }

        /// <summary>
        /// Attachments  __NOTE__: Actually this value is required, but will be set to an empty array, when auto-completing missing values.
        /// </summary>
        /// <value>Attachments  __NOTE__: Actually this value is required, but will be set to an empty array, when auto-completing missing values.</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<GotomaxxJsonDocumentAttachment> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GotomaxxJsonUploadRestRequestJson {\n");
            sb.Append("  Seller: ").Append(Seller).Append("\n");
            sb.Append("  Buyer: ").Append(Buyer).Append("\n");
            sb.Append("  Shipping: ").Append(Shipping).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Allowance: ").Append(Allowance).Append("\n");
            sb.Append("  Vat: ").Append(Vat).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GotomaxxJsonUploadRestRequestJson)obj);
        }

        /// <summary>
        /// Returns true if GotomaxxJsonUploadRestRequestJson instances are equal
        /// </summary>
        /// <param name="other">Instance of GotomaxxJsonUploadRestRequestJson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GotomaxxJsonUploadRestRequestJson other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Seller == other.Seller ||
                    Seller != null &&
                    Seller.Equals(other.Seller)
                ) && 
                (
                    Buyer == other.Buyer ||
                    Buyer != null &&
                    Buyer.Equals(other.Buyer)
                ) && 
                (
                    Shipping == other.Shipping ||
                    Shipping != null &&
                    Shipping.Equals(other.Shipping)
                ) && 
                (
                    Header == other.Header ||
                    Header != null &&
                    Header.Equals(other.Header)
                ) && 
                (
                    Payment == other.Payment ||
                    Payment != null &&
                    Payment.Equals(other.Payment)
                ) && 
                (
                    Items == other.Items ||
                    Items != null &&
                    other.Items != null &&
                    Items.SequenceEqual(other.Items)
                ) && 
                (
                    Allowance == other.Allowance ||
                    Allowance != null &&
                    other.Allowance != null &&
                    Allowance.SequenceEqual(other.Allowance)
                ) && 
                (
                    Vat == other.Vat ||
                    Vat != null &&
                    other.Vat != null &&
                    Vat.SequenceEqual(other.Vat)
                ) && 
                (
                    Summary == other.Summary ||
                    Summary != null &&
                    Summary.Equals(other.Summary)
                ) && 
                (
                    Attachments == other.Attachments ||
                    Attachments != null &&
                    other.Attachments != null &&
                    Attachments.SequenceEqual(other.Attachments)
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
                    if (Seller != null)
                    hashCode = hashCode * 59 + Seller.GetHashCode();
                    if (Buyer != null)
                    hashCode = hashCode * 59 + Buyer.GetHashCode();
                    if (Shipping != null)
                    hashCode = hashCode * 59 + Shipping.GetHashCode();
                    if (Header != null)
                    hashCode = hashCode * 59 + Header.GetHashCode();
                    if (Payment != null)
                    hashCode = hashCode * 59 + Payment.GetHashCode();
                    if (Items != null)
                    hashCode = hashCode * 59 + Items.GetHashCode();
                    if (Allowance != null)
                    hashCode = hashCode * 59 + Allowance.GetHashCode();
                    if (Vat != null)
                    hashCode = hashCode * 59 + Vat.GetHashCode();
                    if (Summary != null)
                    hashCode = hashCode * 59 + Summary.GetHashCode();
                    if (Attachments != null)
                    hashCode = hashCode * 59 + Attachments.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GotomaxxJsonUploadRestRequestJson left, GotomaxxJsonUploadRestRequestJson right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GotomaxxJsonUploadRestRequestJson left, GotomaxxJsonUploadRestRequestJson right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
