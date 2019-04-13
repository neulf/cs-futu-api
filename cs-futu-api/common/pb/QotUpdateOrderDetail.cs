// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Qot_UpdateOrderDetail.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace QotUpdateOrderDetail {

  /// <summary>Holder for reflection information generated from Qot_UpdateOrderDetail.proto</summary>
  public static partial class QotUpdateOrderDetailReflection {

    #region Descriptor
    /// <summary>File descriptor for Qot_UpdateOrderDetail.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QotUpdateOrderDetailReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtRb3RfVXBkYXRlT3JkZXJEZXRhaWwucHJvdG8SFVFvdF9VcGRhdGVPcmRl",
            "ckRldGFpbBoMQ29tbW9uLnByb3RvGhBRb3RfQ29tbW9uLnByb3RvIo8BCgNT",
            "MkMSJgoIc2VjdXJpdHkYASABKAsyFC5Rb3RfQ29tbW9uLlNlY3VyaXR5Ei8K",
            "Dm9yZGVyRGV0YWlsQXNrGAIgASgLMhcuUW90X0NvbW1vbi5PcmRlckRldGFp",
            "bBIvCg5vcmRlckRldGFpbEJpZBgDIAEoCzIXLlFvdF9Db21tb24uT3JkZXJE",
            "ZXRhaWwiZQoIUmVzcG9uc2USDwoHcmV0VHlwZRgBIAEoBRIOCgZyZXRNc2cY",
            "AiABKAkSDwoHZXJyQ29kZRgDIAEoBRInCgNzMmMYBCABKAsyGi5Rb3RfVXBk",
            "YXRlT3JkZXJEZXRhaWwuUzJDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common.CommonReflection.Descriptor, global::QotCommon.QotCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::QotUpdateOrderDetail.S2C), global::QotUpdateOrderDetail.S2C.Parser, new[]{ "Security", "OrderDetailAsk", "OrderDetailBid" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::QotUpdateOrderDetail.Response), global::QotUpdateOrderDetail.Response.Parser, new[]{ "RetType", "RetMsg", "ErrCode", "S2C" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class S2C : pb::IMessage<S2C> {
    private static readonly pb::MessageParser<S2C> _parser = new pb::MessageParser<S2C>(() => new S2C());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<S2C> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::QotUpdateOrderDetail.QotUpdateOrderDetailReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C(S2C other) : this() {
      security_ = other.security_ != null ? other.security_.Clone() : null;
      orderDetailAsk_ = other.orderDetailAsk_ != null ? other.orderDetailAsk_.Clone() : null;
      orderDetailBid_ = other.orderDetailBid_ != null ? other.orderDetailBid_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C Clone() {
      return new S2C(this);
    }

    /// <summary>Field number for the "security" field.</summary>
    public const int SecurityFieldNumber = 1;
    private global::QotCommon.Security security_;
    /// <summary>
    ///股票
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::QotCommon.Security Security {
      get { return security_; }
      set {
        security_ = value;
      }
    }

    /// <summary>Field number for the "orderDetailAsk" field.</summary>
    public const int OrderDetailAskFieldNumber = 2;
    private global::QotCommon.OrderDetail orderDetailAsk_;
    /// <summary>
    ///卖盘
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::QotCommon.OrderDetail OrderDetailAsk {
      get { return orderDetailAsk_; }
      set {
        orderDetailAsk_ = value;
      }
    }

    /// <summary>Field number for the "orderDetailBid" field.</summary>
    public const int OrderDetailBidFieldNumber = 3;
    private global::QotCommon.OrderDetail orderDetailBid_;
    /// <summary>
    ///买盘
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::QotCommon.OrderDetail OrderDetailBid {
      get { return orderDetailBid_; }
      set {
        orderDetailBid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as S2C);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(S2C other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Security, other.Security)) return false;
      if (!object.Equals(OrderDetailAsk, other.OrderDetailAsk)) return false;
      if (!object.Equals(OrderDetailBid, other.OrderDetailBid)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (security_ != null) hash ^= Security.GetHashCode();
      if (orderDetailAsk_ != null) hash ^= OrderDetailAsk.GetHashCode();
      if (orderDetailBid_ != null) hash ^= OrderDetailBid.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (security_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Security);
      }
      if (orderDetailAsk_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(OrderDetailAsk);
      }
      if (orderDetailBid_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OrderDetailBid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (security_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Security);
      }
      if (orderDetailAsk_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OrderDetailAsk);
      }
      if (orderDetailBid_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OrderDetailBid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(S2C other) {
      if (other == null) {
        return;
      }
      if (other.security_ != null) {
        if (security_ == null) {
          Security = new global::QotCommon.Security();
        }
        Security.MergeFrom(other.Security);
      }
      if (other.orderDetailAsk_ != null) {
        if (orderDetailAsk_ == null) {
          OrderDetailAsk = new global::QotCommon.OrderDetail();
        }
        OrderDetailAsk.MergeFrom(other.OrderDetailAsk);
      }
      if (other.orderDetailBid_ != null) {
        if (orderDetailBid_ == null) {
          OrderDetailBid = new global::QotCommon.OrderDetail();
        }
        OrderDetailBid.MergeFrom(other.OrderDetailBid);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (security_ == null) {
              Security = new global::QotCommon.Security();
            }
            input.ReadMessage(Security);
            break;
          }
          case 18: {
            if (orderDetailAsk_ == null) {
              OrderDetailAsk = new global::QotCommon.OrderDetail();
            }
            input.ReadMessage(OrderDetailAsk);
            break;
          }
          case 26: {
            if (orderDetailBid_ == null) {
              OrderDetailBid = new global::QotCommon.OrderDetail();
            }
            input.ReadMessage(OrderDetailBid);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Response : pb::IMessage<Response> {
    private static readonly pb::MessageParser<Response> _parser = new pb::MessageParser<Response>(() => new Response());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Response> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::QotUpdateOrderDetail.QotUpdateOrderDetailReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response(Response other) : this() {
      retType_ = other.retType_;
      retMsg_ = other.retMsg_;
      errCode_ = other.errCode_;
      s2C_ = other.s2C_ != null ? other.s2C_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Response Clone() {
      return new Response(this);
    }

    /// <summary>Field number for the "retType" field.</summary>
    public const int RetTypeFieldNumber = 1;
    private int retType_;
    /// <summary>
    ///RetType,返回结果
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RetType {
      get { return retType_; }
      set {
        retType_ = value;
      }
    }

    /// <summary>Field number for the "retMsg" field.</summary>
    public const int RetMsgFieldNumber = 2;
    private string retMsg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RetMsg {
      get { return retMsg_; }
      set {
        retMsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "errCode" field.</summary>
    public const int ErrCodeFieldNumber = 3;
    private int errCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ErrCode {
      get { return errCode_; }
      set {
        errCode_ = value;
      }
    }

    /// <summary>Field number for the "s2c" field.</summary>
    public const int S2CFieldNumber = 4;
    private global::QotUpdateOrderDetail.S2C s2C_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::QotUpdateOrderDetail.S2C S2C {
      get { return s2C_; }
      set {
        s2C_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Response);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Response other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RetType != other.RetType) return false;
      if (RetMsg != other.RetMsg) return false;
      if (ErrCode != other.ErrCode) return false;
      if (!object.Equals(S2C, other.S2C)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RetType != 0) hash ^= RetType.GetHashCode();
      if (RetMsg.Length != 0) hash ^= RetMsg.GetHashCode();
      if (ErrCode != 0) hash ^= ErrCode.GetHashCode();
      if (s2C_ != null) hash ^= S2C.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RetType != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RetType);
      }
      if (RetMsg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RetMsg);
      }
      if (ErrCode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ErrCode);
      }
      if (s2C_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(S2C);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RetType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RetType);
      }
      if (RetMsg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RetMsg);
      }
      if (ErrCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ErrCode);
      }
      if (s2C_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(S2C);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Response other) {
      if (other == null) {
        return;
      }
      if (other.RetType != 0) {
        RetType = other.RetType;
      }
      if (other.RetMsg.Length != 0) {
        RetMsg = other.RetMsg;
      }
      if (other.ErrCode != 0) {
        ErrCode = other.ErrCode;
      }
      if (other.s2C_ != null) {
        if (s2C_ == null) {
          S2C = new global::QotUpdateOrderDetail.S2C();
        }
        S2C.MergeFrom(other.S2C);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            RetType = input.ReadInt32();
            break;
          }
          case 18: {
            RetMsg = input.ReadString();
            break;
          }
          case 24: {
            ErrCode = input.ReadInt32();
            break;
          }
          case 34: {
            if (s2C_ == null) {
              S2C = new global::QotUpdateOrderDetail.S2C();
            }
            input.ReadMessage(S2C);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code