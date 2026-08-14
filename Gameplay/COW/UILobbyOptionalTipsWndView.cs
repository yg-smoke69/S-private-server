using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200384D")]
public class UILobbyOptionalTipsWndView : UIBaseView
{
	[Token(Token = "0x40170E9")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PosRoot;

	[Token(Token = "0x40170EA")]
	[FieldOffset(Offset = "0x18")]
	public UITable ContentTable;

	[Token(Token = "0x40170EB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject TopLine;

	[Token(Token = "0x40170EC")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Description;

	[Token(Token = "0x40170ED")]
	[FieldOffset(Offset = "0x24")]
	public GameObject BtnGroup;

	[Token(Token = "0x40170EE")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CancelBtn;

	[Token(Token = "0x40170EF")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel CancelTitle;

	[Token(Token = "0x40170F0")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x40170F1")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ConfirmTitle;

	[Token(Token = "0x40170F2")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BottomLine;

	[Token(Token = "0x40170F3")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject BGPivot;

	[Token(Token = "0x40170F4")]
	[FieldOffset(Offset = "0x40")]
	public UISprite BG;

	[Token(Token = "0x40170F5")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ArrowAnchor;

	[Token(Token = "0x40170F6")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BgBtn;

	[Token(Token = "0x40170F7")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject ContentStyle;

	[Token(Token = "0x40170F8")]
	[FieldOffset(Offset = "0x50")]
	public UILabel ContentLabel;

	[Token(Token = "0x40170F9")]
	[FieldOffset(Offset = "0x54")]
	public GameObject GoPosStyle;

	[Token(Token = "0x40170FA")]
	[FieldOffset(Offset = "0x58")]
	public UILabel GoposContentLabel;

	[Token(Token = "0x40170FB")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton GoposBtn;

	[Token(Token = "0x40170FC")]
	[FieldOffset(Offset = "0x60")]
	public UILabel GoposBtnLabel;

	[Token(Token = "0x40170FD")]
	[FieldOffset(Offset = "0x64")]
	public UIButton GoPosBtn;

	[Token(Token = "0x40170FE")]
	[FieldOffset(Offset = "0x68")]
	public BoxCollider GoPosCollider;

	[Token(Token = "0x40170FF")]
	[FieldOffset(Offset = "0x6C")]
	public BoxCollider ContentCollider;

	[Token(Token = "0x4017100")]
	[FieldOffset(Offset = "0x70")]
	public UIButton ContextBtn;

	[Token(Token = "0x6016C92")]
	[Address(RVA = "0x1CB2614", Offset = "0x1CB2614", VA = "0x1CB2614")]
	public UILobbyOptionalTipsWndView()
	{
	}

	[Token(Token = "0x6016C93")]
	[Address(RVA = "0x1CB261C", Offset = "0x1CB261C", VA = "0x1CB261C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C94")]
	[Address(RVA = "0x1CB3004", Offset = "0x1CB3004", VA = "0x1CB3004")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
