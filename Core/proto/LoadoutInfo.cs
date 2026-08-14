using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001394")]
public class LoadoutInfo
{
	[Token(Token = "0x4008A0E")]
	[FieldOffset(Offset = "0x8")]
	public uint loadout_id;

	[Token(Token = "0x4008A0F")]
	[FieldOffset(Offset = "0xC")]
	public uint loadout_num;

	[Token(Token = "0x4008A10")]
	[FieldOffset(Offset = "0x10")]
	public bool is_free_play;

	[Token(Token = "0x6007A90")]
	[Address(RVA = "0x30A6710", Offset = "0x30A6710", VA = "0x30A6710")]
	public LoadoutInfo()
	{
	}
}
