using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035DC")]
public class UIHudAutoFireSwitchView : UIBaseView
{
	[Token(Token = "0x40158F4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnFireModeSwitch;

	[Token(Token = "0x40158F5")]
	[FieldOffset(Offset = "0x18")]
	public UISprite SpriteIcon;

	[Token(Token = "0x40158F6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel FireModeInfo;

	[Token(Token = "0x40158F7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject On;

	[Token(Token = "0x6016542")]
	[Address(RVA = "0x170CDB0", Offset = "0x170CDB0", VA = "0x170CDB0")]
	public UIHudAutoFireSwitchView()
	{
	}

	[Token(Token = "0x6016543")]
	[Address(RVA = "0x170CDB8", Offset = "0x170CDB8", VA = "0x170CDB8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016544")]
	[Address(RVA = "0x170D074", Offset = "0x170D074", VA = "0x170D074")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
