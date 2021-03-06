// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetUserInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GetUserInfo {

  /// <summary>Holder for reflection information generated from GetUserInfo.proto</summary>
  public static partial class GetUserInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GetUserInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetUserInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHZXRVc2VySW5mby5wcm90bxILR2V0VXNlckluZm8aDENvbW1vbi5wcm90",
            "byIVCgNDMlMSDgoGdXNlcklEGAEgASgEIqcBCgNTMkMSEAoIbmlja05hbWUY",
            "ASABKAkSEQoJYXZhdGFyVXJsGAIgASgJEhAKCGFwaUxldmVsGAMgASgJEhIK",
            "CmhrUW90UmlnaHQYBCABKAUSEgoKdXNRb3RSaWdodBgFIAEoBRISCgpjblFv",
            "dFJpZ2h0GAYgASgFEh0KFWlzTmVlZEFncmVlRGlzY2xhaW1lchgHIAEoCBIO",
            "CgZ1c2VySUQYCCABKAMiKAoHUmVxdWVzdBIdCgNjMnMYASABKAsyEC5HZXRV",
            "c2VySW5mby5DMlMiWwoIUmVzcG9uc2USDwoHcmV0VHlwZRgBIAEoBRIOCgZy",
            "ZXRNc2cYAiABKAkSDwoHZXJyQ29kZRgDIAEoBRIdCgNzMmMYBCABKAsyEC5H",
            "ZXRVc2VySW5mby5TMkMqWwoIUW90UmlnaHQSEwoPUW90UmlnaHRfVW5rbm93",
            "EAASEAoMUW90UmlnaHRfQm1wEAESEwoPUW90UmlnaHRfTGV2ZWwxEAISEwoP",
            "UW90UmlnaHRfTGV2ZWwyEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Common.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::GetUserInfo.QotRight), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GetUserInfo.C2S), global::GetUserInfo.C2S.Parser, new[]{ "UserID" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GetUserInfo.S2C), global::GetUserInfo.S2C.Parser, new[]{ "NickName", "AvatarUrl", "ApiLevel", "HkQotRight", "UsQotRight", "CnQotRight", "IsNeedAgreeDisclaimer", "UserID" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GetUserInfo.Request), global::GetUserInfo.Request.Parser, new[]{ "C2S" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GetUserInfo.Response), global::GetUserInfo.Response.Parser, new[]{ "RetType", "RetMsg", "ErrCode", "S2C" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///行情权限
  /// </summary>
  public enum QotRight {
    /// <summary>
    ///未知
    /// </summary>
    [pbr::OriginalName("QotRight_Unknow")] Unknow = 0,
    /// <summary>
    ///Bmp，无法订阅
    /// </summary>
    [pbr::OriginalName("QotRight_Bmp")] Bmp = 1,
    /// <summary>
    ///Level1
    /// </summary>
    [pbr::OriginalName("QotRight_Level1")] Level1 = 2,
    /// <summary>
    ///Level2
    /// </summary>
    [pbr::OriginalName("QotRight_Level2")] Level2 = 3,
  }

  #endregion

  #region Messages
  public sealed partial class C2S : pb::IMessage<C2S> {
    private static readonly pb::MessageParser<C2S> _parser = new pb::MessageParser<C2S>(() => new C2S());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C2S> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GetUserInfo.GetUserInfoReflection.Descriptor.MessageTypes[0]; }
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
      userID_ = other.userID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2S Clone() {
      return new C2S(this);
    }

    /// <summary>Field number for the "userID" field.</summary>
    public const int UserIDFieldNumber = 1;
    private ulong userID_;
    /// <summary>
    ///需要跟FutuOpenD登陆的牛牛用户ID一致，否则会返回失败
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong UserID {
      get { return userID_; }
      set {
        userID_ = value;
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
      if (UserID != other.UserID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserID != 0UL) hash ^= UserID.GetHashCode();
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
      if (UserID != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(UserID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserID != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UserID);
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
      if (other.UserID != 0UL) {
        UserID = other.UserID;
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
            UserID = input.ReadUInt64();
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
      get { return global::GetUserInfo.GetUserInfoReflection.Descriptor.MessageTypes[1]; }
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
      nickName_ = other.nickName_;
      avatarUrl_ = other.avatarUrl_;
      apiLevel_ = other.apiLevel_;
      hkQotRight_ = other.hkQotRight_;
      usQotRight_ = other.usQotRight_;
      cnQotRight_ = other.cnQotRight_;
      isNeedAgreeDisclaimer_ = other.isNeedAgreeDisclaimer_;
      userID_ = other.userID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public S2C Clone() {
      return new S2C(this);
    }

    /// <summary>Field number for the "nickName" field.</summary>
    public const int NickNameFieldNumber = 1;
    private string nickName_ = "";
    /// <summary>
    ///用户昵称
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NickName {
      get { return nickName_; }
      set {
        nickName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "avatarUrl" field.</summary>
    public const int AvatarUrlFieldNumber = 2;
    private string avatarUrl_ = "";
    /// <summary>
    ///用户头像url
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AvatarUrl {
      get { return avatarUrl_; }
      set {
        avatarUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "apiLevel" field.</summary>
    public const int ApiLevelFieldNumber = 3;
    private string apiLevel_ = "";
    /// <summary>
    ///api用户等级描述
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApiLevel {
      get { return apiLevel_; }
      set {
        apiLevel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hkQotRight" field.</summary>
    public const int HkQotRightFieldNumber = 4;
    private int hkQotRight_;
    /// <summary>
    ///港股行情权限, QotRight
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int HkQotRight {
      get { return hkQotRight_; }
      set {
        hkQotRight_ = value;
      }
    }

    /// <summary>Field number for the "usQotRight" field.</summary>
    public const int UsQotRightFieldNumber = 5;
    private int usQotRight_;
    /// <summary>
    ///美股行情权限, QotRight
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int UsQotRight {
      get { return usQotRight_; }
      set {
        usQotRight_ = value;
      }
    }

    /// <summary>Field number for the "cnQotRight" field.</summary>
    public const int CnQotRightFieldNumber = 6;
    private int cnQotRight_;
    /// <summary>
    ///A股行情权限, QotRight
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CnQotRight {
      get { return cnQotRight_; }
      set {
        cnQotRight_ = value;
      }
    }

    /// <summary>Field number for the "isNeedAgreeDisclaimer" field.</summary>
    public const int IsNeedAgreeDisclaimerFieldNumber = 7;
    private bool isNeedAgreeDisclaimer_;
    /// <summary>
    ///已开户用户需要同意免责声明，未开户或已同意的用户返回false
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsNeedAgreeDisclaimer {
      get { return isNeedAgreeDisclaimer_; }
      set {
        isNeedAgreeDisclaimer_ = value;
      }
    }

    /// <summary>Field number for the "userID" field.</summary>
    public const int UserIDFieldNumber = 8;
    private long userID_;
    /// <summary>
    ///用户牛牛号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long UserID {
      get { return userID_; }
      set {
        userID_ = value;
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
      if (NickName != other.NickName) return false;
      if (AvatarUrl != other.AvatarUrl) return false;
      if (ApiLevel != other.ApiLevel) return false;
      if (HkQotRight != other.HkQotRight) return false;
      if (UsQotRight != other.UsQotRight) return false;
      if (CnQotRight != other.CnQotRight) return false;
      if (IsNeedAgreeDisclaimer != other.IsNeedAgreeDisclaimer) return false;
      if (UserID != other.UserID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NickName.Length != 0) hash ^= NickName.GetHashCode();
      if (AvatarUrl.Length != 0) hash ^= AvatarUrl.GetHashCode();
      if (ApiLevel.Length != 0) hash ^= ApiLevel.GetHashCode();
      if (HkQotRight != 0) hash ^= HkQotRight.GetHashCode();
      if (UsQotRight != 0) hash ^= UsQotRight.GetHashCode();
      if (CnQotRight != 0) hash ^= CnQotRight.GetHashCode();
      if (IsNeedAgreeDisclaimer != false) hash ^= IsNeedAgreeDisclaimer.GetHashCode();
      if (UserID != 0L) hash ^= UserID.GetHashCode();
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
      if (NickName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(NickName);
      }
      if (AvatarUrl.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AvatarUrl);
      }
      if (ApiLevel.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ApiLevel);
      }
      if (HkQotRight != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(HkQotRight);
      }
      if (UsQotRight != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(UsQotRight);
      }
      if (CnQotRight != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(CnQotRight);
      }
      if (IsNeedAgreeDisclaimer != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsNeedAgreeDisclaimer);
      }
      if (UserID != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(UserID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NickName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NickName);
      }
      if (AvatarUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AvatarUrl);
      }
      if (ApiLevel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiLevel);
      }
      if (HkQotRight != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HkQotRight);
      }
      if (UsQotRight != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(UsQotRight);
      }
      if (CnQotRight != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CnQotRight);
      }
      if (IsNeedAgreeDisclaimer != false) {
        size += 1 + 1;
      }
      if (UserID != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserID);
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
      if (other.NickName.Length != 0) {
        NickName = other.NickName;
      }
      if (other.AvatarUrl.Length != 0) {
        AvatarUrl = other.AvatarUrl;
      }
      if (other.ApiLevel.Length != 0) {
        ApiLevel = other.ApiLevel;
      }
      if (other.HkQotRight != 0) {
        HkQotRight = other.HkQotRight;
      }
      if (other.UsQotRight != 0) {
        UsQotRight = other.UsQotRight;
      }
      if (other.CnQotRight != 0) {
        CnQotRight = other.CnQotRight;
      }
      if (other.IsNeedAgreeDisclaimer != false) {
        IsNeedAgreeDisclaimer = other.IsNeedAgreeDisclaimer;
      }
      if (other.UserID != 0L) {
        UserID = other.UserID;
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
            NickName = input.ReadString();
            break;
          }
          case 18: {
            AvatarUrl = input.ReadString();
            break;
          }
          case 26: {
            ApiLevel = input.ReadString();
            break;
          }
          case 32: {
            HkQotRight = input.ReadInt32();
            break;
          }
          case 40: {
            UsQotRight = input.ReadInt32();
            break;
          }
          case 48: {
            CnQotRight = input.ReadInt32();
            break;
          }
          case 56: {
            IsNeedAgreeDisclaimer = input.ReadBool();
            break;
          }
          case 64: {
            UserID = input.ReadInt64();
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
      get { return global::GetUserInfo.GetUserInfoReflection.Descriptor.MessageTypes[2]; }
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
    private global::GetUserInfo.C2S c2S_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GetUserInfo.C2S C2S {
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
          C2S = new global::GetUserInfo.C2S();
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
              C2S = new global::GetUserInfo.C2S();
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
      get { return global::GetUserInfo.GetUserInfoReflection.Descriptor.MessageTypes[3]; }
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
    ///返回结果，参见Common.RetType的枚举定义
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
    /// <summary>
    ///返回结果描述
    /// </summary>
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
    /// <summary>
    ///错误码，客户端一般通过retType和retMsg来判断结果和详情，errCode只做日志记录，仅在个别协议失败时对账用
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ErrCode {
      get { return errCode_; }
      set {
        errCode_ = value;
      }
    }

    /// <summary>Field number for the "s2c" field.</summary>
    public const int S2CFieldNumber = 4;
    private global::GetUserInfo.S2C s2C_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GetUserInfo.S2C S2C {
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
          S2C = new global::GetUserInfo.S2C();
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
              S2C = new global::GetUserInfo.S2C();
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
