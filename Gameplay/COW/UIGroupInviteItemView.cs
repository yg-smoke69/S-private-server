using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035B4")]
public class UIGroupInviteItemView : UIBaseView
{
	[Token(Token = "0x401578A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton bgBtn;

	[Token(Token = "0x401578B")]
	[FieldOffset(Offset = "0x18")]
	public UISprite platformIcon;

	[Token(Token = "0x401578C")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton inviteBtn;

	[Token(Token = "0x401578D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject inviteBtnGray;

	[Token(Token = "0x401578E")]
	[FieldOffset(Offset = "0x24")]
	public GameObject inviteSprite;

	[Token(Token = "0x401578F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject JoinObj;

	[Token(Token = "0x4015790")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject JoinObjGrey;

	[Token(Token = "0x4015791")]
	[FieldOffset(Offset = "0x30")]
	public Transform invited;

	[Token(Token = "0x4015792")]
	[FieldOffset(Offset = "0x34")]
	public Transform profileinfo;

	[Token(Token = "0x4015793")]
	[FieldOffset(Offset = "0x38")]
	public UIButton ReserveBtn;

	[Token(Token = "0x4015794")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject CanReserve;

	[Token(Token = "0x4015795")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Reserved;

	[Token(Token = "0x4015796")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Reserving;

	[Token(Token = "0x4015797")]
	[FieldOffset(Offset = "0x48")]
	public GameObject CannotReserve;

	[Token(Token = "0x60164CA")]
	[Address(RVA = "0x1D01694", Offset = "0x1D01694", VA = "0x1D01694")]
	public UIGroupInviteItemView()
	{
	}

	[Token(Token = "0x60164CB")]
	[Address(RVA = "0x1D0169C", Offset = "0x1D0169C", VA = "0x1D0169C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164CC")]
	[Address(RVA = "0x1D01C74", Offset = "0x1D01C74", VA = "0x1D01C74")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
