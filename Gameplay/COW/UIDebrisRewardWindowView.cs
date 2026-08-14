using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034B1")]
public class UIDebrisRewardWindowView : UIBaseView
{
	[Token(Token = "0x40149CB")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TitleLabel;

	[Token(Token = "0x40149CC")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid AwardGrid;

	[Token(Token = "0x40149CD")]
	[FieldOffset(Offset = "0x1C")]
	public AwardItemView ItemInstance;

	[Token(Token = "0x40149CE")]
	[FieldOffset(Offset = "0x20")]
	public UISprite RewardIcon;

	[Token(Token = "0x40149CF")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x40149D0")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnConfirm;

	[Token(Token = "0x40149D1")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ConfirmBtnBg;

	[Token(Token = "0x40149D2")]
	[FieldOffset(Offset = "0x30")]
	public Transform BGTopPos2;

	[Token(Token = "0x40149D3")]
	[FieldOffset(Offset = "0x34")]
	public Transform BGBottomPos2;

	[Token(Token = "0x60161C7")]
	[Address(RVA = "0x11F4BD0", Offset = "0x11F4BD0", VA = "0x11F4BD0")]
	public UIDebrisRewardWindowView()
	{
	}

	[Token(Token = "0x60161C8")]
	[Address(RVA = "0x11F4BD8", Offset = "0x11F4BD8", VA = "0x11F4BD8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161C9")]
	[Address(RVA = "0x11F5030", Offset = "0x11F5030", VA = "0x11F5030")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
