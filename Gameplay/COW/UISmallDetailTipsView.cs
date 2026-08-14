using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039B2")]
public class UISmallDetailTipsView : UIBaseView
{
	[Token(Token = "0x401839D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PosRoot;

	[Token(Token = "0x401839E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ItemAnchor;

	[Token(Token = "0x401839F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject UIStandardItemMini;

	[Token(Token = "0x40183A0")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ItemName;

	[Token(Token = "0x40183A1")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TypeIcon;

	[Token(Token = "0x40183A2")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ItemTime;

	[Token(Token = "0x40183A3")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite TimeIcon;

	[Token(Token = "0x40183A4")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ItemCount;

	[Token(Token = "0x40183A5")]
	[FieldOffset(Offset = "0x34")]
	public UITable ContentTable;

	[Token(Token = "0x40183A6")]
	[FieldOffset(Offset = "0x38")]
	public GameObject TopLine;

	[Token(Token = "0x40183A7")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget EmptyItem;

	[Token(Token = "0x40183A8")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Description;

	[Token(Token = "0x40183A9")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BtnGroup;

	[Token(Token = "0x40183AA")]
	[FieldOffset(Offset = "0x48")]
	public UIButton CancelBtn;

	[Token(Token = "0x40183AB")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel CancelTitle;

	[Token(Token = "0x40183AC")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x40183AD")]
	[FieldOffset(Offset = "0x54")]
	public UILabel ConfirmTitle;

	[Token(Token = "0x40183AE")]
	[FieldOffset(Offset = "0x58")]
	public GameObject BottomLine;

	[Token(Token = "0x40183AF")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject BGPivot;

	[Token(Token = "0x40183B0")]
	[FieldOffset(Offset = "0x60")]
	public UISprite BG;

	[Token(Token = "0x40183B1")]
	[FieldOffset(Offset = "0x64")]
	public GameObject ArrowAnchor;

	[Token(Token = "0x40183B2")]
	[FieldOffset(Offset = "0x68")]
	public UIButton BgBtn;

	[Token(Token = "0x40183B3")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject Mask;

	[Token(Token = "0x60170BD")]
	[Address(RVA = "0x2059414", Offset = "0x2059414", VA = "0x2059414")]
	public UISmallDetailTipsView()
	{
	}

	[Token(Token = "0x60170BE")]
	[Address(RVA = "0x205941C", Offset = "0x205941C", VA = "0x205941C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170BF")]
	[Address(RVA = "0x2059D98", Offset = "0x2059D98", VA = "0x2059D98")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
