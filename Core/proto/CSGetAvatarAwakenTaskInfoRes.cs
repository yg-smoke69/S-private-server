using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200167E")]
public class CSGetAvatarAwakenTaskInfoRes
{
	[Token(Token = "0x4009650")]
	[FieldOffset(Offset = "0x8")]
	public List<AwakenTask> awaken_task_info;

	[Token(Token = "0x4009651")]
	[FieldOffset(Offset = "0xC")]
	public List<AvatarAwakenRefreshCount> refresh_count;

	[Token(Token = "0x6007CC8")]
	[Address(RVA = "0x3181CE0", Offset = "0x3181CE0", VA = "0x3181CE0")]
	public CSGetAvatarAwakenTaskInfoRes()
	{
	}
}
