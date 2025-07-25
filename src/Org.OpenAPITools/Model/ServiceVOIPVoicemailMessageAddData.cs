/*
 * White Label Communications CPaas API Documentation
 *
 * A CPaaS platform API
 *
 * The version of the OpenAPI document: 1.1
 * Contact: support@whitelabelcomm.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ServiceVOIPVoicemailMessageAddData
    /// </summary>
    [DataContract(Name = "service.VOIPVoicemailMessageAddData")]
    public partial class ServiceVOIPVoicemailMessageAddData : IValidatableObject
    {
        /// <summary>
        /// Defines Folder
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FolderEnum
        {
            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 1,

            /// <summary>
            /// Enum Saved for value: saved
            /// </summary>
            [EnumMember(Value = "saved")]
            Saved = 2,

            /// <summary>
            /// Enum New for value: new
            /// </summary>
            [EnumMember(Value = "new")]
            New = 3
        }


        /// <summary>
        /// Gets or Sets Folder
        /// </summary>
        [DataMember(Name = "folder", IsRequired = true, EmitDefaultValue = true)]
        public FolderEnum Folder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceVOIPVoicemailMessageAddData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceVOIPVoicemailMessageAddData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceVOIPVoicemailMessageAddData" /> class.
        /// </summary>
        /// <param name="callerIdName">callerIdName.</param>
        /// <param name="callerIdNumber">callerIdNumber.</param>
        /// <param name="folder">folder (required).</param>
        /// <param name="from">from.</param>
        /// <param name="to">to.</param>
        public ServiceVOIPVoicemailMessageAddData(string callerIdName = default, string callerIdNumber = default, FolderEnum folder = default, string from = default, string to = default)
        {
            this.Folder = folder;
            this.CallerIdName = callerIdName;
            this.CallerIdNumber = callerIdNumber;
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Gets or Sets CallerIdName
        /// </summary>
        [DataMember(Name = "caller_id_name", EmitDefaultValue = false)]
        public string CallerIdName { get; set; }

        /// <summary>
        /// Gets or Sets CallerIdNumber
        /// </summary>
        [DataMember(Name = "caller_id_number", EmitDefaultValue = false)]
        public string CallerIdNumber { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceVOIPVoicemailMessageAddData {\n");
            sb.Append("  CallerIdName: ").Append(CallerIdName).Append("\n");
            sb.Append("  CallerIdNumber: ").Append(CallerIdNumber).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
