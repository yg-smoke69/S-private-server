using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001861")]
public class CSHurricaneBSettingRes
{
	[Token(Token = "0x4009CE3")]
	[FieldOffset(Offset = "0x8")]
	public HurricaneBSettingsDesc setting;

	[Token(Token = "0x4009CE4")]
	[FieldOffset(Offset = "0xC")]
	public List<HurricaneBLevelShow> level_shows;

	[Token(Token = "0x6007EBA")]
	[Address(RVA = "0x30971B8", Offset = "0x30971B8", VA = "0x30971B8")]
	public CSHurricaneBSettingRes()
	{
	}
}
