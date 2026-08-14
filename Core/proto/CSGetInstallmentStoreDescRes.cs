using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200174E")]
public class CSGetInstallmentStoreDescRes
{
	[Token(Token = "0x40099E4")]
	[FieldOffset(Offset = "0x8")]
	public List<InstallmentStoreDesc> installment_stores;

	[Token(Token = "0x6007DA8")]
	[Address(RVA = "0x31863F8", Offset = "0x31863F8", VA = "0x31863F8")]
	public CSGetInstallmentStoreDescRes()
	{
	}
}
