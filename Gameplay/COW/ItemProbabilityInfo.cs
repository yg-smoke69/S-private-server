using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003141")]
public class ItemProbabilityInfo
{
	[Token(Token = "0x4012B51")]
	[FieldOffset(Offset = "0x8")]
	public uint Id;

	[Token(Token = "0x4012B52")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	[Token(Token = "0x4012B53")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.RareType Rare;

	[Token(Token = "0x4012B54")]
	[FieldOffset(Offset = "0x14")]
	public uint Count;

	[Token(Token = "0x4012B55")]
	[FieldOffset(Offset = "0x18")]
	public uint ExpireTime;

	[Token(Token = "0x4012B56")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsUnique;

	[Token(Token = "0x4012B57")]
	[FieldOffset(Offset = "0x20")]
	public uint Probability;

	[Token(Token = "0x6014A62")]
	[Address(RVA = "0x1EE292C", Offset = "0x1EE292C", VA = "0x1EE292C")]
	public ItemProbabilityInfo()
	{
	}
}
