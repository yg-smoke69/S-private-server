using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032C6")]
public class NewPlayerSurveyInfo
{
	[Token(Token = "0x401353D")]
	[FieldOffset(Offset = "0x8")]
	public uint SurveyId;

	[Token(Token = "0x401353E")]
	[FieldOffset(Offset = "0xC")]
	public string SurveyLink;

	[Token(Token = "0x401353F")]
	[FieldOffset(Offset = "0x10")]
	public uint LevelLimit;

	[Token(Token = "0x4013540")]
	[FieldOffset(Offset = "0x14")]
	public string Region;

	[Token(Token = "0x4013541")]
	[FieldOffset(Offset = "0x18")]
	public uint[] RewardID;

	[Token(Token = "0x4013542")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] RewardNum;

	[Token(Token = "0x60156C6")]
	[Address(RVA = "0x28B3DF8", Offset = "0x28B3DF8", VA = "0x28B3DF8")]
	public NewPlayerSurveyInfo()
	{
	}

	[Token(Token = "0x60156C7")]
	[Address(RVA = "0x28B3E00", Offset = "0x28B3E00", VA = "0x28B3E00")]
	public static implicit operator NewPlayerSurveyInfo(NewPlayerSurveyEntranceData data)
	{
		return null;
	}
}
