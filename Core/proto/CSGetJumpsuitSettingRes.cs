using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200191E")]
public class CSGetJumpsuitSettingRes
{
	[Token(Token = "0x4009ECD")]
	[FieldOffset(Offset = "0x8")]
	public JumpsuitSettingDesc setting;

	[Token(Token = "0x4009ECE")]
	[FieldOffset(Offset = "0xC")]
	public List<JumpsuitAwardDesc> awards;

	[Token(Token = "0x6007F77")]
	[Address(RVA = "0x31865D8", Offset = "0x31865D8", VA = "0x31865D8")]
	public CSGetJumpsuitSettingRes()
	{
	}
}
