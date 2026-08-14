using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001E4")]
public class PaymentConfigData : CSVBaseData
{
	[Token(Token = "0x4000B5A")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000B5B")]
	[FieldOffset(Offset = "0xC")]
	public uint Weight;

	[Token(Token = "0x60009FD")]
	[Address(RVA = "0x2DDE1C4", Offset = "0x2DDE1C4", VA = "0x2DDE1C4")]
	public PaymentConfigData()
	{
	}

	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x2DDE248", Offset = "0x2DDE248", VA = "0x2DDE248", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60009FF")]
	[Address(RVA = "0x2DDE2AC", Offset = "0x2DDE2AC", VA = "0x2DDE2AC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
