using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039CA")]
public class UISPHudRankListItemView : UIBaseView
{
	[Token(Token = "0x40184F8")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget UISPHudRankListItem;

	[Token(Token = "0x40184F9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RankLabel;

	[Token(Token = "0x40184FA")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Grade1;

	[Token(Token = "0x40184FB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Grade2;

	[Token(Token = "0x40184FC")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Grade3;

	[Token(Token = "0x40184FD")]
	[FieldOffset(Offset = "0x28")]
	public UISprite TeamIcon;

	[Token(Token = "0x40184FE")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite FakeIcon;

	[Token(Token = "0x40184FF")]
	[FieldOffset(Offset = "0x30")]
	public UILabel TeamName;

	[Token(Token = "0x4018500")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ScoreLabel;

	[Token(Token = "0x6017104")]
	[Address(RVA = "0x1D28760", Offset = "0x1D28760", VA = "0x1D28760")]
	public UISPHudRankListItemView()
	{
	}

	[Token(Token = "0x6017105")]
	[Address(RVA = "0x1D28768", Offset = "0x1D28768", VA = "0x1D28768", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017106")]
	[Address(RVA = "0x1D28AEC", Offset = "0x1D28AEC", VA = "0x1D28AEC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
