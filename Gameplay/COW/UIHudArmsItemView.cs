using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035CC")]
public class UIHudArmsItemView : UIBaseView
{
	[Token(Token = "0x401589F")]
	[FieldOffset(Offset = "0x14")]
	public Animator EffectControl;

	[Token(Token = "0x40158A0")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid Grid;

	[Token(Token = "0x40158A1")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Tens;

	[Token(Token = "0x40158A2")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Units;

	[Token(Token = "0x40158A3")]
	[FieldOffset(Offset = "0x24")]
	public UISprite WeaponSprite;

	[Token(Token = "0x6016512")]
	[Address(RVA = "0x1703E60", Offset = "0x1703E60", VA = "0x1703E60")]
	public UIHudArmsItemView()
	{
	}

	[Token(Token = "0x6016513")]
	[Address(RVA = "0x1703E68", Offset = "0x1703E68", VA = "0x1703E68", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016514")]
	[Address(RVA = "0x1704190", Offset = "0x1704190", VA = "0x1704190")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
