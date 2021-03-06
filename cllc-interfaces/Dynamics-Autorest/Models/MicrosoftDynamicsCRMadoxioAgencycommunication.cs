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
    /// adoxio_agencycommunication
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioAgencycommunication
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioAgencycommunication class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioAgencycommunication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioAgencycommunication class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioAgencycommunication(string _owninguserValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _adoxioApplicationValue = default(string), int? adoxioCommunicationtype = default(int?), string _createdbyValue = default(string), int? statecode = default(int?), int? statuscode = default(int?), string _adoxioApplicantValue = default(string), string _owneridValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _adoxioLgorfnorpoliceValue = default(string), string _modifiedbyValue = default(string), string adoxioName = default(string), string _owningbusinessunitValue = default(string), string adoxioAgencycommunicationid = default(string), int? adoxioDecision = default(int?), string _modifiedonbehalfbyValue = default(string), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), long? versionnumber = default(long?), string _createdonbehalfbyValue = default(string), string _owningteamValue = default(string), int? importsequencenumber = default(int?), System.DateTimeOffset? adoxioDecisiondate = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _adoxioLgorfnorpoliceprimarycontactValue = default(string), string adoxioDenyreason = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> adoxioAgencycommunicationActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMappointment> adoxioAgencycommunicationAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> adoxioAgencycommunicationEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> adoxioAgencycommunicationFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> adoxioAgencycommunicationLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> adoxioAgencycommunicationPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMserviceappointment> adoxioAgencycommunicationServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMtask> adoxioAgencycommunicationTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> adoxioAgencycommunicationRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> adoxioAgencycommunicationSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMsyncerror> adoxioAgencycommunicationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioAgencycommunicationDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioAgencycommunicationDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMannotation> adoxioAgencycommunicationAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioAgencycommunicationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioAgencycommunicationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMaccount adoxioApplicant = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMaccount adoxioLGorFNorPolice = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMadoxioApplication adoxioApplication = default(MicrosoftDynamicsCRMadoxioApplication), MicrosoftDynamicsCRMcontact adoxioLGorFNorPolicePrimaryContact = default(MicrosoftDynamicsCRMcontact))
        {
            this._owninguserValue = _owninguserValue;
            Overriddencreatedon = overriddencreatedon;
            this._adoxioApplicationValue = _adoxioApplicationValue;
            AdoxioCommunicationtype = adoxioCommunicationtype;
            this._createdbyValue = _createdbyValue;
            Statecode = statecode;
            Statuscode = statuscode;
            this._adoxioApplicantValue = _adoxioApplicantValue;
            this._owneridValue = _owneridValue;
            Modifiedon = modifiedon;
            this._adoxioLgorfnorpoliceValue = _adoxioLgorfnorpoliceValue;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioName = adoxioName;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            AdoxioAgencycommunicationid = adoxioAgencycommunicationid;
            AdoxioDecision = adoxioDecision;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            Importsequencenumber = importsequencenumber;
            AdoxioDecisiondate = adoxioDecisiondate;
            Createdon = createdon;
            this._adoxioLgorfnorpoliceprimarycontactValue = _adoxioLgorfnorpoliceprimarycontactValue;
            AdoxioDenyreason = adoxioDenyreason;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioAgencycommunicationActivityPointers = adoxioAgencycommunicationActivityPointers;
            AdoxioAgencycommunicationAppointments = adoxioAgencycommunicationAppointments;
            AdoxioAgencycommunicationEmails = adoxioAgencycommunicationEmails;
            AdoxioAgencycommunicationFaxes = adoxioAgencycommunicationFaxes;
            AdoxioAgencycommunicationLetters = adoxioAgencycommunicationLetters;
            AdoxioAgencycommunicationPhoneCalls = adoxioAgencycommunicationPhoneCalls;
            AdoxioAgencycommunicationServiceAppointments = adoxioAgencycommunicationServiceAppointments;
            AdoxioAgencycommunicationTasks = adoxioAgencycommunicationTasks;
            AdoxioAgencycommunicationRecurringAppointmentMasters = adoxioAgencycommunicationRecurringAppointmentMasters;
            AdoxioAgencycommunicationSocialActivities = adoxioAgencycommunicationSocialActivities;
            AdoxioAgencycommunicationSyncErrors = adoxioAgencycommunicationSyncErrors;
            AdoxioAgencycommunicationDuplicateMatchingRecord = adoxioAgencycommunicationDuplicateMatchingRecord;
            AdoxioAgencycommunicationDuplicateBaseRecord = adoxioAgencycommunicationDuplicateBaseRecord;
            AdoxioAgencycommunicationAnnotations = adoxioAgencycommunicationAnnotations;
            AdoxioAgencycommunicationAsyncOperations = adoxioAgencycommunicationAsyncOperations;
            AdoxioAgencycommunicationBulkDeleteFailures = adoxioAgencycommunicationBulkDeleteFailures;
            AdoxioApplicant = adoxioApplicant;
            AdoxioLGorFNorPolice = adoxioLGorFNorPolice;
            AdoxioApplication = adoxioApplication;
            AdoxioLGorFNorPolicePrimaryContact = adoxioLGorFNorPolicePrimaryContact;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_application_value")]
        public string _adoxioApplicationValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_communicationtype")]
        public int? AdoxioCommunicationtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_applicant_value")]
        public string _adoxioApplicantValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_lgorfnorpolice_value")]
        public string _adoxioLgorfnorpoliceValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunicationid")]
        public string AdoxioAgencycommunicationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_decision")]
        public int? AdoxioDecision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_decisiondate")]
        public System.DateTimeOffset? AdoxioDecisiondate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_lgorfnorpoliceprimarycontact_value")]
        public string _adoxioLgorfnorpoliceprimarycontactValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_denyreason")]
        public string AdoxioDenyreason { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> AdoxioAgencycommunicationActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> AdoxioAgencycommunicationAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_Emails")]
        public IList<MicrosoftDynamicsCRMemail> AdoxioAgencycommunicationEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> AdoxioAgencycommunicationFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_Letters")]
        public IList<MicrosoftDynamicsCRMletter> AdoxioAgencycommunicationLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> AdoxioAgencycommunicationPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> AdoxioAgencycommunicationServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> AdoxioAgencycommunicationTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> AdoxioAgencycommunicationRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> AdoxioAgencycommunicationSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioAgencycommunicationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioAgencycommunicationDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioAgencycommunicationDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> AdoxioAgencycommunicationAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioAgencycommunicationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_agencycommunication_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioAgencycommunicationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Applicant")]
        public MicrosoftDynamicsCRMaccount AdoxioApplicant { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LGorFNorPolice")]
        public MicrosoftDynamicsCRMaccount AdoxioLGorFNorPolice { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_Application")]
        public MicrosoftDynamicsCRMadoxioApplication AdoxioApplication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_LGorFNorPolicePrimaryContact")]
        public MicrosoftDynamicsCRMcontact AdoxioLGorFNorPolicePrimaryContact { get; set; }

    }
}
