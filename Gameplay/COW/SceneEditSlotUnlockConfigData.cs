using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2000225")]
public class SceneEditSlotUnlockConfigData : CSVBaseData
{
	[Token(Token = "0x4000CD4")]
	[FieldOffset(Offset = "0x8")]
	public uint SlotID;

	[Token(Token = "0x4000CD5")]
	[FieldOffset(Offset = "0xC")]
	public uint CostItem;

	[Token(Token = "0x4000CD6")]
	[FieldOffset(Offset = "0x10")]
	public EWorkshop.UnlockSlotCostType CostType;

	[Token(Token = "0x4000CD7")]
	[FieldOffset(Offset = "0x14")]
	public uint CostCnt;

	[Token(Token = "0x6000AE5")]
	[Address(RVA = "0x20DBD84", Offset = "0x20DBD84", VA = "0x20DBD84")]
	public SceneEditSlotUnlockConfigData()
	{
	}

	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x20DBE08", Offset = "0x20DBE08", VA = "0x20DBE08", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AE7")]
	[Address(RVA = "0x20DBE6C", Offset = "0x20DBE6C", VA = "0x20DBE6C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
