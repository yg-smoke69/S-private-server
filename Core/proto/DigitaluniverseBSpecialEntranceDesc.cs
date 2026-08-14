using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B68")]
public class DigitaluniverseBSpecialEntranceDesc
{
	[Token(Token = "0x400AC70")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AC71")]
	[FieldOffset(Offset = "0x10")]
	public long start_time;

	[Token(Token = "0x400AC72")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400AC73")]
	[FieldOffset(Offset = "0x20")]
	public string vfx_url;

	[Token(Token = "0x60081C3")]
	[Address(RVA = "0x309ECF0", Offset = "0x309ECF0", VA = "0x309ECF0")]
	public DigitaluniverseBSpecialEntranceDesc()
	{
	}
}
