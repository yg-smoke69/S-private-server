using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001958")]
public class CSGetBoybandBSettingRes
{
	[Token(Token = "0x4009F78")]
	[FieldOffset(Offset = "0x8")]
	public List<BoybandBCardDesc> card_descs;

	[Token(Token = "0x4009F79")]
	[FieldOffset(Offset = "0xC")]
	public List<BoybandBJackPotDesc> jack_pot_descs;

	[Token(Token = "0x4009F7A")]
	[FieldOffset(Offset = "0x10")]
	public BoybandBSettingDesc setting;

	[Token(Token = "0x6007FB1")]
	[Address(RVA = "0x3182A5C", Offset = "0x3182A5C", VA = "0x3182A5C")]
	public CSGetBoybandBSettingRes()
	{
	}
}
