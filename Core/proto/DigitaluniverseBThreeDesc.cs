using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B69")]
public class DigitaluniverseBThreeDesc
{
	[Token(Token = "0x400AC74")]
	[FieldOffset(Offset = "0x8")]
	public ELimitedEvent.DigitaluniverseBGateType gate_type;

	[Token(Token = "0x400AC75")]
	[FieldOffset(Offset = "0xC")]
	public uint id;

	[Token(Token = "0x400AC76")]
	[FieldOffset(Offset = "0x10")]
	public uint previous_id;

	[Token(Token = "0x400AC77")]
	[FieldOffset(Offset = "0x14")]
	public uint[] activity_ids;

	[Token(Token = "0x400AC78")]
	[FieldOffset(Offset = "0x18")]
	public string unlock_time;

	[Token(Token = "0x400AC79")]
	[FieldOffset(Offset = "0x20")]
	public long unlock_timestamp;

	[Token(Token = "0x400AC7A")]
	[FieldOffset(Offset = "0x28")]
	public uint progress;

	[Token(Token = "0x60081C4")]
	[Address(RVA = "0x309EF08", Offset = "0x309EF08", VA = "0x309EF08")]
	public DigitaluniverseBThreeDesc()
	{
	}
}
