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
    /// ServiceVOIPDeviceAddEdit2
    /// </summary>
    [DataContract(Name = "service.VOIPDeviceAddEdit2")]
    public partial class ServiceVOIPDeviceAddEdit2 : IValidatableObject
    {
        /// <summary>
        /// Defines DeviceType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceTypeEnum
        {
            /// <summary>
            /// Enum Softphone for value: softphone
            /// </summary>
            [EnumMember(Value = "softphone")]
            Softphone = 1,

            /// <summary>
            /// Enum SipUri for value: sip_uri
            /// </summary>
            [EnumMember(Value = "sip_uri")]
            SipUri = 2,

            /// <summary>
            /// Enum SipDevice for value: sip_device
            /// </summary>
            [EnumMember(Value = "sip_device")]
            SipDevice = 3
        }


        /// <summary>
        /// Gets or Sets DeviceType
        /// </summary>
        [DataMember(Name = "device_type", EmitDefaultValue = false)]
        public DeviceTypeEnum? DeviceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceVOIPDeviceAddEdit2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceVOIPDeviceAddEdit2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceVOIPDeviceAddEdit2" /> class.
        /// </summary>
        /// <param name="callForward">callForward.</param>
        /// <param name="callerId">callerId.</param>
        /// <param name="deviceType">deviceType.</param>
        /// <param name="doNotDisturb">doNotDisturb.</param>
        /// <param name="enabled">cannot use required, else it has to be true and false is not allowed.</param>
        /// <param name="macAddress">dont use mac, it enforces :, which voip does not like.</param>
        /// <param name="media">media.</param>
        /// <param name="musicOnHold">musicOnHold.</param>
        /// <param name="name">name (required).</param>
        /// <param name="ownerId">json omitempty is needed else voip fails on \&quot;\&quot; for owner_id.</param>
        /// <param name="provision">provision.</param>
        /// <param name="sip">sip (required).</param>
        public ServiceVOIPDeviceAddEdit2(ModelsCallForward callForward = default, ServiceVOIPDeviceAddEdit3c callerId = default, DeviceTypeEnum? deviceType = default, ModelsVOIPSharedDoNotDisturb doNotDisturb = default, bool enabled = default, string macAddress = default, ServiceVOIPDeviceAddEdit3d media = default, ModelsMusicOnHold musicOnHold = default, string name = default, string ownerId = default, ServiceVOIPDeviceAddEditProvision provision = default, ServiceVOIPDeviceAddEdit3a sip = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ServiceVOIPDeviceAddEdit2 and cannot be null");
            }
            this.Name = name;
            // to ensure "sip" is required (not null)
            if (sip == null)
            {
                throw new ArgumentNullException("sip is a required property for ServiceVOIPDeviceAddEdit2 and cannot be null");
            }
            this.Sip = sip;
            this.CallForward = callForward;
            this.CallerId = callerId;
            this.DeviceType = deviceType;
            this.DoNotDisturb = doNotDisturb;
            this.Enabled = enabled;
            this.MacAddress = macAddress;
            this.Media = media;
            this.MusicOnHold = musicOnHold;
            this.OwnerId = ownerId;
            this.Provision = provision;
        }

        /// <summary>
        /// Gets or Sets CallForward
        /// </summary>
        [DataMember(Name = "call_forward", EmitDefaultValue = false)]
        public ModelsCallForward CallForward { get; set; }

        /// <summary>
        /// Gets or Sets CallerId
        /// </summary>
        [DataMember(Name = "caller_id", EmitDefaultValue = false)]
        public ServiceVOIPDeviceAddEdit3c CallerId { get; set; }

        /// <summary>
        /// Gets or Sets DoNotDisturb
        /// </summary>
        [DataMember(Name = "do_not_disturb", EmitDefaultValue = false)]
        public ModelsVOIPSharedDoNotDisturb DoNotDisturb { get; set; }

        /// <summary>
        /// cannot use required, else it has to be true and false is not allowed
        /// </summary>
        /// <value>cannot use required, else it has to be true and false is not allowed</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// dont use mac, it enforces :, which voip does not like
        /// </summary>
        /// <value>dont use mac, it enforces :, which voip does not like</value>
        [DataMember(Name = "mac_address", EmitDefaultValue = false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        public ServiceVOIPDeviceAddEdit3d Media { get; set; }

        /// <summary>
        /// Gets or Sets MusicOnHold
        /// </summary>
        [DataMember(Name = "music_on_hold", EmitDefaultValue = false)]
        public ModelsMusicOnHold MusicOnHold { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// json omitempty is needed else voip fails on \&quot;\&quot; for owner_id
        /// </summary>
        /// <value>json omitempty is needed else voip fails on \&quot;\&quot; for owner_id</value>
        [DataMember(Name = "owner_id", EmitDefaultValue = false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Gets or Sets Provision
        /// </summary>
        [DataMember(Name = "provision", EmitDefaultValue = false)]
        public ServiceVOIPDeviceAddEditProvision Provision { get; set; }

        /// <summary>
        /// Gets or Sets Sip
        /// </summary>
        [DataMember(Name = "sip", IsRequired = true, EmitDefaultValue = true)]
        public ServiceVOIPDeviceAddEdit3a Sip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceVOIPDeviceAddEdit2 {\n");
            sb.Append("  CallForward: ").Append(CallForward).Append("\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  DoNotDisturb: ").Append(DoNotDisturb).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  MusicOnHold: ").Append(MusicOnHold).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  Provision: ").Append(Provision).Append("\n");
            sb.Append("  Sip: ").Append(Sip).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 128)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            yield break;
        }
    }

}
