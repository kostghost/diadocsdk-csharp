//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Documents/UniversalTransferDocument.proto
// Note: requires additional types generated from: Documents/ReceiptStatus.proto
namespace Diadoc.Api.Proto.Documents.UniversalTransferDocument
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UniversalTransferDocumentMetadata")]
  public partial class UniversalTransferDocumentMetadata : global::ProtoBuf.IExtensible
  {
    public UniversalTransferDocumentMetadata() {}
    

    private Diadoc.Api.Proto.Documents.UniversalTransferDocument.UniversalTransferDocumentStatus _DocumentStatus = Diadoc.Api.Proto.Documents.UniversalTransferDocument.UniversalTransferDocumentStatus.UnknownDocumentStatus;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"DocumentStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.UniversalTransferDocument.UniversalTransferDocumentStatus.UnknownDocumentStatus)]
    public Diadoc.Api.Proto.Documents.UniversalTransferDocument.UniversalTransferDocumentStatus DocumentStatus
    {
      get { return _DocumentStatus; }
      set { _DocumentStatus = value; }
    }
    private string _Total;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }

    private string _Vat = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }

    private string _Grounds = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Grounds", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Grounds
    {
      get { return _Grounds; }
      set { _Grounds = value; }
    }
    private string _DocumentFunction;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"DocumentFunction", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string DocumentFunction
    {
      get { return _DocumentFunction; }
      set { _DocumentFunction = value; }
    }
    private int _Currency;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"Currency", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Currency
    {
      get { return _Currency; }
      set { _Currency = value; }
    }

    private Diadoc.Api.Proto.Documents.ReceiptStatus _ReceiptStatus = Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ReceiptStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.ReceiptStatus.UnknownReceiptStatus)]
    public Diadoc.Api.Proto.Documents.ReceiptStatus ReceiptStatus
    {
      get { return _ReceiptStatus; }
      set { _ReceiptStatus = value; }
    }

    private long _ConfirmationDateTimeTicks = default(long);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ConfirmationDateTimeTicks", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long ConfirmationDateTimeTicks
    {
      get { return _ConfirmationDateTimeTicks; }
      set { _ConfirmationDateTimeTicks = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"UniversalTransferDocumentStatus")]
    public enum UniversalTransferDocumentStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"UnknownDocumentStatus", Value=0)]
      UnknownDocumentStatus = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForSenderSignature", Value=1)]
      OutboundWaitingForSenderSignature = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForInvoiceReceiptAndRecipientSignature", Value=2)]
      OutboundWaitingForInvoiceReceiptAndRecipientSignature = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForInvoiceReceipt", Value=3)]
      OutboundWaitingForInvoiceReceipt = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForRecipientSignature", Value=4)]
      OutboundWaitingForRecipientSignature = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundInvalidSenderSignature", Value=5)]
      OutboundInvalidSenderSignature = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundWaitingForInvoiceReceiptAndRecipientSignature", Value=6)]
      InboundWaitingForInvoiceReceiptAndRecipientSignature = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundWaitingForRecipientSignature", Value=7)]
      InboundWaitingForRecipientSignature = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundWaitingForInvoiceReceipt", Value=8)]
      InboundWaitingForInvoiceReceipt = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundWithRecipientSignature", Value=9)]
      InboundWithRecipientSignature = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundInvalidRecipientSignature", Value=10)]
      InboundInvalidRecipientSignature = 10
    }
  
}