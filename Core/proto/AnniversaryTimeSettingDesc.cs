using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B3A")]
public class AnniversaryTimeSettingDesc
{
	[Token(Token = "0x400AB38")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AB39")]
	[FieldOffset(Offset = "0x10")]
	public ulong material_amount;

	[Token(Token = "0x400AB3A")]
	[FieldOffset(Offset = "0x18")]
	public string time;

	[Token(Token = "0x6008195")]
	[Address(RVA = "0x317A978", Offset = "0x317A978", VA = "0x317A978")]
	public AnniversaryTimeSettingDesc()
	{
	}
}
