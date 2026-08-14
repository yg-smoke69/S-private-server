using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001383")]
public class AwakenTask
{
	[Token(Token = "0x40089BD")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40089BE")]
	[FieldOffset(Offset = "0x10")]
	public uint avatar_id;

	[Token(Token = "0x40089BF")]
	[FieldOffset(Offset = "0x14")]
	public uint task_type;

	[Token(Token = "0x40089C0")]
	[FieldOffset(Offset = "0x18")]
	public uint data;

	[Token(Token = "0x40089C1")]
	[FieldOffset(Offset = "0x1C")]
	public EProfile.TaskState state;

	[Token(Token = "0x6007A84")]
	[Address(RVA = "0x317B2E4", Offset = "0x317B2E4", VA = "0x317B2E4")]
	public AwakenTask()
	{
	}
}
