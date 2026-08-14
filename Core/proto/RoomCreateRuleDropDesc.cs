using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019F4")]
public class RoomCreateRuleDropDesc
{
	[Token(Token = "0x400A2E7")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A2E8")]
	[FieldOffset(Offset = "0xC")]
	public string suffix;

	[Token(Token = "0x400A2E9")]
	[FieldOffset(Offset = "0x10")]
	public uint room_type;

	[Token(Token = "0x400A2EA")]
	[FieldOffset(Offset = "0x14")]
	public string loc_key;

	[Token(Token = "0x400A2EB")]
	[FieldOffset(Offset = "0x18")]
	public ERoom.DropPresetState unlimited_ammo_switch;

	[Token(Token = "0x400A2EC")]
	[FieldOffset(Offset = "0x1C")]
	public ERoom.DropPresetState air_drop_switch;

	[Token(Token = "0x400A2ED")]
	[FieldOffset(Offset = "0x20")]
	public ERoom.DropPresetState loadout_switch;

	[Token(Token = "0x400A2EE")]
	[FieldOffset(Offset = "0x24")]
	public ERoom.DropPresetState car_drop_switch;

	[Token(Token = "0x400A2EF")]
	[FieldOffset(Offset = "0x28")]
	public uint drop_type;

	[Token(Token = "0x400A2F0")]
	[FieldOffset(Offset = "0x2C")]
	public ERoom.DropPresetState air_ship_switch;

	[Token(Token = "0x400A2F1")]
	[FieldOffset(Offset = "0x30")]
	public ERoom.DropPresetState ban_gun_skin_attr;

	[Token(Token = "0x400A2F2")]
	[FieldOffset(Offset = "0x34")]
	public ERoom.DropPresetState hide_enemy_fashion;

	[Token(Token = "0x400A2F3")]
	[FieldOffset(Offset = "0x38")]
	public ERoom.DropPresetState friendly_fire;

	[Token(Token = "0x400A2F4")]
	[FieldOffset(Offset = "0x3C")]
	public ERoom.DropPresetState hide_hud;

	[Token(Token = "0x400A2F5")]
	[FieldOffset(Offset = "0x40")]
	public uint revival;

	[Token(Token = "0x400A2F6")]
	[FieldOffset(Offset = "0x44")]
	public string describe_key;

	[Token(Token = "0x400A2F7")]
	[FieldOffset(Offset = "0x48")]
	public ERoom.DropPresetState save_zone_speed;

	[Token(Token = "0x400A2F8")]
	[FieldOffset(Offset = "0x4C")]
	public ERoom.DropPresetState save_zone_damage;

	[Token(Token = "0x400A2F9")]
	[FieldOffset(Offset = "0x50")]
	public ERoom.DropPresetState auto_revival;

	[Token(Token = "0x600804C")]
	[Address(RVA = "0x33E1C10", Offset = "0x33E1C10", VA = "0x33E1C10")]
	public RoomCreateRuleDropDesc()
	{
	}
}
