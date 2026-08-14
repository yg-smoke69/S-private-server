using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000BF")]
public class BanInfoUrlData : CSVBaseData
{
	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0xC")]
	public string Country;

	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x10")]
	public int BanReasonId;

	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x14")]
	public string Url;

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x2E4F2A0", Offset = "0x2E4F2A0", VA = "0x2E4F2A0")]
	public BanInfoUrlData()
	{
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0x2E4F324", Offset = "0x2E4F324", VA = "0x2E4F324", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0x2E4F388", Offset = "0x2E4F388", VA = "0x2E4F388", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
