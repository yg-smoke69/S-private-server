using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001834")]
public class CSFourSymbolsRoadAdvanceRes
{
	[Token(Token = "0x4009C50")]
	[FieldOffset(Offset = "0x8")]
	public ELimitedEvent.FourSymbolsID symbol_id;

	[Token(Token = "0x4009C51")]
	[FieldOffset(Offset = "0xC")]
	public uint node_id;

	[Token(Token = "0x6007E8E")]
	[Address(RVA = "0x318089C", Offset = "0x318089C", VA = "0x318089C")]
	public CSFourSymbolsRoadAdvanceRes()
	{
	}
}
