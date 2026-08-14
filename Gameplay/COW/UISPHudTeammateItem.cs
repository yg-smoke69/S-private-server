using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002292")]
internal class UISPHudTeammateItem : UIHudTeammateItem
{
	[Token(Token = "0x400D884")]
	[FieldOffset(Offset = "0x104")]
	public UISprite WeaponIcon;

	[Token(Token = "0x400D885")]
	[FieldOffset(Offset = "0x108")]
	public GameObject FiringGo;

	[Token(Token = "0x400D886")]
	[FieldOffset(Offset = "0x10C")]
	public UILabel killCount;

	[Token(Token = "0x400D887")]
	[FieldOffset(Offset = "0x110")]
	public GameObject ReviveGo;

	[Token(Token = "0x400D888")]
	[FieldOffset(Offset = "0x114")]
	private int weapon_origin_width;

	[Token(Token = "0x400D889")]
	[FieldOffset(Offset = "0x118")]
	private int weapon_origin_height;

	[Token(Token = "0x400D88A")]
	[FieldOffset(Offset = "0x11C")]
	private Player m_Player;

	[Token(Token = "0x400D88B")]
	[FieldOffset(Offset = "0x120")]
	private readonly Color HP_COLOR_NORMAL;

	[Token(Token = "0x400D88C")]
	[FieldOffset(Offset = "0x130")]
	private readonly Color HP_COLOR_KNOCK_DOWN;

	[Token(Token = "0x400D88D")]
	[FieldOffset(Offset = "0x140")]
	private readonly Color NAME_COLOR_NORMAL;

	[Token(Token = "0x400D88E")]
	[FieldOffset(Offset = "0x150")]
	private readonly Color NAME_COLOR_DEAD;

	[Token(Token = "0x600BD9C")]
	[Address(RVA = "0x149B698", Offset = "0x149B698", VA = "0x149B698")]
	public UISPHudTeammateItem()
	{
	}

	[Token(Token = "0x600BD9D")]
	[Address(RVA = "0x149B748", Offset = "0x149B748", VA = "0x149B748")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BD9E")]
	[Address(RVA = "0x149B890", Offset = "0x149B890", VA = "0x149B890")]
	public void UpdatePlayerKillCount(uint count)
	{
	}

	[Token(Token = "0x600BD9F")]
	[Address(RVA = "0x149B934", Offset = "0x149B934", VA = "0x149B934", Slot = "4")]
	public override void InitInfo(Player p)
	{
	}

	[Token(Token = "0x600BDA0")]
	[Address(RVA = "0x149CC0C", Offset = "0x149CC0C", VA = "0x149CC0C", Slot = "5")]
	public override void InitInfo(MatchTeam.MNJIFKDNEKI p)
	{
	}

	[Token(Token = "0x600BDA1")]
	[Address(RVA = "0x149D0E4", Offset = "0x149D0E4", VA = "0x149D0E4", Slot = "6")]
	public override void InitWithPlayerInfo(MNJIFKDNEKI playerInfo)
	{
	}

	[Token(Token = "0x600BDA2")]
	[Address(RVA = "0x149BEB0", Offset = "0x149BEB0", VA = "0x149BEB0")]
	public void UpdateWeaponInfo(Player p)
	{
	}

	[Token(Token = "0x600BDA3")]
	[Address(RVA = "0x149C9AC", Offset = "0x149C9AC", VA = "0x149C9AC")]
	private void InitFiring(Player p)
	{
	}

	[Token(Token = "0x600BDA4")]
	[Address(RVA = "0x149D3FC", Offset = "0x149D3FC", VA = "0x149D3FC", Slot = "7")]
	public override void SetReviveInfo()
	{
	}

	[Token(Token = "0x600BDA5")]
	[Address(RVA = "0x149D324", Offset = "0x149D324", VA = "0x149D324")]
	public void SetFireEffect(bool firing)
	{
	}

	[Token(Token = "0x600BDA6")]
	[Address(RVA = "0x149D81C", Offset = "0x149D81C", VA = "0x149D81C")]
	public void OnKnockDownStateChanged(bool isDown)
	{
	}

	[Token(Token = "0x600BDA7")]
	[Address(RVA = "0x149D964", Offset = "0x149D964", VA = "0x149D964", Slot = "8")]
	public override void OnHPChanged(Player p)
	{
	}

	[Token(Token = "0x600BDA8")]
	[Address(RVA = "0x149D8C8", Offset = "0x149D8C8", VA = "0x149D8C8")]
	private Color GetHPColor(bool isDieing)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x600BDA9")]
	[Address(RVA = "0x149DB7C", Offset = "0x149DB7C", VA = "0x149DB7C")]
	public void OnPlayerDead()
	{
	}

	[Token(Token = "0x600BDAA")]
	[Address(RVA = "0x149DC24", Offset = "0x149DC24", VA = "0x149DC24")]
	public void OnPlayerRevive()
	{
	}

	[Token(Token = "0x600BDAB")]
	[Address(RVA = "0x149CB30", Offset = "0x149CB30", VA = "0x149CB30")]
	public void SetNameColor(bool isDead)
	{
	}

	[Token(Token = "0x600BDAC")]
	[Address(RVA = "0x149DCCC", Offset = "0x149DCCC", VA = "0x149DCCC", Slot = "9")]
	protected override void InitModeRelatedInfo(Player p)
	{
	}

	[Token(Token = "0x600BDAD")]
	[Address(RVA = "0x149DD28", Offset = "0x149DD28", VA = "0x149DD28", Slot = "11")]
	public override void RepositionKnockInfo()
	{
	}

	[Token(Token = "0x600BDAE")]
	[Address(RVA = "0x149E398", Offset = "0x149E398", VA = "0x149E398")]
	public void _003C_003EiFixBaseProxy_InitInfo(Player P0)
	{
	}

	[Token(Token = "0x600BDAF")]
	[Address(RVA = "0x149E3A0", Offset = "0x149E3A0", VA = "0x149E3A0")]
	public void _003C_003EiFixBaseProxy_InitInfo(MatchTeam.MNJIFKDNEKI P0)
	{
	}

	[Token(Token = "0x600BDB0")]
	[Address(RVA = "0x149E3A8", Offset = "0x149E3A8", VA = "0x149E3A8")]
	public void _003C_003EiFixBaseProxy_InitWithPlayerInfo(MNJIFKDNEKI P0)
	{
	}

	[Token(Token = "0x600BDB1")]
	[Address(RVA = "0x149E3B0", Offset = "0x149E3B0", VA = "0x149E3B0")]
	public void _003C_003EiFixBaseProxy_SetReviveInfo()
	{
	}

	[Token(Token = "0x600BDB2")]
	[Address(RVA = "0x149E3B8", Offset = "0x149E3B8", VA = "0x149E3B8")]
	public void _003C_003EiFixBaseProxy_OnHPChanged(Player P0)
	{
	}

	[Token(Token = "0x600BDB3")]
	[Address(RVA = "0x149E3C0", Offset = "0x149E3C0", VA = "0x149E3C0")]
	public void _003C_003EiFixBaseProxy_InitModeRelatedInfo(Player P0)
	{
	}

	[Token(Token = "0x600BDB4")]
	[Address(RVA = "0x149E3C8", Offset = "0x149E3C8", VA = "0x149E3C8")]
	public void _003C_003EiFixBaseProxy_RepositionKnockInfo()
	{
	}
}
