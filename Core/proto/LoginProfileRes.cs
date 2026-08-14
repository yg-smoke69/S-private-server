using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200167D")]
public class LoginProfileRes
{
	[Token(Token = "0x400964D")]
	[FieldOffset(Offset = "0x8")]
	public CSGetProfileListRes profile_res;

	[Token(Token = "0x400964E")]
	[FieldOffset(Offset = "0xC")]
	public CSGetSkillListRes skill_res;

	[Token(Token = "0x400964F")]
	[FieldOffset(Offset = "0x10")]
	public PetInfo pet_info;

	[Token(Token = "0x6007CC7")]
	[Address(RVA = "0x30A6858", Offset = "0x30A6858", VA = "0x30A6858")]
	public LoginProfileRes()
	{
	}
}
