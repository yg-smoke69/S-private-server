using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001987")]
public class CSGetLabSettingRes
{
	[Token(Token = "0x400A006")]
	[FieldOffset(Offset = "0x8")]
	public List<LabDesc> lab_desc;

	[Token(Token = "0x6007FE0")]
	[Address(RVA = "0x3186664", Offset = "0x3186664", VA = "0x3186664")]
	public CSGetLabSettingRes()
	{
	}
}
