using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016D3")]
public class CSGetUniversalLinkSettingRes
{
	[Token(Token = "0x4009760")]
	[FieldOffset(Offset = "0x8")]
	public List<UniversalLinkSettingDesc> universal_link_settings;

	[Token(Token = "0x6007D2D")]
	[Address(RVA = "0x3095D24", Offset = "0x3095D24", VA = "0x3095D24")]
	public CSGetUniversalLinkSettingRes()
	{
	}
}
