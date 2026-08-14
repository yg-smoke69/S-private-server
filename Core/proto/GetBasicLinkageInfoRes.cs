using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200144B")]
public class GetBasicLinkageInfoRes
{
	[Token(Token = "0x4008D2A")]
	[FieldOffset(Offset = "0x8")]
	public uint activity_id;

	[Token(Token = "0x4008D2B")]
	[FieldOffset(Offset = "0xC")]
	public uint activity_type;

	[Token(Token = "0x4008D2C")]
	[FieldOffset(Offset = "0x10")]
	public uint today_data;

	[Token(Token = "0x4008D2D")]
	[FieldOffset(Offset = "0x14")]
	public uint day;

	[Token(Token = "0x6007AF9")]
	[Address(RVA = "0x30A1F3C", Offset = "0x30A1F3C", VA = "0x30A1F3C")]
	public GetBasicLinkageInfoRes()
	{
	}
}
