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
    /// CompleteExternalTaskDto
    /// </summary>
    [DataContract(Name = "CompleteExternalTaskDto")]
    public partial class CompleteExternalTaskDto : IEquatable<CompleteExternalTaskDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteExternalTaskDto" /> class.
        /// </summary>
        /// <param name="variables">A JSON object containing variable key-value pairs. Each key is a variable name and each value a JSON variable value object with the following properties:.</param>
        /// <param name="localVariables">A JSON object containing local variable key-value pairs. Local variables are set only in the scope of external task. Each key is a variable name and each value a JSON variable value object with the following properties:.</param>
        /// <param name="workerId">**Mandatory.** The ID of the worker who is performing the operation on the external task. If the task is already locked, must match the id of the worker who has most recently locked the task..</param>
        public CompleteExternalTaskDto(Dictionary<string, VariableValueDto> variables = default(Dictionary<string, VariableValueDto>), Dictionary<string, VariableValueDto> localVariables = default(Dictionary<string, VariableValueDto>), string workerId = default(string))
        {
            this.Variables = variables;
            this.LocalVariables = localVariables;
            this.WorkerId = workerId;
        }

        /// <summary>
        /// A JSON object containing variable key-value pairs. Each key is a variable name and each value a JSON variable value object with the following properties:
        /// </summary>
        /// <value>A JSON object containing variable key-value pairs. Each key is a variable name and each value a JSON variable value object with the following properties:</value>
        [DataMember(Name = "variables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> Variables { get; set; }

        /// <summary>
        /// A JSON object containing local variable key-value pairs. Local variables are set only in the scope of external task. Each key is a variable name and each value a JSON variable value object with the following properties:
        /// </summary>
        /// <value>A JSON object containing local variable key-value pairs. Local variables are set only in the scope of external task. Each key is a variable name and each value a JSON variable value object with the following properties:</value>
        [DataMember(Name = "localVariables", EmitDefaultValue = true)]
        public Dictionary<string, VariableValueDto> LocalVariables { get; set; }

        /// <summary>
        /// **Mandatory.** The ID of the worker who is performing the operation on the external task. If the task is already locked, must match the id of the worker who has most recently locked the task.
        /// </summary>
        /// <value>**Mandatory.** The ID of the worker who is performing the operation on the external task. If the task is already locked, must match the id of the worker who has most recently locked the task.</value>
        [DataMember(Name = "workerId", EmitDefaultValue = false)]
        public string WorkerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompleteExternalTaskDto {\n");
            sb.Append("  Variables: ").Append(Variables).Append("\n");
            sb.Append("  LocalVariables: ").Append(LocalVariables).Append("\n");
            sb.Append("  WorkerId: ").Append(WorkerId).Append("\n");
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
            return this.Equals(input as CompleteExternalTaskDto);
        }

        /// <summary>
        /// Returns true if CompleteExternalTaskDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CompleteExternalTaskDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompleteExternalTaskDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Variables == input.Variables ||
                    this.Variables != null &&
                    input.Variables != null &&
                    this.Variables.SequenceEqual(input.Variables)
                ) && 
                (
                    this.LocalVariables == input.LocalVariables ||
                    this.LocalVariables != null &&
                    input.LocalVariables != null &&
                    this.LocalVariables.SequenceEqual(input.LocalVariables)
                ) && 
                (
                    this.WorkerId == input.WorkerId ||
                    (this.WorkerId != null &&
                    this.WorkerId.Equals(input.WorkerId))
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
                if (this.Variables != null)
                    hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.LocalVariables != null)
                    hashCode = hashCode * 59 + this.LocalVariables.GetHashCode();
                if (this.WorkerId != null)
                    hashCode = hashCode * 59 + this.WorkerId.GetHashCode();
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
