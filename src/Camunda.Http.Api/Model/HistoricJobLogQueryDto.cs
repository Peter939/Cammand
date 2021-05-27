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
    /// A Historic Job Log instance query which defines a list of Historic Job Log instances
    /// </summary>
    [DataContract(Name = "HistoricJobLogQueryDto")]
    public partial class HistoricJobLogQueryDto : IEquatable<HistoricJobLogQueryDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricJobLogQueryDto" /> class.
        /// </summary>
        /// <param name="logId">Filter by historic job log id..</param>
        /// <param name="jobId">Filter by job id..</param>
        /// <param name="jobExceptionMessage">Filter by job exception message..</param>
        /// <param name="jobDefinitionId">Filter by job definition id..</param>
        /// <param name="jobDefinitionType">Filter by job definition type. See the [User Guide](https://docs.camunda.org/manual/latest/user-guide/process-engine/the-job-executor/#job-creation) for more information about job definition types..</param>
        /// <param name="jobDefinitionConfiguration">Filter by job definition configuration..</param>
        /// <param name="activityIdIn">Only include historic job logs which belong to one of the passed activity ids..</param>
        /// <param name="failedActivityIdIn">Only include historic job logs which belong to failures of one of the passed activity ids..</param>
        /// <param name="executionIdIn">Only include historic job logs which belong to one of the passed execution ids..</param>
        /// <param name="processInstanceId">Filter by process instance id..</param>
        /// <param name="processDefinitionId">Filter by process definition id..</param>
        /// <param name="processDefinitionKey">Filter by process definition key..</param>
        /// <param name="deploymentId">Filter by deployment id..</param>
        /// <param name="tenantIdIn">Only include historic job log entries which belong to one of the passed and comma- separated tenant ids..</param>
        /// <param name="withoutTenantId">Only include historic job log entries that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="hostname">Filter by hostname..</param>
        /// <param name="jobPriorityLowerThanOrEquals">Only include logs for which the associated job had a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value..</param>
        /// <param name="jobPriorityHigherThanOrEquals">Only include logs for which the associated job had a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value..</param>
        /// <param name="creationLog">Only include creation logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="failureLog">Only include failure logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="successLog">Only include success logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="deletionLog">Only include deletion logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior..</param>
        /// <param name="sorting">An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Sorting has no effect for &#x60;count&#x60; endpoints.</param>
        public HistoricJobLogQueryDto(string logId = default(string), string jobId = default(string), string jobExceptionMessage = default(string), string jobDefinitionId = default(string), string jobDefinitionType = default(string), string jobDefinitionConfiguration = default(string), List<string> activityIdIn = default(List<string>), List<string> failedActivityIdIn = default(List<string>), List<string> executionIdIn = default(List<string>), string processInstanceId = default(string), string processDefinitionId = default(string), string processDefinitionKey = default(string), string deploymentId = default(string), List<string> tenantIdIn = default(List<string>), bool? withoutTenantId = default(bool?), string hostname = default(string), long? jobPriorityLowerThanOrEquals = default(long?), long? jobPriorityHigherThanOrEquals = default(long?), bool? creationLog = default(bool?), bool? failureLog = default(bool?), bool? successLog = default(bool?), bool? deletionLog = default(bool?), List<HistoricJobLogQueryDtoSorting> sorting = default(List<HistoricJobLogQueryDtoSorting>))
        {
            this.LogId = logId;
            this.JobId = jobId;
            this.JobExceptionMessage = jobExceptionMessage;
            this.JobDefinitionId = jobDefinitionId;
            this.JobDefinitionType = jobDefinitionType;
            this.JobDefinitionConfiguration = jobDefinitionConfiguration;
            this.ActivityIdIn = activityIdIn;
            this.FailedActivityIdIn = failedActivityIdIn;
            this.ExecutionIdIn = executionIdIn;
            this.ProcessInstanceId = processInstanceId;
            this.ProcessDefinitionId = processDefinitionId;
            this.ProcessDefinitionKey = processDefinitionKey;
            this.DeploymentId = deploymentId;
            this.TenantIdIn = tenantIdIn;
            this.WithoutTenantId = withoutTenantId;
            this.Hostname = hostname;
            this.JobPriorityLowerThanOrEquals = jobPriorityLowerThanOrEquals;
            this.JobPriorityHigherThanOrEquals = jobPriorityHigherThanOrEquals;
            this.CreationLog = creationLog;
            this.FailureLog = failureLog;
            this.SuccessLog = successLog;
            this.DeletionLog = deletionLog;
            this.Sorting = sorting;
        }

        /// <summary>
        /// Filter by historic job log id.
        /// </summary>
        /// <value>Filter by historic job log id.</value>
        [DataMember(Name = "logId", EmitDefaultValue = true)]
        public string LogId { get; set; }

        /// <summary>
        /// Filter by job id.
        /// </summary>
        /// <value>Filter by job id.</value>
        [DataMember(Name = "jobId", EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Filter by job exception message.
        /// </summary>
        /// <value>Filter by job exception message.</value>
        [DataMember(Name = "jobExceptionMessage", EmitDefaultValue = true)]
        public string JobExceptionMessage { get; set; }

        /// <summary>
        /// Filter by job definition id.
        /// </summary>
        /// <value>Filter by job definition id.</value>
        [DataMember(Name = "jobDefinitionId", EmitDefaultValue = true)]
        public string JobDefinitionId { get; set; }

        /// <summary>
        /// Filter by job definition type. See the [User Guide](https://docs.camunda.org/manual/latest/user-guide/process-engine/the-job-executor/#job-creation) for more information about job definition types.
        /// </summary>
        /// <value>Filter by job definition type. See the [User Guide](https://docs.camunda.org/manual/latest/user-guide/process-engine/the-job-executor/#job-creation) for more information about job definition types.</value>
        [DataMember(Name = "jobDefinitionType", EmitDefaultValue = true)]
        public string JobDefinitionType { get; set; }

        /// <summary>
        /// Filter by job definition configuration.
        /// </summary>
        /// <value>Filter by job definition configuration.</value>
        [DataMember(Name = "jobDefinitionConfiguration", EmitDefaultValue = true)]
        public string JobDefinitionConfiguration { get; set; }

        /// <summary>
        /// Only include historic job logs which belong to one of the passed activity ids.
        /// </summary>
        /// <value>Only include historic job logs which belong to one of the passed activity ids.</value>
        [DataMember(Name = "activityIdIn", EmitDefaultValue = true)]
        public List<string> ActivityIdIn { get; set; }

        /// <summary>
        /// Only include historic job logs which belong to failures of one of the passed activity ids.
        /// </summary>
        /// <value>Only include historic job logs which belong to failures of one of the passed activity ids.</value>
        [DataMember(Name = "failedActivityIdIn", EmitDefaultValue = true)]
        public List<string> FailedActivityIdIn { get; set; }

        /// <summary>
        /// Only include historic job logs which belong to one of the passed execution ids.
        /// </summary>
        /// <value>Only include historic job logs which belong to one of the passed execution ids.</value>
        [DataMember(Name = "executionIdIn", EmitDefaultValue = true)]
        public List<string> ExecutionIdIn { get; set; }

        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        /// <value>Filter by process instance id.</value>
        [DataMember(Name = "processInstanceId", EmitDefaultValue = true)]
        public string ProcessInstanceId { get; set; }

        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        /// <value>Filter by process definition id.</value>
        [DataMember(Name = "processDefinitionId", EmitDefaultValue = true)]
        public string ProcessDefinitionId { get; set; }

        /// <summary>
        /// Filter by process definition key.
        /// </summary>
        /// <value>Filter by process definition key.</value>
        [DataMember(Name = "processDefinitionKey", EmitDefaultValue = true)]
        public string ProcessDefinitionKey { get; set; }

        /// <summary>
        /// Filter by deployment id.
        /// </summary>
        /// <value>Filter by deployment id.</value>
        [DataMember(Name = "deploymentId", EmitDefaultValue = true)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// Only include historic job log entries which belong to one of the passed and comma- separated tenant ids.
        /// </summary>
        /// <value>Only include historic job log entries which belong to one of the passed and comma- separated tenant ids.</value>
        [DataMember(Name = "tenantIdIn", EmitDefaultValue = true)]
        public List<string> TenantIdIn { get; set; }

        /// <summary>
        /// Only include historic job log entries that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include historic job log entries that belong to no tenant. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "withoutTenantId", EmitDefaultValue = true)]
        public bool? WithoutTenantId { get; set; }

        /// <summary>
        /// Filter by hostname.
        /// </summary>
        /// <value>Filter by hostname.</value>
        [DataMember(Name = "hostname", EmitDefaultValue = true)]
        public string Hostname { get; set; }

        /// <summary>
        /// Only include logs for which the associated job had a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value.
        /// </summary>
        /// <value>Only include logs for which the associated job had a priority lower than or equal to the given value. Value must be a valid &#x60;long&#x60; value.</value>
        [DataMember(Name = "jobPriorityLowerThanOrEquals", EmitDefaultValue = true)]
        public long? JobPriorityLowerThanOrEquals { get; set; }

        /// <summary>
        /// Only include logs for which the associated job had a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value.
        /// </summary>
        /// <value>Only include logs for which the associated job had a priority higher than or equal to the given value. Value must be a valid &#x60;long&#x60; value.</value>
        [DataMember(Name = "jobPriorityHigherThanOrEquals", EmitDefaultValue = true)]
        public long? JobPriorityHigherThanOrEquals { get; set; }

        /// <summary>
        /// Only include creation logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include creation logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "creationLog", EmitDefaultValue = true)]
        public bool? CreationLog { get; set; }

        /// <summary>
        /// Only include failure logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include failure logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "failureLog", EmitDefaultValue = true)]
        public bool? FailureLog { get; set; }

        /// <summary>
        /// Only include success logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include success logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "successLog", EmitDefaultValue = true)]
        public bool? SuccessLog { get; set; }

        /// <summary>
        /// Only include deletion logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.
        /// </summary>
        /// <value>Only include deletion logs. Value may only be &#x60;true&#x60;, as &#x60;false&#x60; is the default behavior.</value>
        [DataMember(Name = "deletionLog", EmitDefaultValue = true)]
        public bool? DeletionLog { get; set; }

        /// <summary>
        /// An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Sorting has no effect for &#x60;count&#x60; endpoints
        /// </summary>
        /// <value>An array of criteria to sort the result by. Each element of the array is                        an object that specifies one ordering. The position in the array                        identifies the rank of an ordering, i.e., whether it is primary, secondary,                        etc. Sorting has no effect for &#x60;count&#x60; endpoints</value>
        [DataMember(Name = "sorting", EmitDefaultValue = false)]
        public List<HistoricJobLogQueryDtoSorting> Sorting { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoricJobLogQueryDto {\n");
            sb.Append("  LogId: ").Append(LogId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobExceptionMessage: ").Append(JobExceptionMessage).Append("\n");
            sb.Append("  JobDefinitionId: ").Append(JobDefinitionId).Append("\n");
            sb.Append("  JobDefinitionType: ").Append(JobDefinitionType).Append("\n");
            sb.Append("  JobDefinitionConfiguration: ").Append(JobDefinitionConfiguration).Append("\n");
            sb.Append("  ActivityIdIn: ").Append(ActivityIdIn).Append("\n");
            sb.Append("  FailedActivityIdIn: ").Append(FailedActivityIdIn).Append("\n");
            sb.Append("  ExecutionIdIn: ").Append(ExecutionIdIn).Append("\n");
            sb.Append("  ProcessInstanceId: ").Append(ProcessInstanceId).Append("\n");
            sb.Append("  ProcessDefinitionId: ").Append(ProcessDefinitionId).Append("\n");
            sb.Append("  ProcessDefinitionKey: ").Append(ProcessDefinitionKey).Append("\n");
            sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
            sb.Append("  TenantIdIn: ").Append(TenantIdIn).Append("\n");
            sb.Append("  WithoutTenantId: ").Append(WithoutTenantId).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("  JobPriorityLowerThanOrEquals: ").Append(JobPriorityLowerThanOrEquals).Append("\n");
            sb.Append("  JobPriorityHigherThanOrEquals: ").Append(JobPriorityHigherThanOrEquals).Append("\n");
            sb.Append("  CreationLog: ").Append(CreationLog).Append("\n");
            sb.Append("  FailureLog: ").Append(FailureLog).Append("\n");
            sb.Append("  SuccessLog: ").Append(SuccessLog).Append("\n");
            sb.Append("  DeletionLog: ").Append(DeletionLog).Append("\n");
            sb.Append("  Sorting: ").Append(Sorting).Append("\n");
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
            return this.Equals(input as HistoricJobLogQueryDto);
        }

        /// <summary>
        /// Returns true if HistoricJobLogQueryDto instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoricJobLogQueryDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoricJobLogQueryDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogId == input.LogId ||
                    (this.LogId != null &&
                    this.LogId.Equals(input.LogId))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobExceptionMessage == input.JobExceptionMessage ||
                    (this.JobExceptionMessage != null &&
                    this.JobExceptionMessage.Equals(input.JobExceptionMessage))
                ) && 
                (
                    this.JobDefinitionId == input.JobDefinitionId ||
                    (this.JobDefinitionId != null &&
                    this.JobDefinitionId.Equals(input.JobDefinitionId))
                ) && 
                (
                    this.JobDefinitionType == input.JobDefinitionType ||
                    (this.JobDefinitionType != null &&
                    this.JobDefinitionType.Equals(input.JobDefinitionType))
                ) && 
                (
                    this.JobDefinitionConfiguration == input.JobDefinitionConfiguration ||
                    (this.JobDefinitionConfiguration != null &&
                    this.JobDefinitionConfiguration.Equals(input.JobDefinitionConfiguration))
                ) && 
                (
                    this.ActivityIdIn == input.ActivityIdIn ||
                    this.ActivityIdIn != null &&
                    input.ActivityIdIn != null &&
                    this.ActivityIdIn.SequenceEqual(input.ActivityIdIn)
                ) && 
                (
                    this.FailedActivityIdIn == input.FailedActivityIdIn ||
                    this.FailedActivityIdIn != null &&
                    input.FailedActivityIdIn != null &&
                    this.FailedActivityIdIn.SequenceEqual(input.FailedActivityIdIn)
                ) && 
                (
                    this.ExecutionIdIn == input.ExecutionIdIn ||
                    this.ExecutionIdIn != null &&
                    input.ExecutionIdIn != null &&
                    this.ExecutionIdIn.SequenceEqual(input.ExecutionIdIn)
                ) && 
                (
                    this.ProcessInstanceId == input.ProcessInstanceId ||
                    (this.ProcessInstanceId != null &&
                    this.ProcessInstanceId.Equals(input.ProcessInstanceId))
                ) && 
                (
                    this.ProcessDefinitionId == input.ProcessDefinitionId ||
                    (this.ProcessDefinitionId != null &&
                    this.ProcessDefinitionId.Equals(input.ProcessDefinitionId))
                ) && 
                (
                    this.ProcessDefinitionKey == input.ProcessDefinitionKey ||
                    (this.ProcessDefinitionKey != null &&
                    this.ProcessDefinitionKey.Equals(input.ProcessDefinitionKey))
                ) && 
                (
                    this.DeploymentId == input.DeploymentId ||
                    (this.DeploymentId != null &&
                    this.DeploymentId.Equals(input.DeploymentId))
                ) && 
                (
                    this.TenantIdIn == input.TenantIdIn ||
                    this.TenantIdIn != null &&
                    input.TenantIdIn != null &&
                    this.TenantIdIn.SequenceEqual(input.TenantIdIn)
                ) && 
                (
                    this.WithoutTenantId == input.WithoutTenantId ||
                    (this.WithoutTenantId != null &&
                    this.WithoutTenantId.Equals(input.WithoutTenantId))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                ) && 
                (
                    this.JobPriorityLowerThanOrEquals == input.JobPriorityLowerThanOrEquals ||
                    (this.JobPriorityLowerThanOrEquals != null &&
                    this.JobPriorityLowerThanOrEquals.Equals(input.JobPriorityLowerThanOrEquals))
                ) && 
                (
                    this.JobPriorityHigherThanOrEquals == input.JobPriorityHigherThanOrEquals ||
                    (this.JobPriorityHigherThanOrEquals != null &&
                    this.JobPriorityHigherThanOrEquals.Equals(input.JobPriorityHigherThanOrEquals))
                ) && 
                (
                    this.CreationLog == input.CreationLog ||
                    (this.CreationLog != null &&
                    this.CreationLog.Equals(input.CreationLog))
                ) && 
                (
                    this.FailureLog == input.FailureLog ||
                    (this.FailureLog != null &&
                    this.FailureLog.Equals(input.FailureLog))
                ) && 
                (
                    this.SuccessLog == input.SuccessLog ||
                    (this.SuccessLog != null &&
                    this.SuccessLog.Equals(input.SuccessLog))
                ) && 
                (
                    this.DeletionLog == input.DeletionLog ||
                    (this.DeletionLog != null &&
                    this.DeletionLog.Equals(input.DeletionLog))
                ) && 
                (
                    this.Sorting == input.Sorting ||
                    this.Sorting != null &&
                    input.Sorting != null &&
                    this.Sorting.SequenceEqual(input.Sorting)
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
                if (this.LogId != null)
                    hashCode = hashCode * 59 + this.LogId.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobExceptionMessage != null)
                    hashCode = hashCode * 59 + this.JobExceptionMessage.GetHashCode();
                if (this.JobDefinitionId != null)
                    hashCode = hashCode * 59 + this.JobDefinitionId.GetHashCode();
                if (this.JobDefinitionType != null)
                    hashCode = hashCode * 59 + this.JobDefinitionType.GetHashCode();
                if (this.JobDefinitionConfiguration != null)
                    hashCode = hashCode * 59 + this.JobDefinitionConfiguration.GetHashCode();
                if (this.ActivityIdIn != null)
                    hashCode = hashCode * 59 + this.ActivityIdIn.GetHashCode();
                if (this.FailedActivityIdIn != null)
                    hashCode = hashCode * 59 + this.FailedActivityIdIn.GetHashCode();
                if (this.ExecutionIdIn != null)
                    hashCode = hashCode * 59 + this.ExecutionIdIn.GetHashCode();
                if (this.ProcessInstanceId != null)
                    hashCode = hashCode * 59 + this.ProcessInstanceId.GetHashCode();
                if (this.ProcessDefinitionId != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionId.GetHashCode();
                if (this.ProcessDefinitionKey != null)
                    hashCode = hashCode * 59 + this.ProcessDefinitionKey.GetHashCode();
                if (this.DeploymentId != null)
                    hashCode = hashCode * 59 + this.DeploymentId.GetHashCode();
                if (this.TenantIdIn != null)
                    hashCode = hashCode * 59 + this.TenantIdIn.GetHashCode();
                if (this.WithoutTenantId != null)
                    hashCode = hashCode * 59 + this.WithoutTenantId.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                if (this.JobPriorityLowerThanOrEquals != null)
                    hashCode = hashCode * 59 + this.JobPriorityLowerThanOrEquals.GetHashCode();
                if (this.JobPriorityHigherThanOrEquals != null)
                    hashCode = hashCode * 59 + this.JobPriorityHigherThanOrEquals.GetHashCode();
                if (this.CreationLog != null)
                    hashCode = hashCode * 59 + this.CreationLog.GetHashCode();
                if (this.FailureLog != null)
                    hashCode = hashCode * 59 + this.FailureLog.GetHashCode();
                if (this.SuccessLog != null)
                    hashCode = hashCode * 59 + this.SuccessLog.GetHashCode();
                if (this.DeletionLog != null)
                    hashCode = hashCode * 59 + this.DeletionLog.GetHashCode();
                if (this.Sorting != null)
                    hashCode = hashCode * 59 + this.Sorting.GetHashCode();
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
