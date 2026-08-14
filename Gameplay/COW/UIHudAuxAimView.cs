using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035DD")]
public class UIHudAuxAimView : UIBaseView
{
	[Token(Token = "0x40158F8")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnAuxAim;

	[Token(Token = "0x40158F9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SpriteSelectedRoot;

	[Token(Token = "0x40158FA")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteSelected;

	[Token(Token = "0x40158FB")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteBg;

	[Token(Token = "0x40158FC")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteNormal;

	[Token(Token = "0x40158FD")]
	[FieldOffset(Offset = "0x28")]
	public Transform iconFire;

	[Token(Token = "0x40158FE")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite iconWidget;

	[Token(Token = "0x40158FF")]
	[FieldOffset(Offset = "0x30")]
	public Transform fire_BG;

	[Token(Token = "0x6016545")]
	[Address(RVA = "0x170ED70", Offset = "0x170ED70", VA = "0x170ED70")]
	public UIHudAuxAimView()
	{
	}

	[Token(Token = "0x6016546")]
	[Address(RVA = "0x170ED78", Offset = "0x170ED78", VA = "0x170ED78", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016547")]
	[Address(RVA = "0x170F164", Offset = "0x170F164", VA = "0x170F164")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
