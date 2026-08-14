using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B6D")]
public class BooyahDayRankingDesc
{
	[Token(Token = "0x400AC85")]
	[FieldOffset(Offset = "0x8")]
	public uint start_time_stamp;

	[Token(Token = "0x400AC86")]
	[FieldOffset(Offset = "0xC")]
	public uint end_time_stamp;

	[Token(Token = "0x400AC87")]
	[FieldOffset(Offset = "0x10")]
	public List<ModeRecord> modes;

	[Token(Token = "0x60081C8")]
	[Address(RVA = "0x317CA94", Offset = "0x317CA94", VA = "0x317CA94")]
	public BooyahDayRankingDesc()
	{
	}
}
