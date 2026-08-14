using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039DE")]
public class UISPHudTeamRankingItemView : UIBaseView
{
	[Token(Token = "0x40185B1")]
	[FieldOffset(Offset = "0x14")]
	public GameObject DeadBg;

	[Token(Token = "0x40185B2")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget TeamIconGo;

	[Token(Token = "0x40185B3")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x40185B4")]
	[FieldOffset(Offset = "0x20")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x40185B5")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamBg;

	[Token(Token = "0x40185B6")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TeamId;

	[Token(Token = "0x40185B7")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Name;

	[Token(Token = "0x40185B8")]
	[FieldOffset(Offset = "0x30")]
	public UISprite P1;

	[Token(Token = "0x40185B9")]
	[FieldOffset(Offset = "0x34")]
	public UISprite P2;

	[Token(Token = "0x40185BA")]
	[FieldOffset(Offset = "0x38")]
	public UISprite P3;

	[Token(Token = "0x40185BB")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite P4;

	[Token(Token = "0x40185BC")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LiveCnt;

	[Token(Token = "0x40185BD")]
	[FieldOffset(Offset = "0x44")]
	public UILabel KillCnt;

	[Token(Token = "0x40185BE")]
	[FieldOffset(Offset = "0x48")]
	public UILabel CombatLevel;

	[Token(Token = "0x6017140")]
	[Address(RVA = "0x1499AF0", Offset = "0x1499AF0", VA = "0x1499AF0")]
	public UISPHudTeamRankingItemView()
	{
	}

	[Token(Token = "0x6017141")]
	[Address(RVA = "0x1499AF8", Offset = "0x1499AF8", VA = "0x1499AF8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017142")]
	[Address(RVA = "0x149A020", Offset = "0x149A020", VA = "0x149A020")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
