using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E3D")]
public class GachaSpDescData
{
	[Token(Token = "0x4011AD6")]
	[FieldOffset(Offset = "0x8")]
	public uint GachaID;

	[Token(Token = "0x4011AD7")]
	[FieldOffset(Offset = "0xC")]
	public List<ChestSpecialExchangeDesc> GachaSpDescList;

	[Token(Token = "0x601355F")]
	[Address(RVA = "0x105575C", Offset = "0x105575C", VA = "0x105575C")]
	public GachaSpDescData()
	{
	}

	[Token(Token = "0x6013560")]
	[Address(RVA = "0x10557E8", Offset = "0x10557E8", VA = "0x10557E8")]
	public void ComposeSpDesc(ChestSpecialExchangeDesc exchangeDesc)
	{
	}
}
