using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001764")]
public class CSGetLiveInfoRes
{
	[Token(Token = "0x4009A24")]
	[FieldOffset(Offset = "0x8")]
	public bool is_streamer;

	[Token(Token = "0x4009A25")]
	[FieldOffset(Offset = "0xC")]
	public string nickname;

	[Token(Token = "0x4009A26")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.GenderType sex;

	[Token(Token = "0x4009A27")]
	[FieldOffset(Offset = "0x14")]
	public uint head_pic;

	[Token(Token = "0x4009A28")]
	[FieldOffset(Offset = "0x18")]
	public uint banner_id;

	[Token(Token = "0x4009A29")]
	[FieldOffset(Offset = "0x1C")]
	public uint fan_count;

	[Token(Token = "0x6007DBE")]
	[Address(RVA = "0x318703C", Offset = "0x318703C", VA = "0x318703C")]
	public CSGetLiveInfoRes()
	{
	}
}
