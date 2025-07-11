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
    /// ModelsCallRecordingSource
    /// </summary>
    [DataContract(Name = "models.CallRecordingSource")]
    public partial class ModelsCallRecordingSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCallRecordingSource" /> class.
        /// </summary>
        /// <param name="any">any.</param>
        /// <param name="offnet">offnet.</param>
        /// <param name="onnet">onnet.</param>
        public ModelsCallRecordingSource(ModelsCallRecordingParameters any = default, ModelsCallRecordingParameters offnet = default, ModelsCallRecordingParameters onnet = default)
        {
            this.Any = any;
            this.Offnet = offnet;
            this.Onnet = onnet;
        }

        /// <summary>
        /// Gets or Sets Any
        /// </summary>
        [DataMember(Name = "any", EmitDefaultValue = false)]
        public ModelsCallRecordingParameters Any { get; set; }

        /// <summary>
        /// Gets or Sets Offnet
        /// </summary>
        [DataMember(Name = "offnet", EmitDefaultValue = false)]
        public ModelsCallRecordingParameters Offnet { get; set; }

        /// <summary>
        /// Gets or Sets Onnet
        /// </summary>
        [DataMember(Name = "onnet", EmitDefaultValue = false)]
        public ModelsCallRecordingParameters Onnet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelsCallRecordingSource {\n");
            sb.Append("  Any: ").Append(Any).Append("\n");
            sb.Append("  Offnet: ").Append(Offnet).Append("\n");
            sb.Append("  Onnet: ").Append(Onnet).Append("\n");
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
