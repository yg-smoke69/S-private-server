using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000113")]
public class DiscolorationCollectionData : CSVBaseData
{
	[Token(Token = "0x40006EB")]
	[FieldOffset(Offset = "0x8")]
	public uint iid;

	[Token(Token = "0x40006EC")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID ResourceLow;

	[Token(Token = "0x40006ED")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID ResourceHighRed;

	[Token(Token = "0x40006EE")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID ResourceHighBlue;

	[Token(Token = "0x40006EF")]
	[FieldOffset(Offset = "0x18")]
	public uint resourcesizex;

	[Token(Token = "0x40006F0")]
	[FieldOffset(Offset = "0x1C")]
	public uint resourcesizey;

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x1C93D68", Offset = "0x1C93D68", VA = "0x1C93D68")]
	public DiscolorationCollectionData()
	{
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x1C93DEC", Offset = "0x1C93DEC", VA = "0x1C93DEC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x1C93E50", Offset = "0x1C93E50", VA = "0x1C93E50", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
