using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019E1")]
public class AIInfoDesc
{
	[Token(Token = "0x400A290")]
	[FieldOffset(Offset = "0x8")]
	public string ai_index;

	[Token(Token = "0x400A291")]
	[FieldOffset(Offset = "0xC")]
	public uint ai_num;

	[Token(Token = "0x6008039")]
	[Address(RVA = "0x31792E4", Offset = "0x31792E4", VA = "0x31792E4")]
	public AIInfoDesc()
	{
	}
}
