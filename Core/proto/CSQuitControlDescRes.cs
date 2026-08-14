using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200171B")]
public class CSQuitControlDescRes
{
	[Token(Token = "0x4009874")]
	[FieldOffset(Offset = "0x8")]
	public List<QuitControlDesc> quit_control_settings;

	[Token(Token = "0x6007D75")]
	[Address(RVA = "0x30989F0", Offset = "0x30989F0", VA = "0x30989F0")]
	public CSQuitControlDescRes()
	{
	}
}
