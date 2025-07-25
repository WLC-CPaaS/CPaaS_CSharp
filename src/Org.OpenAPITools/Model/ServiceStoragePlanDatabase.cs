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
    /// ServiceStoragePlanDatabase
    /// </summary>
    [DataContract(Name = "service.StoragePlanDatabase")]
    public partial class ServiceStoragePlanDatabase : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceStoragePlanDatabase" /> class.
        /// </summary>
        /// <param name="attachments">attachments.</param>
        /// <param name="connection">connection.</param>
        /// <param name="database">database.</param>
        /// <param name="types">types.</param>
        public ServiceStoragePlanDatabase(ServiceStoragePlanDatabaseAttachment attachments = default, string connection = default, ServiceStoragePlanDatabaseProperties database = default, ServiceStoragePlanDatabaseTypes types = default)
        {
            this.Attachments = attachments;
            this.Connection = connection;
            this.Database = database;
            this.Types = types;
        }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public ServiceStoragePlanDatabaseAttachment Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Connection
        /// </summary>
        [DataMember(Name = "connection", EmitDefaultValue = false)]
        public string Connection { get; set; }

        /// <summary>
        /// Gets or Sets Database
        /// </summary>
        [DataMember(Name = "database", EmitDefaultValue = false)]
        public ServiceStoragePlanDatabaseProperties Database { get; set; }

        /// <summary>
        /// Gets or Sets Types
        /// </summary>
        [DataMember(Name = "types", EmitDefaultValue = false)]
        public ServiceStoragePlanDatabaseTypes Types { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceStoragePlanDatabase {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Connection: ").Append(Connection).Append("\n");
            sb.Append("  Database: ").Append(Database).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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
