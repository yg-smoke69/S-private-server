using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018D2")]
public class CSSubmitMocoHackGameDataRes
{
	[Token(Token = "0x4009DE9")]
	[FieldOffset(Offset = "0x8")]
	public uint moco_coin_num;

	[Token(Token = "0x4009DEA")]
	[FieldOffset(Offset = "0xC")]
	public uint free_times_used;

	[Token(Token = "0x6007F2B")]
	[Address(RVA = "0x3099EBC", Offset = "0x3099EBC", VA = "0x3099EBC")]
	public CSSubmitMocoHackGameDataRes()
	{
	}
}
