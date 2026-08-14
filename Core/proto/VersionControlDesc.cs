using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B11")]
public class VersionControlDesc
{
	[Token(Token = "0x400AA23")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400AA24")]
	[FieldOffset(Offset = "0xC")]
	public List<string> ffo_version;

	[Token(Token = "0x400AA25")]
	[FieldOffset(Offset = "0x10")]
	public List<string> ffm_version;

	[Token(Token = "0x600816C")]
	[Address(RVA = "0x33E41D0", Offset = "0x33E41D0", VA = "0x33E41D0")]
	public VersionControlDesc()
	{
	}
}
