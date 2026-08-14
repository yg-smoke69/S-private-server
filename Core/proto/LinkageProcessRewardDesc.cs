using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B17")]
public class LinkageProcessRewardDesc
{
	[Token(Token = "0x400AA48")]
	[FieldOffset(Offset = "0x8")]
	public uint rewards_process_id;

	[Token(Token = "0x400AA49")]
	[FieldOffset(Offset = "0x10")]
	public ulong target_value;

	[Token(Token = "0x400AA4A")]
	[FieldOffset(Offset = "0x18")]
	public uint rewards_id;

	[Token(Token = "0x6008172")]
	[Address(RVA = "0x30A640C", Offset = "0x30A640C", VA = "0x30A640C")]
	public LinkageProcessRewardDesc()
	{
	}
}
