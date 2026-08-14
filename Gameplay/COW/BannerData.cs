using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000DE")]
public class BannerData : CSVBaseData, _Attribute
{
	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0xC")]
	public uint iID;

	[Token(Token = "0x4000541")]
	[FieldOffset(Offset = "0x10")]
	public uint sortId;

	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID baseRes;

	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID effectRes;

	[Token(Token = "0x4000544")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID briefRes;

	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x20")]
	public ESourceType sourceTypeKey;

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x2E50C48", Offset = "0x2E50C48", VA = "0x2E50C48")]
	public BannerData()
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x2E50D2C", Offset = "0x2E50D2C", VA = "0x2E50D2C", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x2E50D84", Offset = "0x2E50D84", VA = "0x2E50D84", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x2E50DE8", Offset = "0x2E50DE8", VA = "0x2E50DE8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
