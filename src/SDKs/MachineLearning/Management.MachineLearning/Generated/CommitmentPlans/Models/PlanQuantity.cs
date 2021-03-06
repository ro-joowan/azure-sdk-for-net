// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.CommitmentPlans.Models
{
    using System.Linq;

    /// <summary>
    /// Represents the quantity a commitment plan provides of a metered
    /// resource.
    /// </summary>
    public partial class PlanQuantity
    {
        /// <summary>
        /// Initializes a new instance of the PlanQuantity class.
        /// </summary>
        public PlanQuantity() { }

        /// <summary>
        /// Initializes a new instance of the PlanQuantity class.
        /// </summary>
        /// <param name="allowance">The quantity added to the commitment plan
        /// at an interval specified by its allowance frequency.</param>
        /// <param name="amount">The quantity available to the plan the last
        /// time usage was calculated.</param>
        /// <param name="includedQuantityMeter">The Azure meter for usage
        /// against included quantities.</param>
        /// <param name="overageMeter">The Azure meter for usage which exceeds
        /// included quantities.</param>
        public PlanQuantity(double? allowance = default(double?), double? amount = default(double?), string includedQuantityMeter = default(string), string overageMeter = default(string))
        {
            Allowance = allowance;
            Amount = amount;
            IncludedQuantityMeter = includedQuantityMeter;
            OverageMeter = overageMeter;
        }

        /// <summary>
        /// Gets the quantity added to the commitment plan at an interval
        /// specified by its allowance frequency.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "allowance")]
        public double? Allowance { get; private set; }

        /// <summary>
        /// Gets the quantity available to the plan the last time usage was
        /// calculated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "amount")]
        public double? Amount { get; private set; }

        /// <summary>
        /// Gets the Azure meter for usage against included quantities.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "includedQuantityMeter")]
        public string IncludedQuantityMeter { get; private set; }

        /// <summary>
        /// Gets the Azure meter for usage which exceeds included quantities.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "overageMeter")]
        public string OverageMeter { get; private set; }

    }
}
