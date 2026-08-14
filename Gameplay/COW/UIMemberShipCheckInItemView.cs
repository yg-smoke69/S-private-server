using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038A3")]
public class UIMemberShipCheckInItemView : UIBaseView
{
	[Token(Token = "0x401768F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject LockSprite;

	[Token(Token = "0x4017690")]
	[FieldOffset(Offset = "0x18")]
	public GameObject CountDown;

	[Token(Token = "0x4017691")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel CountDownLabel;

	[Token(Token = "0x4017692")]
	[FieldOffset(Offset = "0x20")]
	public UISprite CardSprite;

	[Token(Token = "0x4017693")]
	[FieldOffset(Offset = "0x24")]
	public GameObject CardActiveVfx;

	[Token(Token = "0x4017694")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CardSprite_W;

	[Token(Token = "0x4017695")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject CardSprite_M;

	[Token(Token = "0x4017696")]
	[FieldOffset(Offset = "0x30")]
	public GameObject CardSprite_S;

	[Token(Token = "0x4017697")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SVIPvfx;

	[Token(Token = "0x4017698")]
	[FieldOffset(Offset = "0x38")]
	public GameObject flowLight_W;

	[Token(Token = "0x4017699")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject flowLight_M;

	[Token(Token = "0x401769A")]
	[FieldOffset(Offset = "0x40")]
	public GameObject flowLight_S;

	[Token(Token = "0x401769B")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid ItemGrid;

	[Token(Token = "0x401769C")]
	[FieldOffset(Offset = "0x48")]
	public UIButton CheckInBtn;

	[Token(Token = "0x401769D")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject HasCheckedLabel;

	[Token(Token = "0x401769E")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ReBuyBtn;

	[Token(Token = "0x6016D94")]
	[Address(RVA = "0x269BD10", Offset = "0x269BD10", VA = "0x269BD10")]
	public UIMemberShipCheckInItemView()
	{
	}

	[Token(Token = "0x6016D95")]
	[Address(RVA = "0x269BD18", Offset = "0x269BD18", VA = "0x269BD18", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D96")]
	[Address(RVA = "0x269C3DC", Offset = "0x269C3DC", VA = "0x269C3DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
