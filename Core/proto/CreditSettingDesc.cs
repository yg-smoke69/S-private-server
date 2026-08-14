using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C01")]
public class CreditSettingDesc
{
	[Token(Token = "0x400B03E")]
	[FieldOffset(Offset = "0x8")]
	public uint credit_max;

	[Token(Token = "0x400B03F")]
	[FieldOffset(Offset = "0xC")]
	public uint credit_min;

	[Token(Token = "0x400B040")]
	[FieldOffset(Offset = "0x10")]
	public uint credit_default;

	[Token(Token = "0x600825C")]
	[Address(RVA = "0x309D920", Offset = "0x309D920", VA = "0x309D920")]
	public CreditSettingDesc()
	{
	}
}
