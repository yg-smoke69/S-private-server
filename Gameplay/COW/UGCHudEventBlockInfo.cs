using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003283")]
public class UGCHudEventBlockInfo
{
	[Token(Token = "0x40133F1")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40133F2")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	[Token(Token = "0x40133F3")]
	[FieldOffset(Offset = "0x10")]
	public int LogicEntityType;

	[Token(Token = "0x60154D1")]
	[Address(RVA = "0x29F03D4", Offset = "0x29F03D4", VA = "0x29F03D4")]
	public UGCHudEventBlockInfo()
	{
	}
}
