using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E32")]
public class RoomOBEventData : CSVBaseData
{
	[Token(Token = "0x2002E33")]
	public enum ERoomOBEventType
	{
		[Token(Token = "0x4011ABA")]
		None,
		[Token(Token = "0x4011ABB")]
		Local,
		[Token(Token = "0x4011ABC")]
		Global
	}

	[Token(Token = "0x4011AB1")]
	[FieldOffset(Offset = "0x8")]
	public byte ID;

	[Token(Token = "0x4011AB2")]
	[FieldOffset(Offset = "0xC")]
	public ERoomOBEventType EventType;

	[Token(Token = "0x4011AB3")]
	[FieldOffset(Offset = "0x10")]
	public string EventTypeName;

	[Token(Token = "0x4011AB4")]
	[FieldOffset(Offset = "0x14")]
	public string EventName;

	[Token(Token = "0x4011AB5")]
	[FieldOffset(Offset = "0x18")]
	public string SpriteName;

	[Token(Token = "0x4011AB6")]
	[FieldOffset(Offset = "0x1C")]
	public float Param;

	[Token(Token = "0x4011AB7")]
	[FieldOffset(Offset = "0x20")]
	public string EventActiveDesc;

	[Token(Token = "0x4011AB8")]
	[FieldOffset(Offset = "0x24")]
	public int[] GroupModeBan;

	[Token(Token = "0x601352C")]
	[Address(RVA = "0x24162D4", Offset = "0x24162D4", VA = "0x24162D4")]
	public RoomOBEventData()
	{
	}

	[Token(Token = "0x601352D")]
	[Address(RVA = "0x2416358", Offset = "0x2416358", VA = "0x2416358", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x601352E")]
	[Address(RVA = "0x24169B4", Offset = "0x24169B4", VA = "0x24169B4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}
}
