using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003705")]
internal class UIHudRedEnvelopeReceiveWindowView : UIBaseView
{
	[Token(Token = "0x401637C")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelOwnerInfo;

	[Token(Token = "0x401637D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ReceiveInfo;

	[Token(Token = "0x401637E")]
	[FieldOffset(Offset = "0x1C")]
	public RedEnvelopeAwardItemView ReceiveItem;

	[Token(Token = "0x401637F")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LabelDone;

	[Token(Token = "0x4016380")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnOpen;

	[Token(Token = "0x4016381")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnReceiveInfo;

	[Token(Token = "0x4016382")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnReceiveInfo2;

	[Token(Token = "0x4016383")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnClose;

	[Token(Token = "0x60168BA")]
	[Address(RVA = "0x13DEA5C", Offset = "0x13DEA5C", VA = "0x13DEA5C")]
	public UIHudRedEnvelopeReceiveWindowView()
	{
	}

	[Token(Token = "0x60168BB")]
	[Address(RVA = "0x13DEA64", Offset = "0x13DEA64", VA = "0x13DEA64", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168BC")]
	[Address(RVA = "0x13DEE94", Offset = "0x13DEE94", VA = "0x13DEE94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
