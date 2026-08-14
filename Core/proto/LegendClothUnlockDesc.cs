using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019BF")]
public class LegendClothUnlockDesc
{
	[Token(Token = "0x400A156")]
	[FieldOffset(Offset = "0x8")]
	public uint set_id;

	[Token(Token = "0x400A157")]
	[FieldOffset(Offset = "0xC")]
	public uint unlock_level;

	[Token(Token = "0x400A158")]
	[FieldOffset(Offset = "0x10")]
	public uint legend_cloth_id;

	[Token(Token = "0x400A159")]
	[FieldOffset(Offset = "0x14")]
	public EInventory.LegendClothCdtType cdt_type;

	[Token(Token = "0x400A15A")]
	[FieldOffset(Offset = "0x18")]
	public uint cdt_value;

	[Token(Token = "0x400A15B")]
	[FieldOffset(Offset = "0x1C")]
	public uint unlock_lead_emote;

	[Token(Token = "0x400A15C")]
	[FieldOffset(Offset = "0x20")]
	public uint unlock_booyah_emote;

	[Token(Token = "0x400A15D")]
	[FieldOffset(Offset = "0x24")]
	public uint arrive_anim_id;

	[Token(Token = "0x400A15E")]
	[FieldOffset(Offset = "0x28")]
	public uint collection_transform_id;

	[Token(Token = "0x6008017")]
	[Address(RVA = "0x30A4464", Offset = "0x30A4464", VA = "0x30A4464")]
	public LegendClothUnlockDesc()
	{
	}
}
