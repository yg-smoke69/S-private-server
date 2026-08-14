using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003673")]
public class UIHudIdentityView : UIBaseView
{
	[Token(Token = "0x4015DB6")]
	[FieldOffset(Offset = "0x14")]
	public UISprite IconSprite;

	[Token(Token = "0x4015DB7")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ArrowUp;

	[Token(Token = "0x4015DB8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject arrowRight;

	[Token(Token = "0x4015DB9")]
	[FieldOffset(Offset = "0x20")]
	public GameObject arrowDown;

	[Token(Token = "0x4015DBA")]
	[FieldOffset(Offset = "0x24")]
	public GameObject arrowLeft;

	[Token(Token = "0x4015DBB")]
	[FieldOffset(Offset = "0x28")]
	public UISprite IconSpriteHuman;

	[Token(Token = "0x4015DBC")]
	[FieldOffset(Offset = "0x2C")]
	public Transform container;

	[Token(Token = "0x6016706")]
	[Address(RVA = "0x134FC08", Offset = "0x134FC08", VA = "0x134FC08")]
	public UIHudIdentityView()
	{
	}

	[Token(Token = "0x6016707")]
	[Address(RVA = "0x134FC10", Offset = "0x134FC10", VA = "0x134FC10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016708")]
	[Address(RVA = "0x134FFA0", Offset = "0x134FFA0", VA = "0x134FFA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
