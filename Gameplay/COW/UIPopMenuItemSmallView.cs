using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003913")]
public class UIPopMenuItemSmallView : UIBaseView
{
	[Token(Token = "0x4017BF6")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4017BF7")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x4017BF8")]
	[FieldOffset(Offset = "0x1C")]
	public UIDragScrollView UIDragScrollView;

	[Token(Token = "0x4017BF9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Label;

	[Token(Token = "0x4017BFA")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HighLight;

	[Token(Token = "0x4017BFB")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Icon;

	[Token(Token = "0x4017BFC")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Tag;

	[Token(Token = "0x4017BFD")]
	[FieldOffset(Offset = "0x30")]
	public UISprite TagIconBg;

	[Token(Token = "0x4017BFE")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TagLabel;

	[Token(Token = "0x4017BFF")]
	[FieldOffset(Offset = "0x38")]
	public UISprite IconNew;

	[Token(Token = "0x4017C00")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite TagIcon;

	[Token(Token = "0x4017C01")]
	[FieldOffset(Offset = "0x40")]
	public GameObject download;

	[Token(Token = "0x6016EE2")]
	[Address(RVA = "0x2C5F984", Offset = "0x2C5F984", VA = "0x2C5F984")]
	public UIPopMenuItemSmallView()
	{
	}

	[Token(Token = "0x6016EE3")]
	[Address(RVA = "0x2C5F98C", Offset = "0x2C5F98C", VA = "0x2C5F98C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EE4")]
	[Address(RVA = "0x2C5FF30", Offset = "0x2C5FF30", VA = "0x2C5FF30")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
