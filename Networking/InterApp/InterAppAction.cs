using System.Collections.Generic;
using Il2CppDummyDll;

namespace InterApp;

[Token(Token = "0x2003EF0")]
public class InterAppAction
{
	[Token(Token = "0x401A946")]
	[FieldOffset(Offset = "0x8")]
	public string Action;

	[Token(Token = "0x401A947")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<string, string> Parameters;

	[Token(Token = "0x401A948")]
	[FieldOffset(Offset = "0x10")]
	public string Fragment;

	[Token(Token = "0x6019A36")]
	[Address(RVA = "0x310C2E4", Offset = "0x310C2E4", VA = "0x310C2E4")]
	public InterAppAction()
	{
	}
}
