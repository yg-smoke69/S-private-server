using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003783")]
public class UIHudTreasureMapView : UIBaseView
{
	[Token(Token = "0x40167F0")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnTreasureMap;

	[Token(Token = "0x40167F1")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BGTreasureMap;

	[Token(Token = "0x40167F2")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite LocateTreasureIcon;

	[Token(Token = "0x40167F3")]
	[FieldOffset(Offset = "0x20")]
	public UISprite DigTreasureIcon;

	[Token(Token = "0x40167F4")]
	[FieldOffset(Offset = "0x24")]
	public UILabel TreasureLabel;

	[Token(Token = "0x6016A34")]
	[Address(RVA = "0x1589B54", Offset = "0x1589B54", VA = "0x1589B54")]
	public UIHudTreasureMapView()
	{
	}

	[Token(Token = "0x6016A35")]
	[Address(RVA = "0x1589B5C", Offset = "0x1589B5C", VA = "0x1589B5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A36")]
	[Address(RVA = "0x1589E84", Offset = "0x1589E84", VA = "0x1589E84")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
