using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000FA")]
public class CreditBehaviorSettingData : CSVBaseData
{
	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x8")]
	public uint BehaviorID;

	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0xC")]
	public string IngameNotificationReportKey;

	[Token(Token = "0x4000658")]
	[FieldOffset(Offset = "0x10")]
	public string IngameTeammateKey;

	[Token(Token = "0x6000654")]
	[Address(RVA = "0x1C81D24", Offset = "0x1C81D24", VA = "0x1C81D24")]
	public CreditBehaviorSettingData()
	{
	}

	[Token(Token = "0x6000655")]
	[Address(RVA = "0x1C81DA8", Offset = "0x1C81DA8", VA = "0x1C81DA8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000656")]
	[Address(RVA = "0x1C81E0C", Offset = "0x1C81E0C", VA = "0x1C81E0C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
