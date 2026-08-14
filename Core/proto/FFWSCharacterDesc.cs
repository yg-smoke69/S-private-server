using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B93")]
public class FFWSCharacterDesc
{
	[Token(Token = "0x400AD71")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AD72")]
	[FieldOffset(Offset = "0xC")]
	public uint level;

	[Token(Token = "0x400AD73")]
	[FieldOffset(Offset = "0x10")]
	public uint sword;

	[Token(Token = "0x400AD74")]
	[FieldOffset(Offset = "0x14")]
	public uint policy;

	[Token(Token = "0x400AD75")]
	[FieldOffset(Offset = "0x18")]
	public uint experience_required;

	[Token(Token = "0x400AD76")]
	[FieldOffset(Offset = "0x1C")]
	public bool full_level_judgement;

	[Token(Token = "0x60081EE")]
	[Address(RVA = "0x30A03A8", Offset = "0x30A03A8", VA = "0x30A03A8")]
	public FFWSCharacterDesc()
	{
	}
}
