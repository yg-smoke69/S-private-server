using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200197D")]
public class CSRampage4BTowerForwardRes
{
	[Token(Token = "0x4009FF2")]
	[FieldOffset(Offset = "0x8")]
	public uint buff;

	[Token(Token = "0x4009FF3")]
	[FieldOffset(Offset = "0xC")]
	public bool is_need_selection;

	[Token(Token = "0x4009FF4")]
	[FieldOffset(Offset = "0x10")]
	public AwardDesc book_token;

	[Token(Token = "0x4009FF5")]
	[FieldOffset(Offset = "0x14")]
	public AwardDesc award;

	[Token(Token = "0x4009FF6")]
	[FieldOffset(Offset = "0x18")]
	public AwardDesc phase_award;

	[Token(Token = "0x6007FD6")]
	[Address(RVA = "0x3098AA4", Offset = "0x3098AA4", VA = "0x3098AA4")]
	public CSRampage4BTowerForwardRes()
	{
	}
}
