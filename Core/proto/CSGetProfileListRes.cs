using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200166A")]
public class CSGetProfileListRes
{
	[Token(Token = "0x4009622")]
	[FieldOffset(Offset = "0x8")]
	public List<AvatarProfile> profiles;

	[Token(Token = "0x6007CB4")]
	[Address(RVA = "0x3094C00", Offset = "0x3094C00", VA = "0x3094C00")]
	public CSGetProfileListRes()
	{
	}
}
