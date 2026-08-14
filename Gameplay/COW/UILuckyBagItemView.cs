using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200385C")]
public class UILuckyBagItemView : UIBaseView
{
	[Token(Token = "0x40171CD")]
	[FieldOffset(Offset = "0x14")]
	public Animator Anim;

	[Token(Token = "0x40171CE")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget widget;

	[Token(Token = "0x40171CF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LuckyBagMessage;

	[Token(Token = "0x40171D0")]
	[FieldOffset(Offset = "0x20")]
	public UIButton LuckyBagMessageBtn;

	[Token(Token = "0x40171D1")]
	[FieldOffset(Offset = "0x24")]
	public UIButton DrawBtn;

	[Token(Token = "0x40171D2")]
	[FieldOffset(Offset = "0x28")]
	public UISprite DrawBtnBG;

	[Token(Token = "0x40171D3")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel DrawBtnLabel;

	[Token(Token = "0x40171D4")]
	[FieldOffset(Offset = "0x30")]
	public UICountDownLabel ExpiredTime;

	[Token(Token = "0x40171D5")]
	[FieldOffset(Offset = "0x34")]
	public UIButton LuckyBag;

	[Token(Token = "0x40171D6")]
	[FieldOffset(Offset = "0x38")]
	public UISprite LuckyBagSprite;

	[Token(Token = "0x40171D7")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LuckBagName;

	[Token(Token = "0x40171D8")]
	[FieldOffset(Offset = "0x40")]
	public UILabel TakenNum;

	[Token(Token = "0x40171D9")]
	[FieldOffset(Offset = "0x44")]
	public UILabel TotalNum;

	[Token(Token = "0x6016CBF")]
	[Address(RVA = "0x2202AB4", Offset = "0x2202AB4", VA = "0x2202AB4")]
	public UILuckyBagItemView()
	{
	}

	[Token(Token = "0x6016CC0")]
	[Address(RVA = "0x2202ABC", Offset = "0x2202ABC", VA = "0x2202ABC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CC1")]
	[Address(RVA = "0x22030E4", Offset = "0x22030E4", VA = "0x22030E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
