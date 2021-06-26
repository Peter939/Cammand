/*
 * Camunda Platform REST API
 *
 * OpenApi Spec for Camunda Platform REST API.
 *
 * The version of the OpenAPI document: 7.16.0-alpha1
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
using OpenAPIDateConverter = Camunda.Http.Api.Client.OpenAPIDateConverter;

namespace Camunda.Http.Api.Model
{
    /// <summary>
    /// DeleteHistoricDecisionInstancesDto
    /// </summary>
    [DataContract(Name = "DeleteHistoricDecisionInstancesDto")]
    public partial class DeleteHistoricDecisionInstancesDto : IEquatable<DeleteHistoricDecisionInstancesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteHistoricDecisionInstancesDto" /> class.
        /// </summary>
        /// <param name="historicDecisionInstanceIds">A list of historic decision instance ids to delete..</param>
        /// <param name="historicDecisionInstanceQuery">historicDecisionInstanceQuery.</param>
        /// <param name="deleteReason">A string with delete reason..</param>
        public DeleteHistoricDecisionInstancesDto(List<string> historicDecisionInstanceIds = default(List<string>), HistoricDecisionInstanceQueryDto historicDecisionInstanceQuery = default(HistoricDecisionInstanceQueryDto), string deleteReason = default(string))
        {
            this.HistoricDecisionInstanceIds = historicDecisionInstanceIds;
            this.HistoricDecisionInstanceQuery = historicDecisionInstanceQuery;
            this.DeleteReason = deleteReason;
        }

        /// <summary>
        /// A list of historic decision instance ids to delete.
        /// </summary>
        /// <value>A list of historic decision instance ids to delete.</value>
        [DataMember(Name = "historicDecisionInstanceIds", EmitDefaultValue = true)]
        public List<string> HistoricDecisionInstanceIds { get; set; }

        /// <summary>
        /// Gets or Sets HistoricDecisionInstanceQuery
        /// </summary>
        [DataMember(Name = "historicDecisionInstanceQuery", EmitDefaultValue = false)]
        public HistoricDecisionInstanceQueryDto HistoricDecisionInstanceQuery { get; set; }

        /// <summary>
        /// A string with delete reason.
        /// </summary>
        /// <value>A string with delete reason.</value>
        [DataMember(Name = "deleteReason", EmitDefaultValue = true)]
        public string DeleteReason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteHistoricDecisionInstancesDto {\n");
            sb.Append("  HistoricDecisionInstanceIds: ").Append(HistoricDecisionInstanceIds).Append("\n");
            sb.Append("  HistoricDecisionInstanceQuery: ").Append(HistoricDecisionInstanceQuery).Append("\n");
            sb.Append("  DeleteReason: ").Append(DeleteReason).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteHistoricDecisionInstancesDto);
        }

        /// <summary>
        /// Returns true if DeleteHistoricDecisionInstancesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteHistoricDecisionInstancesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteHistoricDecisionInstancesDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HistoricDecisionInstanceIds == input.HistoricDecisionInstanceIds ||
                    this.HistoricDecisionInstanceIds != null &&
                    input.HistoricDecisionInstanceIds != null &&
                    this.HistoricDecisionInstanceIds.SequenceEqual(input.HistoricDecisionInstanceIds)
                ) && 
                (
                    this.HistoricDecisionInstanceQuery == input.HistoricDecisionInstanceQuery ||
                    (this.HistoricDecisionInstanceQuery != null &&
                    this.HistoricDecisionInstanceQuery.Equals(input.HistoricDecisionInstanceQuery))
                ) && 
                (
                    this.DeleteReason == input.DeleteReason ||
                    (this.DeleteReason != null &&
                    this.DeleteReason.Equals(input.DeleteReason))
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
                int hashCode = 41;
                if (this.HistoricDecisionInstanceIds != null)
                    hashCode = hashCode * 59 + this.HistoricDecisionInstanceIds.GetHashCode();
                if (this.HistoricDecisionInstanceQuery != null)
                    hashCode = hashCode * 59 + this.HistoricDecisionInstanceQuery.GetHashCode();
                if (this.DeleteReason != null)
                    hashCode = hashCode * 59 + this.DeleteReason.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}