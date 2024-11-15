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
    /// Document form field REST response object
    /// </summary>
    [DataContract]
    public partial class GotomaxxDocumentFormFieldRestResponse : IEquatable<GotomaxxDocumentFormFieldRestResponse>
    {
        /// <summary>
        /// Party ID
        /// </summary>
        /// <value>Party ID</value>
        [Required]
        [DataMember(Name="party", EmitDefaultValue=false)]
        public int Party { get; set; }

        /// <summary>
        /// Field name
        /// </summary>
        /// <value>Field name</value>
        [Required]
        [MinLength(1)]
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Display label
        /// </summary>
        /// <value>Display label</value>
        [Required]
        [MinLength(1)]
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }


        /// <summary>
        /// Field type  Possible types:  - `0`: Single line text (no line breaks are allowed) - `1`: Multiline text - `2`: Integer - `3`: Decimal - `4`: Flag (boolean) - `5`: Option (has choices, value is the choice key) - `6`: Multiple options (has choices, value is the choice key) - `7`: Signature (base64 encoded value) - `8`: Signing date (Unix timestamp) - `9`: Image (base64 encoded value) - `10`: Party name (signer name, if signed) - `11`: Party email address (signer email address, if signed) - `12`: Currency (having a Symbol)
        /// </summary>
        /// <value>Field type  Possible types:  - `0`: Single line text (no line breaks are allowed) - `1`: Multiline text - `2`: Integer - `3`: Decimal - `4`: Flag (boolean) - `5`: Option (has choices, value is the choice key) - `6`: Multiple options (has choices, value is the choice key) - `7`: Signature (base64 encoded value) - `8`: Signing date (Unix timestamp) - `9`: Image (base64 encoded value) - `10`: Party name (signer name, if signed) - `11`: Party email address (signer email address, if signed) - `12`: Currency (having a Symbol)</value>
        
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum _0Enum for 0
            /// </summary>
            
            _0Enum = 0,
            
            /// <summary>
            /// Enum _1Enum for 1
            /// </summary>
            
            _1Enum = 1,
            
            /// <summary>
            /// Enum _2Enum for 2
            /// </summary>
            
            _2Enum = 2,
            
            /// <summary>
            /// Enum _3Enum for 3
            /// </summary>
            
            _3Enum = 3,
            
            /// <summary>
            /// Enum _4Enum for 4
            /// </summary>
            
            _4Enum = 4,
            
            /// <summary>
            /// Enum _5Enum for 5
            /// </summary>
            
            _5Enum = 5,
            
            /// <summary>
            /// Enum _6Enum for 6
            /// </summary>
            
            _6Enum = 6,
            
            /// <summary>
            /// Enum _7Enum for 7
            /// </summary>
            
            _7Enum = 7,
            
            /// <summary>
            /// Enum _8Enum for 8
            /// </summary>
            
            _8Enum = 8,
            
            /// <summary>
            /// Enum _9Enum for 9
            /// </summary>
            
            _9Enum = 9,
            
            /// <summary>
            /// Enum _10Enum for 10
            /// </summary>
            
            _10Enum = 10,
            
            /// <summary>
            /// Enum _11Enum for 11
            /// </summary>
            
            _11Enum = 11,
            
            /// <summary>
            /// Enum _12Enum for 12
            /// </summary>
            
            _12Enum = 12
        }

        /// <summary>
        /// Field type  Possible types:  - &#x60;0&#x60;: Single line text (no line breaks are allowed) - &#x60;1&#x60;: Multiline text - &#x60;2&#x60;: Integer - &#x60;3&#x60;: Decimal - &#x60;4&#x60;: Flag (boolean) - &#x60;5&#x60;: Option (has choices, value is the choice key) - &#x60;6&#x60;: Multiple options (has choices, value is the choice key) - &#x60;7&#x60;: Signature (base64 encoded value) - &#x60;8&#x60;: Signing date (Unix timestamp) - &#x60;9&#x60;: Image (base64 encoded value) - &#x60;10&#x60;: Party name (signer name, if signed) - &#x60;11&#x60;: Party email address (signer email address, if signed) - &#x60;12&#x60;: Currency (having a Symbol)
        /// </summary>
        /// <value>Field type  Possible types:  - &#x60;0&#x60;: Single line text (no line breaks are allowed) - &#x60;1&#x60;: Multiline text - &#x60;2&#x60;: Integer - &#x60;3&#x60;: Decimal - &#x60;4&#x60;: Flag (boolean) - &#x60;5&#x60;: Option (has choices, value is the choice key) - &#x60;6&#x60;: Multiple options (has choices, value is the choice key) - &#x60;7&#x60;: Signature (base64 encoded value) - &#x60;8&#x60;: Signing date (Unix timestamp) - &#x60;9&#x60;: Image (base64 encoded value) - &#x60;10&#x60;: Party name (signer name, if signed) - &#x60;11&#x60;: Party email address (signer email address, if signed) - &#x60;12&#x60;: Currency (having a Symbol)</value>
        [Required]
        [Range(0, 12)]
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }

        /// <summary>
        /// Example value
        /// </summary>
        /// <value>Example value</value>
        [Required]
        [DataMember(Name="example", EmitDefaultValue=true)]
        public string Example { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [Required]
        [DataMember(Name="value", EmitDefaultValue=true)]
        public GotomaxxDocumentFormFieldRestResponseValue Value { get; set; }

        /// <summary>
        /// Available choices  For a field type &#x60;Option&#x60;, the value contains the display label of the option.  For a field type &#x60;Multiple options&#x60;, the value contains an object of type &#x60;gotomaxx_DocumentFormFieldOptionRestResponse&#x60;,  which includes position and dimension informations.
        /// </summary>
        /// <value>Available choices  For a field type &#x60;Option&#x60;, the value contains the display label of the option.  For a field type &#x60;Multiple options&#x60;, the value contains an object of type &#x60;gotomaxx_DocumentFormFieldOptionRestResponse&#x60;,  which includes position and dimension informations.</value>
        [Required]
        [DataMember(Name="choices", EmitDefaultValue=true)]
        public List<GotomaxxJsonKeyValuePair> Choices { get; set; }

        /// <summary>
        /// Regular expression to validate the value
        /// </summary>
        /// <value>Regular expression to validate the value</value>
        [Required]
        [DataMember(Name="validation", EmitDefaultValue=true)]
        public string Validation { get; set; }

        /// <summary>
        /// Minimum length or value (if the field type is numeric)
        /// </summary>
        /// <value>Minimum length or value (if the field type is numeric)</value>
        [Required]
        [DataMember(Name="minLen", EmitDefaultValue=false)]
        public int MinLen { get; set; }

        /// <summary>
        /// Maximum length or value (if the field type is numeric)
        /// </summary>
        /// <value>Maximum length or value (if the field type is numeric)</value>
        [Required]
        [DataMember(Name="maxLen", EmitDefaultValue=false)]
        public int MaxLen { get; set; }

        /// <summary>
        /// Font family
        /// </summary>
        /// <value>Font family</value>
        [Required]
        [DataMember(Name="fontFamily", EmitDefaultValue=true)]
        public string FontFamily { get; set; }

        /// <summary>
        /// Font size
        /// </summary>
        /// <value>Font size</value>
        [Required]
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public int FontSize { get; set; }

        /// <summary>
        /// Font color RGB as 24bit integer
        /// </summary>
        /// <value>Font color RGB as 24bit integer</value>
        [Required]
        [Range(0, 16777215)]
        [DataMember(Name="fontColor", EmitDefaultValue=false)]
        public int FontColor { get; set; }

        /// <summary>
        /// Bold font?
        /// </summary>
        /// <value>Bold font?</value>
        [Required]
        [DataMember(Name="fontBold", EmitDefaultValue=false)]
        public bool FontBold { get; set; }

        /// <summary>
        /// Italic font?
        /// </summary>
        /// <value>Italic font?</value>
        [Required]
        [DataMember(Name="fontItalic", EmitDefaultValue=false)]
        public bool FontItalic { get; set; }


        /// <summary>
        /// Text align  - `0`: Left - `1`: Right - `2`: Center
        /// </summary>
        /// <value>Text align  - `0`: Left - `1`: Right - `2`: Center</value>
        
        public enum AlignEnum
        {
            
            /// <summary>
            /// Enum _0Enum for 0
            /// </summary>
            
            _0Enum = 0,
            
            /// <summary>
            /// Enum _1Enum for 1
            /// </summary>
            
            _1Enum = 1,
            
            /// <summary>
            /// Enum _2Enum for 2
            /// </summary>
            
            _2Enum = 2
        }

        /// <summary>
        /// Text align  - &#x60;0&#x60;: Left - &#x60;1&#x60;: Right - &#x60;2&#x60;: Center
        /// </summary>
        /// <value>Text align  - &#x60;0&#x60;: Left - &#x60;1&#x60;: Right - &#x60;2&#x60;: Center</value>
        [Required]
        [Range(0, 2)]
        [DataMember(Name="align", EmitDefaultValue=false)]
        public AlignEnum Align { get; set; }

        /// <summary>
        /// PDF form template page index
        /// </summary>
        /// <value>PDF form template page index</value>
        [Required]
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int Page { get; set; }

        /// <summary>
        /// Input element PDF form template page X position
        /// </summary>
        /// <value>Input element PDF form template page X position</value>
        [Required]
        [DataMember(Name="x", EmitDefaultValue=false)]
        public int X { get; set; }

        /// <summary>
        /// Input element PDF form template page Y position
        /// </summary>
        /// <value>Input element PDF form template page Y position</value>
        [Required]
        [DataMember(Name="y", EmitDefaultValue=false)]
        public int Y { get; set; }

        /// <summary>
        /// Input element width
        /// </summary>
        /// <value>Input element width</value>
        [Required]
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int Width { get; set; }

        /// <summary>
        /// Input element height
        /// </summary>
        /// <value>Input element height</value>
        [Required]
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int Height { get; set; }

        /// <summary>
        /// Required?
        /// </summary>
        /// <value>Required?</value>
        [Required]
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool Required { get; set; }

        /// <summary>
        /// Visible in PDF document?
        /// </summary>
        /// <value>Visible in PDF document?</value>
        [Required]
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool Visible { get; set; }

        /// <summary>
        /// Currency symbol
        /// </summary>
        /// <value>Currency symbol</value>
        [Required]
        [StringLength(3, MinimumLength=0)]
        [DataMember(Name="symbol", EmitDefaultValue=true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GotomaxxDocumentFormFieldRestResponse {\n");
            sb.Append("  Party: ").Append(Party).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Example: ").Append(Example).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Choices: ").Append(Choices).Append("\n");
            sb.Append("  Validation: ").Append(Validation).Append("\n");
            sb.Append("  MinLen: ").Append(MinLen).Append("\n");
            sb.Append("  MaxLen: ").Append(MaxLen).Append("\n");
            sb.Append("  FontFamily: ").Append(FontFamily).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  FontColor: ").Append(FontColor).Append("\n");
            sb.Append("  FontBold: ").Append(FontBold).Append("\n");
            sb.Append("  FontItalic: ").Append(FontItalic).Append("\n");
            sb.Append("  Align: ").Append(Align).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
            return obj.GetType() == GetType() && Equals((GotomaxxDocumentFormFieldRestResponse)obj);
        }

        /// <summary>
        /// Returns true if GotomaxxDocumentFormFieldRestResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of GotomaxxDocumentFormFieldRestResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GotomaxxDocumentFormFieldRestResponse other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Party == other.Party ||
                    
                    Party.Equals(other.Party)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Label == other.Label ||
                    Label != null &&
                    Label.Equals(other.Label)
                ) && 
                (
                    Type == other.Type ||
                    
                    Type.Equals(other.Type)
                ) && 
                (
                    Example == other.Example ||
                    Example != null &&
                    Example.Equals(other.Example)
                ) && 
                (
                    Value == other.Value ||
                    Value != null &&
                    Value.Equals(other.Value)
                ) && 
                (
                    Choices == other.Choices ||
                    Choices != null &&
                    other.Choices != null &&
                    Choices.SequenceEqual(other.Choices)
                ) && 
                (
                    Validation == other.Validation ||
                    Validation != null &&
                    Validation.Equals(other.Validation)
                ) && 
                (
                    MinLen == other.MinLen ||
                    
                    MinLen.Equals(other.MinLen)
                ) && 
                (
                    MaxLen == other.MaxLen ||
                    
                    MaxLen.Equals(other.MaxLen)
                ) && 
                (
                    FontFamily == other.FontFamily ||
                    FontFamily != null &&
                    FontFamily.Equals(other.FontFamily)
                ) && 
                (
                    FontSize == other.FontSize ||
                    
                    FontSize.Equals(other.FontSize)
                ) && 
                (
                    FontColor == other.FontColor ||
                    
                    FontColor.Equals(other.FontColor)
                ) && 
                (
                    FontBold == other.FontBold ||
                    
                    FontBold.Equals(other.FontBold)
                ) && 
                (
                    FontItalic == other.FontItalic ||
                    
                    FontItalic.Equals(other.FontItalic)
                ) && 
                (
                    Align == other.Align ||
                    
                    Align.Equals(other.Align)
                ) && 
                (
                    Page == other.Page ||
                    
                    Page.Equals(other.Page)
                ) && 
                (
                    X == other.X ||
                    
                    X.Equals(other.X)
                ) && 
                (
                    Y == other.Y ||
                    
                    Y.Equals(other.Y)
                ) && 
                (
                    Width == other.Width ||
                    
                    Width.Equals(other.Width)
                ) && 
                (
                    Height == other.Height ||
                    
                    Height.Equals(other.Height)
                ) && 
                (
                    Required == other.Required ||
                    
                    Required.Equals(other.Required)
                ) && 
                (
                    Visible == other.Visible ||
                    
                    Visible.Equals(other.Visible)
                ) && 
                (
                    Symbol == other.Symbol ||
                    Symbol != null &&
                    Symbol.Equals(other.Symbol)
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
                    
                    hashCode = hashCode * 59 + Party.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Label != null)
                    hashCode = hashCode * 59 + Label.GetHashCode();
                    
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Example != null)
                    hashCode = hashCode * 59 + Example.GetHashCode();
                    if (Value != null)
                    hashCode = hashCode * 59 + Value.GetHashCode();
                    if (Choices != null)
                    hashCode = hashCode * 59 + Choices.GetHashCode();
                    if (Validation != null)
                    hashCode = hashCode * 59 + Validation.GetHashCode();
                    
                    hashCode = hashCode * 59 + MinLen.GetHashCode();
                    
                    hashCode = hashCode * 59 + MaxLen.GetHashCode();
                    if (FontFamily != null)
                    hashCode = hashCode * 59 + FontFamily.GetHashCode();
                    
                    hashCode = hashCode * 59 + FontSize.GetHashCode();
                    
                    hashCode = hashCode * 59 + FontColor.GetHashCode();
                    
                    hashCode = hashCode * 59 + FontBold.GetHashCode();
                    
                    hashCode = hashCode * 59 + FontItalic.GetHashCode();
                    
                    hashCode = hashCode * 59 + Align.GetHashCode();
                    
                    hashCode = hashCode * 59 + Page.GetHashCode();
                    
                    hashCode = hashCode * 59 + X.GetHashCode();
                    
                    hashCode = hashCode * 59 + Y.GetHashCode();
                    
                    hashCode = hashCode * 59 + Width.GetHashCode();
                    
                    hashCode = hashCode * 59 + Height.GetHashCode();
                    
                    hashCode = hashCode * 59 + Required.GetHashCode();
                    
                    hashCode = hashCode * 59 + Visible.GetHashCode();
                    if (Symbol != null)
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(GotomaxxDocumentFormFieldRestResponse left, GotomaxxDocumentFormFieldRestResponse right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(GotomaxxDocumentFormFieldRestResponse left, GotomaxxDocumentFormFieldRestResponse right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
