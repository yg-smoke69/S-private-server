using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015E1")]
public class CSGetTreasureBoxPRReq
{
	[Token(Token = "0x4009476")]
	[FieldOffset(Offset = "0x8")]
	public uint treasure_id;

	[Token(Token = "0x4009477")]
	[FieldOffset(Offset = "0xC")]
	public uint box_type;

	[Token(Token = "0x6007C2B")]
	[Address(RVA = "0x3095B68", Offset = "0x3095B68", VA = "0x3095B68")]
	public CSGetTreasureBoxPRReq()
	{
	}
}
