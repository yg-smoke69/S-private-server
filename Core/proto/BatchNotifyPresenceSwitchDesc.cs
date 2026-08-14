using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019FA")]
public class BatchNotifyPresenceSwitchDesc
{
	[Token(Token = "0x400A304")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A305")]
	[FieldOffset(Offset = "0xC")]
	public bool @switch;

	[Token(Token = "0x400A306")]
	[FieldOffset(Offset = "0x10")]
	public uint update_presence_interval;

	[Token(Token = "0x400A307")]
	[FieldOffset(Offset = "0x14")]
	public uint batch_update_counts;

	[Token(Token = "0x6008052")]
	[Address(RVA = "0x317B864", Offset = "0x317B864", VA = "0x317B864")]
	public BatchNotifyPresenceSwitchDesc()
	{
	}
}
