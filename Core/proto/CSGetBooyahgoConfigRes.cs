using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200184D")]
public class CSGetBooyahgoConfigRes
{
	[Token(Token = "0x4009CA9")]
	[FieldOffset(Offset = "0x8")]
	public List<BooyahgoNodeDesc> nodes;

	[Token(Token = "0x4009CAA")]
	[FieldOffset(Offset = "0xC")]
	public BooyahgoMiniGameSettingDesc setting;

	[Token(Token = "0x4009CAB")]
	[FieldOffset(Offset = "0x10")]
	public List<BooyahgoEventDesc> events;

	[Token(Token = "0x4009CAC")]
	[FieldOffset(Offset = "0x14")]
	public List<BooyahgoSkullKingActivityDesc> skull_kings;

	[Token(Token = "0x6007EA7")]
	[Address(RVA = "0x31827D8", Offset = "0x31827D8", VA = "0x31827D8")]
	public CSGetBooyahgoConfigRes()
	{
	}
}
