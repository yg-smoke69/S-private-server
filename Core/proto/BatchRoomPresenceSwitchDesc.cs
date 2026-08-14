using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019FC")]
public class BatchRoomPresenceSwitchDesc
{
	[Token(Token = "0x400A30C")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A30D")]
	[FieldOffset(Offset = "0xC")]
	public bool @switch;

	[Token(Token = "0x400A30E")]
	[FieldOffset(Offset = "0x10")]
	public uint update_presence_interval;

	[Token(Token = "0x400A30F")]
	[FieldOffset(Offset = "0x14")]
	public uint batch_update_counts;

	[Token(Token = "0x6008054")]
	[Address(RVA = "0x317B904", Offset = "0x317B904", VA = "0x317B904")]
	public BatchRoomPresenceSwitchDesc()
	{
	}
}
