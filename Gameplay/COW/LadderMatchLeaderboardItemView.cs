using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003385")]
public class LadderMatchLeaderboardItemView : UIBaseView
{
	[Token(Token = "0x40139F9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x40139FA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject FirstCupIcon;

	[Token(Token = "0x40139FB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SecondCupIcon;

	[Token(Token = "0x40139FC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ThirdCupIcon;

	[Token(Token = "0x40139FD")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FirstBg;

	[Token(Token = "0x40139FE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SecondBg;

	[Token(Token = "0x40139FF")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ThirdBg;

	[Token(Token = "0x4013A00")]
	[FieldOffset(Offset = "0x30")]
	public UISprite NormalBg;

	[Token(Token = "0x4013A01")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabelNormalCup;

	[Token(Token = "0x4013A02")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelRankPoints;

	[Token(Token = "0x4013A03")]
	[FieldOffset(Offset = "0x3C")]
	public Transform ProfileContainer;

	[Token(Token = "0x4013A04")]
	[FieldOffset(Offset = "0x40")]
	public UISprite SelfBg;

	[Token(Token = "0x6015E46")]
	[Address(RVA = "0x1EF1B3C", Offset = "0x1EF1B3C", VA = "0x1EF1B3C")]
	public LadderMatchLeaderboardItemView()
	{
	}

	[Token(Token = "0x6015E47")]
	[Address(RVA = "0x1EF1B44", Offset = "0x1EF1B44", VA = "0x1EF1B44", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E48")]
	[Address(RVA = "0x1EF209C", Offset = "0x1EF209C", VA = "0x1EF209C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
