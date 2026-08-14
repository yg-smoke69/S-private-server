using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000208")]
public class ProfileMapThresholdData : CSVBaseData
{
	[Token(Token = "0x4000C0A")]
	[FieldOffset(Offset = "0x8")]
	public string FieldName;

	[Token(Token = "0x4000C0B")]
	[FieldOffset(Offset = "0xC")]
	public float[] Thresholds;

	[Token(Token = "0x6000A7D")]
	[Address(RVA = "0x1969C78", Offset = "0x1969C78", VA = "0x1969C78")]
	public ProfileMapThresholdData()
	{
	}

	[Token(Token = "0x6000A7E")]
	[Address(RVA = "0x1969CFC", Offset = "0x1969CFC", VA = "0x1969CFC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A7F")]
	[Address(RVA = "0x1969D54", Offset = "0x1969D54", VA = "0x1969D54", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000A80")]
	[Address(RVA = "0x196A00C", Offset = "0x196A00C", VA = "0x196A00C")]
	public float GetValuePos(float value)
	{
		return default(float);
	}
}
