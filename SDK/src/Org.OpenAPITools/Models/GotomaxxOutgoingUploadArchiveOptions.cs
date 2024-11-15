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
    /// Upload REST request archive options template for documentation purposes
    /// </summary>
    [DataContract]
    public partial class GotomaxxOutgoingUploadArchiveOptions : IEquatable<GotomaxxOutgoingUploadArchiveOptions>
    {
        /// <summary>
        /// Email address
        /// </summary>
        /// <value>Email address</value>
        [DataMember(Name="email", EmitDefaultValue=true)]
        public string Email { get; set; }

        /// <summary>
        /// Inbox ID
        /// </summary>
        /// <value>Inbox ID</value>
        [DataMember(Name="inbox", EmitDefaultValue=true)]
        public int? Inbox { get; set; }

        /// <summary>
        /// Sender name
        /// </summary>
        /// <value>Sender name</value>
        [StringLength(255, MinimumLength=1)]
        [DataMember(Name="sender", EmitDefaultValue=true)]
        public string Sender { get; set; }

        /// <summary>
        /// Recipient name
        /// </summary>
        /// <value>Recipient name</value>
        [StringLength(255, MinimumLength=1)]
        [DataMember(Name="recipient", EmitDefaultValue=true)]
        public string Recipient { get; set; }


        /// <summary>
        /// Document type
        /// </summary>
        /// <value>Document type</value>
        [TypeConverter(typeof(CustomEnumConverter<TypeEnum>))]
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum InvoiceEnum for invoice
            /// </summary>
            [EnumMember(Value = "invoice")]
            InvoiceEnum = 1,
            
            /// <summary>
            /// Enum ReceiptEnum for receipt
            /// </summary>
            [EnumMember(Value = "receipt")]
            ReceiptEnum = 2,
            
            /// <summary>
            /// Enum CreditNoteEnum for credit-note
            /// </summary>
            [EnumMember(Value = "credit-note")]
            CreditNoteEnum = 3,
            
            /// <summary>
            /// Enum ReminderEnum for reminder
            /// </summary>
            [EnumMember(Value = "reminder")]
            ReminderEnum = 4,
            
            /// <summary>
            /// Enum SalaryStatementEnum for salary-statement
            /// </summary>
            [EnumMember(Value = "salary-statement")]
            SalaryStatementEnum = 5,
            
            /// <summary>
            /// Enum BankStatementEnum for bank-statement
            /// </summary>
            [EnumMember(Value = "bank-statement")]
            BankStatementEnum = 6,
            
            /// <summary>
            /// Enum ContractEnum for contract
            /// </summary>
            [EnumMember(Value = "contract")]
            ContractEnum = 7,
            
            /// <summary>
            /// Enum BalanceSheetEnum for balance-sheet
            /// </summary>
            [EnumMember(Value = "balance-sheet")]
            BalanceSheetEnum = 8,
            
            /// <summary>
            /// Enum TaxAssessmentNoteEnum for tax-assessment-note
            /// </summary>
            [EnumMember(Value = "tax-assessment-note")]
            TaxAssessmentNoteEnum = 9,
            
            /// <summary>
            /// Enum LetterEnum for letter
            /// </summary>
            [EnumMember(Value = "letter")]
            LetterEnum = 10,
            
            /// <summary>
            /// Enum OtherEnum for other
            /// </summary>
            [EnumMember(Value = "other")]
            OtherEnum = 11
        }

        /// <summary>
        /// Document type
        /// </summary>
        /// <value>Document type</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Document type ID
        /// </summary>
        /// <value>Document type ID</value>
        [DataMember(Name="typeId", EmitDefaultValue=true)]
        public int? TypeId { get; set; }

        /// <summary>
        /// Tags
        /// </summary>
        /// <value>Tags</value>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        /// <value>Fields</value>
        [DataMember(Name="fields", EmitDefaultValue=true)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// Note
        /// </summary>
        /// <value>Note</value>
        [MaxLength(65535)]
        [DataMember(Name="note", EmitDefaultValue=true)]
        public string Note { get; set; }

        /// <summary>
        /// Folder ID
        /// </summary>
        /// <value>Folder ID</value>
        [DataMember(Name="folder", EmitDefaultValue=true)]
        public int? Folder { get; set; }

        /// <summary>
        /// Archive
        /// </summary>
        /// <value>Archive</value>
        [DataMember(Name="archive", EmitDefaultValue=true)]
        public bool? Archive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GotomaxxOutgoingUploadArchiveOptions {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Inbox: ").Append(Inbox).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Archive: ").Append(Archive).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GotomaxxOutgoingUploadArchiveOptions)obj);
        }

        /// <summary>
        /// Returns true if GotomaxxOutgoingUploadArchiveOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of GotomaxxOutgoingUploadArchiveOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GotomaxxOutgoingUploadArchiveOptions other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    Inbox == other.Inbox ||
                    Inbox != null &&
                    Inbox.Equals(other.Inbox)
                ) && 
                (
                    Sender == other.Sender ||
                    Sender != null &&
                    Sender.Equals(other.Sender)
                ) && 
                (
                    Recipient == other.Recipient ||
                    Recipient != null &&
                    Recipient.Equals(other.Recipient)
                ) && 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    TypeId == other.TypeId ||
                    TypeId != null &&
                    TypeId.Equals(other.TypeId)
                ) && 
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    other.Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    Fields == other.Fields ||
                    Fields != null &&
                    other.Fields != null &&
                    Fields.SequenceEqual(other.Fields)
                ) && 
                (
                    Note == other.Note ||
                    Note != null &&
                    Note.Equals(other.Note)
                ) && 
                (
                    Folder == other.Folder ||
                    Folder != null &&
                    Folder.Equals(other.Folder)
                ) && 
                (
                    Archive == other.Archive ||
                    Archive != null &&
                    Archive.Equals(other.Archive)
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
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (Inbox != null)
                    hashCode = hashCode * 59 + Inbox.GetHashCode();
                    if (Sender != null)
                    hashCode = hashCode * 59 + Sender.GetHashCode();
                    if (Recipient != null)
                    hashCode = hashCode * 59 + Recipient.GetHashCode();
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (TypeId != null)
                    hashCode = hashCode * 59 + TypeId.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                    if (Fields != null)
                    hashCode = hashCode * 59 + Fields.GetHashCode();
                    if (Note != null)
                    hashCode = hashCode * 59 + Note.GetHashCode();
                    if (Folder != null)
                    hashCode = hashCode * 59 + Folder.GetHashCode();
                    if (Archive != null)
                    hashCode = hashCode * 59 + Archive.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GotomaxxOutgoingUploadArchiveOptions left, GotomaxxOutgoingUploadArchiveOptions right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GotomaxxOutgoingUploadArchiveOptions left, GotomaxxOutgoingUploadArchiveOptions right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}