using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017C1")]
public class CSClaimNewbieGuideRewardsReq
{
	[Token(Token = "0x4009B53")]
	[FieldOffset(Offset = "0x8")]
	public EFresh.GuideMode mode;

	[Token(Token = "0x4009B54")]
	[FieldOffset(Offset = "0xC")]
	public bool is_drop_out;

	[Token(Token = "0x6007E1B")]
	[Address(RVA = "0x317E958", Offset = "0x317E958", VA = "0x317E958")]
	public CSClaimNewbieGuideRewardsReq()
	{
	}
}
