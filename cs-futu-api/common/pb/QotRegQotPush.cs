// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Qot_RegQotPush.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace QotRegQotPush {

  /// <summary>Holder for reflection information generated from Qot_RegQotPush.proto</summary>
  public static partial class QotRegQotPushReflection {

    #region Descriptor
    /// <summary>File descriptor for Qot_RegQotPush.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QotRegQotPushReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRRb3RfUmVnUW90UHVzaC5wcm90bxIOUW90X1JlZ1FvdFB1c2gaDENvbW1v",
            "bi5wcm90bxoQUW90X0NvbW1vbi5wcm90byKIAQoDQzJTEioKDHNlY3VyaXR5",
            "TGlzdBgBIAMoCzIULlFvdF9Db21tb24uU2VjdXJpdHkSEwoLc3ViVHlwZUxp",
            "c3QYAiADKAUSFQoNcmVoYWJUeXBlTGlzdBgDIAMoBRIUCgxpc1JlZ09yVW5S",
            "ZWcYBCABKAgSEwoLaXNGaXJzdFB1c2gYBSABKAgiBQoDUzJDIisKB1JlcXVl",
            "c3QSIAoDYzJzGAEgASgLMhMuUW90X1JlZ1FvdFB1c2guQzJTIl4KCFJlc3Bv",
            "bnNlEg8KB3JldFR5cGUYASABKAUSDgoGcmV0TXNnGAIgASgJEg8KB2VyckNv",
            "ZGUYAyABKAUSIAoDczJjGAQgASgLMhMuUW90X1JlZ1FvdFB1c2guUzJDYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common.CommonReflection.Descriptor, global::QotCommon.QotCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::QotRegQotPush.C2S), global::QotRegQotPush.C2S.Parser, new[]{ "SecurityList", "SubTypeList", "RehabTypeList", "IsRegOrUnReg", "IsFirstPush" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::QotRegQotPush.S2C), global::QotRegQotPush.S2C.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::QotRegQotPush.Request), global::QotRegQotPush.Request.Parser, new[]{ "C2S" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::QotRegQotPush.Response), global::QotRegQotPush.Response.Parser, new[]{ "RetType", "RetMsg", "ErrCode", "S2C" }, null, null, null)
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
      get { return global::QotRegQotPush.QotRegQotPushReflection.Descriptor.MessageTypes[0]; }
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
      securityList_ = other.securityList_.Clone();
      subTypeList_ = other.subTypeList_.Clone();
      rehabTypeList_ = other.rehabTypeList_.Clone();
      isRegOrUnReg_ = other.isRegOrUnReg_;
      isFirstPush_ = other.isFirstPush_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S Clone() {
      return new C2S(this);
    }

    /// <summary>Field number for the "securityList" field.</summary>
    public const int SecurityListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::QotCommon.Security> _repeated_securityList_codec
        = pb::FieldCodec.ForMessage(10, global::QotCommon.Security.Parser);
    private readonly pbc::RepeatedField<global::QotCommon.Security> securityList_ = new pbc::RepeatedField<global::QotCommon.Security>();
    /// <summary>
    ///股票
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::QotCommon.Security> SecurityList {
      get { return securityList_; }
    }

    /// <summary>Field number for the "subTypeList" field.</summary>
    public const int SubTypeListFieldNumber = 2;
    private static readonly pb::FieldCodec<int> _repeated_subTypeList_codec
        = pb::FieldCodec.ForInt32(18);
    private readonly pbc::RepeatedField<int> subTypeList_ = new pbc::RepeatedField<int>();
    /// <summary>
    ///Qot_Common.SubType,要注册到该连接的订阅类型
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> SubTypeList {
      get { return subTypeList_; }
    }

    /// <summary>Field number for the "rehabTypeList" field.</summary>
    public const int RehabTypeListFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_rehabTypeList_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> rehabTypeList_ = new pbc::RepeatedField<int>();
    /// <summary>
    ///Qot_Common.RehabType,复权类型,注册K线类型才生效,其他订阅类型忽略该参数,注册K线时该参数不指定默认前复权
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> RehabTypeList {
      get { return rehabTypeList_; }
    }

    /// <summary>Field number for the "isRegOrUnReg" field.</summary>
    public const int IsRegOrUnRegFieldNumber = 4;
    private bool isRegOrUnReg_;
    /// <summary>
    ///注册或取消
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsRegOrUnReg {
      get { return isRegOrUnReg_; }
      set {
        isRegOrUnReg_ = value;
      }
    }

    /// <summary>Field number for the "isFirstPush" field.</summary>
    public const int IsFirstPushFieldNumber = 5;
    private bool isFirstPush_;
    /// <summary>
    ///注册后如果本地已有数据是否首推一次已存在数据,该参数不指定则默认true
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsFirstPush {
      get { return isFirstPush_; }
      set {
        isFirstPush_ = value;
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
      if(!securityList_.Equals(other.securityList_)) return false;
      if(!subTypeList_.Equals(other.subTypeList_)) return false;
      if(!rehabTypeList_.Equals(other.rehabTypeList_)) return false;
      if (IsRegOrUnReg != other.IsRegOrUnReg) return false;
      if (IsFirstPush != other.IsFirstPush) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= securityList_.GetHashCode();
      hash ^= subTypeList_.GetHashCode();
      hash ^= rehabTypeList_.GetHashCode();
      if (IsRegOrUnReg != false) hash ^= IsRegOrUnReg.GetHashCode();
      if (IsFirstPush != false) hash ^= IsFirstPush.GetHashCode();
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
      securityList_.WriteTo(output, _repeated_securityList_codec);
      subTypeList_.WriteTo(output, _repeated_subTypeList_codec);
      rehabTypeList_.WriteTo(output, _repeated_rehabTypeList_codec);
      if (IsRegOrUnReg != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsRegOrUnReg);
      }
      if (IsFirstPush != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsFirstPush);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += securityList_.CalculateSize(_repeated_securityList_codec);
      size += subTypeList_.CalculateSize(_repeated_subTypeList_codec);
      size += rehabTypeList_.CalculateSize(_repeated_rehabTypeList_codec);
      if (IsRegOrUnReg != false) {
        size += 1 + 1;
      }
      if (IsFirstPush != false) {
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
      securityList_.Add(other.securityList_);
      subTypeList_.Add(other.subTypeList_);
      rehabTypeList_.Add(other.rehabTypeList_);
      if (other.IsRegOrUnReg != false) {
        IsRegOrUnReg = other.IsRegOrUnReg;
      }
      if (other.IsFirstPush != false) {
        IsFirstPush = other.IsFirstPush;
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
            securityList_.AddEntriesFrom(input, _repeated_securityList_codec);
            break;
          }
          case 18:
          case 16: {
            subTypeList_.AddEntriesFrom(input, _repeated_subTypeList_codec);
            break;
          }
          case 26:
          case 24: {
            rehabTypeList_.AddEntriesFrom(input, _repeated_rehabTypeList_codec);
            break;
          }
          case 32: {
            IsRegOrUnReg = input.ReadBool();
            break;
          }
          case 40: {
            IsFirstPush = input.ReadBool();
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
      get { return global::QotRegQotPush.QotRegQotPushReflection.Descriptor.MessageTypes[1]; }
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
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C Clone() {
      return new S2C(this);
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
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
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
      get { return global::QotRegQotPush.QotRegQotPushReflection.Descriptor.MessageTypes[2]; }
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
    private global::QotRegQotPush.C2S c2S_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::QotRegQotPush.C2S C2S {
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
          C2S = new global::QotRegQotPush.C2S();
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
              C2S = new global::QotRegQotPush.C2S();
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
      get { return global::QotRegQotPush.QotRegQotPushReflection.Descriptor.MessageTypes[3]; }
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
    private global::QotRegQotPush.S2C s2C_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::QotRegQotPush.S2C S2C {
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
          S2C = new global::QotRegQotPush.S2C();
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
              S2C = new global::QotRegQotPush.S2C();
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
