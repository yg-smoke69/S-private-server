using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E08")]
internal class PCClothConfigDataManager : SingletonModule<PCClothConfigDataManager>
{
	[Token(Token = "0x4011A1B")]
	[FieldOffset(Offset = "0xC")]
	public List<uint> MaleClothList;

	[Token(Token = "0x4011A1C")]
	[FieldOffset(Offset = "0x10")]
	public List<uint> FeMaleClothList;

	[Token(Token = "0x4011A1D")]
	[FieldOffset(Offset = "0x14")]
	public List<uint> WeaponSkinsList;

	[Token(Token = "0x4011A1E")]
	[FieldOffset(Offset = "0x18")]
	public uint DeadboxCollection;

	[Token(Token = "0x4011A1F")]
	[FieldOffset(Offset = "0x1C")]
	public uint ParachuteCollection;

	[Token(Token = "0x4011A20")]
	[FieldOffset(Offset = "0x20")]
	public uint SkyboardCollection;

	[Token(Token = "0x4011A21")]
	[FieldOffset(Offset = "0x24")]
	public uint FlightCollection;

	[Token(Token = "0x4011A22")]
	[FieldOffset(Offset = "0x28")]
	public uint BackPackCollection;

	[Token(Token = "0x4011A23")]
	[FieldOffset(Offset = "0x2C")]
	public List<uint> VehicleSkinList;

	[Token(Token = "0x4011A24")]
	public const int GRENADE_WEAPON_ID = 601;

	[Token(Token = "0x4011A25")]
	public const int SMOKEGRENADE_WEAPON_ID = 603;

	[Token(Token = "0x6013485")]
	[Address(RVA = "0x28C97F0", Offset = "0x28C97F0", VA = "0x28C97F0")]
	public PCClothConfigDataManager()
	{
	}

	[Token(Token = "0x6013486")]
	[Address(RVA = "0x28C9B2C", Offset = "0x28C9B2C", VA = "0x28C9B2C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6013487")]
	[Address(RVA = "0x28C9C84", Offset = "0x28C9C84", VA = "0x28C9C84", Slot = "6")]
	protected override void OnInit()
	{
	}
}
