using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001836")]
public class CSHoodedkillerBAssassinateReq
{
	[Token(Token = "0x4009C58")]
	[FieldOffset(Offset = "0x8")]
	public uint target_id;

	[Token(Token = "0x4009C59")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.HoodedkillerBWeaponType weapon_type;

	[Token(Token = "0x6007E90")]
	[Address(RVA = "0x30971A0", Offset = "0x30971A0", VA = "0x30971A0")]
	public CSHoodedkillerBAssassinateReq()
	{
	}
}
