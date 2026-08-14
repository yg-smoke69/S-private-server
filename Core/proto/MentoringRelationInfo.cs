using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001931")]
public class MentoringRelationInfo
{
	[Token(Token = "0x4009F0F")]
	[FieldOffset(Offset = "0x8")]
	public bool is_mentor;

	[Token(Token = "0x4009F10")]
	[FieldOffset(Offset = "0xC")]
	public uint graduates_num;

	[Token(Token = "0x4009F11")]
	[FieldOffset(Offset = "0x10")]
	public AccountInfoBasicBundleRes classmate;

	[Token(Token = "0x6007F8A")]
	[Address(RVA = "0x30A88C8", Offset = "0x30A88C8", VA = "0x30A88C8")]
	public MentoringRelationInfo()
	{
	}
}
