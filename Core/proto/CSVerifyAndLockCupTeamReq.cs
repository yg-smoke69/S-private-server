using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001590")]
public class CSVerifyAndLockCupTeamReq
{
	[Token(Token = "0x400938A")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x400938B")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x400938C")]
	[FieldOffset(Offset = "0x10")]
	public ulong[] member_account_ids;

	[Token(Token = "0x6007BD8")]
	[Address(RVA = "0x309A954", Offset = "0x309A954", VA = "0x309A954")]
	public CSVerifyAndLockCupTeamReq()
	{
	}
}
