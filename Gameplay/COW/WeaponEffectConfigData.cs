using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000F3")]
public class WeaponEffectConfigData : CSVBaseData, _Attribute
{
	[Token(Token = "0x400061E")]
	[FieldOffset(Offset = "0x8")]
	public uint quality;

	[Token(Token = "0x400061F")]
	[FieldOffset(Offset = "0xC")]
	public uint effectMyHand;

	[Token(Token = "0x4000620")]
	[FieldOffset(Offset = "0x10")]
	public uint effectMyBack;

	[Token(Token = "0x4000621")]
	[FieldOffset(Offset = "0x14")]
	public uint effectTeammateHand;

	[Token(Token = "0x4000622")]
	[FieldOffset(Offset = "0x18")]
	public uint effectTeammateBack;

	[Token(Token = "0x4000623")]
	[FieldOffset(Offset = "0x1C")]
	public uint effectEnemyHand;

	[Token(Token = "0x4000624")]
	[FieldOffset(Offset = "0x20")]
	public uint effectEnemyBack;

	[Token(Token = "0x4000625")]
	[FieldOffset(Offset = "0x24")]
	public uint effectMyFire;

	[Token(Token = "0x4000626")]
	[FieldOffset(Offset = "0x28")]
	public uint effectTeammateFire;

	[Token(Token = "0x4000627")]
	[FieldOffset(Offset = "0x2C")]
	public uint effectEnemyFire;

	[Token(Token = "0x4000628")]
	[FieldOffset(Offset = "0x30")]
	public uint effectMyHit;

	[Token(Token = "0x4000629")]
	[FieldOffset(Offset = "0x34")]
	public uint effectTeammateHit;

	[Token(Token = "0x400062A")]
	[FieldOffset(Offset = "0x38")]
	public uint effectEnemyHit;

	[Token(Token = "0x400062B")]
	[FieldOffset(Offset = "0x3C")]
	public uint effectMyKill;

	[Token(Token = "0x400062C")]
	[FieldOffset(Offset = "0x40")]
	public uint effectTeammateKill;

	[Token(Token = "0x400062D")]
	[FieldOffset(Offset = "0x44")]
	public uint effectEnemyKill;

	[Token(Token = "0x400062E")]
	[FieldOffset(Offset = "0x48")]
	public uint effectMyAnnounce;

	[Token(Token = "0x400062F")]
	[FieldOffset(Offset = "0x4C")]
	public uint effectTeammateAnnounce;

	[Token(Token = "0x4000630")]
	[FieldOffset(Offset = "0x50")]
	public uint effectEnemyAnnounce;

	[Token(Token = "0x4000631")]
	[FieldOffset(Offset = "0x54")]
	public uint effectMyGunTrace;

	[Token(Token = "0x6000623")]
	[Address(RVA = "0x21A3B34", Offset = "0x21A3B34", VA = "0x21A3B34")]
	public WeaponEffectConfigData()
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0x21A3BB8", Offset = "0x21A3BB8", VA = "0x21A3BB8", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0x21A3C10", Offset = "0x21A3C10", VA = "0x21A3C10", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0x21A3C74", Offset = "0x21A3C74", VA = "0x21A3C74", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
