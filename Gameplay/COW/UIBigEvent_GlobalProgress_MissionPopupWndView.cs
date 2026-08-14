using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033F1")]
public class UIBigEvent_GlobalProgress_MissionPopupWndView : UIBaseView
{
	[Token(Token = "0x4013FC3")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelTitle;

	[Token(Token = "0x4013FC4")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClose;

	[Token(Token = "0x4013FC5")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteBtnClose;

	[Token(Token = "0x4013FC6")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView MissionScrollView;

	[Token(Token = "0x4013FC7")]
	[FieldOffset(Offset = "0x24")]
	public UIEasyList MissionList;

	[Token(Token = "0x4013FC8")]
	[FieldOffset(Offset = "0x28")]
	public UINetworkTexture TextureBg;

	[Token(Token = "0x4013FC9")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelRefreshTime;

	[Token(Token = "0x6015F87")]
	[Address(RVA = "0x10BF1F0", Offset = "0x10BF1F0", VA = "0x10BF1F0")]
	public UIBigEvent_GlobalProgress_MissionPopupWndView()
	{
	}

	[Token(Token = "0x6015F88")]
	[Address(RVA = "0x10BF1F8", Offset = "0x10BF1F8", VA = "0x10BF1F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F89")]
	[Address(RVA = "0x10BF5E0", Offset = "0x10BF5E0", VA = "0x10BF5E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
