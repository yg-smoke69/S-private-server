using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017A0")]
public class CSGetChampionshipConfigReq
{
	[Token(Token = "0x4009AD7")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x4009AD8")]
	[FieldOffset(Offset = "0xC")]
	public uint championship_id;

	[Token(Token = "0x4009AD9")]
	[FieldOffset(Offset = "0x10")]
	public string language;

	[Token(Token = "0x6007DFA")]
	[Address(RVA = "0x3182CD0", Offset = "0x3182CD0", VA = "0x3182CD0")]
	public CSGetChampionshipConfigReq()
	{
	}
}
