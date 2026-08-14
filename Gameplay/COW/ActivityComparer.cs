using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001E99")]
internal class ActivityComparer : _Attribute
{
	[Token(Token = "0x600939E")]
	[Address(RVA = "0x14BE578", Offset = "0x14BE578", VA = "0x14BE578")]
	public ActivityComparer()
	{
	}

	[Token(Token = "0x600939F")]
	[Address(RVA = "0x14BE580", Offset = "0x14BE580", VA = "0x14BE580", Slot = "4")]
	public int Compare(ClientActivityDesc x, ClientActivityDesc y)
	{
		return default(int);
	}
}
