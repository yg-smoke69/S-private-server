using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018D8")]
public class CSGetWinterFest21BSettingRes
{
	[Token(Token = "0x4009DF3")]
	[FieldOffset(Offset = "0x8")]
	public WinterFest21BSettingDesc setting;

	[Token(Token = "0x4009DF4")]
	[FieldOffset(Offset = "0xC")]
	public List<WinterFest21BBuildMissionDesc> missions;

	[Token(Token = "0x4009DF5")]
	[FieldOffset(Offset = "0x10")]
	public List<WinterFest21BMapUnlockDesc> map_desc;

	[Token(Token = "0x6007F31")]
	[Address(RVA = "0x3096720", Offset = "0x3096720", VA = "0x3096720")]
	public CSGetWinterFest21BSettingRes()
	{
	}
}
