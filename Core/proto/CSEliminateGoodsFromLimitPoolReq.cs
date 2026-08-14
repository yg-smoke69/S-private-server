using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016E3")]
public class CSEliminateGoodsFromLimitPoolReq
{
	[Token(Token = "0x4009791")]
	[FieldOffset(Offset = "0x8")]
	public uint lottery_id;

	[Token(Token = "0x4009792")]
	[FieldOffset(Offset = "0xC")]
	public uint lottery_sub_id;

	[Token(Token = "0x4009793")]
	[FieldOffset(Offset = "0x10")]
	public uint[] eliminated_goods;

	[Token(Token = "0x6007D3D")]
	[Address(RVA = "0x317FDCC", Offset = "0x317FDCC", VA = "0x317FDCC")]
	public CSEliminateGoodsFromLimitPoolReq()
	{
	}
}
