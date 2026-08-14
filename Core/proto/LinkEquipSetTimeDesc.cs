using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B1D")]
public class LinkEquipSetTimeDesc
{
	[Token(Token = "0x400AA6F")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AA70")]
	[FieldOffset(Offset = "0xC")]
	public string start_time;

	[Token(Token = "0x400AA71")]
	[FieldOffset(Offset = "0x10")]
	public string end_time;

	[Token(Token = "0x400AA72")]
	[FieldOffset(Offset = "0x14")]
	public uint[] build_ids;

	[Token(Token = "0x400AA73")]
	[FieldOffset(Offset = "0x18")]
	public long start_timestamp;

	[Token(Token = "0x400AA74")]
	[FieldOffset(Offset = "0x20")]
	public long end_timestamp;

	[Token(Token = "0x6008178")]
	[Address(RVA = "0x30A4C70", Offset = "0x30A4C70", VA = "0x30A4C70")]
	public LinkEquipSetTimeDesc()
	{
	}
}
