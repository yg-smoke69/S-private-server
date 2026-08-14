using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BF3")]
public class MentorSettingDesc
{
	[Token(Token = "0x400B009")]
	[FieldOffset(Offset = "0x8")]
	public uint br_max_rank;

	[Token(Token = "0x400B00A")]
	[FieldOffset(Offset = "0xC")]
	public uint cs_max_rank;

	[Token(Token = "0x600824E")]
	[Address(RVA = "0x30A88C0", Offset = "0x30A88C0", VA = "0x30A88C0")]
	public MentorSettingDesc()
	{
	}
}
