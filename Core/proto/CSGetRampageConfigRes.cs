using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017F3")]
public class CSGetRampageConfigRes
{
	[Token(Token = "0x4009BBF")]
	[FieldOffset(Offset = "0x8")]
	public CSGetRampageSettingRes rampage_setting;

	[Token(Token = "0x4009BC0")]
	[FieldOffset(Offset = "0xC")]
	public CSGetProcessRampagePointsRes process_rampage_points;

	[Token(Token = "0x4009BC1")]
	[FieldOffset(Offset = "0x10")]
	public CSGetRampageRankRes rampage_rank;

	[Token(Token = "0x6007E4D")]
	[Address(RVA = "0x3094DBC", Offset = "0x3094DBC", VA = "0x3094DBC")]
	public CSGetRampageConfigRes()
	{
	}
}
