using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200187E")]
public class CSBatchGetProfileRes
{
	[Token(Token = "0x4009D14")]
	[FieldOffset(Offset = "0x8")]
	public List<AvatarProfileWithID> profiles;

	[Token(Token = "0x6007ED7")]
	[Address(RVA = "0x317DE80", Offset = "0x317DE80", VA = "0x317DE80")]
	public CSBatchGetProfileRes()
	{
	}
}
