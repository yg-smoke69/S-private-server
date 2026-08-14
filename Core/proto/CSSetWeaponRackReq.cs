using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015C8")]
public class CSSetWeaponRackReq
{
	[Token(Token = "0x4009446")]
	[FieldOffset(Offset = "0x8")]
	public uint[] weapon_ids;

	[Token(Token = "0x6007C12")]
	[Address(RVA = "0x3099B70", Offset = "0x3099B70", VA = "0x3099B70")]
	public CSSetWeaponRackReq()
	{
	}
}
