using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015C0")]
public class CSGetRoleDebrisDescRes
{
	[Token(Token = "0x4009431")]
	[FieldOffset(Offset = "0x8")]
	public List<RoleDebrisPurchaseDesc> role_debris_tables;

	[Token(Token = "0x6007C0A")]
	[Address(RVA = "0x3095334", Offset = "0x3095334", VA = "0x3095334")]
	public CSGetRoleDebrisDescRes()
	{
	}
}
