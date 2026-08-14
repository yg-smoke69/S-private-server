using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018C0")]
public class MusicFestTradeRecord
{
	[Token(Token = "0x4009DBF")]
	[FieldOffset(Offset = "0x8")]
	public ulong trade_id;

	[Token(Token = "0x4009DC0")]
	[FieldOffset(Offset = "0x10")]
	public ulong sender_id;

	[Token(Token = "0x4009DC1")]
	[FieldOffset(Offset = "0x18")]
	public ulong receiver_id;

	[Token(Token = "0x4009DC2")]
	[FieldOffset(Offset = "0x20")]
	public uint token_id;

	[Token(Token = "0x6007F19")]
	[Address(RVA = "0x30A94C0", Offset = "0x30A94C0", VA = "0x30A94C0")]
	public MusicFestTradeRecord()
	{
	}
}
