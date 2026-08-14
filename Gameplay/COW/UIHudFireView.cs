using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003653")]
public class UIHudFireView : UIBaseView
{
	[Token(Token = "0x4015CA7")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnFire;

	[Token(Token = "0x4015CA8")]
	[FieldOffset(Offset = "0x18")]
	public Transform ShowEffectPos;

	[Token(Token = "0x4015CA9")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BgCore;

	[Token(Token = "0x4015CAA")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteNormal;

	[Token(Token = "0x4015CAB")]
	[FieldOffset(Offset = "0x24")]
	public Transform iconFire;

	[Token(Token = "0x4015CAC")]
	[FieldOffset(Offset = "0x28")]
	public UISprite iconWidget;

	[Token(Token = "0x4015CAD")]
	[FieldOffset(Offset = "0x2C")]
	public Transform DamageBuffGo;

	[Token(Token = "0x4015CAE")]
	[FieldOffset(Offset = "0x30")]
	public Transform fire_BG;

	[Token(Token = "0x4015CAF")]
	[FieldOffset(Offset = "0x34")]
	public UISprite CDProgress;

	[Token(Token = "0x4015CB0")]
	[FieldOffset(Offset = "0x38")]
	public GameObject CDMask;

	[Token(Token = "0x4015CB1")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget UIHudFire;

	[Token(Token = "0x60166A6")]
	[Address(RVA = "0x1BA872C", Offset = "0x1BA872C", VA = "0x1BA872C")]
	public UIHudFireView()
	{
	}

	[Token(Token = "0x60166A7")]
	[Address(RVA = "0x1BA8734", Offset = "0x1BA8734", VA = "0x1BA8734", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166A8")]
	[Address(RVA = "0x1BA8BF0", Offset = "0x1BA8BF0", VA = "0x1BA8BF0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
