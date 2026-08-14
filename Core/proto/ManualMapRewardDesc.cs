using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AF2")]
public class ManualMapRewardDesc
{
	[Token(Token = "0x400A958")]
	[FieldOffset(Offset = "0x8")]
	public uint map_id;

	[Token(Token = "0x400A959")]
	[FieldOffset(Offset = "0xC")]
	public List<AwardDesc> awards;

	[Token(Token = "0x600814D")]
	[Address(RVA = "0x30A7860", Offset = "0x30A7860", VA = "0x30A7860")]
	public ManualMapRewardDesc()
	{
	}
}
