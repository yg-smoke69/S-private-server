using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001684")]
public class CSGetDispatchInfoRes
{
	[Token(Token = "0x400965B")]
	[FieldOffset(Offset = "0x8")]
	public List<AvatarDispatchStatus> avatar_dispatch_status;

	[Token(Token = "0x400965C")]
	[FieldOffset(Offset = "0xC")]
	public List<AvatarDispatchQuest> avatar_dispatch_quest;

	[Token(Token = "0x6007CCE")]
	[Address(RVA = "0x3184234", Offset = "0x3184234", VA = "0x3184234")]
	public CSGetDispatchInfoRes()
	{
	}
}
