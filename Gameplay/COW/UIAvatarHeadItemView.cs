using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033C7")]
public class UIAvatarHeadItemView : UIBaseView
{
	[Token(Token = "0x4013CC2")]
	[FieldOffset(Offset = "0x14")]
	public UIButton itemButton;

	[Token(Token = "0x4013CC3")]
	[FieldOffset(Offset = "0x18")]
	public UISprite headIcon;

	[Token(Token = "0x4013CC4")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel nameLabel;

	[Token(Token = "0x4013CC5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HLSprite;

	[Token(Token = "0x4013CC6")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GraySprite;

	[Token(Token = "0x4013CC7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DebrisCnt;

	[Token(Token = "0x4013CC8")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject CanLevelUpSpr;

	[Token(Token = "0x6015F0B")]
	[Address(RVA = "0x2A7FEDC", Offset = "0x2A7FEDC", VA = "0x2A7FEDC")]
	public UIAvatarHeadItemView()
	{
	}

	[Token(Token = "0x6015F0C")]
	[Address(RVA = "0x2A7FEE4", Offset = "0x2A7FEE4", VA = "0x2A7FEE4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F0D")]
	[Address(RVA = "0x2A802A8", Offset = "0x2A802A8", VA = "0x2A802A8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
