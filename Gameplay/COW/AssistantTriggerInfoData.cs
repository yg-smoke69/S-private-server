using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000A0")]
public class AssistantTriggerInfoData : CSVBaseData
{
	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x8")]
	public uint AssistantID;

	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0xC")]
	public float CoolDown;

	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x10")]
	public uint BroadcastType;

	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x14")]
	public uint Priority;

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x14CE7C4", Offset = "0x14CE7C4", VA = "0x14CE7C4")]
	public AssistantTriggerInfoData()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x14CE848", Offset = "0x14CE848", VA = "0x14CE848", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x14CE8AC", Offset = "0x14CE8AC", VA = "0x14CE8AC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
