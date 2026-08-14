using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E21")]
public class DropListConfigInfo
{
	[Token(Token = "0x4011A63")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4011A64")]
	[FieldOffset(Offset = "0xC")]
	public string LocKey;

	[Token(Token = "0x4011A65")]
	[FieldOffset(Offset = "0x10")]
	public string DescribeKey;

	[Token(Token = "0x4011A66")]
	[FieldOffset(Offset = "0x14")]
	public ERoom.DropPresetState UnlimitedAmmo;

	[Token(Token = "0x4011A67")]
	[FieldOffset(Offset = "0x18")]
	public ERoom.DropPresetState AirDrop;

	[Token(Token = "0x4011A68")]
	[FieldOffset(Offset = "0x1C")]
	public ERoom.DropPresetState Loadout;

	[Token(Token = "0x4011A69")]
	[FieldOffset(Offset = "0x20")]
	public ERoom.DropPresetState Vehicle;

	[Token(Token = "0x4011A6A")]
	[FieldOffset(Offset = "0x24")]
	public ERoom.DropPresetState Zeppelin;

	[Token(Token = "0x4011A6B")]
	[FieldOffset(Offset = "0x28")]
	public ERoom.DropPresetState BanGunSkinAttr;

	[Token(Token = "0x4011A6C")]
	[FieldOffset(Offset = "0x2C")]
	public ERoom.DropPresetState HideEnemyFashion;

	[Token(Token = "0x4011A6D")]
	[FieldOffset(Offset = "0x30")]
	public ERoom.DropPresetState FriendlyFire;

	[Token(Token = "0x4011A6E")]
	[FieldOffset(Offset = "0x34")]
	public ERoom.DropPresetState HideHud;

	[Token(Token = "0x4011A6F")]
	[FieldOffset(Offset = "0x38")]
	public uint Revival;

	[Token(Token = "0x4011A70")]
	[FieldOffset(Offset = "0x3C")]
	public ERoom.DropPresetState AutoRevival;

	[Token(Token = "0x4011A71")]
	[FieldOffset(Offset = "0x40")]
	public ERoom.DropPresetState SaveZoneSpeed;

	[Token(Token = "0x4011A72")]
	[FieldOffset(Offset = "0x44")]
	public ERoom.DropPresetState SaveZoneDamage;

	[Token(Token = "0x60134D6")]
	[Address(RVA = "0x1C980C8", Offset = "0x1C980C8", VA = "0x1C980C8")]
	public DropListConfigInfo()
	{
	}
}
