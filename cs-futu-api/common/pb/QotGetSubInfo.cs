// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Qot_GetSubInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace QotGetSubInfo {

  /// <summary>Holder for reflection information generated from Qot_GetSubInfo.proto</summary>
  public static partial class QotGetSubInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for Qot_GetSubInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QotGetSubInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRRb3RfR2V0U3ViSW5mby5wcm90bxIOUW90X0dldFN1YkluZm8aDENvbW1v",
            "bi5wcm90bxoQUW90X0NvbW1vbi5wcm90byIbCgNDMlMSFAoMaXNSZXFBbGxD",
            "b25uGAEgASgIImQKA1MyQxIwCg9jb25uU3ViSW5mb0xpc3QYASADKAsyFy5R",
            "b3RfQ29tbW9uLkNvbm5TdWJJbmZvEhYKDnRvdGFsVXNlZFF1b3RhGAIgASgF",
            "EhMKC3JlbWFpblF1b3RhGAMgASgFIisKB1JlcXVlc3QSIAoDYzJzGAEgASgL",
            "MhMuUW90X0dldFN1YkluZm8uQzJTIl4KCFJlc3BvbnNlEg8KB3JldFR5cGUY",
            "ASABKAUSDgoGcmV0TXNnGAIgASgJEg8KB2VyckNvZGUYAyABKAUSIAoDczJj",
            "GAQgASgLMhMuUW90X0dldFN1YkluZm8uUzJDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common.CommonReflection.Descriptor, global::QotCommon.QotCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::QotGetSubInfo.C2S), global::QotGetSubInfo.C2S.Parser, new[]{ "IsReqAllConn" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::QotGetSubInfo.S2C), global::QotGetSubInfo.S2C.Parser, new[]{ "ConnSubInfoList", "TotalUsedQuota", "RemainQuota" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::QotGetSubInfo.Request), global::QotGetSubInfo.Request.Parser, new[]{ "C2S" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::QotGetSubInfo.Response), global::QotGetSubInfo.Response.Parser, new[]{ "RetType", "RetMsg", "ErrCode", "S2C" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class C2S : pb::IMessage<C2S> {
    private static readonly pb::MessageParser<C2S> _parser = new pb::MessageParser<C2S>(() => new C2S());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C2S> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::QotGetSubInfo.QotGetSubInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S(C2S other) : this() {
      isReqAllConn_ = other.isReqAllConn_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S Clone() {
      return new C2S(this);
    }

    /// <summary>Field number for the "isReqAllConn" field.</summary>
    public const int IsReqAllConnFieldNumber = 1;
    private bool isReqAllConn_;
    /// <summary>
    ///是否返回所有连接的订阅状态,不传或者传false只返回当前连接数据
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsReqAllConn {
      get { return isReqAllConn_; }
      set {
        isReqAllConn_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as C2S);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(C2S other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsReqAllConn != other.IsReqAllConn) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsReqAllConn != false) hash ^= IsReqAllConn.GetHashCode();
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
      if (IsReqAllConn != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsReqAllConn);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsReqAllConn != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(C2S other) {
      if (other == null) {
        return;
      }
      if (other.IsReqAllConn != false) {
        IsReqAllConn = other.IsReqAllConn;
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
            IsReqAllConn = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class S2C : pb::IMessage<S2C> {
    private static readonly pb::MessageParser<S2C> _parser = new pb::MessageParser<S2C>(() => new S2C());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<S2C> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::QotGetSubInfo.QotGetSubInfoReflection.Descriptor.MessageTypes[1]; }
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
      connSubInfoList_ = other.connSubInfoList_.Clone();
      totalUsedQuota_ = other.totalUsedQuota_;
      remainQuota_ = other.remainQuota_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C Clone() {
      return new S2C(this);
    }

    /// <summary>Field number for the "connSubInfoList" field.</summary>
    public const int ConnSubInfoListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::QotCommon.ConnSubInfo> _repeated_connSubInfoList_codec
        = pb::FieldCodec.ForMessage(10, global::QotCommon.ConnSubInfo.Parser);
    private readonly pbc::RepeatedField<global::QotCommon.ConnSubInfo> connSubInfoList_ = new pbc::RepeatedField<global::QotCommon.ConnSubInfo>();
    /// <summary>
    ///订阅订阅信息
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::QotCommon.ConnSubInfo> ConnSubInfoList {
      get { return connSubInfoList_; }
    }

    /// <summary>Field number for the "totalUsedQuota" field.</summary>
    public const int TotalUsedQuotaFieldNumber = 2;
    private int totalUsedQuota_;
    /// <summary>
    ///FutuOpenD已使用的订阅额度
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TotalUsedQuota {
      get { return totalUsedQuota_; }
      set {
        totalUsedQuota_ = value;
      }
    }

    /// <summary>Field number for the "remainQuota" field.</summary>
    public const int RemainQuotaFieldNumber = 3;
    private int remainQuota_;
    /// <summary>
    ///FutuOpenD剩余订阅额度
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RemainQuota {
      get { return remainQuota_; }
      set {
        remainQuota_ = value;
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
      if(!connSubInfoList_.Equals(other.connSubInfoList_)) return false;
      if (TotalUsedQuota != other.TotalUsedQuota) return false;
      if (RemainQuota != other.RemainQuota) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= connSubInfoList_.GetHashCode();
      if (TotalUsedQuota != 0) hash ^= TotalUsedQuota.GetHashCode();
      if (RemainQuota != 0) hash ^= RemainQuota.GetHashCode();
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
      connSubInfoList_.WriteTo(output, _repeated_connSubInfoList_codec);
      if (TotalUsedQuota != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TotalUsedQuota);
      }
      if (RemainQuota != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(RemainQuota);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += connSubInfoList_.CalculateSize(_repeated_connSubInfoList_codec);
      if (TotalUsedQuota != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TotalUsedQuota);
      }
      if (RemainQuota != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RemainQuota);
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
      connSubInfoList_.Add(other.connSubInfoList_);
      if (other.TotalUsedQuota != 0) {
        TotalUsedQuota = other.TotalUsedQuota;
      }
      if (other.RemainQuota != 0) {
        RemainQuota = other.RemainQuota;
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
            connSubInfoList_.AddEntriesFrom(input, _repeated_connSubInfoList_codec);
            break;
          }
          case 16: {
            TotalUsedQuota = input.ReadInt32();
            break;
          }
          case 24: {
            RemainQuota = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Request : pb::IMessage<Request> {
    private static readonly pb::MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Request> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::QotGetSubInfo.QotGetSubInfoReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request(Request other) : this() {
      c2S_ = other.c2S_ != null ? other.c2S_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request Clone() {
      return new Request(this);
    }

    /// <summary>Field number for the "c2s" field.</summary>
    public const int C2SFieldNumber = 1;
    private global::QotGetSubInfo.C2S c2S_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::QotGetSubInfo.C2S C2S {
      get { return c2S_; }
      set {
        c2S_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Request);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Request other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(C2S, other.C2S)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (c2S_ != null) hash ^= C2S.GetHashCode();
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
      if (c2S_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(C2S);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (c2S_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(C2S);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Request other) {
      if (other == null) {
        return;
      }
      if (other.c2S_ != null) {
        if (c2S_ == null) {
          C2S = new global::QotGetSubInfo.C2S();
        }
        C2S.MergeFrom(other.C2S);
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
            if (c2S_ == null) {
              C2S = new global::QotGetSubInfo.C2S();
            }
            input.ReadMessage(C2S);
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
      get { return global::QotGetSubInfo.QotGetSubInfoReflection.Descriptor.MessageTypes[3]; }
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
    private global::QotGetSubInfo.S2C s2C_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::QotGetSubInfo.S2C S2C {
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
          S2C = new global::QotGetSubInfo.S2C();
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
              S2C = new global::QotGetSubInfo.S2C();
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
