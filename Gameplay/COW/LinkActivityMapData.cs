using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000175")]
public class LinkActivityMapData : LinkActivityDetailData
{
	[Token(Token = "0x4000964")]
	[FieldOffset(Offset = "0x8")]
	public uint Id;

	[Token(Token = "0x4000965")]
	[FieldOffset(Offset = "0xC")]
	public string ImageUrl;

	[Token(Token = "0x4000966")]
	[FieldOffset(Offset = "0x10")]
	public uint MapID;

	[Token(Token = "0x6000889")]
	[Address(RVA = "0xEC7050", Offset = "0xEC7050", VA = "0xEC7050")]
	public LinkActivityMapData()
	{
	}

	[Token(Token = "0x600088A")]
	[Address(RVA = "0xEC7054", Offset = "0xEC7054", VA = "0xEC7054", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600088B")]
	[Address(RVA = "0xEC70B8", Offset = "0xEC70B8", VA = "0xEC70B8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
