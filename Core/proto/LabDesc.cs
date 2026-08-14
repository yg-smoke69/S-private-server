using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C1D")]
public class LabDesc
{
	[Token(Token = "0x400B0F2")]
	[FieldOffset(Offset = "0x8")]
	public uint system_id;

	[Token(Token = "0x400B0F3")]
	[FieldOffset(Offset = "0xC")]
	public uint sort_id;

	[Token(Token = "0x400B0F4")]
	[FieldOffset(Offset = "0x10")]
	public long time_pre_start;

	[Token(Token = "0x400B0F5")]
	[FieldOffset(Offset = "0x18")]
	public long time_pre_end;

	[Token(Token = "0x400B0F6")]
	[FieldOffset(Offset = "0x20")]
	public long time_open_start;

	[Token(Token = "0x400B0F7")]
	[FieldOffset(Offset = "0x28")]
	public bool is_open;

	[Token(Token = "0x6008277")]
	[Address(RVA = "0x30A4324", Offset = "0x30A4324", VA = "0x30A4324")]
	public LabDesc()
	{
	}
}
