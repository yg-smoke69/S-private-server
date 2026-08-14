using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015DD")]
public class CSGetNewVaultItemDescRes
{
	[Token(Token = "0x4009469")]
	[FieldOffset(Offset = "0x8")]
	public List<NewVaultItemDesc> new_vault_items;

	[Token(Token = "0x6007C27")]
	[Address(RVA = "0x31881DC", Offset = "0x31881DC", VA = "0x31881DC")]
	public CSGetNewVaultItemDescRes()
	{
	}
}
