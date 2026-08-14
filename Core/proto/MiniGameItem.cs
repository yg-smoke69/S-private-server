using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BCB")]
public class MiniGameItem
{
	[Token(Token = "0x400AEDE")]
	[FieldOffset(Offset = "0x8")]
	public uint item_id;

	[Token(Token = "0x400AEDF")]
	[FieldOffset(Offset = "0xC")]
	public uint item_cnt;

	[Token(Token = "0x6008226")]
	[Address(RVA = "0x30A8A1C", Offset = "0x30A8A1C", VA = "0x30A8A1C")]
	public MiniGameItem()
	{
	}
}
