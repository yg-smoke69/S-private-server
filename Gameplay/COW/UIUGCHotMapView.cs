using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A2A")]
public class UIUGCHotMapView : UIBaseView
{
	[Token(Token = "0x40188FD")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LikeCnt;

	[Token(Token = "0x40188FE")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SubCnt;

	[Token(Token = "0x40188FF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelTag;

	[Token(Token = "0x4018900")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture CDNMapIcon;

	[Token(Token = "0x4018901")]
	[FieldOffset(Offset = "0x24")]
	public UISprite MapIcon;

	[Token(Token = "0x4018902")]
	[FieldOffset(Offset = "0x28")]
	public UILabel NameTxt;

	[Token(Token = "0x4018903")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton UIUGCHotMap;

	[Token(Token = "0x6017224")]
	[Address(RVA = "0x2B97608", Offset = "0x2B97608", VA = "0x2B97608")]
	public UIUGCHotMapView()
	{
	}

	[Token(Token = "0x6017225")]
	[Address(RVA = "0x2B97610", Offset = "0x2B97610", VA = "0x2B97610", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017226")]
	[Address(RVA = "0x2B979F8", Offset = "0x2B979F8", VA = "0x2B979F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
