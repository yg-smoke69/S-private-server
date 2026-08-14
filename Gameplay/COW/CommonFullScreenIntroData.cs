using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200270E")]
public class CommonFullScreenIntroData : CSVBaseData
{
	[Token(Token = "0x400F106")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x400F107")]
	[FieldOffset(Offset = "0xC")]
	public string Title1;

	[Token(Token = "0x400F108")]
	[FieldOffset(Offset = "0x10")]
	public string Title2;

	[Token(Token = "0x400F109")]
	[FieldOffset(Offset = "0x14")]
	public string CDN1;

	[Token(Token = "0x400F10A")]
	[FieldOffset(Offset = "0x18")]
	public string Desc1;

	[Token(Token = "0x400F10B")]
	[FieldOffset(Offset = "0x1C")]
	public string CDN2;

	[Token(Token = "0x400F10C")]
	[FieldOffset(Offset = "0x20")]
	public string Desc2;

	[Token(Token = "0x400F10D")]
	[FieldOffset(Offset = "0x24")]
	public string CDN3;

	[Token(Token = "0x400F10E")]
	[FieldOffset(Offset = "0x28")]
	public string Desc3;

	[Token(Token = "0x400F10F")]
	[FieldOffset(Offset = "0x2C")]
	public string TutorialURL;

	[Token(Token = "0x600ED51")]
	[Address(RVA = "0x1737970", Offset = "0x1737970", VA = "0x1737970")]
	public CommonFullScreenIntroData()
	{
	}

	[Token(Token = "0x600ED52")]
	[Address(RVA = "0x17379F4", Offset = "0x17379F4", VA = "0x17379F4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600ED53")]
	[Address(RVA = "0x1737A58", Offset = "0x1737A58", VA = "0x1737A58", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
