using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001615")]
public class ClientActivityBingoInfoDesc
{
	[Token(Token = "0x40094FF")]
	[FieldOffset(Offset = "0x8")]
	public uint level;

	[Token(Token = "0x4009500")]
	[FieldOffset(Offset = "0xC")]
	public uint key_id;

	[Token(Token = "0x4009501")]
	[FieldOffset(Offset = "0x10")]
	public uint init_key_num;

	[Token(Token = "0x4009502")]
	[FieldOffset(Offset = "0x14")]
	public uint cost_key_num;

	[Token(Token = "0x4009503")]
	[FieldOffset(Offset = "0x18")]
	public uint cost_diamond;

	[Token(Token = "0x4009504")]
	[FieldOffset(Offset = "0x20")]
	public long start_time;

	[Token(Token = "0x4009505")]
	[FieldOffset(Offset = "0x28")]
	public long end_time;

	[Token(Token = "0x6007C5F")]
	[Address(RVA = "0x309C46C", Offset = "0x309C46C", VA = "0x309C46C")]
	public ClientActivityBingoInfoDesc()
	{
	}
}
