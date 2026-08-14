using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003699")]
public class UIHudLuckyDrawBoxView : UIBaseView
{
	[Token(Token = "0x4015F77")]
	[FieldOffset(Offset = "0x14")]
	public UIButton RefreshBtn;

	[Token(Token = "0x4015F78")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RefreshPrice;

	[Token(Token = "0x4015F79")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BuyPrice;

	[Token(Token = "0x4015F7A")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid ItemGrid;

	[Token(Token = "0x4015F7B")]
	[FieldOffset(Offset = "0x24")]
	public UIButton CloseBtn;

	[Token(Token = "0x4015F7C")]
	[FieldOffset(Offset = "0x28")]
	public UISprite LevelBg;

	[Token(Token = "0x4015F7D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Level;

	[Token(Token = "0x4015F7E")]
	[FieldOffset(Offset = "0x30")]
	public UILabel CountDownDesc;

	[Token(Token = "0x4015F7F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject NormalRefreshVfx;

	[Token(Token = "0x4015F80")]
	[FieldOffset(Offset = "0x38")]
	public GameObject LevelUpRefreshVfx;

	[Token(Token = "0x4015F81")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget GuideWidget;

	[Token(Token = "0x4015F82")]
	[FieldOffset(Offset = "0x40")]
	public UIButton GuideBtn;

	[Token(Token = "0x4015F83")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BuyBtn;

	[Token(Token = "0x4015F84")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget BuyBtnWidget;

	[Token(Token = "0x4015F85")]
	[FieldOffset(Offset = "0x4C")]
	public ParticleSystem LevelUpRefreshVfx1;

	[Token(Token = "0x4015F86")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem LevelUpRefreshVfx2;

	[Token(Token = "0x4015F87")]
	[FieldOffset(Offset = "0x54")]
	public ParticleSystem LevelUpRefreshVfx3;

	[Token(Token = "0x6016778")]
	[Address(RVA = "0xFF3490", Offset = "0xFF3490", VA = "0xFF3490")]
	public UIHudLuckyDrawBoxView()
	{
	}

	[Token(Token = "0x6016779")]
	[Address(RVA = "0xFF3498", Offset = "0xFF3498", VA = "0xFF3498", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601677A")]
	[Address(RVA = "0xFF3C28", Offset = "0xFF3C28", VA = "0xFF3C28")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
