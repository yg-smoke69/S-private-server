using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A06")]
public class UITrainingCampMemberItemView : UIBaseView
{
	[Token(Token = "0x40187A5")]
	[FieldOffset(Offset = "0x14")]
	public UILabel MemberRoleLabel;

	[Token(Token = "0x40187A6")]
	[FieldOffset(Offset = "0x18")]
	public UIButton AddBtn;

	[Token(Token = "0x40187A7")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton InfoBtn;

	[Token(Token = "0x40187A8")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HeadPic;

	[Token(Token = "0x40187A9")]
	[FieldOffset(Offset = "0x24")]
	public UILabel MemberNameLabel;

	[Token(Token = "0x40187AA")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ScoreContainer;

	[Token(Token = "0x40187AB")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Score;

	[Token(Token = "0x40187AC")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BreakUpMask;

	[Token(Token = "0x40187AD")]
	[FieldOffset(Offset = "0x34")]
	public UICountDownLabel BreakUpCountDown;

	[Token(Token = "0x40187AE")]
	[FieldOffset(Offset = "0x38")]
	public UIButton GraduateBtn;

	[Token(Token = "0x60171B8")]
	[Address(RVA = "0x2B0ADB4", Offset = "0x2B0ADB4", VA = "0x2B0ADB4")]
	public UITrainingCampMemberItemView()
	{
	}

	[Token(Token = "0x60171B9")]
	[Address(RVA = "0x2B0ADBC", Offset = "0x2B0ADBC", VA = "0x2B0ADBC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171BA")]
	[Address(RVA = "0x2B0B2AC", Offset = "0x2B0B2AC", VA = "0x2B0B2AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
