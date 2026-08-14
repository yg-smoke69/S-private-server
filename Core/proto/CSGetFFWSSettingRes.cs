using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001881")]
public class CSGetFFWSSettingRes
{
	[Token(Token = "0x4009D19")]
	[FieldOffset(Offset = "0x8")]
	public FFWSSettingDesc setting;

	[Token(Token = "0x4009D1A")]
	[FieldOffset(Offset = "0xC")]
	public List<FFWSTeamInfoDesc> team_infos;

	[Token(Token = "0x4009D1B")]
	[FieldOffset(Offset = "0x10")]
	public List<FFWSGuessingAwardDesc> awards;

	[Token(Token = "0x4009D1C")]
	[FieldOffset(Offset = "0x14")]
	public List<FFWSDailyTaskTextDesc> daily_task;

	[Token(Token = "0x4009D1D")]
	[FieldOffset(Offset = "0x18")]
	public List<FFWSSpecialTaskTextDesc> special_task;

	[Token(Token = "0x6007EDA")]
	[Address(RVA = "0x3184A18", Offset = "0x3184A18", VA = "0x3184A18")]
	public CSGetFFWSSettingRes()
	{
	}
}
