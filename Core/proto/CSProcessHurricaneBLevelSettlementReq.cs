using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200194C")]
public class CSProcessHurricaneBLevelSettlementReq
{
	[Token(Token = "0x4009F60")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009F61")]
	[FieldOffset(Offset = "0x10")]
	public uint level_id;

	[Token(Token = "0x4009F62")]
	[FieldOffset(Offset = "0x14")]
	public uint star_score;

	[Token(Token = "0x4009F63")]
	[FieldOffset(Offset = "0x18")]
	public uint steps_left;

	[Token(Token = "0x6007FA5")]
	[Address(RVA = "0x309886C", Offset = "0x309886C", VA = "0x309886C")]
	public CSProcessHurricaneBLevelSettlementReq()
	{
	}
}
