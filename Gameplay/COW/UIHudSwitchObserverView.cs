using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003763")]
public class UIHudSwitchObserverView : UIBaseView
{
	[Token(Token = "0x4016697")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnSwitchPrev;

	[Token(Token = "0x4016698")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnSwitchNext;

	[Token(Token = "0x4016699")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ReviveTips;

	[Token(Token = "0x60169D4")]
	[Address(RVA = "0x1FF28C8", Offset = "0x1FF28C8", VA = "0x1FF28C8")]
	public UIHudSwitchObserverView()
	{
	}

	[Token(Token = "0x60169D5")]
	[Address(RVA = "0x1FF28D0", Offset = "0x1FF28D0", VA = "0x1FF28D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169D6")]
	[Address(RVA = "0x1FF2B2C", Offset = "0x1FF2B2C", VA = "0x1FF2B2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
