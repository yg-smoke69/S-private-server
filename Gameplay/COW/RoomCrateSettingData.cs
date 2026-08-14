using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200021B")]
public class RoomCrateSettingData : CSVBaseData
{
	[Token(Token = "0x4000C7B")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000C7C")]
	[FieldOffset(Offset = "0xC")]
	public uint GameMode;

	[Token(Token = "0x4000C7D")]
	[FieldOffset(Offset = "0x10")]
	public uint Environment;

	[Token(Token = "0x4000C7E")]
	[FieldOffset(Offset = "0x14")]
	public uint UnlimitedAmmoSwitch;

	[Token(Token = "0x4000C7F")]
	[FieldOffset(Offset = "0x18")]
	public uint FallDamage;

	[Token(Token = "0x4000C80")]
	[FieldOffset(Offset = "0x1C")]
	public uint LoadoutSwitch;

	[Token(Token = "0x4000C81")]
	[FieldOffset(Offset = "0x20")]
	public uint AirDropSwitch;

	[Token(Token = "0x4000C82")]
	[FieldOffset(Offset = "0x24")]
	public uint CharacterSkill;

	[Token(Token = "0x4000C83")]
	[FieldOffset(Offset = "0x28")]
	public uint CarDropSwitch;

	[Token(Token = "0x4000C84")]
	[FieldOffset(Offset = "0x2C")]
	public uint BanGunSkinAttr;

	[Token(Token = "0x4000C85")]
	[FieldOffset(Offset = "0x30")]
	public uint UAV;

	[Token(Token = "0x4000C86")]
	[FieldOffset(Offset = "0x34")]
	public uint Airstrike;

	[Token(Token = "0x4000C87")]
	[FieldOffset(Offset = "0x38")]
	public uint AirShipSwitch;

	[Token(Token = "0x4000C88")]
	[FieldOffset(Offset = "0x3C")]
	public uint HideEnemyFashion;

	[Token(Token = "0x4000C89")]
	[FieldOffset(Offset = "0x40")]
	public uint HideHud;

	[Token(Token = "0x4000C8A")]
	[FieldOffset(Offset = "0x44")]
	public uint FriendlyFire;

	[Token(Token = "0x4000C8B")]
	[FieldOffset(Offset = "0x48")]
	public uint PreciseAim;

	[Token(Token = "0x4000C8C")]
	[FieldOffset(Offset = "0x4C")]
	public uint SaveZoneSpeed;

	[Token(Token = "0x4000C8D")]
	[FieldOffset(Offset = "0x50")]
	public uint SaveZoneDamage;

	[Token(Token = "0x4000C8E")]
	[FieldOffset(Offset = "0x54")]
	public uint AutoRevival;

	[Token(Token = "0x6000ABE")]
	[Address(RVA = "0x240E8C4", Offset = "0x240E8C4", VA = "0x240E8C4")]
	public RoomCrateSettingData()
	{
	}

	[Token(Token = "0x6000ABF")]
	[Address(RVA = "0x240E948", Offset = "0x240E948", VA = "0x240E948", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000AC0")]
	[Address(RVA = "0x240ED60", Offset = "0x240ED60", VA = "0x240ED60", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AC1")]
	[Address(RVA = "0x240EDC4", Offset = "0x240EDC4", VA = "0x240EDC4")]
	public static bool IsHide(uint value)
	{
		return default(bool);
	}
}
