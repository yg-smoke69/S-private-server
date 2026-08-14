using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001A5")]
public class MaxLobbyLogoData : CSVBaseData
{
	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x8")]
	public uint ClothesID;

	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0xC")]
	public string Region;

	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID VFXRes;

	[Token(Token = "0x600091C")]
	[Address(RVA = "0x1546B98", Offset = "0x1546B98", VA = "0x1546B98")]
	public MaxLobbyLogoData()
	{
	}

	[Token(Token = "0x600091D")]
	[Address(RVA = "0x1546C1C", Offset = "0x1546C1C", VA = "0x1546C1C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600091E")]
	[Address(RVA = "0x1546C80", Offset = "0x1546C80", VA = "0x1546C80", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
