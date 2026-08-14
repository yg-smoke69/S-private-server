using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014B8")]
public class WorkshopHotInfo
{
	[Token(Token = "0x4008F96")]
	[FieldOffset(Offset = "0x8")]
	public uint order;

	[Token(Token = "0x4008F97")]
	[FieldOffset(Offset = "0xC")]
	public string picture;

	[Token(Token = "0x4008F98")]
	[FieldOffset(Offset = "0x10")]
	public WorkshopBasicInfo workshop_basic_info;

	[Token(Token = "0x4008F99")]
	[FieldOffset(Offset = "0x14")]
	public string workshop_code;

	[Token(Token = "0x4008F9A")]
	[FieldOffset(Offset = "0x18")]
	public uint recommend_mode;

	[Token(Token = "0x6007B19")]
	[Address(RVA = "0x33E647C", Offset = "0x33E647C", VA = "0x33E647C")]
	public WorkshopHotInfo()
	{
	}
}
