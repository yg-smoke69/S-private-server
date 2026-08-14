using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003687")]
public class UIHudJanKenPonBuffView : UIBaseView
{
	[Token(Token = "0x4015EDF")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RelationshipObject;

	[Token(Token = "0x4015EE0")]
	[FieldOffset(Offset = "0x18")]
	public UISprite WeakBuffIcon;

	[Token(Token = "0x4015EE1")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel WeakBuffLevel;

	[Token(Token = "0x4015EE2")]
	[FieldOffset(Offset = "0x20")]
	public UISprite CurrentBuffIcon;

	[Token(Token = "0x4015EE3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CurrentBuffLevel;

	[Token(Token = "0x4015EE4")]
	[FieldOffset(Offset = "0x28")]
	public UISprite StrongBuffIcon;

	[Token(Token = "0x4015EE5")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel StrongBuffLevel;

	[Token(Token = "0x4015EE6")]
	[FieldOffset(Offset = "0x30")]
	public UILabel WeakBuffCountLabel;

	[Token(Token = "0x6016742")]
	[Address(RVA = "0x20B0A40", Offset = "0x20B0A40", VA = "0x20B0A40")]
	public UIHudJanKenPonBuffView()
	{
	}

	[Token(Token = "0x6016743")]
	[Address(RVA = "0x20B0A48", Offset = "0x20B0A48", VA = "0x20B0A48", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016744")]
	[Address(RVA = "0x20B0E84", Offset = "0x20B0E84", VA = "0x20B0E84")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
