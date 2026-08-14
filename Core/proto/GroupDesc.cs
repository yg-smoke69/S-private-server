using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019F1")]
public class GroupDesc
{
	[Token(Token = "0x400A2D8")]
	[FieldOffset(Offset = "0x8")]
	public bool enable_region;

	[Token(Token = "0x400A2D9")]
	[FieldOffset(Offset = "0x9")]
	public bool enable_hacker_auto_group;

	[Token(Token = "0x400A2DA")]
	[FieldOffset(Offset = "0xC")]
	public uint idc_auto_group_timeout;

	[Token(Token = "0x400A2DB")]
	[FieldOffset(Offset = "0x10")]
	public uint kicked_player_cnt;

	[Token(Token = "0x6008049")]
	[Address(RVA = "0x30A2D44", Offset = "0x30A2D44", VA = "0x30A2D44")]
	public GroupDesc()
	{
	}
}
