using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200199E")]
public class ClothesDesc
{
	[Token(Token = "0x400A0B3")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A0B4")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.ClothesType type;

	[Token(Token = "0x400A0B5")]
	[FieldOffset(Offset = "0x10")]
	public bool is_default;

	[Token(Token = "0x400A0B6")]
	[FieldOffset(Offset = "0x11")]
	public bool is_selected;

	[Token(Token = "0x400A0B7")]
	[FieldOffset(Offset = "0x14")]
	public uint avatar_id;

	[Token(Token = "0x400A0B8")]
	[FieldOffset(Offset = "0x18")]
	public uint cloth_set_id;

	[Token(Token = "0x400A0B9")]
	[FieldOffset(Offset = "0x1C")]
	public string team_effect_male;

	[Token(Token = "0x400A0BA")]
	[FieldOffset(Offset = "0x20")]
	public string team_effect_female;

	[Token(Token = "0x6007FF5")]
	[Address(RVA = "0x309CB14", Offset = "0x309CB14", VA = "0x309CB14")]
	public ClothesDesc()
	{
	}
}
