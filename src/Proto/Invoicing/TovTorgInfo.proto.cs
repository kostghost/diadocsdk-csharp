//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Invoicing/TovTorgInfo.proto
// Note: requires additional types generated from: Invoicing/InvoiceInfo.proto
// Note: requires additional types generated from: Invoicing/ExtendedSigner.proto
// Note: requires additional types generated from: Invoicing/ExtendedOrganizationInfo.proto
// Note: requires additional types generated from: Invoicing/UniversalTransferDocumentInfo.proto
namespace Diadoc.Api.Proto.Invoicing
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TovTorgSellerTitleInfo")]
  public partial class TovTorgSellerTitleInfo : global::ProtoBuf.IExtensible
  {
    public TovTorgSellerTitleInfo() {}
    
    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _Seller;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Seller", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo Seller
    {
      get { return _Seller; }
      set { _Seller = value; }
    }
    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _Buyer;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Buyer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo Buyer
    {
      get { return _Buyer; }
      set { _Buyer = value; }
    }

    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _Shipper = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Shipper", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo Shipper
    {
      get { return _Shipper; }
      set { _Shipper = value; }
    }

    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _Consignee = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Consignee", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo Consignee
    {
      get { return _Consignee; }
      set { _Consignee = value; }
    }

    private Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo _Carrier = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Carrier", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.Organizations.ExtendedOrganizationInfo Carrier
    {
      get { return _Carrier; }
      set { _Carrier = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> _Signers = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner>();
    [global::ProtoBuf.ProtoMember(6, Name=@"Signers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> Signers
    {
      get { return _Signers; }
    }
  
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.GroundInfo> _Grounds = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.GroundInfo>();
    [global::ProtoBuf.ProtoMember(7, Name=@"Grounds", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.GroundInfo> Grounds
    {
      get { return _Grounds; }
    }
  
    private string _Currency;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"Currency", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Currency
    {
      get { return _Currency; }
      set { _Currency = value; }
    }

    private string _CurrencyRate = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CurrencyRate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CurrencyRate
    {
      get { return _CurrencyRate; }
      set { _CurrencyRate = value; }
    }
    private string _DocumentDate;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"DocumentDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentDate
    {
      get { return _DocumentDate; }
      set { _DocumentDate = value; }
    }

    private string _DocumentNumber = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DocumentNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DocumentNumber
    {
      get { return _DocumentNumber; }
      set { _DocumentNumber = value; }
    }

    private string _RevisionDate = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"RevisionDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string RevisionDate
    {
      get { return _RevisionDate; }
      set { _RevisionDate = value; }
    }

    private string _RevisionNumber = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"RevisionNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string RevisionNumber
    {
      get { return _RevisionNumber; }
      set { _RevisionNumber = value; }
    }
    private Diadoc.Api.Proto.Invoicing.TovTorgTransferInfo _TransferInfo;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"TransferInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public Diadoc.Api.Proto.Invoicing.TovTorgTransferInfo TransferInfo
    {
      get { return _TransferInfo; }
      set { _TransferInfo = value; }
    }
    private string _DocumentCreator;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"DocumentCreator", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentCreator
    {
      get { return _DocumentCreator; }
      set { _DocumentCreator = value; }
    }

    private string _DocumentCreatorBase = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DocumentCreatorBase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DocumentCreatorBase
    {
      get { return _DocumentCreatorBase; }
      set { _DocumentCreatorBase = value; }
    }

    private string _OperationType = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"OperationType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OperationType
    {
      get { return _OperationType; }
      set { _OperationType = value; }
    }

    private string _GovernmentContractInfo = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"GovernmentContractInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string GovernmentContractInfo
    {
      get { return _GovernmentContractInfo; }
      set { _GovernmentContractInfo = value; }
    }

    private Diadoc.Api.Proto.Invoicing.TovTorgTable _Table = null;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"Table", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.TovTorgTable Table
    {
      get { return _Table; }
      set { _Table = value; }
    }

    private Diadoc.Api.Proto.Invoicing.AdditionalInfoId _AdditionalInfoId = null;
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"AdditionalInfoId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.AdditionalInfoId AdditionalInfoId
    {
      get { return _AdditionalInfoId; }
      set { _AdditionalInfoId = value; }
    }
    private string _DocumentName;
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"DocumentName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentName
    {
      get { return _DocumentName; }
      set { _DocumentName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TovTorgBuyerTitleInfo")]
  public partial class TovTorgBuyerTitleInfo : global::ProtoBuf.IExtensible
  {
    public TovTorgBuyerTitleInfo() {}
    
    private string _DocumentCreator;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"DocumentCreator", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentCreator
    {
      get { return _DocumentCreator; }
      set { _DocumentCreator = value; }
    }

    private string _DocumentCreatorBase = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DocumentCreatorBase", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string DocumentCreatorBase
    {
      get { return _DocumentCreatorBase; }
      set { _DocumentCreatorBase = value; }
    }

    private string _OperationCode = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"OperationCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OperationCode
    {
      get { return _OperationCode; }
      set { _OperationCode = value; }
    }
    private string _OperationContent;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"OperationContent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OperationContent
    {
      get { return _OperationContent; }
      set { _OperationContent = value; }
    }

    private string _AcceptanceDate = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"AcceptanceDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string AcceptanceDate
    {
      get { return _AcceptanceDate; }
      set { _AcceptanceDate = value; }
    }

    private Diadoc.Api.Proto.Invoicing.Employee _Employee = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Employee", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.Employee Employee
    {
      get { return _Employee; }
      set { _Employee = value; }
    }

    private Diadoc.Api.Proto.Invoicing.OtherIssuer _OtherIssuer = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"OtherIssuer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.OtherIssuer OtherIssuer
    {
      get { return _OtherIssuer; }
      set { _OtherIssuer = value; }
    }

    private Diadoc.Api.Proto.Invoicing.AdditionalInfoId _AdditionalInfoId = null;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"AdditionalInfoId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.AdditionalInfoId AdditionalInfoId
    {
      get { return _AdditionalInfoId; }
      set { _AdditionalInfoId = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> _Signers = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner>();
    [global::ProtoBuf.ProtoMember(9, Name=@"Signers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Signers.ExtendedSigner> Signers
    {
      get { return _Signers; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TovTorgTable")]
  public partial class TovTorgTable : global::ProtoBuf.IExtensible
  {
    public TovTorgTable() {}
    
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.TovTorgItem> _Items = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.TovTorgItem>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.TovTorgItem> Items
    {
      get { return _Items; }
    }
  

    private string _TotalQuantity = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TotalQuantity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TotalQuantity
    {
      get { return _TotalQuantity; }
      set { _TotalQuantity = value; }
    }

    private string _TotalGross = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"TotalGross", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TotalGross
    {
      get { return _TotalGross; }
      set { _TotalGross = value; }
    }

    private string _TotalNet = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"TotalNet", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TotalNet
    {
      get { return _TotalNet; }
      set { _TotalNet = value; }
    }

    private string _TotalWithVatExcluded = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"TotalWithVatExcluded", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TotalWithVatExcluded
    {
      get { return _TotalWithVatExcluded; }
      set { _TotalWithVatExcluded = value; }
    }

    private string _TotalVat = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"TotalVat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TotalVat
    {
      get { return _TotalVat; }
      set { _TotalVat = value; }
    }

    private string _Total = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TovTorgItem")]
  public partial class TovTorgItem : global::ProtoBuf.IExtensible
  {
    public TovTorgItem() {}
    

    private string _Product = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Product", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Product
    {
      get { return _Product; }
      set { _Product = value; }
    }

    private string _Feature = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Feature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Feature
    {
      get { return _Feature; }
      set { _Feature = value; }
    }

    private string _Sort = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Sort", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Sort
    {
      get { return _Sort; }
      set { _Sort = value; }
    }

    private string _VendorCode = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"VendorCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string VendorCode
    {
      get { return _VendorCode; }
      set { _VendorCode = value; }
    }

    private string _ProductCode = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ProductCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ProductCode
    {
      get { return _ProductCode; }
      set { _ProductCode = value; }
    }

    private string _UnitName = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"UnitName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string UnitName
    {
      get { return _UnitName; }
      set { _UnitName = value; }
    }
    private string _Unit;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"Unit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Unit
    {
      get { return _Unit; }
      set { _Unit = value; }
    }

    private string _PackageType = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"PackageType", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string PackageType
    {
      get { return _PackageType; }
      set { _PackageType = value; }
    }

    private string _QuantityInPack = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"QuantityInPack", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string QuantityInPack
    {
      get { return _QuantityInPack; }
      set { _QuantityInPack = value; }
    }

    private string _Quantity = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Quantity", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Quantity
    {
      get { return _Quantity; }
      set { _Quantity = value; }
    }

    private string _Gross = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Gross", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Gross
    {
      get { return _Gross; }
      set { _Gross = value; }
    }
    private string _Net;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"Net", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Net
    {
      get { return _Net; }
      set { _Net = value; }
    }

    private string _ItemToRelease = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ItemToRelease", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ItemToRelease
    {
      get { return _ItemToRelease; }
      set { _ItemToRelease = value; }
    }

    private string _Price = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Price", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    private string _SubtotalWithVatExcluded = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"SubtotalWithVatExcluded", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string SubtotalWithVatExcluded
    {
      get { return _SubtotalWithVatExcluded; }
      set { _SubtotalWithVatExcluded = value; }
    }

    private Diadoc.Api.Proto.Invoicing.TaxRate _TaxRate = Diadoc.Api.Proto.Invoicing.TaxRate.Percent_18;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"TaxRate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Invoicing.TaxRate.Percent_18)]
    public Diadoc.Api.Proto.Invoicing.TaxRate TaxRate
    {
      get { return _TaxRate; }
      set { _TaxRate = value; }
    }

    private string _Vat = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }
    private string _Subtotal;
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"Subtotal", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Subtotal
    {
      get { return _Subtotal; }
      set { _Subtotal = value; }
    }

    private string _ItemAccountDebit = "";
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ItemAccountDebit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ItemAccountDebit
    {
      get { return _ItemAccountDebit; }
      set { _ItemAccountDebit = value; }
    }

    private string _ItemAccountCredit = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"ItemAccountCredit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string ItemAccountCredit
    {
      get { return _ItemAccountCredit; }
      set { _ItemAccountCredit = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> _AdditionalInfos = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo>();
    [global::ProtoBuf.ProtoMember(21, Name=@"AdditionalInfos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> AdditionalInfos
    {
      get { return _AdditionalInfos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TovTorgTransferInfo")]
  public partial class TovTorgTransferInfo : global::ProtoBuf.IExtensible
  {
    public TovTorgTransferInfo() {}
    
    private string _OperationInfo;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"OperationInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string OperationInfo
    {
      get { return _OperationInfo; }
      set { _OperationInfo = value; }
    }

    private string _TransferDate = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TransferDate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string TransferDate
    {
      get { return _TransferDate; }
      set { _TransferDate = value; }
    }

    private string _Attachment = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Attachment", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Attachment
    {
      get { return _Attachment; }
      set { _Attachment = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Waybill> _Waybills = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Waybill>();
    [global::ProtoBuf.ProtoMember(4, Name=@"Waybills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.Waybill> Waybills
    {
      get { return _Waybills; }
    }
  

    private Diadoc.Api.Proto.Invoicing.Employee _Employee = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Employee", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.Employee Employee
    {
      get { return _Employee; }
      set { _Employee = value; }
    }

    private Diadoc.Api.Proto.Invoicing.OtherIssuer _OtherIssuer = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"OtherIssuer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Invoicing.OtherIssuer OtherIssuer
    {
      get { return _OtherIssuer; }
      set { _OtherIssuer = value; }
    }
    private readonly global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> _AdditionalInfos = new global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo>();
    [global::ProtoBuf.ProtoMember(7, Name=@"AdditionalInfos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Diadoc.Api.Proto.Invoicing.AdditionalInfo> AdditionalInfos
    {
      get { return _AdditionalInfos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GroundInfo")]
  public partial class GroundInfo : global::ProtoBuf.IExtensible
  {
    public GroundInfo() {}
    
    private string _Name;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }

    private string _Number = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Number", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Number
    {
      get { return _Number; }
      set { _Number = value; }
    }

    private string _Date = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Date", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Date
    {
      get { return _Date; }
      set { _Date = value; }
    }

    private string _Info = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Info
    {
      get { return _Info; }
      set { _Info = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}