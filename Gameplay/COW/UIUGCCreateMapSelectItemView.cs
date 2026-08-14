using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A21")]
public class UIUGCCreateMapSelectItemView : UIBaseView
{
	[Token(Token = "0x40188B5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIUGCCreateMapSelectItem;

	[Token(Token = "0x40188B6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TagContainer;

	[Token(Token = "0x40188B7")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton WebTutorial;

	[Token(Token = "0x40188B8")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture CDNIcon;

	[Token(Token = "0x40188B9")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Icon;

	[Token(Token = "0x40188BA")]
	[FieldOffset(Offset = "0x28")]
	public UILabel NameTxt;

	[Token(Token = "0x40188BB")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SelectedBg;

	[Token(Token = "0x40188BC")]
	[FieldOffset(Offset = "0x30")]
	public GameObject HotIcon;

	[Token(Token = "0x40188BD")]
	[FieldOffset(Offset = "0x34")]
	public GameObject UnselectedBg;

	[Token(Token = "0x40188BE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject NewIcon;

	[Token(Token = "0x6017209")]
	[Address(RVA = "0x2B8B94C", Offset = "0x2B8B94C", VA = "0x2B8B94C")]
	public UIUGCCreateMapSelectItemView()
	{
	}

	[Token(Token = "0x601720A")]
	[Address(RVA = "0x2B8B954", Offset = "0x2B8B954", VA = "0x2B8B954", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601720B")]
	[Address(RVA = "0x2B8BE20", Offset = "0x2B8BE20", VA = "0x2B8BE20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
