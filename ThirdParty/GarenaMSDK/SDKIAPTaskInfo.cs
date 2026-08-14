using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x2000060")]
public class SDKIAPTaskInfo
{
	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0x8")]
	public string Delegate;

	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0xC")]
	public string Identifier;

	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x10")]
	public int ServerID;

	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x14")]
	public int RoleID;

	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x0")]
	public static readonly SDKIAPTaskInfo Empty;

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x3464774", Offset = "0x3464774", VA = "0x3464774")]
	public SDKIAPTaskInfo()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x3464818", Offset = "0x3464818", VA = "0x3464818")]
	public static bool Equals(SDKIAPTaskInfo a, SDKIAPTaskInfo b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x3452C78", Offset = "0x3452C78", VA = "0x3452C78")]
	public string IdentifySelf()
	{
		return null;
	}
}
