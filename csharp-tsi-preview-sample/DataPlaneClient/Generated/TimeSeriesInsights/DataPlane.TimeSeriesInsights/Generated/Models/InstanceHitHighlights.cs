// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.TimeSeriesInsights.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Highlighted text of time series instance to be displayed to the user.
    /// Highlighting inserts &lt;hit&gt; and &lt;/hit&gt; tags in the portions
    /// of text that matched the search string. Do not use any of the
    /// highlighted properties to do further API calls.
    /// </summary>
    public partial class InstanceHitHighlights
    {
        /// <summary>
        /// Initializes a new instance of the InstanceHitHighlights class.
        /// </summary>
        public InstanceHitHighlights()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InstanceHitHighlights class.
        /// </summary>
        /// <param name="timeSeriesId">List of highlighted string values of
        /// Time Series ID for displaying. Cannot be used to lookup
        /// instance.</param>
        /// <param name="typeName">Highlighted time series type name that this
        /// instance belongs to.</param>
        /// <param name="name">Highlighted name of time series instance. May be
        /// null.</param>
        /// <param name="description">Highlighted description of time series
        /// instance. May be null.</param>
        /// <param name="hierarchyIds">List of highlighted time series
        /// hierarchy IDs that time series instance belongs to. Cannot be used
        /// to lookup hierarchies. May be null.</param>
        /// <param name="hierarchyNames">List of highlighted time series
        /// hierarchy names that time series instance belongs to. Cannot be
        /// used to lookup hierarchies. May be null.</param>
        /// <param name="instanceFieldNames">List of highlighted time series
        /// instance field names. May be null.</param>
        /// <param name="instanceFieldValues">List of highlighted time series
        /// instance field values. May be null.</param>
        public InstanceHitHighlights(IList<string> timeSeriesId = default(IList<string>), string typeName = default(string), string name = default(string), string description = default(string), IList<System.Guid?> hierarchyIds = default(IList<System.Guid?>), IList<string> hierarchyNames = default(IList<string>), IList<string> instanceFieldNames = default(IList<string>), IList<string> instanceFieldValues = default(IList<string>))
        {
            TimeSeriesId = timeSeriesId;
            TypeName = typeName;
            Name = name;
            Description = description;
            HierarchyIds = hierarchyIds;
            HierarchyNames = hierarchyNames;
            InstanceFieldNames = instanceFieldNames;
            InstanceFieldValues = instanceFieldValues;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of highlighted string values of Time Series ID for
        /// displaying. Cannot be used to lookup instance.
        /// </summary>
        [JsonProperty(PropertyName = "timeSeriesId")]
        public IList<string> TimeSeriesId { get; private set; }

        /// <summary>
        /// Gets highlighted time series type name that this instance belongs
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "typeName")]
        public string TypeName { get; private set; }

        /// <summary>
        /// Gets highlighted name of time series instance. May be null.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets highlighted description of time series instance. May be null.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets list of highlighted time series hierarchy IDs that time series
        /// instance belongs to. Cannot be used to lookup hierarchies. May be
        /// null.
        /// </summary>
        [JsonProperty(PropertyName = "hierarchyIds")]
        public IList<System.Guid?> HierarchyIds { get; private set; }

        /// <summary>
        /// Gets list of highlighted time series hierarchy names that time
        /// series instance belongs to. Cannot be used to lookup hierarchies.
        /// May be null.
        /// </summary>
        [JsonProperty(PropertyName = "hierarchyNames")]
        public IList<string> HierarchyNames { get; private set; }

        /// <summary>
        /// Gets list of highlighted time series instance field names. May be
        /// null.
        /// </summary>
        [JsonProperty(PropertyName = "instanceFieldNames")]
        public IList<string> InstanceFieldNames { get; private set; }

        /// <summary>
        /// Gets list of highlighted time series instance field values. May be
        /// null.
        /// </summary>
        [JsonProperty(PropertyName = "instanceFieldValues")]
        public IList<string> InstanceFieldValues { get; private set; }

    }
}
