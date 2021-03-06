// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Trd_GetPositionList.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TrdGetPositionList {

  /// <summary>Holder for reflection information generated from Trd_GetPositionList.proto</summary>
  public static partial class TrdGetPositionListReflection {

    #region Descriptor
    /// <summary>File descriptor for Trd_GetPositionList.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrdGetPositionListReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlUcmRfR2V0UG9zaXRpb25MaXN0LnByb3RvEhNUcmRfR2V0UG9zaXRpb25M",
            "aXN0GgxDb21tb24ucHJvdG8aEFRyZF9Db21tb24ucHJvdG8imwEKA0MyUxIl",
            "CgZoZWFkZXIYASABKAsyFS5UcmRfQ29tbW9uLlRyZEhlYWRlchI5ChBmaWx0",
            "ZXJDb25kaXRpb25zGAIgASgLMh8uVHJkX0NvbW1vbi5UcmRGaWx0ZXJDb25k",
            "aXRpb25zEhgKEGZpbHRlclBMUmF0aW9NaW4YAyABKAESGAoQZmlsdGVyUExS",
            "YXRpb01heBgEIAEoASJYCgNTMkMSJQoGaGVhZGVyGAEgASgLMhUuVHJkX0Nv",
            "bW1vbi5UcmRIZWFkZXISKgoMcG9zaXRpb25MaXN0GAIgAygLMhQuVHJkX0Nv",
            "bW1vbi5Qb3NpdGlvbiIwCgdSZXF1ZXN0EiUKA2MycxgBIAEoCzIYLlRyZF9H",
            "ZXRQb3NpdGlvbkxpc3QuQzJTImMKCFJlc3BvbnNlEg8KB3JldFR5cGUYASAB",
            "KAUSDgoGcmV0TXNnGAIgASgJEg8KB2VyckNvZGUYAyABKAUSJQoDczJjGAQg",
            "ASgLMhguVHJkX0dldFBvc2l0aW9uTGlzdC5TMkNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common.CommonReflection.Descriptor, global::TrdCommon.TrdCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TrdGetPositionList.C2S), global::TrdGetPositionList.C2S.Parser, new[]{ "Header", "FilterConditions", "FilterPLRatioMin", "FilterPLRatioMax" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TrdGetPositionList.S2C), global::TrdGetPositionList.S2C.Parser, new[]{ "Header", "PositionList" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TrdGetPositionList.Request), global::TrdGetPositionList.Request.Parser, new[]{ "C2S" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TrdGetPositionList.Response), global::TrdGetPositionList.Response.Parser, new[]{ "RetType", "RetMsg", "ErrCode", "S2C" }, null, null, null)
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
      get { return global::TrdGetPositionList.TrdGetPositionListReflection.Descriptor.MessageTypes[0]; }
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
      header_ = other.header_ != null ? other.header_.Clone() : null;
      filterConditions_ = other.filterConditions_ != null ? other.filterConditions_.Clone() : null;
      filterPLRatioMin_ = other.filterPLRatioMin_;
      filterPLRatioMax_ = other.filterPLRatioMax_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S Clone() {
      return new C2S(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::TrdCommon.TrdHeader header_;
    /// <summary>
    ///交易公共参数头
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TrdCommon.TrdHeader Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "filterConditions" field.</summary>
    public const int FilterConditionsFieldNumber = 2;
    private global::TrdCommon.TrdFilterConditions filterConditions_;
    /// <summary>
    ///过滤条件
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TrdCommon.TrdFilterConditions FilterConditions {
      get { return filterConditions_; }
      set {
        filterConditions_ = value;
      }
    }

    /// <summary>Field number for the "filterPLRatioMin" field.</summary>
    public const int FilterPLRatioMinFieldNumber = 3;
    private double filterPLRatioMin_;
    /// <summary>
    ///过滤盈亏比例下限，高于此比例的会返回，如0.1，返回盈亏比例大于10%的持仓
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double FilterPLRatioMin {
      get { return filterPLRatioMin_; }
      set {
        filterPLRatioMin_ = value;
      }
    }

    /// <summary>Field number for the "filterPLRatioMax" field.</summary>
    public const int FilterPLRatioMaxFieldNumber = 4;
    private double filterPLRatioMax_;
    /// <summary>
    ///过滤盈亏比例上限，低于此比例的会返回，如0.2，返回盈亏比例小于20%的持仓
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double FilterPLRatioMax {
      get { return filterPLRatioMax_; }
      set {
        filterPLRatioMax_ = value;
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
      if (!object.Equals(Header, other.Header)) return false;
      if (!object.Equals(FilterConditions, other.FilterConditions)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FilterPLRatioMin, other.FilterPLRatioMin)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(FilterPLRatioMax, other.FilterPLRatioMax)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (filterConditions_ != null) hash ^= FilterConditions.GetHashCode();
      if (FilterPLRatioMin != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FilterPLRatioMin);
      if (FilterPLRatioMax != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(FilterPLRatioMax);
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
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (filterConditions_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(FilterConditions);
      }
      if (FilterPLRatioMin != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(FilterPLRatioMin);
      }
      if (FilterPLRatioMax != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(FilterPLRatioMax);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (filterConditions_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FilterConditions);
      }
      if (FilterPLRatioMin != 0D) {
        size += 1 + 8;
      }
      if (FilterPLRatioMax != 0D) {
        size += 1 + 8;
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
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::TrdCommon.TrdHeader();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.filterConditions_ != null) {
        if (filterConditions_ == null) {
          FilterConditions = new global::TrdCommon.TrdFilterConditions();
        }
        FilterConditions.MergeFrom(other.FilterConditions);
      }
      if (other.FilterPLRatioMin != 0D) {
        FilterPLRatioMin = other.FilterPLRatioMin;
      }
      if (other.FilterPLRatioMax != 0D) {
        FilterPLRatioMax = other.FilterPLRatioMax;
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
            if (header_ == null) {
              Header = new global::TrdCommon.TrdHeader();
            }
            input.ReadMessage(Header);
            break;
          }
          case 18: {
            if (filterConditions_ == null) {
              FilterConditions = new global::TrdCommon.TrdFilterConditions();
            }
            input.ReadMessage(FilterConditions);
            break;
          }
          case 25: {
            FilterPLRatioMin = input.ReadDouble();
            break;
          }
          case 33: {
            FilterPLRatioMax = input.ReadDouble();
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
      get { return global::TrdGetPositionList.TrdGetPositionListReflection.Descriptor.MessageTypes[1]; }
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
      header_ = other.header_ != null ? other.header_.Clone() : null;
      positionList_ = other.positionList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C Clone() {
      return new S2C(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::TrdCommon.TrdHeader header_;
    /// <summary>
    ///交易公共参数头
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TrdCommon.TrdHeader Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "positionList" field.</summary>
    public const int PositionListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::TrdCommon.Position> _repeated_positionList_codec
        = pb::FieldCodec.ForMessage(18, global::TrdCommon.Position.Parser);
    private readonly pbc::RepeatedField<global::TrdCommon.Position> positionList_ = new pbc::RepeatedField<global::TrdCommon.Position>();
    /// <summary>
    ///持仓列表
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::TrdCommon.Position> PositionList {
      get { return positionList_; }
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
      if (!object.Equals(Header, other.Header)) return false;
      if(!positionList_.Equals(other.positionList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      hash ^= positionList_.GetHashCode();
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
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      positionList_.WriteTo(output, _repeated_positionList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      size += positionList_.CalculateSize(_repeated_positionList_codec);
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
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::TrdCommon.TrdHeader();
        }
        Header.MergeFrom(other.Header);
      }
      positionList_.Add(other.positionList_);
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
            if (header_ == null) {
              Header = new global::TrdCommon.TrdHeader();
            }
            input.ReadMessage(Header);
            break;
          }
          case 18: {
            positionList_.AddEntriesFrom(input, _repeated_positionList_codec);
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
      get { return global::TrdGetPositionList.TrdGetPositionListReflection.Descriptor.MessageTypes[2]; }
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
    private global::TrdGetPositionList.C2S c2S_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TrdGetPositionList.C2S C2S {
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
          C2S = new global::TrdGetPositionList.C2S();
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
              C2S = new global::TrdGetPositionList.C2S();
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
      get { return global::TrdGetPositionList.TrdGetPositionListReflection.Descriptor.MessageTypes[3]; }
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
    ///以下3个字段每条协议都有，注释说明在InitConnect.proto中
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
    private global::TrdGetPositionList.S2C s2C_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TrdGetPositionList.S2C S2C {
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
          S2C = new global::TrdGetPositionList.S2C();
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
              S2C = new global::TrdGetPositionList.S2C();
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
