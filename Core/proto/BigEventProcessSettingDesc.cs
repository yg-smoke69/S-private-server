using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B35")]
public class BigEventProcessSettingDesc
{
	[Token(Token = "0x400AB09")]
	[FieldOffset(Offset = "0x8")]
	public ELimitedEvent.EventID event_id;

	[Token(Token = "0x400AB0A")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.ProcessType process_type;

	[Token(Token = "0x400AB0B")]
	[FieldOffset(Offset = "0x10")]
	public uint process_id;

	[Token(Token = "0x400AB0C")]
	[FieldOffset(Offset = "0x18")]
	public ulong start_value;

	[Token(Token = "0x400AB0D")]
	[FieldOffset(Offset = "0x20")]
	public ulong end_value;

	[Token(Token = "0x400AB0E")]
	[FieldOffset(Offset = "0x28")]
	public uint time_span;

	[Token(Token = "0x400AB0F")]
	[FieldOffset(Offset = "0x2C")]
	public uint lower_bound;

	[Token(Token = "0x400AB10")]
	[FieldOffset(Offset = "0x30")]
	public uint upper_bound;

	[Token(Token = "0x6008190")]
	[Address(RVA = "0x317C3DC", Offset = "0x317C3DC", VA = "0x317C3DC")]
	public BigEventProcessSettingDesc()
	{
	}
}
