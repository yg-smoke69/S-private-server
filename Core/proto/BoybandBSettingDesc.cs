using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C00")]
public class BoybandBSettingDesc
{
	[Token(Token = "0x400B039")]
	[FieldOffset(Offset = "0x8")]
	public uint bundle_token_id;

	[Token(Token = "0x400B03A")]
	[FieldOffset(Offset = "0xC")]
	public uint sugar_id;

	[Token(Token = "0x400B03B")]
	[FieldOffset(Offset = "0x10")]
	public uint first_chose;

	[Token(Token = "0x400B03C")]
	[FieldOffset(Offset = "0x14")]
	public uint second_chose;

	[Token(Token = "0x400B03D")]
	[FieldOffset(Offset = "0x18")]
	public AwardDesc reward;

	[Token(Token = "0x600825B")]
	[Address(RVA = "0x317D370", Offset = "0x317D370", VA = "0x317D370")]
	public BoybandBSettingDesc()
	{
	}
}
