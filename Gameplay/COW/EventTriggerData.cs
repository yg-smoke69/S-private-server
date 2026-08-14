using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200012C")]
public class EventTriggerData : CSVBaseData
{
	[Token(Token = "0x40007B5")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40007B6")]
	[FieldOffset(Offset = "0xC")]
	public uint BehaviorType1;

	[Token(Token = "0x40007B7")]
	[FieldOffset(Offset = "0x10")]
	public uint value1;

	[Token(Token = "0x40007B8")]
	[FieldOffset(Offset = "0x14")]
	public uint BehaviorType2;

	[Token(Token = "0x40007B9")]
	[FieldOffset(Offset = "0x18")]
	public uint value2;

	[Token(Token = "0x40007BA")]
	[FieldOffset(Offset = "0x1C")]
	public uint BehaviorType3;

	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x20")]
	public uint value3;

	[Token(Token = "0x600074D")]
	[Address(RVA = "0x22FF058", Offset = "0x22FF058", VA = "0x22FF058")]
	public EventTriggerData()
	{
	}

	[Token(Token = "0x600074E")]
	[Address(RVA = "0x22FF0DC", Offset = "0x22FF0DC", VA = "0x22FF0DC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x22FF140", Offset = "0x22FF140", VA = "0x22FF140", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
