using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001679")]
public class CSGetAvatarAwakenRes
{
	[Token(Token = "0x4009642")]
	[FieldOffset(Offset = "0x8")]
	public List<AvatarAwaken> infos;

	[Token(Token = "0x6007CC3")]
	[Address(RVA = "0x3181C54", Offset = "0x3181C54", VA = "0x3181C54")]
	public CSGetAvatarAwakenRes()
	{
	}
}
