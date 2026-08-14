using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019FB")]
public class BatchGroupPresenceSwitchDesc
{
	[Token(Token = "0x400A308")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A309")]
	[FieldOffset(Offset = "0xC")]
	public bool @switch;

	[Token(Token = "0x400A30A")]
	[FieldOffset(Offset = "0x10")]
	public uint update_presence_interval;

	[Token(Token = "0x400A30B")]
	[FieldOffset(Offset = "0x14")]
	public uint batch_update_counts;

	[Token(Token = "0x6008053")]
	[Address(RVA = "0x317B724", Offset = "0x317B724", VA = "0x317B724")]
	public BatchGroupPresenceSwitchDesc()
	{
	}
}
