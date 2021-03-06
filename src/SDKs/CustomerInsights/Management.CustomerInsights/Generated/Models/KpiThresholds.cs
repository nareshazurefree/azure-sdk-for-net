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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines the KPI Threshold limits.
    /// </summary>
    public partial class KpiThresholds
    {
        /// <summary>
        /// Initializes a new instance of the KpiThresholds class.
        /// </summary>
        public KpiThresholds() { }

        /// <summary>
        /// Initializes a new instance of the KpiThresholds class.
        /// </summary>
        /// <param name="lowerLimit">The lower threshold limit.</param>
        /// <param name="upperLimit">The upper threshold limit.</param>
        /// <param name="increasingKpi">Whether or not the KPI is an increasing
        /// KPI.</param>
        public KpiThresholds(decimal lowerLimit, decimal upperLimit, bool increasingKpi)
        {
            LowerLimit = lowerLimit;
            UpperLimit = upperLimit;
            IncreasingKpi = increasingKpi;
        }

        /// <summary>
        /// Gets or sets the lower threshold limit.
        /// </summary>
        [JsonProperty(PropertyName = "lowerLimit")]
        public decimal LowerLimit { get; set; }

        /// <summary>
        /// Gets or sets the upper threshold limit.
        /// </summary>
        [JsonProperty(PropertyName = "upperLimit")]
        public decimal UpperLimit { get; set; }

        /// <summary>
        /// Gets or sets whether or not the KPI is an increasing KPI.
        /// </summary>
        [JsonProperty(PropertyName = "increasingKpi")]
        public bool IncreasingKpi { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}

