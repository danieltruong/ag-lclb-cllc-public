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

    public partial class MicrosoftDynamicsCRMsalesorder
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsalesorder
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesorder()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMsalesorder
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMsalesorder(IList<MicrosoftDynamicsCRMactivitypointer> salesOrderActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMannotation> salesOrderAnnotation = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMappointment> salesOrderAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMasyncoperation> salesOrderAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> salesOrderBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMemail> salesOrderEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> salesOrderFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> salesOrderLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMorderclose> salesOrderOrderClose = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMphonecall> salesOrderPhonecalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> salesOrderRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMserviceappointment> salesOrderServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMsocialactivity> salesOrderSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMsyncerror> salesOrderSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMtask> salesOrderTasks = default(IList<MicrosoftDynamicsCRMtask>), string _accountidValue = default(string), string _campaignidValue = default(string), string _contactidValue = default(string), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _customeridValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _opportunityidValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), string _pricelevelidValue = default(string), string _quoteidValue = default(string), string _slaidValue = default(string), string _slainvokedidValue = default(string), string _transactioncurrencyidValue = default(string), string billtoAddressid = default(string), string billtoCity = default(string), string billtoComposite = default(string), string billtoContactname = default(string), string billtoCountry = default(string), string billtoFax = default(string), string billtoLine1 = default(string), string billtoLine2 = default(string), string billtoLine3 = default(string), string billtoName = default(string), string billtoPostalcode = default(string), string billtoStateorprovince = default(string), string billtoTelephone = default(string), MicrosoftDynamicsCRMcampaign campaignid = default(MicrosoftDynamicsCRMcampaign), IList<MicrosoftDynamicsCRMcontact> contactordersAssociation = default(IList<MicrosoftDynamicsCRMcontact>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMaccount customeridAccount = default(MicrosoftDynamicsCRMaccount), MicrosoftDynamicsCRMcontact customeridContact = default(MicrosoftDynamicsCRMcontact), System.DateTimeOffset? datefulfilled = default(System.DateTimeOffset?), string description = default(string), double? discountamount = default(double?), double? discountamountBase = default(double?), double? discountpercentage = default(double?), string entityimage = default(string), object entityimageTimestamp = default(object), string entityimageUrl = default(string), string entityimageid = default(string), double? exchangerate = default(double?), double? freightamount = default(double?), double? freightamountBase = default(double?), int? freighttermscode = default(int?), int? importsequencenumber = default(int?), bool? ispricelocked = default(bool?), System.DateTimeOffset? lastbackofficesubmit = default(System.DateTimeOffset?), System.DateTimeOffset? lastonholdtime = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string name = default(string), int? onholdtime = default(int?), MicrosoftDynamicsCRMopportunity opportunityid = default(MicrosoftDynamicsCRMopportunity), IList<MicrosoftDynamicsCRMsalesorderdetail> orderDetails = default(IList<MicrosoftDynamicsCRMsalesorderdetail>), IList<MicrosoftDynamicsCRMinvoice> orderInvoices = default(IList<MicrosoftDynamicsCRMinvoice>), string ordernumber = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), int? paymenttermscode = default(int?), MicrosoftDynamicsCRMpricelevel pricelevelid = default(MicrosoftDynamicsCRMpricelevel), int? pricingerrorcode = default(int?), int? prioritycode = default(int?), string processid = default(string), MicrosoftDynamicsCRMquote quoteid = default(MicrosoftDynamicsCRMquote), System.DateTimeOffset? requestdeliveryby = default(System.DateTimeOffset?), IList<MicrosoftDynamicsCRMactivityparty> salesorderActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMconnection> salesorderConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> salesorderConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMopportunitysalesprocess> salesorderOpportunitysalesprocess = default(IList<MicrosoftDynamicsCRMopportunitysalesprocess>), string salesorderid = default(string), int? shippingmethodcode = default(int?), string shiptoAddressid = default(string), string shiptoCity = default(string), string shiptoComposite = default(string), string shiptoContactname = default(string), string shiptoCountry = default(string), string shiptoFax = default(string), int? shiptoFreighttermscode = default(int?), string shiptoLine1 = default(string), string shiptoLine2 = default(string), string shiptoLine3 = default(string), string shiptoName = default(string), string shiptoPostalcode = default(string), string shiptoStateorprovince = default(string), string shiptoTelephone = default(string), MicrosoftDynamicsCRMsla slaSalesorderSla = default(MicrosoftDynamicsCRMsla), MicrosoftDynamicsCRMsla slainvokedidSalesorderSla = default(MicrosoftDynamicsCRMsla), IList<MicrosoftDynamicsCRMslakpiinstance> slakpiinstanceSalesorder = default(IList<MicrosoftDynamicsCRMslakpiinstance>), string stageid = default(string), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), int? statecode = default(int?), int? statuscode = default(int?), System.DateTimeOffset? submitdate = default(System.DateTimeOffset?), int? submitstatus = default(int?), string submitstatusdescription = default(string), int? timezoneruleversionnumber = default(int?), double? totalamount = default(double?), double? totalamountBase = default(double?), double? totalamountlessfreight = default(double?), double? totalamountlessfreightBase = default(double?), double? totaldiscountamount = default(double?), double? totaldiscountamountBase = default(double?), double? totallineitemamount = default(double?), double? totallineitemamountBase = default(double?), double? totallineitemdiscountamount = default(double?), double? totallineitemdiscountamountBase = default(double?), double? totaltax = default(double?), double? totaltaxBase = default(double?), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), string traversedpath = default(string), int? utcconversiontimezonecode = default(int?), object versionnumber = default(object), bool? willcall = default(bool?))
        {
            SalesOrderActivityPointers = salesOrderActivityPointers;
            SalesOrderAnnotation = salesOrderAnnotation;
            SalesOrderAppointments = salesOrderAppointments;
            SalesOrderAsyncOperations = salesOrderAsyncOperations;
            SalesOrderBulkDeleteFailures = salesOrderBulkDeleteFailures;
            SalesOrderEmails = salesOrderEmails;
            SalesOrderFaxes = salesOrderFaxes;
            SalesOrderLetters = salesOrderLetters;
            SalesOrderOrderClose = salesOrderOrderClose;
            SalesOrderPhonecalls = salesOrderPhonecalls;
            SalesOrderRecurringAppointmentMasters = salesOrderRecurringAppointmentMasters;
            SalesOrderServiceAppointments = salesOrderServiceAppointments;
            SalesOrderSocialActivities = salesOrderSocialActivities;
            SalesOrderSyncErrors = salesOrderSyncErrors;
            SalesOrderTasks = salesOrderTasks;
            this._accountidValue = _accountidValue;
            this._campaignidValue = _campaignidValue;
            this._contactidValue = _contactidValue;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._customeridValue = _customeridValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._opportunityidValue = _opportunityidValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            this._pricelevelidValue = _pricelevelidValue;
            this._quoteidValue = _quoteidValue;
            this._slaidValue = _slaidValue;
            this._slainvokedidValue = _slainvokedidValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            BilltoAddressid = billtoAddressid;
            BilltoCity = billtoCity;
            BilltoComposite = billtoComposite;
            BilltoContactname = billtoContactname;
            BilltoCountry = billtoCountry;
            BilltoFax = billtoFax;
            BilltoLine1 = billtoLine1;
            BilltoLine2 = billtoLine2;
            BilltoLine3 = billtoLine3;
            BilltoName = billtoName;
            BilltoPostalcode = billtoPostalcode;
            BilltoStateorprovince = billtoStateorprovince;
            BilltoTelephone = billtoTelephone;
            Campaignid = campaignid;
            ContactordersAssociation = contactordersAssociation;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            CustomeridAccount = customeridAccount;
            CustomeridContact = customeridContact;
            Datefulfilled = datefulfilled;
            Description = description;
            Discountamount = discountamount;
            DiscountamountBase = discountamountBase;
            Discountpercentage = discountpercentage;
            Entityimage = entityimage;
            EntityimageTimestamp = entityimageTimestamp;
            EntityimageUrl = entityimageUrl;
            Entityimageid = entityimageid;
            Exchangerate = exchangerate;
            Freightamount = freightamount;
            FreightamountBase = freightamountBase;
            Freighttermscode = freighttermscode;
            Importsequencenumber = importsequencenumber;
            Ispricelocked = ispricelocked;
            Lastbackofficesubmit = lastbackofficesubmit;
            Lastonholdtime = lastonholdtime;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Name = name;
            Onholdtime = onholdtime;
            Opportunityid = opportunityid;
            OrderDetails = orderDetails;
            OrderInvoices = orderInvoices;
            Ordernumber = ordernumber;
            Overriddencreatedon = overriddencreatedon;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Owningteam = owningteam;
            Owninguser = owninguser;
            Paymenttermscode = paymenttermscode;
            Pricelevelid = pricelevelid;
            Pricingerrorcode = pricingerrorcode;
            Prioritycode = prioritycode;
            Processid = processid;
            Quoteid = quoteid;
            Requestdeliveryby = requestdeliveryby;
            SalesorderActivityParties = salesorderActivityParties;
            SalesorderConnections1 = salesorderConnections1;
            SalesorderConnections2 = salesorderConnections2;
            SalesorderOpportunitysalesprocess = salesorderOpportunitysalesprocess;
            Salesorderid = salesorderid;
            Shippingmethodcode = shippingmethodcode;
            ShiptoAddressid = shiptoAddressid;
            ShiptoCity = shiptoCity;
            ShiptoComposite = shiptoComposite;
            ShiptoContactname = shiptoContactname;
            ShiptoCountry = shiptoCountry;
            ShiptoFax = shiptoFax;
            ShiptoFreighttermscode = shiptoFreighttermscode;
            ShiptoLine1 = shiptoLine1;
            ShiptoLine2 = shiptoLine2;
            ShiptoLine3 = shiptoLine3;
            ShiptoName = shiptoName;
            ShiptoPostalcode = shiptoPostalcode;
            ShiptoStateorprovince = shiptoStateorprovince;
            ShiptoTelephone = shiptoTelephone;
            SlaSalesorderSla = slaSalesorderSla;
            SlainvokedidSalesorderSla = slainvokedidSalesorderSla;
            SlakpiinstanceSalesorder = slakpiinstanceSalesorder;
            Stageid = stageid;
            StageidProcessstage = stageidProcessstage;
            Statecode = statecode;
            Statuscode = statuscode;
            Submitdate = submitdate;
            Submitstatus = submitstatus;
            Submitstatusdescription = submitstatusdescription;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Totalamount = totalamount;
            TotalamountBase = totalamountBase;
            Totalamountlessfreight = totalamountlessfreight;
            TotalamountlessfreightBase = totalamountlessfreightBase;
            Totaldiscountamount = totaldiscountamount;
            TotaldiscountamountBase = totaldiscountamountBase;
            Totallineitemamount = totallineitemamount;
            TotallineitemamountBase = totallineitemamountBase;
            Totallineitemdiscountamount = totallineitemdiscountamount;
            TotallineitemdiscountamountBase = totallineitemdiscountamountBase;
            Totaltax = totaltax;
            TotaltaxBase = totaltaxBase;
            Transactioncurrencyid = transactioncurrencyid;
            Traversedpath = traversedpath;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            Willcall = willcall;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> SalesOrderActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> SalesOrderAnnotation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> SalesOrderAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SalesOrderAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SalesOrderBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Emails")]
        public IList<MicrosoftDynamicsCRMemail> SalesOrderEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> SalesOrderFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Letters")]
        public IList<MicrosoftDynamicsCRMletter> SalesOrderLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_OrderClose")]
        public IList<MicrosoftDynamicsCRMorderclose> SalesOrderOrderClose { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Phonecalls")]
        public IList<MicrosoftDynamicsCRMphonecall> SalesOrderPhonecalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> SalesOrderRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> SalesOrderServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> SalesOrderSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SalesOrderSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SalesOrder_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> SalesOrderTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_accountid_value")]
        public string _accountidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_campaignid_value")]
        public string _campaignidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_contactid_value")]
        public string _contactidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_customerid_value")]
        public string _customeridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_opportunityid_value")]
        public string _opportunityidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_pricelevelid_value")]
        public string _pricelevelidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_quoteid_value")]
        public string _quoteidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slaid_value")]
        public string _slaidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_slainvokedid_value")]
        public string _slainvokedidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_addressid")]
        public string BilltoAddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_city")]
        public string BilltoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_composite")]
        public string BilltoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_contactname")]
        public string BilltoContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_country")]
        public string BilltoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_fax")]
        public string BilltoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line1")]
        public string BilltoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line2")]
        public string BilltoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_line3")]
        public string BilltoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_name")]
        public string BilltoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_postalcode")]
        public string BilltoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_stateorprovince")]
        public string BilltoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billto_telephone")]
        public string BilltoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "campaignid")]
        public MicrosoftDynamicsCRMcampaign Campaignid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "contactorders_association")]
        public IList<MicrosoftDynamicsCRMcontact> ContactordersAssociation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_account")]
        public MicrosoftDynamicsCRMaccount CustomeridAccount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customerid_contact")]
        public MicrosoftDynamicsCRMcontact CustomeridContact { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "datefulfilled")]
        public System.DateTimeOffset? Datefulfilled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount")]
        public double? Discountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountamount_base")]
        public double? DiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "discountpercentage")]
        public double? Discountpercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage")]
        public string Entityimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_timestamp")]
        public object EntityimageTimestamp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimage_url")]
        public string EntityimageUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entityimageid")]
        public string Entityimageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public double? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount")]
        public double? Freightamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freightamount_base")]
        public double? FreightamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "freighttermscode")]
        public int? Freighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ispricelocked")]
        public bool? Ispricelocked { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastbackofficesubmit")]
        public System.DateTimeOffset? Lastbackofficesubmit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastonholdtime")]
        public System.DateTimeOffset? Lastonholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "onholdtime")]
        public int? Onholdtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "opportunityid")]
        public MicrosoftDynamicsCRMopportunity Opportunityid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "order_details")]
        public IList<MicrosoftDynamicsCRMsalesorderdetail> OrderDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "order_invoices")]
        public IList<MicrosoftDynamicsCRMinvoice> OrderInvoices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ordernumber")]
        public string Ordernumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

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
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paymenttermscode")]
        public int? Paymenttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricelevelid")]
        public MicrosoftDynamicsCRMpricelevel Pricelevelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pricingerrorcode")]
        public int? Pricingerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "prioritycode")]
        public int? Prioritycode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quoteid")]
        public MicrosoftDynamicsCRMquote Quoteid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestdeliveryby")]
        public System.DateTimeOffset? Requestdeliveryby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorder_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> SalesorderActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorder_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> SalesorderConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorder_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> SalesorderConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorder_opportunitysalesprocess")]
        public IList<MicrosoftDynamicsCRMopportunitysalesprocess> SalesorderOpportunitysalesprocess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "salesorderid")]
        public string Salesorderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shippingmethodcode")]
        public int? Shippingmethodcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_addressid")]
        public string ShiptoAddressid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_city")]
        public string ShiptoCity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_composite")]
        public string ShiptoComposite { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_contactname")]
        public string ShiptoContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_country")]
        public string ShiptoCountry { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_fax")]
        public string ShiptoFax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_freighttermscode")]
        public int? ShiptoFreighttermscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line1")]
        public string ShiptoLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line2")]
        public string ShiptoLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_line3")]
        public string ShiptoLine3 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_name")]
        public string ShiptoName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_postalcode")]
        public string ShiptoPostalcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_stateorprovince")]
        public string ShiptoStateorprovince { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "shipto_telephone")]
        public string ShiptoTelephone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sla_salesorder_sla")]
        public MicrosoftDynamicsCRMsla SlaSalesorderSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slainvokedid_salesorder_sla")]
        public MicrosoftDynamicsCRMsla SlainvokedidSalesorderSla { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "slakpiinstance_salesorder")]
        public IList<MicrosoftDynamicsCRMslakpiinstance> SlakpiinstanceSalesorder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

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
        [JsonProperty(PropertyName = "submitdate")]
        public System.DateTimeOffset? Submitdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "submitstatus")]
        public int? Submitstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "submitstatusdescription")]
        public string Submitstatusdescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount")]
        public double? Totalamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamount_base")]
        public double? TotalamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight")]
        public double? Totalamountlessfreight { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalamountlessfreight_base")]
        public double? TotalamountlessfreightBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount")]
        public double? Totaldiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaldiscountamount_base")]
        public double? TotaldiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount")]
        public double? Totallineitemamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemamount_base")]
        public double? TotallineitemamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount")]
        public double? Totallineitemdiscountamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totallineitemdiscountamount_base")]
        public double? TotallineitemdiscountamountBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax")]
        public double? Totaltax { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totaltax_base")]
        public double? TotaltaxBase { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "willcall")]
        public bool? Willcall { get; set; }

    }
}