using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BD9")]
public class WorkshopEditorChoiceDesc
{
	[Token(Token = "0x400AF2A")]
	[FieldOffset(Offset = "0x8")]
	public uint choice_id;

	[Token(Token = "0x400AF2B")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x400AF2C")]
	[FieldOffset(Offset = "0x10")]
	public uint type;

	[Token(Token = "0x400AF2D")]
	[FieldOffset(Offset = "0x14")]
	public uint order;

	[Token(Token = "0x400AF2E")]
	[FieldOffset(Offset = "0x18")]
	public string title;

	[Token(Token = "0x400AF2F")]
	[FieldOffset(Offset = "0x1C")]
	public string desc;

	[Token(Token = "0x400AF30")]
	[FieldOffset(Offset = "0x20")]
	public string cover_cdn;

	[Token(Token = "0x400AF31")]
	[FieldOffset(Offset = "0x24")]
	public string content_cdn;

	[Token(Token = "0x400AF32")]
	[FieldOffset(Offset = "0x28")]
	public string text;

	[Token(Token = "0x400AF33")]
	[FieldOffset(Offset = "0x2C")]
	public uint[] include_map_ids;

	[Token(Token = "0x400AF34")]
	[FieldOffset(Offset = "0x30")]
	public bool enable_direct_gopos;

	[Token(Token = "0x400AF35")]
	[FieldOffset(Offset = "0x34")]
	public string gopos;

	[Token(Token = "0x400AF36")]
	[FieldOffset(Offset = "0x38")]
	public string sub_gopos;

	[Token(Token = "0x400AF37")]
	[FieldOffset(Offset = "0x40")]
	public long shelf_time;

	[Token(Token = "0x400AF38")]
	[FieldOffset(Offset = "0x48")]
	public long under_time;

	[Token(Token = "0x6008234")]
	[Address(RVA = "0x33E622C", Offset = "0x33E622C", VA = "0x33E622C")]
	public WorkshopEditorChoiceDesc()
	{
	}
}
