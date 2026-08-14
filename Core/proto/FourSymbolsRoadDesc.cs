using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B5B")]
public class FourSymbolsRoadDesc
{
	[Token(Token = "0x400AC1F")]
	[FieldOffset(Offset = "0x8")]
	public uint node_id;

	[Token(Token = "0x400AC20")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.FourSymbolsID symbol_id;

	[Token(Token = "0x400AC21")]
	[FieldOffset(Offset = "0x10")]
	public ELimitedEvent.FourSymbolsRoadNodeType node_type;

	[Token(Token = "0x400AC22")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400AC23")]
	[FieldOffset(Offset = "0x18")]
	public string node_title;

	[Token(Token = "0x400AC24")]
	[FieldOffset(Offset = "0x1C")]
	public string node_text;

	[Token(Token = "0x400AC25")]
	[FieldOffset(Offset = "0x20")]
	public uint start_time;

	[Token(Token = "0x400AC26")]
	[FieldOffset(Offset = "0x24")]
	public uint token_num_required;

	[Token(Token = "0x60081B6")]
	[Address(RVA = "0x30A0F1C", Offset = "0x30A0F1C", VA = "0x30A0F1C")]
	public FourSymbolsRoadDesc()
	{
	}
}
