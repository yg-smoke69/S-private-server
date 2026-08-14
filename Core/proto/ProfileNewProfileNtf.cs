using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200167C")]
public class ProfileNewProfileNtf
{
	[Token(Token = "0x400964B")]
	[FieldOffset(Offset = "0x8")]
	public AvatarProfile new_profile;

	[Token(Token = "0x400964C")]
	[FieldOffset(Offset = "0xC")]
	public List<Item> rewards;

	[Token(Token = "0x6007CC6")]
	[Address(RVA = "0x33E0310", Offset = "0x33E0310", VA = "0x33E0310")]
	public ProfileNewProfileNtf()
	{
	}
}
