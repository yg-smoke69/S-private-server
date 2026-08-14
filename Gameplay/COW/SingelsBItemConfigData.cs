using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000231")]
public class SingelsBItemConfigData : CSVBaseData
{
	[Token(Token = "0x4000D6D")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000D6E")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID PrefabResID;

	[Token(Token = "0x4000D6F")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID SpawnSfxID;

	[Token(Token = "0x6000B25")]
	[Address(RVA = "0x20E7180", Offset = "0x20E7180", VA = "0x20E7180")]
	public SingelsBItemConfigData()
	{
	}

	[Token(Token = "0x6000B26")]
	[Address(RVA = "0x20E7258", Offset = "0x20E7258", VA = "0x20E7258", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B27")]
	[Address(RVA = "0x20E72BC", Offset = "0x20E72BC", VA = "0x20E72BC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
