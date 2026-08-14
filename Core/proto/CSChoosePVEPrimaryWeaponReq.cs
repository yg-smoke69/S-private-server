using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015B1")]
public class CSChoosePVEPrimaryWeaponReq
{
	[Token(Token = "0x40093ED")]
	[FieldOffset(Offset = "0x8")]
	public uint primary_weapon_id;

	[Token(Token = "0x40093EE")]
	[FieldOffset(Offset = "0x10")]
	public ulong group_id;

	[Token(Token = "0x6007BFB")]
	[Address(RVA = "0x317E31C", Offset = "0x317E31C", VA = "0x317E31C")]
	public CSChoosePVEPrimaryWeaponReq()
	{
	}
}
