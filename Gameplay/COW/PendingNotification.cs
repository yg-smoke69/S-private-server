using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D18")]
public class PendingNotification
{
	[Token(Token = "0x4011362")]
	[FieldOffset(Offset = "0x8")]
	public IHAAMHPPLMG KillerId;

	[Token(Token = "0x4011363")]
	[FieldOffset(Offset = "0x20")]
	public string m_KillerName;

	[Token(Token = "0x4011364")]
	[FieldOffset(Offset = "0x0")]
	public static string EllipsisName;

	[Token(Token = "0x4011365")]
	[FieldOffset(Offset = "0x24")]
	public string m_BeKilledName;

	[Token(Token = "0x4011366")]
	[FieldOffset(Offset = "0x28")]
	public string WeaponName;

	[Token(Token = "0x4011367")]
	[FieldOffset(Offset = "0x2C")]
	public string KillerNameColor;

	[Token(Token = "0x4011368")]
	[FieldOffset(Offset = "0x30")]
	public string BeKilledNameColor;

	[Token(Token = "0x4011369")]
	[FieldOffset(Offset = "0x34")]
	public bool ShowKillBonus;

	[Token(Token = "0x401136A")]
	[FieldOffset(Offset = "0x38")]
	public string BattleInfo;

	[Token(Token = "0x401136B")]
	[FieldOffset(Offset = "0x3C")]
	public EPendingNotificationType InfoType;

	[Token(Token = "0x401136C")]
	[FieldOffset(Offset = "0x40")]
	public uint SkinItemId;

	[Token(Token = "0x401136D")]
	[FieldOffset(Offset = "0x44")]
	public uint WeaponID;

	[Token(Token = "0x401136E")]
	[FieldOffset(Offset = "0x48")]
	public float DefaultVisibleTime;

	[Token(Token = "0x401136F")]
	[FieldOffset(Offset = "0x4C")]
	public uint KillerRole;

	[Token(Token = "0x4011370")]
	[FieldOffset(Offset = "0x50")]
	public uint BeKilledRole;

	[Token(Token = "0x4011371")]
	[FieldOffset(Offset = "0x54")]
	public bool KillerHasEP;

	[Token(Token = "0x4011372")]
	[FieldOffset(Offset = "0x55")]
	public bool VictimHasEP;

	[Token(Token = "0x17001354")]
	public string KillerName
	{
		[Token(Token = "0x6012DA3")]
		[Address(RVA = "0x2DDF154", Offset = "0x2DDF154", VA = "0x2DDF154")]
		get
		{
			return null;
		}
		[Token(Token = "0x6012DA2")]
		[Address(RVA = "0x2DDF0F4", Offset = "0x2DDF0F4", VA = "0x2DDF0F4")]
		set
		{
		}
	}

	[Token(Token = "0x17001355")]
	public string BeKilledName
	{
		[Token(Token = "0x6012DA5")]
		[Address(RVA = "0x2DDF474", Offset = "0x2DDF474", VA = "0x2DDF474")]
		get
		{
			return null;
		}
		[Token(Token = "0x6012DA4")]
		[Address(RVA = "0x2DDF414", Offset = "0x2DDF414", VA = "0x2DDF414")]
		set
		{
		}
	}

	[Token(Token = "0x6012DA1")]
	[Address(RVA = "0x2DDEFB8", Offset = "0x2DDEFB8", VA = "0x2DDEFB8")]
	public PendingNotification()
	{
	}

	[Token(Token = "0x6012DA6")]
	[Address(RVA = "0x2DDF734", Offset = "0x2DDF734", VA = "0x2DDF734")]
	public void Reset()
	{
	}
}
