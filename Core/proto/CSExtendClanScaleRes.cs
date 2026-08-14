using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001637")]
public class CSExtendClanScaleRes
{
	[Token(Token = "0x400956F")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x4009570")]
	[FieldOffset(Offset = "0x10")]
	public uint capacity;

	[Token(Token = "0x4009571")]
	[FieldOffset(Offset = "0x14")]
	public uint extended_times;

	[Token(Token = "0x6007C81")]
	[Address(RVA = "0x317FF54", Offset = "0x317FF54", VA = "0x317FF54")]
	public CSExtendClanScaleRes()
	{
	}
}
