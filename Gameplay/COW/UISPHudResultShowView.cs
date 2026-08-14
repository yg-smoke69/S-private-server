using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039D3")]
internal class UISPHudResultShowView : UIBaseView
{
	[Token(Token = "0x401853D")]
	[FieldOffset(Offset = "0x14")]
	public Animator ShowAnimator;

	[Token(Token = "0x401853E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TeamCallSignContainer;

	[Token(Token = "0x401853F")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Label;

	[Token(Token = "0x4018540")]
	[FieldOffset(Offset = "0x20")]
	public UIEffectSprite TeamIcon;

	[Token(Token = "0x4018541")]
	[FieldOffset(Offset = "0x24")]
	public UITexture BGTexture;

	[Token(Token = "0x4018542")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PersonalCallSignContainer;

	[Token(Token = "0x4018543")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnMask;

	[Token(Token = "0x601711F")]
	[Address(RVA = "0x1D2D780", Offset = "0x1D2D780", VA = "0x1D2D780")]
	public UISPHudResultShowView()
	{
	}

	[Token(Token = "0x6017120")]
	[Address(RVA = "0x1D2D788", Offset = "0x1D2D788", VA = "0x1D2D788", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017121")]
	[Address(RVA = "0x1D2DA6C", Offset = "0x1D2DA6C", VA = "0x1D2DA6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
