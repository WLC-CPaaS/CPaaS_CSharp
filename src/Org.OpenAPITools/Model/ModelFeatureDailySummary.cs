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
    /// ModelFeatureDailySummary
    /// </summary>
    [DataContract(Name = "model.FeatureDailySummary")]
    public partial class ModelFeatureDailySummary : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelFeatureDailySummary" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="featureCount">featureCount.</param>
        /// <param name="featureName">featureName.</param>
        /// <param name="logDate">logDate.</param>
        public ModelFeatureDailySummary(string createdAt = default, int featureCount = default, string featureName = default, string logDate = default)
        {
            this.CreatedAt = createdAt;
            this.FeatureCount = featureCount;
            this.FeatureName = featureName;
            this.LogDate = logDate;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets FeatureCount
        /// </summary>
        [DataMember(Name = "feature_count", EmitDefaultValue = false)]
        public int FeatureCount { get; set; }

        /// <summary>
        /// Gets or Sets FeatureName
        /// </summary>
        [DataMember(Name = "feature_name", EmitDefaultValue = false)]
        public string FeatureName { get; set; }

        /// <summary>
        /// Gets or Sets LogDate
        /// </summary>
        [DataMember(Name = "log_date", EmitDefaultValue = false)]
        public string LogDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModelFeatureDailySummary {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  FeatureCount: ").Append(FeatureCount).Append("\n");
            sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
            sb.Append("  LogDate: ").Append(LogDate).Append("\n");
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
