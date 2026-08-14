using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003785")]
public class UIHudTriggerGrenadeView : UIBaseView
{
	[Token(Token = "0x40167FC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Root;

	[Token(Token = "0x40167FD")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Button;

	[Token(Token = "0x40167FE")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite GrenadeIcon;

	[Token(Token = "0x40167FF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CDIcon;

	[Token(Token = "0x4016800")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Circle;

	[Token(Token = "0x4016801")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TimeLabel;

	[Token(Token = "0x6016A3A")]
	[Address(RVA = "0x158DAB4", Offset = "0x158DAB4", VA = "0x158DAB4")]
	public UIHudTriggerGrenadeView()
	{
	}

	[Token(Token = "0x6016A3B")]
	[Address(RVA = "0x158DABC", Offset = "0x158DABC", VA = "0x158DABC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A3C")]
	[Address(RVA = "0x158DE2C", Offset = "0x158DE2C", VA = "0x158DE2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
