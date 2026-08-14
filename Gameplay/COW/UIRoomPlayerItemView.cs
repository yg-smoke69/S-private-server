using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200396D")]
public class UIRoomPlayerItemView : UIBaseView
{
	[Token(Token = "0x40180BD")]
	[FieldOffset(Offset = "0x14")]
	public UIButton PlayerBtn;

	[Token(Token = "0x40180BE")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget UIRoomPlayerItem;

	[Token(Token = "0x40180BF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ReadyMark;

	[Token(Token = "0x40180C0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Tag;

	[Token(Token = "0x40180C1")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SelfBg;

	[Token(Token = "0x40180C2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x40180C3")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid InfoGrid;

	[Token(Token = "0x40180C4")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SimulationScore;

	[Token(Token = "0x40180C5")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SimulationIcon;

	[Token(Token = "0x40180C6")]
	[FieldOffset(Offset = "0x38")]
	public GameObject MaxIconMid;

	[Token(Token = "0x40180C7")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject MaxIconBot;

	[Token(Token = "0x40180C8")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Voice;

	[Token(Token = "0x40180C9")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Selected;

	[Token(Token = "0x40180CA")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget NameWidget;

	[Token(Token = "0x40180CB")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel Name;

	[Token(Token = "0x40180CC")]
	[FieldOffset(Offset = "0x50")]
	public UISprite MapResState;

	[Token(Token = "0x40180CD")]
	[FieldOffset(Offset = "0x54")]
	public GameObject DownloadingEffect;

	[Token(Token = "0x40180CE")]
	[FieldOffset(Offset = "0x58")]
	public GameObject MaxInfo;

	[Token(Token = "0x6016FEE")]
	[Address(RVA = "0x2BE3580", Offset = "0x2BE3580", VA = "0x2BE3580")]
	public UIRoomPlayerItemView()
	{
	}

	[Token(Token = "0x6016FEF")]
	[Address(RVA = "0x2BE3588", Offset = "0x2BE3588", VA = "0x2BE3588", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FF0")]
	[Address(RVA = "0x2BE3D0C", Offset = "0x2BE3D0C", VA = "0x2BE3D0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
