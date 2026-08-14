using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017E4")]
public class CSGetAnniversaryNodesInfoRes
{
	[Token(Token = "0x4009BA1")]
	[FieldOffset(Offset = "0x8")]
	public List<AnniversaryNodeShort> nodes;

	[Token(Token = "0x6007E3E")]
	[Address(RVA = "0x3181A98", Offset = "0x3181A98", VA = "0x3181A98")]
	public CSGetAnniversaryNodesInfoRes()
	{
	}
}
