using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200199F")]
public class AvatarDesc
{
	[Token(Token = "0x400A0BB")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A0BC")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.GenderType gender;

	[Token(Token = "0x400A0BD")]
	[FieldOffset(Offset = "0x10")]
	public bool is_default;

	[Token(Token = "0x400A0BE")]
	[FieldOffset(Offset = "0x11")]
	public bool is_selected;

	[Token(Token = "0x400A0BF")]
	[FieldOffset(Offset = "0x12")]
	public bool can_change_skin_color;

	[Token(Token = "0x400A0C0")]
	[FieldOffset(Offset = "0x14")]
	public uint pve_primary_weapon;

	[Token(Token = "0x400A0C1")]
	[FieldOffset(Offset = "0x18")]
	public bool head_additive_switch;

	[Token(Token = "0x400A0C2")]
	[FieldOffset(Offset = "0x1C")]
	public EInventory.AvatarType avatar_type;

	[Token(Token = "0x6007FF6")]
	[Address(RVA = "0x317B16C", Offset = "0x317B16C", VA = "0x317B16C")]
	public AvatarDesc()
	{
	}
}
