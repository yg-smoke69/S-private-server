using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003942")]
public class UIRankComparisonView : UIBaseView
{
	[Token(Token = "0x4017F52")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BgBtn;

	[Token(Token = "0x4017F53")]
	[FieldOffset(Offset = "0x18")]
	public UILabel titleTxt;

	[Token(Token = "0x4017F54")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ExtendFriendsTxt;

	[Token(Token = "0x4017F55")]
	[FieldOffset(Offset = "0x20")]
	public UISprite RankIcon;

	[Token(Token = "0x4017F56")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RankName;

	[Token(Token = "0x4017F57")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RankScore;

	[Token(Token = "0x4017F58")]
	[FieldOffset(Offset = "0x2C")]
	public ParticleSystem RankNormalEffect;

	[Token(Token = "0x4017F59")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid FriendsGrid;

	[Token(Token = "0x4017F5A")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget ItemContainer1;

	[Token(Token = "0x4017F5B")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget ItemContainer2;

	[Token(Token = "0x4017F5C")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget ItemContainer3;

	[Token(Token = "0x4017F5D")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget ItemContainer4;

	[Token(Token = "0x4017F5E")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget ItemContainer5;

	[Token(Token = "0x4017F5F")]
	[FieldOffset(Offset = "0x48")]
	public UIButton GotoBtn;

	[Token(Token = "0x4017F60")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid BtnGrid;

	[Token(Token = "0x4017F61")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ShowBtn;

	[Token(Token = "0x4017F62")]
	[FieldOffset(Offset = "0x54")]
	public UIButton ShareBtn;

	[Token(Token = "0x4017F63")]
	[FieldOffset(Offset = "0x58")]
	public UILabel closeTxt;

	[Token(Token = "0x4017F64")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ShareUI;

	[Token(Token = "0x4017F65")]
	[FieldOffset(Offset = "0x60")]
	public UISprite FreeFireLogo;

	[Token(Token = "0x6016F6D")]
	[Address(RVA = "0x1AC8020", Offset = "0x1AC8020", VA = "0x1AC8020")]
	public UIRankComparisonView()
	{
	}

	[Token(Token = "0x6016F6E")]
	[Address(RVA = "0x1AC8028", Offset = "0x1AC8028", VA = "0x1AC8028", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F6F")]
	[Address(RVA = "0x1AC88E4", Offset = "0x1AC88E4", VA = "0x1AC88E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
