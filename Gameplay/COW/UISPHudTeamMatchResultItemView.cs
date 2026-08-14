using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039DB")]
internal class UISPHudTeamMatchResultItemView : UIBaseView
{
	[Token(Token = "0x4018580")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4018581")]
	[FieldOffset(Offset = "0x18")]
	public UISprite RankIcon;

	[Token(Token = "0x4018582")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel RankTxt;

	[Token(Token = "0x4018583")]
	[FieldOffset(Offset = "0x20")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x4018584")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamFakeIcon;

	[Token(Token = "0x4018585")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TeamTxt;

	[Token(Token = "0x4018586")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel KillTxt;

	[Token(Token = "0x4018587")]
	[FieldOffset(Offset = "0x30")]
	public UILabel RankScoreTxt;

	[Token(Token = "0x4018588")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TotalScoreTxt;

	[Token(Token = "0x4018589")]
	[FieldOffset(Offset = "0x38")]
	public UISprite HighlightBg;

	[Token(Token = "0x6017137")]
	[Address(RVA = "0x14979E8", Offset = "0x14979E8", VA = "0x14979E8")]
	public UISPHudTeamMatchResultItemView()
	{
	}

	[Token(Token = "0x6017138")]
	[Address(RVA = "0x14979F0", Offset = "0x14979F0", VA = "0x14979F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017139")]
	[Address(RVA = "0x1497DD8", Offset = "0x1497DD8", VA = "0x1497DD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
