using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001572")]
public class CSGetAccountCupInfoBundleByAccountIDsOrderlyReq
{
	[Token(Token = "0x4009336")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x4009337")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x4009338")]
	[FieldOffset(Offset = "0x10")]
	public ulong[] account_ids;

	[Token(Token = "0x4009339")]
	[FieldOffset(Offset = "0x14")]
	public bool need_team_info;

	[Token(Token = "0x6007BBA")]
	[Address(RVA = "0x3180AB8", Offset = "0x3180AB8", VA = "0x3180AB8")]
	public CSGetAccountCupInfoBundleByAccountIDsOrderlyReq()
	{
	}
}
