using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001360")]
public class ExternalIDSlice
{
	[Token(Token = "0x40088CF")]
	[FieldOffset(Offset = "0x8")]
	public List<string> external_ids;

	[Token(Token = "0x40088D0")]
	[FieldOffset(Offset = "0xC")]
	public EAccount.PlatformType platform_type;

	[Token(Token = "0x6007A61")]
	[Address(RVA = "0x30A00E0", Offset = "0x30A00E0", VA = "0x30A00E0")]
	public ExternalIDSlice()
	{
	}
}
