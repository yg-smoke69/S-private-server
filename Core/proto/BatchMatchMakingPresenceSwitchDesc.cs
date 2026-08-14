using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019FD")]
public class BatchMatchMakingPresenceSwitchDesc
{
	[Token(Token = "0x400A310")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A311")]
	[FieldOffset(Offset = "0xC")]
	public bool @switch;

	[Token(Token = "0x400A312")]
	[FieldOffset(Offset = "0x10")]
	public uint update_presence_interval;

	[Token(Token = "0x400A313")]
	[FieldOffset(Offset = "0x14")]
	public uint batch_update_counts;

	[Token(Token = "0x6008055")]
	[Address(RVA = "0x317B7C4", Offset = "0x317B7C4", VA = "0x317B7C4")]
	public BatchMatchMakingPresenceSwitchDesc()
	{
	}
}
