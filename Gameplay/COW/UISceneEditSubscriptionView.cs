using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200399C")]
public class UISceneEditSubscriptionView : UIBaseView
{
	[Token(Token = "0x4018276")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList GridEasyList;

	[Token(Token = "0x4018277")]
	[FieldOffset(Offset = "0x18")]
	public GameObject InfoPanel;

	[Token(Token = "0x4018278")]
	[FieldOffset(Offset = "0x1C")]
	public UISceneEditSlotInfoView SlotInfoView;

	[Token(Token = "0x4018279")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid InfoGrid;

	[Token(Token = "0x401827A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EmptyPanel;

	[Token(Token = "0x401827B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject WarningIcon;

	[Token(Token = "0x401827C")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Tips;

	[Token(Token = "0x401827D")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnSelect;

	[Token(Token = "0x401827E")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnOverwrite;

	[Token(Token = "0x401827F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Introduction;

	[Token(Token = "0x4018280")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LikeAndSubscribePanel;

	[Token(Token = "0x601707B")]
	[Address(RVA = "0x2DB41C0", Offset = "0x2DB41C0", VA = "0x2DB41C0")]
	public UISceneEditSubscriptionView()
	{
	}

	[Token(Token = "0x601707C")]
	[Address(RVA = "0x2DB41C8", Offset = "0x2DB41C8", VA = "0x2DB41C8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601707D")]
	[Address(RVA = "0x2DB46F4", Offset = "0x2DB46F4", VA = "0x2DB46F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
