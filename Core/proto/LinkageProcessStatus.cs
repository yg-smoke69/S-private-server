using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B18")]
public class LinkageProcessStatus
{
	[Token(Token = "0x400AA4B")]
	[FieldOffset(Offset = "0x8")]
	public List<LinkageProcessRewardsStatus> process_status;

	[Token(Token = "0x6008173")]
	[Address(RVA = "0x30A642C", Offset = "0x30A642C", VA = "0x30A642C")]
	public LinkageProcessStatus()
	{
	}
}
