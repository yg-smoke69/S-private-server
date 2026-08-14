using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033CC")]
public class UIAvatarLinkListItemView : UIBaseView
{
	[Token(Token = "0x4013CEC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton AvatarBtn;

	[Token(Token = "0x4013CED")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SelectedBorder;

	[Token(Token = "0x4013CEE")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LinkIcon;

	[Token(Token = "0x4013CEF")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LinkProgressLabel;

	[Token(Token = "0x4013CF0")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LockedGroup;

	[Token(Token = "0x4013CF1")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CountdownLabel;

	[Token(Token = "0x4013CF2")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite AvatarPreviewImage;

	[Token(Token = "0x4013CF3")]
	[FieldOffset(Offset = "0x30")]
	public UILabel AvatarNameLabel;

	[Token(Token = "0x4013CF4")]
	[FieldOffset(Offset = "0x34")]
	public GameObject CountdownGroup;

	[Token(Token = "0x6015F1A")]
	[Address(RVA = "0x2A992FC", Offset = "0x2A992FC", VA = "0x2A992FC")]
	public UIAvatarLinkListItemView()
	{
	}

	[Token(Token = "0x6015F1B")]
	[Address(RVA = "0x2A99304", Offset = "0x2A99304", VA = "0x2A99304", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F1C")]
	[Address(RVA = "0x2A9977C", Offset = "0x2A9977C", VA = "0x2A9977C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
