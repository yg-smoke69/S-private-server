using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003771")]
public class UIHudThumbUpChatBtnView : UIBaseView
{
	[Token(Token = "0x401675C")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIHudThumbUpChatBtn;

	[Token(Token = "0x401675D")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition pluseffect;

	[Token(Token = "0x401675E")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject VFXClick;

	[Token(Token = "0x401675F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Icon;

	[Token(Token = "0x4016760")]
	[FieldOffset(Offset = "0x24")]
	public GameObject TenTimesThumbIcon;

	[Token(Token = "0x4016761")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MutliClickEffect;

	[Token(Token = "0x60169FE")]
	[Address(RVA = "0x157DD08", Offset = "0x157DD08", VA = "0x157DD08")]
	public UIHudThumbUpChatBtnView()
	{
	}

	[Token(Token = "0x60169FF")]
	[Address(RVA = "0x157DD10", Offset = "0x157DD10", VA = "0x157DD10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A00")]
	[Address(RVA = "0x157E068", Offset = "0x157E068", VA = "0x157E068")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
