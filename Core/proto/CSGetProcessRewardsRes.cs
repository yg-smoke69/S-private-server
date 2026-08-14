using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017C5")]
public class CSGetProcessRewardsRes
{
	[Token(Token = "0x4009B64")]
	[FieldOffset(Offset = "0x8")]
	public AwardData awards;

	[Token(Token = "0x4009B65")]
	[FieldOffset(Offset = "0xC")]
	public uint process_id;

	[Token(Token = "0x4009B66")]
	[FieldOffset(Offset = "0x10")]
	public bool is_button_open;

	[Token(Token = "0x6007E1F")]
	[Address(RVA = "0x3094BF8", Offset = "0x3094BF8", VA = "0x3094BF8")]
	public CSGetProcessRewardsRes()
	{
	}
}
