using COW.GamePlay;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200228A")]
internal class SPGameAchievement
{
	[Token(Token = "0x400D855")]
	[FieldOffset(Offset = "0x8")]
	public IHAAMHPPLMG killerId;

	[Token(Token = "0x400D856")]
	[FieldOffset(Offset = "0x20")]
	public string killerName;

	[Token(Token = "0x400D857")]
	[FieldOffset(Offset = "0x28")]
	public ulong killlerUserID;

	[Token(Token = "0x400D858")]
	[FieldOffset(Offset = "0x30")]
	public string killerTeam;

	[Token(Token = "0x400D859")]
	[FieldOffset(Offset = "0x34")]
	public uint KillerIcon;

	[Token(Token = "0x400D85A")]
	[FieldOffset(Offset = "0x38")]
	public uint KillerKillCount;

	[Token(Token = "0x400D85B")]
	[FieldOffset(Offset = "0x3C")]
	public uint TeamKillCount;

	[Token(Token = "0x400D85C")]
	[FieldOffset(Offset = "0x40")]
	public IHAAMHPPLMG beKilledId;

	[Token(Token = "0x400D85D")]
	[FieldOffset(Offset = "0x58")]
	public string beKilledName;

	[Token(Token = "0x400D85E")]
	[FieldOffset(Offset = "0x5C")]
	public string beKilledTeam;

	[Token(Token = "0x400D85F")]
	[FieldOffset(Offset = "0x60")]
	public uint beKilledIcon;

	[Token(Token = "0x400D860")]
	[FieldOffset(Offset = "0x64")]
	public string weaponName;

	[Token(Token = "0x400D861")]
	[FieldOffset(Offset = "0x68")]
	public ABDONPHCKLK type;

	[Token(Token = "0x600BD6A")]
	[Address(RVA = "0x241DF04", Offset = "0x241DF04", VA = "0x241DF04")]
	public SPGameAchievement()
	{
	}
}
