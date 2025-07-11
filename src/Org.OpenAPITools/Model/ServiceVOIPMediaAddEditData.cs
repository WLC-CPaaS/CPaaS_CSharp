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
    /// ServiceVOIPMediaAddEditData
    /// </summary>
    [DataContract(Name = "service.VOIPMediaAddEditData")]
    public partial class ServiceVOIPMediaAddEditData : IValidatableObject
    {
        /// <summary>
        /// Defines MediaSource
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MediaSourceEnum
        {
            /// <summary>
            /// Enum Upload for value: upload
            /// </summary>
            [EnumMember(Value = "upload")]
            Upload = 1,

            /// <summary>
            /// Enum Recording for value: recording
            /// </summary>
            [EnumMember(Value = "recording")]
            Recording = 2,

            /// <summary>
            /// Enum Tts for value: tts
            /// </summary>
            [EnumMember(Value = "tts")]
            Tts = 3
        }


        /// <summary>
        /// Gets or Sets MediaSource
        /// </summary>
        [DataMember(Name = "media_source", EmitDefaultValue = false)]
        public MediaSourceEnum? MediaSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceVOIPMediaAddEditData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceVOIPMediaAddEditData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceVOIPMediaAddEditData" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="mediaSource">mediaSource.</param>
        /// <param name="name">name (required).</param>
        /// <param name="tts">tts.</param>
        public ServiceVOIPMediaAddEditData(string description = default, MediaSourceEnum? mediaSource = default, string name = default, ServiceTTS tts = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ServiceVOIPMediaAddEditData and cannot be null");
            }
            this.Name = name;
            this.Description = description;
            this.MediaSource = mediaSource;
            this.Tts = tts;
        }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Tts
        /// </summary>
        [DataMember(Name = "tts", EmitDefaultValue = false)]
        public ServiceTTS Tts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceVOIPMediaAddEditData {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MediaSource: ").Append(MediaSource).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tts: ").Append(Tts).Append("\n");
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 128)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 128.", new [] { "Description" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 128)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            yield break;
        }
    }

}
