// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The KPI participant profile metadata.
    /// </summary>
    public partial class KpiParticipantProfilesMetadata
    {
        /// <summary>
        /// Initializes a new instance of the KpiParticipantProfilesMetadata
        /// class.
        /// </summary>
        public KpiParticipantProfilesMetadata() { }

        /// <summary>
        /// Initializes a new instance of the KpiParticipantProfilesMetadata
        /// class.
        /// </summary>
        /// <param name="typeName">Name of the type.</param>
        public KpiParticipantProfilesMetadata(string typeName)
        {
            TypeName = typeName;
        }

        /// <summary>
        /// Gets or sets name of the type.
        /// </summary>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TypeName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TypeName");
            }
        }
    }
}

