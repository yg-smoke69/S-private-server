using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003750")]
public class UIHudSkillEffectCountingView : UIBaseView
{
	[Token(Token = "0x401661B")]
	[FieldOffset(Offset = "0x14")]
	public UISprite SkillIcon;

	[Token(Token = "0x401661C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Tips;

	[Token(Token = "0x401661D")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Effect;

	[Token(Token = "0x401661E")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Mask;

	[Token(Token = "0x401661F")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnTip;

	[Token(Token = "0x601699B")]
	[Address(RVA = "0x16C2F7C", Offset = "0x16C2F7C", VA = "0x16C2F7C")]
	public UIHudSkillEffectCountingView()
	{
	}

	[Token(Token = "0x601699C")]
	[Address(RVA = "0x16C2F84", Offset = "0x16C2F84", VA = "0x16C2F84", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601699D")]
	[Address(RVA = "0x16C32A0", Offset = "0x16C32A0", VA = "0x16C32A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
