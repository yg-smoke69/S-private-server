using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A49")]
public class UIUGCSwitchModeItemView : UIBaseView
{
	[Token(Token = "0x4018A2B")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIUGCSwitchModeItem;

	[Token(Token = "0x4018A2C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TagContainer;

	[Token(Token = "0x4018A2D")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture CDNIcon;

	[Token(Token = "0x4018A2E")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Icon;

	[Token(Token = "0x4018A2F")]
	[FieldOffset(Offset = "0x24")]
	public UILabel NameTxt;

	[Token(Token = "0x4018A30")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SelectedBg;

	[Token(Token = "0x4018A31")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject HotIcon;

	[Token(Token = "0x4018A32")]
	[FieldOffset(Offset = "0x30")]
	public GameObject UnselectedBg;

	[Token(Token = "0x4018A33")]
	[FieldOffset(Offset = "0x34")]
	public GameObject NewIcon;

	[Token(Token = "0x6017281")]
	[Address(RVA = "0xF43738", Offset = "0xF43738", VA = "0xF43738")]
	public UIUGCSwitchModeItemView()
	{
	}

	[Token(Token = "0x6017282")]
	[Address(RVA = "0xF43740", Offset = "0xF43740", VA = "0xF43740", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017283")]
	[Address(RVA = "0xF43BAC", Offset = "0xF43BAC", VA = "0xF43BAC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
