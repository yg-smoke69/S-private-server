using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039FD")]
public class UITokenTipsView : UIBaseView
{
	[Token(Token = "0x40186F6")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PosRoot;

	[Token(Token = "0x40186F7")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ItemAnchor;

	[Token(Token = "0x40186F8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject UIStandardItemMini;

	[Token(Token = "0x40186F9")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ItemName;

	[Token(Token = "0x40186FA")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TypeIcon;

	[Token(Token = "0x40186FB")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ItemTime;

	[Token(Token = "0x40186FC")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite TimeIcon;

	[Token(Token = "0x40186FD")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ItemCount;

	[Token(Token = "0x40186FE")]
	[FieldOffset(Offset = "0x34")]
	public UISprite IPTag;

	[Token(Token = "0x40186FF")]
	[FieldOffset(Offset = "0x38")]
	public UITable ContentTable;

	[Token(Token = "0x4018700")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject TopLine;

	[Token(Token = "0x4018701")]
	[FieldOffset(Offset = "0x40")]
	public GameObject EmptyItem;

	[Token(Token = "0x4018702")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Description;

	[Token(Token = "0x4018703")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Gain;

	[Token(Token = "0x4018704")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid Grid;

	[Token(Token = "0x4018705")]
	[FieldOffset(Offset = "0x50")]
	public GameObject BottomLine;

	[Token(Token = "0x4018706")]
	[FieldOffset(Offset = "0x54")]
	public GameObject BGPivot;

	[Token(Token = "0x4018707")]
	[FieldOffset(Offset = "0x58")]
	public UISprite BG;

	[Token(Token = "0x4018708")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ArrowAnchor;

	[Token(Token = "0x4018709")]
	[FieldOffset(Offset = "0x60")]
	public UIButton BgBtn;

	[Token(Token = "0x401870A")]
	[FieldOffset(Offset = "0x64")]
	public UIButton Mask;

	[Token(Token = "0x601719D")]
	[Address(RVA = "0x20204F0", Offset = "0x20204F0", VA = "0x20204F0")]
	public UITokenTipsView()
	{
	}

	[Token(Token = "0x601719E")]
	[Address(RVA = "0x20204F8", Offset = "0x20204F8", VA = "0x20204F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601719F")]
	[Address(RVA = "0x2020DC0", Offset = "0x2020DC0", VA = "0x2020DC0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
