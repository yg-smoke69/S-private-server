using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036CB")]
public class UIHudObserverProfileView : UIBaseView
{
	[Token(Token = "0x40161D9")]
	[FieldOffset(Offset = "0x14")]
	public GameObject normalContainer;

	[Token(Token = "0x40161DA")]
	[FieldOffset(Offset = "0x18")]
	public UILabel name;

	[Token(Token = "0x40161DB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject profileContainer;

	[Token(Token = "0x40161DC")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnReport;

	[Token(Token = "0x40161DD")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ReportIcon;

	[Token(Token = "0x40161DE")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnDrop;

	[Token(Token = "0x40161DF")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnRevive;

	[Token(Token = "0x40161E0")]
	[FieldOffset(Offset = "0x30")]
	public UICountDownLabel ReviveCountDown;

	[Token(Token = "0x40161E1")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ReviveLabel;

	[Token(Token = "0x40161E2")]
	[FieldOffset(Offset = "0x38")]
	public UILabel playerId;

	[Token(Token = "0x40161E3")]
	[FieldOffset(Offset = "0x3C")]
	public Animator Ani_LikeContainer;

	[Token(Token = "0x40161E4")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnLike;

	[Token(Token = "0x40161E5")]
	[FieldOffset(Offset = "0x44")]
	public UISprite LikeIcon;

	[Token(Token = "0x40161E6")]
	[FieldOffset(Offset = "0x48")]
	public UILabel LikeLabel;

	[Token(Token = "0x40161E7")]
	[FieldOffset(Offset = "0x4C")]
	public ParticleSystem VFX_Ring;

	[Token(Token = "0x40161E8")]
	[FieldOffset(Offset = "0x50")]
	public UIButton BtnAdd;

	[Token(Token = "0x40161E9")]
	[FieldOffset(Offset = "0x54")]
	public UISprite AddIcon;

	[Token(Token = "0x40161EA")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ReviveCoin;

	[Token(Token = "0x40161EB")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel ReviveCoinCount;

	[Token(Token = "0x601680E")]
	[Address(RVA = "0x1835BF8", Offset = "0x1835BF8", VA = "0x1835BF8")]
	public UIHudObserverProfileView()
	{
	}

	[Token(Token = "0x601680F")]
	[Address(RVA = "0x1835C00", Offset = "0x1835C00", VA = "0x1835C00", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016810")]
	[Address(RVA = "0x1836444", Offset = "0x1836444", VA = "0x1836444")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
