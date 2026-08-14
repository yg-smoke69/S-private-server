using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BDA")]
public class WorkshopMapEditorChoiceDesc
{
	[Token(Token = "0x400AF39")]
	[FieldOffset(Offset = "0x8")]
	public uint map_id;

	[Token(Token = "0x400AF3A")]
	[FieldOffset(Offset = "0xC")]
	public string map_code;

	[Token(Token = "0x400AF3B")]
	[FieldOffset(Offset = "0x10")]
	public uint order;

	[Token(Token = "0x400AF3C")]
	[FieldOffset(Offset = "0x14")]
	public string picture;

	[Token(Token = "0x400AF3D")]
	[FieldOffset(Offset = "0x18")]
	public long shelf_time;

	[Token(Token = "0x400AF3E")]
	[FieldOffset(Offset = "0x20")]
	public long under_time;

	[Token(Token = "0x6008235")]
	[Address(RVA = "0x33E6714", Offset = "0x33E6714", VA = "0x33E6714")]
	public WorkshopMapEditorChoiceDesc()
	{
	}
}
