using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200186F")]
public class CSGetMegaPunchSettingRes
{
	[Token(Token = "0x4009CF8")]
	[FieldOffset(Offset = "0x8")]
	public List<MegaPunchMonsterDesc> monster_descs;

	[Token(Token = "0x6007EC8")]
	[Address(RVA = "0x3187674", Offset = "0x3187674", VA = "0x3187674")]
	public CSGetMegaPunchSettingRes()
	{
	}
}
