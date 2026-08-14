using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200182E")]
public class CSGetSutoritoSettingRes
{
	[Token(Token = "0x4009C3F")]
	[FieldOffset(Offset = "0x8")]
	public SutoritoSettingDesc setting_desc;

	[Token(Token = "0x4009C40")]
	[FieldOffset(Offset = "0xC")]
	public List<SutoritoBoxingDesc> boxing_descs;

	[Token(Token = "0x4009C41")]
	[FieldOffset(Offset = "0x10")]
	public List<SutoritoEnemyDesc> enemy_descs;

	[Token(Token = "0x6007E88")]
	[Address(RVA = "0x3095AA0", Offset = "0x3095AA0", VA = "0x3095AA0")]
	public CSGetSutoritoSettingRes()
	{
	}
}
