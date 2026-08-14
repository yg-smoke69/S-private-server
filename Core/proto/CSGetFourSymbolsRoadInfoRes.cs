using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001835")]
public class CSGetFourSymbolsRoadInfoRes
{
	[Token(Token = "0x4009C52")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009C53")]
	[FieldOffset(Offset = "0x10")]
	public uint azure_dragon_node;

	[Token(Token = "0x4009C54")]
	[FieldOffset(Offset = "0x14")]
	public uint white_tiger_node;

	[Token(Token = "0x4009C55")]
	[FieldOffset(Offset = "0x18")]
	public uint black_tortoise_node;

	[Token(Token = "0x4009C56")]
	[FieldOffset(Offset = "0x1C")]
	public uint vermillion_bird_node;

	[Token(Token = "0x4009C57")]
	[FieldOffset(Offset = "0x20")]
	public bool big_prize_claimed;

	[Token(Token = "0x6007E8F")]
	[Address(RVA = "0x3184FF0", Offset = "0x3184FF0", VA = "0x3184FF0")]
	public CSGetFourSymbolsRoadInfoRes()
	{
	}
}
