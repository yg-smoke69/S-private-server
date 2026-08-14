using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A13")]
public class UITurntableSignInView : UIBaseView
{
	[Token(Token = "0x401884D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Close;

	[Token(Token = "0x401884E")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RuleButton;

	[Token(Token = "0x401884F")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton TimeBtn;

	[Token(Token = "0x4018850")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TimeLabel;

	[Token(Token = "0x4018851")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Days;

	[Token(Token = "0x4018852")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TipsContainer;

	[Token(Token = "0x4018853")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel EventDesc;

	[Token(Token = "0x4018854")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PeakDayContainer;

	[Token(Token = "0x4018855")]
	[FieldOffset(Offset = "0x34")]
	public UILabel PeakDayAwardDesc;

	[Token(Token = "0x4018856")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PeakDayAwardCantClaime;

	[Token(Token = "0x4018857")]
	[FieldOffset(Offset = "0x3C")]
	public Transform PeakDayAwardContainer;

	[Token(Token = "0x4018858")]
	[FieldOffset(Offset = "0x40")]
	public UIButton SigninBtn;

	[Token(Token = "0x4018859")]
	[FieldOffset(Offset = "0x44")]
	public UISprite SignBtnBG;

	[Token(Token = "0x401885A")]
	[FieldOffset(Offset = "0x48")]
	public UILabel SignLabel;

	[Token(Token = "0x401885B")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Signed;

	[Token(Token = "0x401885C")]
	[FieldOffset(Offset = "0x50")]
	public GameObject UnSign;

	[Token(Token = "0x401885D")]
	[FieldOffset(Offset = "0x54")]
	public TurntableAnim Turntable;

	[Token(Token = "0x401885E")]
	[FieldOffset(Offset = "0x58")]
	public Transform Reward1;

	[Token(Token = "0x401885F")]
	[FieldOffset(Offset = "0x5C")]
	public Transform Reward2;

	[Token(Token = "0x4018860")]
	[FieldOffset(Offset = "0x60")]
	public Transform Reward3;

	[Token(Token = "0x4018861")]
	[FieldOffset(Offset = "0x64")]
	public Transform Reward4;

	[Token(Token = "0x4018862")]
	[FieldOffset(Offset = "0x68")]
	public Transform Reward5;

	[Token(Token = "0x4018863")]
	[FieldOffset(Offset = "0x6C")]
	public Transform Reward6;

	[Token(Token = "0x4018864")]
	[FieldOffset(Offset = "0x70")]
	public Transform Reward7;

	[Token(Token = "0x4018865")]
	[FieldOffset(Offset = "0x74")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x60171DF")]
	[Address(RVA = "0x1C306F8", Offset = "0x1C306F8", VA = "0x1C306F8")]
	public UITurntableSignInView()
	{
	}

	[Token(Token = "0x60171E0")]
	[Address(RVA = "0x1C30700", Offset = "0x1C30700", VA = "0x1C30700", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171E1")]
	[Address(RVA = "0x1C3102C", Offset = "0x1C3102C", VA = "0x1C3102C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
