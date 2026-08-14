using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000860")]
public class RegionActivityData : CSVBaseData
{
	[Token(Token = "0x4005263")]
	[FieldOffset(Offset = "0x8")]
	public uint iID;

	[Token(Token = "0x4005264")]
	[FieldOffset(Offset = "0xC")]
	public string StyleType;

	[Token(Token = "0x4005265")]
	[FieldOffset(Offset = "0x10")]
	public int activityType;

	[Token(Token = "0x4005266")]
	[FieldOffset(Offset = "0x14")]
	public int Priority;

	[Token(Token = "0x4005267")]
	[FieldOffset(Offset = "0x18")]
	public string[] activityParams;

	[Token(Token = "0x6003ABA")]
	[Address(RVA = "0x19723B8", Offset = "0x19723B8", VA = "0x19723B8")]
	public RegionActivityData()
	{
	}

	[Token(Token = "0x6003ABB")]
	[Address(RVA = "0x197243C", Offset = "0x197243C", VA = "0x197243C")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6003ABC")]
	[Address(RVA = "0x1972494", Offset = "0x1972494", VA = "0x1972494", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6003ABD")]
	[Address(RVA = "0x19724F8", Offset = "0x19724F8", VA = "0x19724F8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
