using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003517")]
public class UIEmoteSlotView : UIBaseView
{
	[Token(Token = "0x4014F36")]
	[FieldOffset(Offset = "0x14")]
	public UIButton slotBtn;

	[Token(Token = "0x4014F37")]
	[FieldOffset(Offset = "0x18")]
	public UISprite defaultIcon;

	[Token(Token = "0x4014F38")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite icon;

	[Token(Token = "0x4014F39")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HL;

	[Token(Token = "0x4014F3A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DragItem;

	[Token(Token = "0x4014F3B")]
	[FieldOffset(Offset = "0x28")]
	public UISprite DragIcon;

	[Token(Token = "0x4014F3C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HintArrow;

	[Token(Token = "0x4014F3D")]
	[FieldOffset(Offset = "0x30")]
	public GameObject DownLoadState;

	[Token(Token = "0x4014F3E")]
	[FieldOffset(Offset = "0x34")]
	public UILabel BooyahLabel;

	[Token(Token = "0x60162F5")]
	[Address(RVA = "0x19D6404", Offset = "0x19D6404", VA = "0x19D6404")]
	public UIEmoteSlotView()
	{
	}

	[Token(Token = "0x60162F6")]
	[Address(RVA = "0x19D640C", Offset = "0x19D640C", VA = "0x19D640C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162F7")]
	[Address(RVA = "0x19D6884", Offset = "0x19D6884", VA = "0x19D6884")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
