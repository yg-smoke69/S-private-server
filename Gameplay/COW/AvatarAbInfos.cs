using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FE1")]
public class AvatarAbInfos
{
	[Token(Token = "0x400C874")]
	[FieldOffset(Offset = "0x8")]
	public bool AvatarAbReady;

	[Token(Token = "0x400C875")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<uint, bool> ClothesAbReady;

	[Token(Token = "0x400C876")]
	[FieldOffset(Offset = "0x10")]
	public bool CollectionReady;

	[Token(Token = "0x600A08A")]
	[Address(RVA = "0x10FB1B4", Offset = "0x10FB1B4", VA = "0x10FB1B4")]
	public AvatarAbInfos()
	{
	}
}
