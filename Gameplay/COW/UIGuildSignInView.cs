using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035BA")]
public class UIGuildSignInView : UIBaseView
{
	[Token(Token = "0x401580F")]
	[FieldOffset(Offset = "0x14")]
	public UISprite CurClanIcon;

	[Token(Token = "0x4015810")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CurLevelLabel;

	[Token(Token = "0x4015811")]
	[FieldOffset(Offset = "0x1C")]
	public Animation Animation;

	[Token(Token = "0x4015812")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid TopPivot;

	[Token(Token = "0x4015813")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid BottomPivot;

	[Token(Token = "0x4015814")]
	[FieldOffset(Offset = "0x28")]
	public UISprite NextClanIcon;

	[Token(Token = "0x4015815")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton NextClanBtn;

	[Token(Token = "0x4015816")]
	[FieldOffset(Offset = "0x30")]
	public UILabel NextLevelLabel;

	[Token(Token = "0x4015817")]
	[FieldOffset(Offset = "0x34")]
	public GameObject NextPageState;

	[Token(Token = "0x4015818")]
	[FieldOffset(Offset = "0x38")]
	public GameObject CurPageState;

	[Token(Token = "0x4015819")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ClaimTips;

	[Token(Token = "0x60164DC")]
	[Address(RVA = "0x20287C4", Offset = "0x20287C4", VA = "0x20287C4")]
	public UIGuildSignInView()
	{
	}

	[Token(Token = "0x60164DD")]
	[Address(RVA = "0x20287CC", Offset = "0x20287CC", VA = "0x20287CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164DE")]
	[Address(RVA = "0x2028D1C", Offset = "0x2028D1C", VA = "0x2028D1C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
