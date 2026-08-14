using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015B3")]
public class SelectedItems
{
	[Token(Token = "0x40093F0")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x40093F1")]
	[FieldOffset(Offset = "0xC")]
	public uint skin_color;

	[Token(Token = "0x40093F2")]
	[FieldOffset(Offset = "0x10")]
	public uint[] clothes;

	[Token(Token = "0x40093F3")]
	[FieldOffset(Offset = "0x14")]
	public List<LoadoutInfo> loadouts;

	[Token(Token = "0x40093F4")]
	[FieldOffset(Offset = "0x18")]
	public uint banner_id;

	[Token(Token = "0x40093F5")]
	[FieldOffset(Offset = "0x1C")]
	public uint head_pic;

	[Token(Token = "0x40093F6")]
	[FieldOffset(Offset = "0x20")]
	public uint[] slots;

	[Token(Token = "0x40093F7")]
	[FieldOffset(Offset = "0x24")]
	public ChoosedEmotes emotes;

	[Token(Token = "0x40093F8")]
	[FieldOffset(Offset = "0x28")]
	public uint[] shows;

	[Token(Token = "0x40093F9")]
	[FieldOffset(Offset = "0x2C")]
	public uint pve_primary_weapon_skin;

	[Token(Token = "0x40093FA")]
	[FieldOffset(Offset = "0x30")]
	public uint[] ranking_cards;

	[Token(Token = "0x40093FB")]
	[FieldOffset(Offset = "0x34")]
	public uint pin_id;

	[Token(Token = "0x40093FC")]
	[FieldOffset(Offset = "0x38")]
	public uint game_bag_show;

	[Token(Token = "0x40093FD")]
	[FieldOffset(Offset = "0x3C")]
	public List<RandomSlotInfo> random_slots;

	[Token(Token = "0x6007BFD")]
	[Address(RVA = "0x33E2134", Offset = "0x33E2134", VA = "0x33E2134")]
	public SelectedItems()
	{
	}
}
