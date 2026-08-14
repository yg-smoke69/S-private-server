using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033C1")]
public class UIAvatarAwakenNavigationView : UIBaseView
{
	[Token(Token = "0x4013C66")]
	[FieldOffset(Offset = "0x14")]
	public UILabel AwakenNameLabel;

	[Token(Token = "0x4013C67")]
	[FieldOffset(Offset = "0x18")]
	public UILabel AwakenTitle;

	[Token(Token = "0x4013C68")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel AwakenTitle_2;

	[Token(Token = "0x4013C69")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CDNImgContainer;

	[Token(Token = "0x4013C6A")]
	[FieldOffset(Offset = "0x24")]
	public UIButton CDNBtnClose;

	[Token(Token = "0x4013C6B")]
	[FieldOffset(Offset = "0x28")]
	public UINetworkTextureExt CDNImage;

	[Token(Token = "0x4013C6C")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton LeftClickArea;

	[Token(Token = "0x4013C6D")]
	[FieldOffset(Offset = "0x30")]
	public UIButton RightClickArea;

	[Token(Token = "0x4013C6E")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LeftShowDisable;

	[Token(Token = "0x4013C6F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject LeftShow;

	[Token(Token = "0x4013C70")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject RightShowDisable;

	[Token(Token = "0x4013C71")]
	[FieldOffset(Offset = "0x40")]
	public GameObject RightShow;

	[Token(Token = "0x6015EF9")]
	[Address(RVA = "0x1E82EFC", Offset = "0x1E82EFC", VA = "0x1E82EFC")]
	public UIAvatarAwakenNavigationView()
	{
	}

	[Token(Token = "0x6015EFA")]
	[Address(RVA = "0x1E82F04", Offset = "0x1E82F04", VA = "0x1E82F04", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015EFB")]
	[Address(RVA = "0x1E83490", Offset = "0x1E83490", VA = "0x1E83490")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
