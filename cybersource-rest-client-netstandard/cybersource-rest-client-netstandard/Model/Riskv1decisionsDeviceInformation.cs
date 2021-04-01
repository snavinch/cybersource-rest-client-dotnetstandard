/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Riskv1decisionsDeviceInformation
    /// </summary>
    [DataContract]
    public partial class Riskv1decisionsDeviceInformation :  IEquatable<Riskv1decisionsDeviceInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1decisionsDeviceInformation" /> class.
        /// </summary>
        /// <param name="CookiesAccepted">Whether the customer’s browser accepts cookies. This field can contain one of the following values: - &#x60;yes&#x60;: The customer’s browser accepts cookies. - &#x60;no&#x60;: The customer’s browser does not accept cookies. .</param>
        /// <param name="IpAddress">IP address of the customer.  #### Used by **Authorization, Capture, and Credit** Optional field. .</param>
        /// <param name="HostName">DNS resolved hostname from &#x60;ipAddress&#x60;..</param>
        /// <param name="FingerprintSessionId">Field that contains the session ID that you send to Decision Manager to obtain the device fingerprint information. The string can contain uppercase and lowercase letters, digits, hyphen (-), and underscore (_). However, do not use the same uppercase and lowercase letters to indicate different session IDs.  The session ID must be unique for each merchant ID. You can use any string that you are already generating, such as an order number or web session ID.  The session ID must be unique for each page load, regardless of an individual’s web session ID. If a user navigates to a profiled page and is assigned a web session, navigates away from the profiled page, then navigates back to the profiled page, the generated session ID should be different and unique. You may use a web session ID, but it is preferable to use an application GUID (Globally Unique Identifier). This measure ensures that a unique ID is generated every time the page is loaded, even if it is the same user reloading the page. .</param>
        /// <param name="UseRawFingerprintSessionId">Boolean that indicates whether request contains the device fingerprint information. Values: - &#x60;true&#x60;: Use raw fingerprintSessionId when looking up device details. - &#x60;false&#x60; (default): Use merchant id + fingerprintSessionId as the session id for Device detail collection. .</param>
        /// <param name="HttpBrowserEmail">Email address set in the customer’s browser, which may differ from customer email. .</param>
        /// <param name="UserAgent">Customer’s browser as identified from the HTTP header data. For example, &#x60;Mozilla&#x60; is the value that identifies the Netscape browser. .</param>
        /// <param name="RawData">RawData.</param>
        /// <param name="HttpAcceptBrowserValue">Value of the Accept header sent by the customer’s web browser. **Note** If the customer’s browser provides a value, you must include it in your request. .</param>
        /// <param name="HttpAcceptContent">The exact content of the HTTP accept header. .</param>
        /// <param name="HttpBrowserLanguage">Value represents the browser language as defined in IETF BCP47. Example:en-US, refer  https://en.wikipedia.org/wiki/IETF_language_tag for more details. .</param>
        /// <param name="HttpBrowserJavaEnabled">A Boolean value that represents the ability of the cardholder browser to execute Java. Value is returned from the navigator.javaEnabled property. Possible Values:True/False .</param>
        /// <param name="HttpBrowserJavaScriptEnabled">A Boolean value that represents the ability of the cardholder browser to execute JavaScript. Possible Values:True/False. **Note**: Merchants should be able to know the values from fingerprint details of cardholder&#39;s browser. .</param>
        /// <param name="HttpBrowserColorDepth">Value represents the bit depth of the color palette for displaying images, in bits per pixel. Example : 24, refer https://en.wikipedia.org/wiki/Color_depth for more details .</param>
        /// <param name="HttpBrowserScreenHeight">Total height of the Cardholder&#39;s scree in pixels, example: 864. .</param>
        /// <param name="HttpBrowserScreenWidth">Total width of the cardholder&#39;s screen in pixels. Example: 1536. .</param>
        /// <param name="HttpBrowserTimeDifference">Time difference between UTC time and the cardholder browser local time, in minutes, Example:300 .</param>
        /// <param name="UserAgentBrowserValue">Value of the User-Agent header sent by the customer’s web browser. Note If the customer’s browser provides a value, you must include it in your request. .</param>
        public Riskv1decisionsDeviceInformation(string CookiesAccepted = default(string), string IpAddress = default(string), string HostName = default(string), string FingerprintSessionId = default(string), bool? UseRawFingerprintSessionId = default(bool?), string HttpBrowserEmail = default(string), string UserAgent = default(string), List<Ptsv2paymentsDeviceInformationRawData> RawData = default(List<Ptsv2paymentsDeviceInformationRawData>), string HttpAcceptBrowserValue = default(string), string HttpAcceptContent = default(string), string HttpBrowserLanguage = default(string), bool? HttpBrowserJavaEnabled = default(bool?), bool? HttpBrowserJavaScriptEnabled = default(bool?), string HttpBrowserColorDepth = default(string), string HttpBrowserScreenHeight = default(string), string HttpBrowserScreenWidth = default(string), string HttpBrowserTimeDifference = default(string), string UserAgentBrowserValue = default(string))
        {
            this.CookiesAccepted = CookiesAccepted;
            this.IpAddress = IpAddress;
            this.HostName = HostName;
            this.FingerprintSessionId = FingerprintSessionId;
            this.UseRawFingerprintSessionId = UseRawFingerprintSessionId;
            this.HttpBrowserEmail = HttpBrowserEmail;
            this.UserAgent = UserAgent;
            this.RawData = RawData;
            this.HttpAcceptBrowserValue = HttpAcceptBrowserValue;
            this.HttpAcceptContent = HttpAcceptContent;
            this.HttpBrowserLanguage = HttpBrowserLanguage;
            this.HttpBrowserJavaEnabled = HttpBrowserJavaEnabled;
            this.HttpBrowserJavaScriptEnabled = HttpBrowserJavaScriptEnabled;
            this.HttpBrowserColorDepth = HttpBrowserColorDepth;
            this.HttpBrowserScreenHeight = HttpBrowserScreenHeight;
            this.HttpBrowserScreenWidth = HttpBrowserScreenWidth;
            this.HttpBrowserTimeDifference = HttpBrowserTimeDifference;
            this.UserAgentBrowserValue = UserAgentBrowserValue;
        }
        
        /// <summary>
        /// Whether the customer’s browser accepts cookies. This field can contain one of the following values: - &#x60;yes&#x60;: The customer’s browser accepts cookies. - &#x60;no&#x60;: The customer’s browser does not accept cookies. 
        /// </summary>
        /// <value>Whether the customer’s browser accepts cookies. This field can contain one of the following values: - &#x60;yes&#x60;: The customer’s browser accepts cookies. - &#x60;no&#x60;: The customer’s browser does not accept cookies. </value>
        [DataMember(Name="cookiesAccepted", EmitDefaultValue=false)]
        public string CookiesAccepted { get; set; }

        /// <summary>
        /// IP address of the customer.  #### Used by **Authorization, Capture, and Credit** Optional field. 
        /// </summary>
        /// <value>IP address of the customer.  #### Used by **Authorization, Capture, and Credit** Optional field. </value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// DNS resolved hostname from &#x60;ipAddress&#x60;.
        /// </summary>
        /// <value>DNS resolved hostname from &#x60;ipAddress&#x60;.</value>
        [DataMember(Name="hostName", EmitDefaultValue=false)]
        public string HostName { get; set; }

        /// <summary>
        /// Field that contains the session ID that you send to Decision Manager to obtain the device fingerprint information. The string can contain uppercase and lowercase letters, digits, hyphen (-), and underscore (_). However, do not use the same uppercase and lowercase letters to indicate different session IDs.  The session ID must be unique for each merchant ID. You can use any string that you are already generating, such as an order number or web session ID.  The session ID must be unique for each page load, regardless of an individual’s web session ID. If a user navigates to a profiled page and is assigned a web session, navigates away from the profiled page, then navigates back to the profiled page, the generated session ID should be different and unique. You may use a web session ID, but it is preferable to use an application GUID (Globally Unique Identifier). This measure ensures that a unique ID is generated every time the page is loaded, even if it is the same user reloading the page. 
        /// </summary>
        /// <value>Field that contains the session ID that you send to Decision Manager to obtain the device fingerprint information. The string can contain uppercase and lowercase letters, digits, hyphen (-), and underscore (_). However, do not use the same uppercase and lowercase letters to indicate different session IDs.  The session ID must be unique for each merchant ID. You can use any string that you are already generating, such as an order number or web session ID.  The session ID must be unique for each page load, regardless of an individual’s web session ID. If a user navigates to a profiled page and is assigned a web session, navigates away from the profiled page, then navigates back to the profiled page, the generated session ID should be different and unique. You may use a web session ID, but it is preferable to use an application GUID (Globally Unique Identifier). This measure ensures that a unique ID is generated every time the page is loaded, even if it is the same user reloading the page. </value>
        [DataMember(Name="fingerprintSessionId", EmitDefaultValue=false)]
        public string FingerprintSessionId { get; set; }

        /// <summary>
        /// Boolean that indicates whether request contains the device fingerprint information. Values: - &#x60;true&#x60;: Use raw fingerprintSessionId when looking up device details. - &#x60;false&#x60; (default): Use merchant id + fingerprintSessionId as the session id for Device detail collection. 
        /// </summary>
        /// <value>Boolean that indicates whether request contains the device fingerprint information. Values: - &#x60;true&#x60;: Use raw fingerprintSessionId when looking up device details. - &#x60;false&#x60; (default): Use merchant id + fingerprintSessionId as the session id for Device detail collection. </value>
        [DataMember(Name="useRawFingerprintSessionId", EmitDefaultValue=false)]
        public bool? UseRawFingerprintSessionId { get; set; }

        /// <summary>
        /// Email address set in the customer’s browser, which may differ from customer email. 
        /// </summary>
        /// <value>Email address set in the customer’s browser, which may differ from customer email. </value>
        [DataMember(Name="httpBrowserEmail", EmitDefaultValue=false)]
        public string HttpBrowserEmail { get; set; }

        /// <summary>
        /// Customer’s browser as identified from the HTTP header data. For example, &#x60;Mozilla&#x60; is the value that identifies the Netscape browser. 
        /// </summary>
        /// <value>Customer’s browser as identified from the HTTP header data. For example, &#x60;Mozilla&#x60; is the value that identifies the Netscape browser. </value>
        [DataMember(Name="userAgent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or Sets RawData
        /// </summary>
        [DataMember(Name="rawData", EmitDefaultValue=false)]
        public List<Ptsv2paymentsDeviceInformationRawData> RawData { get; set; }

        /// <summary>
        /// Value of the Accept header sent by the customer’s web browser. **Note** If the customer’s browser provides a value, you must include it in your request. 
        /// </summary>
        /// <value>Value of the Accept header sent by the customer’s web browser. **Note** If the customer’s browser provides a value, you must include it in your request. </value>
        [DataMember(Name="httpAcceptBrowserValue", EmitDefaultValue=false)]
        public string HttpAcceptBrowserValue { get; set; }

        /// <summary>
        /// The exact content of the HTTP accept header. 
        /// </summary>
        /// <value>The exact content of the HTTP accept header. </value>
        [DataMember(Name="httpAcceptContent", EmitDefaultValue=false)]
        public string HttpAcceptContent { get; set; }

        /// <summary>
        /// Value represents the browser language as defined in IETF BCP47. Example:en-US, refer  https://en.wikipedia.org/wiki/IETF_language_tag for more details. 
        /// </summary>
        /// <value>Value represents the browser language as defined in IETF BCP47. Example:en-US, refer  https://en.wikipedia.org/wiki/IETF_language_tag for more details. </value>
        [DataMember(Name="httpBrowserLanguage", EmitDefaultValue=false)]
        public string HttpBrowserLanguage { get; set; }

        /// <summary>
        /// A Boolean value that represents the ability of the cardholder browser to execute Java. Value is returned from the navigator.javaEnabled property. Possible Values:True/False 
        /// </summary>
        /// <value>A Boolean value that represents the ability of the cardholder browser to execute Java. Value is returned from the navigator.javaEnabled property. Possible Values:True/False </value>
        [DataMember(Name="httpBrowserJavaEnabled", EmitDefaultValue=false)]
        public bool? HttpBrowserJavaEnabled { get; set; }

        /// <summary>
        /// A Boolean value that represents the ability of the cardholder browser to execute JavaScript. Possible Values:True/False. **Note**: Merchants should be able to know the values from fingerprint details of cardholder&#39;s browser. 
        /// </summary>
        /// <value>A Boolean value that represents the ability of the cardholder browser to execute JavaScript. Possible Values:True/False. **Note**: Merchants should be able to know the values from fingerprint details of cardholder&#39;s browser. </value>
        [DataMember(Name="httpBrowserJavaScriptEnabled", EmitDefaultValue=false)]
        public bool? HttpBrowserJavaScriptEnabled { get; set; }

        /// <summary>
        /// Value represents the bit depth of the color palette for displaying images, in bits per pixel. Example : 24, refer https://en.wikipedia.org/wiki/Color_depth for more details 
        /// </summary>
        /// <value>Value represents the bit depth of the color palette for displaying images, in bits per pixel. Example : 24, refer https://en.wikipedia.org/wiki/Color_depth for more details </value>
        [DataMember(Name="httpBrowserColorDepth", EmitDefaultValue=false)]
        public string HttpBrowserColorDepth { get; set; }

        /// <summary>
        /// Total height of the Cardholder&#39;s scree in pixels, example: 864. 
        /// </summary>
        /// <value>Total height of the Cardholder&#39;s scree in pixels, example: 864. </value>
        [DataMember(Name="httpBrowserScreenHeight", EmitDefaultValue=false)]
        public string HttpBrowserScreenHeight { get; set; }

        /// <summary>
        /// Total width of the cardholder&#39;s screen in pixels. Example: 1536. 
        /// </summary>
        /// <value>Total width of the cardholder&#39;s screen in pixels. Example: 1536. </value>
        [DataMember(Name="httpBrowserScreenWidth", EmitDefaultValue=false)]
        public string HttpBrowserScreenWidth { get; set; }

        /// <summary>
        /// Time difference between UTC time and the cardholder browser local time, in minutes, Example:300 
        /// </summary>
        /// <value>Time difference between UTC time and the cardholder browser local time, in minutes, Example:300 </value>
        [DataMember(Name="httpBrowserTimeDifference", EmitDefaultValue=false)]
        public string HttpBrowserTimeDifference { get; set; }

        /// <summary>
        /// Value of the User-Agent header sent by the customer’s web browser. Note If the customer’s browser provides a value, you must include it in your request. 
        /// </summary>
        /// <value>Value of the User-Agent header sent by the customer’s web browser. Note If the customer’s browser provides a value, you must include it in your request. </value>
        [DataMember(Name="userAgentBrowserValue", EmitDefaultValue=false)]
        public string UserAgentBrowserValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1decisionsDeviceInformation {\n");
            sb.Append("  CookiesAccepted: ").Append(CookiesAccepted).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  FingerprintSessionId: ").Append(FingerprintSessionId).Append("\n");
            sb.Append("  UseRawFingerprintSessionId: ").Append(UseRawFingerprintSessionId).Append("\n");
            sb.Append("  HttpBrowserEmail: ").Append(HttpBrowserEmail).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  RawData: ").Append(RawData).Append("\n");
            sb.Append("  HttpAcceptBrowserValue: ").Append(HttpAcceptBrowserValue).Append("\n");
            sb.Append("  HttpAcceptContent: ").Append(HttpAcceptContent).Append("\n");
            sb.Append("  HttpBrowserLanguage: ").Append(HttpBrowserLanguage).Append("\n");
            sb.Append("  HttpBrowserJavaEnabled: ").Append(HttpBrowserJavaEnabled).Append("\n");
            sb.Append("  HttpBrowserJavaScriptEnabled: ").Append(HttpBrowserJavaScriptEnabled).Append("\n");
            sb.Append("  HttpBrowserColorDepth: ").Append(HttpBrowserColorDepth).Append("\n");
            sb.Append("  HttpBrowserScreenHeight: ").Append(HttpBrowserScreenHeight).Append("\n");
            sb.Append("  HttpBrowserScreenWidth: ").Append(HttpBrowserScreenWidth).Append("\n");
            sb.Append("  HttpBrowserTimeDifference: ").Append(HttpBrowserTimeDifference).Append("\n");
            sb.Append("  UserAgentBrowserValue: ").Append(UserAgentBrowserValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Riskv1decisionsDeviceInformation);
        }

        /// <summary>
        /// Returns true if Riskv1decisionsDeviceInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1decisionsDeviceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1decisionsDeviceInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CookiesAccepted == other.CookiesAccepted ||
                    this.CookiesAccepted != null &&
                    this.CookiesAccepted.Equals(other.CookiesAccepted)
                ) && 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    this.HostName == other.HostName ||
                    this.HostName != null &&
                    this.HostName.Equals(other.HostName)
                ) && 
                (
                    this.FingerprintSessionId == other.FingerprintSessionId ||
                    this.FingerprintSessionId != null &&
                    this.FingerprintSessionId.Equals(other.FingerprintSessionId)
                ) && 
                (
                    this.UseRawFingerprintSessionId == other.UseRawFingerprintSessionId ||
                    this.UseRawFingerprintSessionId != null &&
                    this.UseRawFingerprintSessionId.Equals(other.UseRawFingerprintSessionId)
                ) && 
                (
                    this.HttpBrowserEmail == other.HttpBrowserEmail ||
                    this.HttpBrowserEmail != null &&
                    this.HttpBrowserEmail.Equals(other.HttpBrowserEmail)
                ) && 
                (
                    this.UserAgent == other.UserAgent ||
                    this.UserAgent != null &&
                    this.UserAgent.Equals(other.UserAgent)
                ) && 
                (
                    this.RawData == other.RawData ||
                    this.RawData != null &&
                    this.RawData.SequenceEqual(other.RawData)
                ) && 
                (
                    this.HttpAcceptBrowserValue == other.HttpAcceptBrowserValue ||
                    this.HttpAcceptBrowserValue != null &&
                    this.HttpAcceptBrowserValue.Equals(other.HttpAcceptBrowserValue)
                ) && 
                (
                    this.HttpAcceptContent == other.HttpAcceptContent ||
                    this.HttpAcceptContent != null &&
                    this.HttpAcceptContent.Equals(other.HttpAcceptContent)
                ) && 
                (
                    this.HttpBrowserLanguage == other.HttpBrowserLanguage ||
                    this.HttpBrowserLanguage != null &&
                    this.HttpBrowserLanguage.Equals(other.HttpBrowserLanguage)
                ) && 
                (
                    this.HttpBrowserJavaEnabled == other.HttpBrowserJavaEnabled ||
                    this.HttpBrowserJavaEnabled != null &&
                    this.HttpBrowserJavaEnabled.Equals(other.HttpBrowserJavaEnabled)
                ) && 
                (
                    this.HttpBrowserJavaScriptEnabled == other.HttpBrowserJavaScriptEnabled ||
                    this.HttpBrowserJavaScriptEnabled != null &&
                    this.HttpBrowserJavaScriptEnabled.Equals(other.HttpBrowserJavaScriptEnabled)
                ) && 
                (
                    this.HttpBrowserColorDepth == other.HttpBrowserColorDepth ||
                    this.HttpBrowserColorDepth != null &&
                    this.HttpBrowserColorDepth.Equals(other.HttpBrowserColorDepth)
                ) && 
                (
                    this.HttpBrowserScreenHeight == other.HttpBrowserScreenHeight ||
                    this.HttpBrowserScreenHeight != null &&
                    this.HttpBrowserScreenHeight.Equals(other.HttpBrowserScreenHeight)
                ) && 
                (
                    this.HttpBrowserScreenWidth == other.HttpBrowserScreenWidth ||
                    this.HttpBrowserScreenWidth != null &&
                    this.HttpBrowserScreenWidth.Equals(other.HttpBrowserScreenWidth)
                ) && 
                (
                    this.HttpBrowserTimeDifference == other.HttpBrowserTimeDifference ||
                    this.HttpBrowserTimeDifference != null &&
                    this.HttpBrowserTimeDifference.Equals(other.HttpBrowserTimeDifference)
                ) && 
                (
                    this.UserAgentBrowserValue == other.UserAgentBrowserValue ||
                    this.UserAgentBrowserValue != null &&
                    this.UserAgentBrowserValue.Equals(other.UserAgentBrowserValue)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CookiesAccepted != null)
                    hash = hash * 59 + this.CookiesAccepted.GetHashCode();
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                if (this.HostName != null)
                    hash = hash * 59 + this.HostName.GetHashCode();
                if (this.FingerprintSessionId != null)
                    hash = hash * 59 + this.FingerprintSessionId.GetHashCode();
                if (this.UseRawFingerprintSessionId != null)
                    hash = hash * 59 + this.UseRawFingerprintSessionId.GetHashCode();
                if (this.HttpBrowserEmail != null)
                    hash = hash * 59 + this.HttpBrowserEmail.GetHashCode();
                if (this.UserAgent != null)
                    hash = hash * 59 + this.UserAgent.GetHashCode();
                if (this.RawData != null)
                    hash = hash * 59 + this.RawData.GetHashCode();
                if (this.HttpAcceptBrowserValue != null)
                    hash = hash * 59 + this.HttpAcceptBrowserValue.GetHashCode();
                if (this.HttpAcceptContent != null)
                    hash = hash * 59 + this.HttpAcceptContent.GetHashCode();
                if (this.HttpBrowserLanguage != null)
                    hash = hash * 59 + this.HttpBrowserLanguage.GetHashCode();
                if (this.HttpBrowserJavaEnabled != null)
                    hash = hash * 59 + this.HttpBrowserJavaEnabled.GetHashCode();
                if (this.HttpBrowserJavaScriptEnabled != null)
                    hash = hash * 59 + this.HttpBrowserJavaScriptEnabled.GetHashCode();
                if (this.HttpBrowserColorDepth != null)
                    hash = hash * 59 + this.HttpBrowserColorDepth.GetHashCode();
                if (this.HttpBrowserScreenHeight != null)
                    hash = hash * 59 + this.HttpBrowserScreenHeight.GetHashCode();
                if (this.HttpBrowserScreenWidth != null)
                    hash = hash * 59 + this.HttpBrowserScreenWidth.GetHashCode();
                if (this.HttpBrowserTimeDifference != null)
                    hash = hash * 59 + this.HttpBrowserTimeDifference.GetHashCode();
                if (this.UserAgentBrowserValue != null)
                    hash = hash * 59 + this.UserAgentBrowserValue.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // IpAddress (string) maxLength
            if(this.IpAddress != null && this.IpAddress.Length >= 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IpAddress, length must be less than or equal to 45.", new [] { "IpAddress" });
            }

            // HostName (string) maxLength
            if(this.HostName != null && this.HostName.Length >= 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HostName, length must be less than or equal to 60.", new [] { "HostName" });
            }

            // UserAgent (string) maxLength
            if(this.UserAgent != null && this.UserAgent.Length >= 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserAgent, length must be less than or equal to 40.", new [] { "UserAgent" });
            }

            // HttpAcceptBrowserValue (string) maxLength
            if(this.HttpAcceptBrowserValue != null && this.HttpAcceptBrowserValue.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HttpAcceptBrowserValue, length must be less than or equal to 255.", new [] { "HttpAcceptBrowserValue" });
            }

            // HttpAcceptContent (string) maxLength
            if(this.HttpAcceptContent != null && this.HttpAcceptContent.Length >= 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HttpAcceptContent, length must be less than or equal to 256.", new [] { "HttpAcceptContent" });
            }

            // HttpBrowserLanguage (string) maxLength
            if(this.HttpBrowserLanguage != null && this.HttpBrowserLanguage.Length >= 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HttpBrowserLanguage, length must be less than or equal to 8.", new [] { "HttpBrowserLanguage" });
            }

            // HttpBrowserColorDepth (string) maxLength
            if(this.HttpBrowserColorDepth != null && this.HttpBrowserColorDepth.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HttpBrowserColorDepth, length must be less than or equal to 2.", new [] { "HttpBrowserColorDepth" });
            }

            // HttpBrowserScreenHeight (string) maxLength
            if(this.HttpBrowserScreenHeight != null && this.HttpBrowserScreenHeight.Length >= 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HttpBrowserScreenHeight, length must be less than or equal to 6.", new [] { "HttpBrowserScreenHeight" });
            }

            // HttpBrowserScreenWidth (string) maxLength
            if(this.HttpBrowserScreenWidth != null && this.HttpBrowserScreenWidth.Length >= 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HttpBrowserScreenWidth, length must be less than or equal to 6.", new [] { "HttpBrowserScreenWidth" });
            }

            // HttpBrowserTimeDifference (string) maxLength
            if(this.HttpBrowserTimeDifference != null && this.HttpBrowserTimeDifference.Length >= 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HttpBrowserTimeDifference, length must be less than or equal to 5.", new [] { "HttpBrowserTimeDifference" });
            }

            // UserAgentBrowserValue (string) maxLength
            if(this.UserAgentBrowserValue != null && this.UserAgentBrowserValue.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserAgentBrowserValue, length must be less than or equal to 255.", new [] { "UserAgentBrowserValue" });
            }

            yield break;
        }
    }

}
