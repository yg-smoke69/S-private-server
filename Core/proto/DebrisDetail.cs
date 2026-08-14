using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001532")]
public class DebrisDetail
{
	[Token(Token = "0x2001533")]
	public enum Source
	{
		[Token(Token = "0x400921F")]
		NONE,
		[Token(Token = "0x4009220")]
		AVATAR,
		[Token(Token = "0x4009221")]
		SKILL
	}

	[Token(Token = "0x4009219")]
	[FieldOffset(Offset = "0x8")]
	public Item debris;

	[Token(Token = "0x400921A")]
	[FieldOffset(Offset = "0xC")]
	public uint debris_gained_today;

	[Token(Token = "0x400921B")]
	[FieldOffset(Offset = "0x10")]
	public uint debris_gain_limit;

	[Token(Token = "0x400921C")]
	[FieldOffset(Offset = "0x14")]
	public bool debris_reach_avatar_limit;

	[Token(Token = "0x400921D")]
	[FieldOffset(Offset = "0x18")]
	public Source source;

	[Token(Token = "0x6007B7B")]
	[Address(RVA = "0x309E568", Offset = "0x309E568", VA = "0x309E568")]
	public DebrisDetail()
	{
	}
}
