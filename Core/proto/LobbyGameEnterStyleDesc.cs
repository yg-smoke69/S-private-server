using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019D4")]
public class LobbyGameEnterStyleDesc
{
	[Token(Token = "0x400A1FD")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x400A1FE")]
	[FieldOffset(Offset = "0xC")]
	public string start_time;

	[Token(Token = "0x400A1FF")]
	[FieldOffset(Offset = "0x10")]
	public string end_time;

	[Token(Token = "0x400A200")]
	[FieldOffset(Offset = "0x14")]
	public string lobby_start_icon;

	[Token(Token = "0x400A201")]
	[FieldOffset(Offset = "0x18")]
	public string lobby_start_vfx;

	[Token(Token = "0x400A202")]
	[FieldOffset(Offset = "0x1C")]
	public string lobby_start_fontcolor;

	[Token(Token = "0x400A203")]
	[FieldOffset(Offset = "0x20")]
	public string match_fontcolor;

	[Token(Token = "0x400A204")]
	[FieldOffset(Offset = "0x24")]
	public string lobby_mode_icon;

	[Token(Token = "0x400A205")]
	[FieldOffset(Offset = "0x28")]
	public string lobby_mode_vfx;

	[Token(Token = "0x400A206")]
	[FieldOffset(Offset = "0x2C")]
	public string mode_fontcolor;

	[Token(Token = "0x400A207")]
	[FieldOffset(Offset = "0x30")]
	public string mode_map_fontcolor;

	[Token(Token = "0x400A208")]
	[FieldOffset(Offset = "0x34")]
	public string mode_ranked_fontcolor;

	[Token(Token = "0x400A209")]
	[FieldOffset(Offset = "0x38")]
	public string mode_buff_fontcolor;

	[Token(Token = "0x400A20A")]
	[FieldOffset(Offset = "0x3C")]
	public string mode_buff_vfx;

	[Token(Token = "0x600802C")]
	[Address(RVA = "0x30A6718", Offset = "0x30A6718", VA = "0x30A6718")]
	public LobbyGameEnterStyleDesc()
	{
	}
}
