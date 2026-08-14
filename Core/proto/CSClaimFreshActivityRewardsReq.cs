using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017BE")]
public class CSClaimFreshActivityRewardsReq
{
	[Token(Token = "0x4009B4D")]
	[FieldOffset(Offset = "0x8")]
	public uint activity_id;

	[Token(Token = "0x4009B4E")]
	[FieldOffset(Offset = "0xC")]
	public bool is_daily;

	[Token(Token = "0x6007E18")]
	[Address(RVA = "0x317E68C", Offset = "0x317E68C", VA = "0x317E68C")]
	public CSClaimFreshActivityRewardsReq()
	{
	}
}
