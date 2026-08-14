using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000E2")]
public class ParachuteData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000568")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x4000569")]
	[FieldOffset(Offset = "0xC")]
	public uint sortId;

	[Token(Token = "0x400056A")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID previewRes;

	[Token(Token = "0x400056B")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID inGameRes;

	[Token(Token = "0x400056C")]
	[FieldOffset(Offset = "0x18")]
	public ESourceType sourceTypeKey;

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x28CF564", Offset = "0x28CF564", VA = "0x28CF564")]
	public ParachuteData()
	{
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x28CF63C", Offset = "0x28CF63C", VA = "0x28CF63C", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x28CF694", Offset = "0x28CF694", VA = "0x28CF694", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60005EB")]
	[Address(RVA = "0x28CF6F8", Offset = "0x28CF6F8", VA = "0x28CF6F8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
