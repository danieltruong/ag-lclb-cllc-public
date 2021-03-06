// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// plugintracelog
    /// </summary>
    public partial class MicrosoftDynamicsCRMplugintracelog
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMplugintracelog class.
        /// </summary>
        public MicrosoftDynamicsCRMplugintracelog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMplugintracelog class.
        /// </summary>
        public MicrosoftDynamicsCRMplugintracelog(int? performanceconstructorduration = default(int?), int? operationtype = default(int?), string primaryentity = default(string), string secureconfiguration = default(string), string configuration = default(string), string exceptiondetails = default(string), string plugintracelogid = default(string), string pluginstepid = default(string), int? mode = default(int?), string messageblock = default(string), string _createdbyValue = default(string), string typename = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), string profile = default(string), string organizationid = default(string), System.DateTimeOffset? performanceconstructorstarttime = default(System.DateTimeOffset?), System.DateTimeOffset? performanceexecutionstarttime = default(System.DateTimeOffset?), int? depth = default(int?), bool? issystemcreated = default(bool?), string requestid = default(string), string correlationid = default(string), string persistencekey = default(string), int? performanceexecutionduration = default(int?), string messagename = default(string), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Performanceconstructorduration = performanceconstructorduration;
            Operationtype = operationtype;
            Primaryentity = primaryentity;
            Secureconfiguration = secureconfiguration;
            Configuration = configuration;
            Exceptiondetails = exceptiondetails;
            Plugintracelogid = plugintracelogid;
            Pluginstepid = pluginstepid;
            Mode = mode;
            Messageblock = messageblock;
            this._createdbyValue = _createdbyValue;
            Typename = typename;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Profile = profile;
            Organizationid = organizationid;
            Performanceconstructorstarttime = performanceconstructorstarttime;
            Performanceexecutionstarttime = performanceexecutionstarttime;
            Depth = depth;
            Issystemcreated = issystemcreated;
            Requestid = requestid;
            Correlationid = correlationid;
            Persistencekey = persistencekey;
            Performanceexecutionduration = performanceexecutionduration;
            Messagename = messagename;
            Createdonbehalfby = createdonbehalfby;
            Createdby = createdby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "performanceconstructorduration")]
        public int? Performanceconstructorduration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operationtype")]
        public int? Operationtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "primaryentity")]
        public string Primaryentity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "secureconfiguration")]
        public string Secureconfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public string Configuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exceptiondetails")]
        public string Exceptiondetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "plugintracelogid")]
        public string Plugintracelogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pluginstepid")]
        public string Pluginstepid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public int? Mode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messageblock")]
        public string Messageblock { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "typename")]
        public string Typename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public string Profile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public string Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "performanceconstructorstarttime")]
        public System.DateTimeOffset? Performanceconstructorstarttime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "performanceexecutionstarttime")]
        public System.DateTimeOffset? Performanceexecutionstarttime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issystemcreated")]
        public bool? Issystemcreated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestid")]
        public string Requestid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "correlationid")]
        public string Correlationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "persistencekey")]
        public string Persistencekey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "performanceexecutionduration")]
        public int? Performanceexecutionduration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messagename")]
        public string Messagename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

    }
}
