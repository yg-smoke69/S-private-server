using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001856")]
public class CSGetWinterFestStrategyInfoRes
{
	[Token(Token = "0x4009CCE")]
	[FieldOffset(Offset = "0x8")]
	public WinterFestStrategyAccountInfo game_info;

	[Token(Token = "0x4009CCF")]
	[FieldOffset(Offset = "0xC")]
	public List<MiniGameItem> all_items;

	[Token(Token = "0x4009CD0")]
	[FieldOffset(Offset = "0x10")]
	public List<WinterFestStrategyHelpLog> history;

	[Token(Token = "0x4009CD1")]
	[FieldOffset(Offset = "0x14")]
	public bool is_first_enter;

	[Token(Token = "0x6007EAF")]
	[Address(RVA = "0x30967E8", Offset = "0x30967E8", VA = "0x30967E8")]
	public CSGetWinterFestStrategyInfoRes()
	{
	}
}
