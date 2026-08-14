using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037C6")]
public class UIHudVehiclePosView : UIBaseView
{
	[Token(Token = "0x4016979")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x401697A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject icon;

	[Token(Token = "0x401697B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel DistanceLabel;

	[Token(Token = "0x401697C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ArrowUp;

	[Token(Token = "0x401697D")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ArrowLeft;

	[Token(Token = "0x401697E")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ArrowRight;

	[Token(Token = "0x401697F")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ArrowDown;

	[Token(Token = "0x6016AFD")]
	[Address(RVA = "0x1A6F910", Offset = "0x1A6F910", VA = "0x1A6F910")]
	public UIHudVehiclePosView()
	{
	}

	[Token(Token = "0x6016AFE")]
	[Address(RVA = "0x1A6F918", Offset = "0x1A6F918", VA = "0x1A6F918", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AFF")]
	[Address(RVA = "0x1A6FCE8", Offset = "0x1A6FCE8", VA = "0x1A6FCE8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
