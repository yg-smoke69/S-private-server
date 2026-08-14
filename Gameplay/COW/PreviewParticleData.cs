using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000206")]
public class PreviewParticleData : CSVBaseData
{
	[Token(Token = "0x4000BFF")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x4000C00")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID previewRes;

	[Token(Token = "0x4000C01")]
	[FieldOffset(Offset = "0x10")]
	public float PosX;

	[Token(Token = "0x4000C02")]
	[FieldOffset(Offset = "0x14")]
	public float PosY;

	[Token(Token = "0x4000C03")]
	[FieldOffset(Offset = "0x18")]
	public float PosZ;

	[Token(Token = "0x4000C04")]
	[FieldOffset(Offset = "0x1C")]
	public float RotX;

	[Token(Token = "0x4000C05")]
	[FieldOffset(Offset = "0x20")]
	public float RotY;

	[Token(Token = "0x4000C06")]
	[FieldOffset(Offset = "0x24")]
	public float RotZ;

	[Token(Token = "0x6000A76")]
	[Address(RVA = "0x195BDAC", Offset = "0x195BDAC", VA = "0x195BDAC")]
	public PreviewParticleData()
	{
	}

	[Token(Token = "0x6000A77")]
	[Address(RVA = "0x195BE78", Offset = "0x195BE78", VA = "0x195BE78", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A78")]
	[Address(RVA = "0x195BEDC", Offset = "0x195BEDC", VA = "0x195BEDC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
