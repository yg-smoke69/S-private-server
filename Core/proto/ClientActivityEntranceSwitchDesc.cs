using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001614")]
public class ClientActivityEntranceSwitchDesc
{
	[Token(Token = "0x40094F5")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x40094F6")]
	[FieldOffset(Offset = "0x10")]
	public long show_time;

	[Token(Token = "0x40094F7")]
	[FieldOffset(Offset = "0x18")]
	public long start_time_stamp;

	[Token(Token = "0x40094F8")]
	[FieldOffset(Offset = "0x20")]
	public long end_time_stamp;

	[Token(Token = "0x40094F9")]
	[FieldOffset(Offset = "0x28")]
	public string go_url;

	[Token(Token = "0x40094FA")]
	[FieldOffset(Offset = "0x2C")]
	public uint go_pos;

	[Token(Token = "0x40094FB")]
	[FieldOffset(Offset = "0x30")]
	public string cdn_url;

	[Token(Token = "0x40094FC")]
	[FieldOffset(Offset = "0x34")]
	public string tip_cdn_url;

	[Token(Token = "0x40094FD")]
	[FieldOffset(Offset = "0x38")]
	public string start_time;

	[Token(Token = "0x40094FE")]
	[FieldOffset(Offset = "0x3C")]
	public string end_time;

	[Token(Token = "0x6007C5E")]
	[Address(RVA = "0x309C5E0", Offset = "0x309C5E0", VA = "0x309C5E0")]
	public ClientActivityEntranceSwitchDesc()
	{
	}
}
