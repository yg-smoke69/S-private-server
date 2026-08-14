using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BDC")]
public class WorkshopCustomModeTemplateRuleDesc
{
	[Token(Token = "0x400AF42")]
	[FieldOffset(Offset = "0x8")]
	public uint mode_index;

	[Token(Token = "0x400AF43")]
	[FieldOffset(Offset = "0xC")]
	public uint enable;

	[Token(Token = "0x400AF44")]
	[FieldOffset(Offset = "0x10")]
	public uint fall_back_index;

	[Token(Token = "0x400AF45")]
	[FieldOffset(Offset = "0x14")]
	public uint multi_team_enabled;

	[Token(Token = "0x400AF46")]
	[FieldOffset(Offset = "0x18")]
	public uint enabled_graph;

	[Token(Token = "0x400AF47")]
	[FieldOffset(Offset = "0x1C")]
	public uint enabled_hud;

	[Token(Token = "0x6008237")]
	[Address(RVA = "0x33E621C", Offset = "0x33E621C", VA = "0x33E621C")]
	public WorkshopCustomModeTemplateRuleDesc()
	{
	}
}
