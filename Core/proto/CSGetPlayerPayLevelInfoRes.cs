using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015DA")]
public class CSGetPlayerPayLevelInfoRes
{
	[Token(Token = "0x4009463")]
	[FieldOffset(Offset = "0x8")]
	public List<PlayLevelInfo> infos;

	[Token(Token = "0x6007C24")]
	[Address(RVA = "0x30948E4", Offset = "0x30948E4", VA = "0x30948E4")]
	public CSGetPlayerPayLevelInfoRes()
	{
	}
}
