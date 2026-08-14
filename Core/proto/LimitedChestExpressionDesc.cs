using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BE6")]
public class LimitedChestExpressionDesc
{
	[Token(Token = "0x400AFA2")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400AFA3")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x400AFA4")]
	[FieldOffset(Offset = "0x10")]
	public uint chest_model_id;

	[Token(Token = "0x400AFA5")]
	[FieldOffset(Offset = "0x14")]
	public uint show_model_male;

	[Token(Token = "0x400AFA6")]
	[FieldOffset(Offset = "0x18")]
	public uint show_model_female;

	[Token(Token = "0x400AFA7")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] show_type;

	[Token(Token = "0x400AFA8")]
	[FieldOffset(Offset = "0x20")]
	public bool is_tab_vfx;

	[Token(Token = "0x6008241")]
	[Address(RVA = "0x30A48A8", Offset = "0x30A48A8", VA = "0x30A48A8")]
	public LimitedChestExpressionDesc()
	{
	}
}
