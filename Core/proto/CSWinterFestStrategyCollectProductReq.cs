using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001859")]
public class CSWinterFestStrategyCollectProductReq
{
	[Token(Token = "0x4009CD4")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009CD5")]
	[FieldOffset(Offset = "0x10")]
	public EMiniGame.BuildingType target;

	[Token(Token = "0x6007EB2")]
	[Address(RVA = "0x309AAA8", Offset = "0x309AAA8", VA = "0x309AAA8")]
	public CSWinterFestStrategyCollectProductReq()
	{
	}
}
