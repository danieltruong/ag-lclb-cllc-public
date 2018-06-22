// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// EndpointCollection
    /// </summary>
    public partial class MicrosoftDynamicsCRMEndpointCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMEndpointCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMEndpointCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMEndpointCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMEndpointCollection(int? count = default(int?), bool? isReadOnly = default(bool?), IList<string> keys = default(IList<string>), IList<string> values = default(IList<string>))
        {
            Count = count;
            IsReadOnly = isReadOnly;
            Keys = keys;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Count")]
        public int? Count { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsReadOnly")]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Keys")]
        public IList<string> Keys { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Values")]
        public IList<string> Values { get; set; }

    }
}