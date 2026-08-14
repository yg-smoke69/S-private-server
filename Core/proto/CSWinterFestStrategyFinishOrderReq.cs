using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200185B")]
public class CSWinterFestStrategyFinishOrderReq
{
	[Token(Token = "0x4009CD8")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009CD9")]
	[FieldOffset(Offset = "0x10")]
	public uint order_id;

	[Token(Token = "0x6007EB4")]
	[Address(RVA = "0x309AAC8", Offset = "0x309AAC8", VA = "0x309AAC8")]
	public CSWinterFestStrategyFinishOrderReq()
	{
	}
}
