using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A22")]
public class UIUGCCreateModeSelectItemView : UIBaseView
{
	[Token(Token = "0x40188BF")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIUGCCreateModeSelectItem;

	[Token(Token = "0x40188C0")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TagContainer;

	[Token(Token = "0x40188C1")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture CDNIcon;

	[Token(Token = "0x40188C2")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Icon;

	[Token(Token = "0x40188C3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel NameTxt;

	[Token(Token = "0x40188C4")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SelectedBg;

	[Token(Token = "0x40188C5")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HotIcon;

	[Token(Token = "0x40188C6")]
	[FieldOffset(Offset = "0x30")]
	public GameObject UnselectedBg;

	[Token(Token = "0x40188C7")]
	[FieldOffset(Offset = "0x34")]
	public GameObject NewIcon;

	[Token(Token = "0x601720C")]
	[Address(RVA = "0x2B8C870", Offset = "0x2B8C870", VA = "0x2B8C870")]
	public UIUGCCreateModeSelectItemView()
	{
	}

	[Token(Token = "0x601720D")]
	[Address(RVA = "0x2B8C878", Offset = "0x2B8C878", VA = "0x2B8C878", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601720E")]
	[Address(RVA = "0x2B8CCE4", Offset = "0x2B8CCE4", VA = "0x2B8CCE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
