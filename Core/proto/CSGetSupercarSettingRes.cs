using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001828")]
public class CSGetSupercarSettingRes
{
	[Token(Token = "0x4009C2E")]
	[FieldOffset(Offset = "0x8")]
	public SupercarSettingDesc supercar_setting;

	[Token(Token = "0x4009C2F")]
	[FieldOffset(Offset = "0xC")]
	public List<SupercarSpeedDesc> cars;

	[Token(Token = "0x4009C30")]
	[FieldOffset(Offset = "0x10")]
	public List<SupercarRoundAward> awards;

	[Token(Token = "0x6007E82")]
	[Address(RVA = "0x30959E0", Offset = "0x30959E0", VA = "0x30959E0")]
	public CSGetSupercarSettingRes()
	{
	}
}
