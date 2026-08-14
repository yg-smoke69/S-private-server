using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001687")]
public class CSRefreshAvatarAwakenTaskInfoRes
{
	[Token(Token = "0x4009660")]
	[FieldOffset(Offset = "0x8")]
	public List<AwakenTask> awaken_task_info;

	[Token(Token = "0x4009661")]
	[FieldOffset(Offset = "0xC")]
	public uint refresh_count;

	[Token(Token = "0x6007CD1")]
	[Address(RVA = "0x3098EEC", Offset = "0x3098EEC", VA = "0x3098EEC")]
	public CSRefreshAvatarAwakenTaskInfoRes()
	{
	}
}
