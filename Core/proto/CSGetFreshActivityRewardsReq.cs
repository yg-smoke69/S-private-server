using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017B8")]
public class CSGetFreshActivityRewardsReq
{
	[Token(Token = "0x4009B3D")]
	[FieldOffset(Offset = "0x8")]
	public uint[] activity_ids;

	[Token(Token = "0x4009B3E")]
	[FieldOffset(Offset = "0xC")]
	public bool is_daily;

	[Token(Token = "0x6007E12")]
	[Address(RVA = "0x318514C", Offset = "0x318514C", VA = "0x318514C")]
	public CSGetFreshActivityRewardsReq()
	{
	}
}
