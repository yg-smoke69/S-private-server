using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001821")]
public class CSGetSuperFighterSettingRes
{
	[Token(Token = "0x4009C1B")]
	[FieldOffset(Offset = "0x8")]
	public SuperFighterSettingDesc setting_desc;

	[Token(Token = "0x4009C1C")]
	[FieldOffset(Offset = "0xC")]
	public List<SuperFighterBoxingDesc> boxing_descs;

	[Token(Token = "0x4009C1D")]
	[FieldOffset(Offset = "0x10")]
	public List<SuperFighterEnemyDesc> enemy_descs;

	[Token(Token = "0x6007E7B")]
	[Address(RVA = "0x3095894", Offset = "0x3095894", VA = "0x3095894")]
	public CSGetSuperFighterSettingRes()
	{
	}
}
