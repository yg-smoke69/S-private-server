using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002C88")]
public struct PreviewShowItemParams
{
	[Token(Token = "0x4010FF2")]
	[FieldOffset(Offset = "0x0")]
	public uint ItemID;

	[Token(Token = "0x4010FF3")]
	[FieldOffset(Offset = "0x4")]
	public EInventory.AwardType AwardType;
}
