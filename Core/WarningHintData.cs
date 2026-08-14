using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2000264")]
public class WarningHintData : CSVBaseData
{
	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x8")]
	public string ID;

	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0xC")]
	public float MaxDistance;

	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x10")]
	public float MinDistance;

	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x14")]
	public float Duration;

	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x18")]
	public int Priority;

	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID EffectRes;

	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0x20")]
	public float MinTransparency;

	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x24")]
	public int CountLimit;

	[Token(Token = "0x4000E98")]
	[FieldOffset(Offset = "0x28")]
	public bool IsOpen;

	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0x2A6B7A4", Offset = "0x2A6B7A4", VA = "0x2A6B7A4")]
	public WarningHintData()
	{
	}

	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x2A6B870", Offset = "0x2A6B870", VA = "0x2A6B870", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x2A6B878", Offset = "0x2A6B878", VA = "0x2A6B878", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
