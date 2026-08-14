using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200166B")]
public class CSGetSkillListRes
{
	[Token(Token = "0x4009623")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009624")]
	[FieldOffset(Offset = "0x10")]
	public uint[] skills;

	[Token(Token = "0x6007CB5")]
	[Address(RVA = "0x3095474", Offset = "0x3095474", VA = "0x3095474")]
	public CSGetSkillListRes()
	{
	}
}
