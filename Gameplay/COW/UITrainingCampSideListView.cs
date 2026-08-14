using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A0D")]
public class UITrainingCampSideListView : UIBaseView
{
	[Token(Token = "0x40187D1")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition SideListBody;

	[Token(Token = "0x40187D2")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x40187D3")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton RecommendTab;

	[Token(Token = "0x40187D4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject RecommendTabSelected;

	[Token(Token = "0x40187D5")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RecommendTabUnselected;

	[Token(Token = "0x40187D6")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton FriendTab;

	[Token(Token = "0x40187D7")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject FriendTabSelected;

	[Token(Token = "0x40187D8")]
	[FieldOffset(Offset = "0x30")]
	public GameObject FriendTabUnselected;

	[Token(Token = "0x40187D9")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TabTitleLabel;

	[Token(Token = "0x40187DA")]
	[FieldOffset(Offset = "0x38")]
	public UIButton RefreshBtn;

	[Token(Token = "0x40187DB")]
	[FieldOffset(Offset = "0x3C")]
	public UICountDownLabel RefreshDisable;

	[Token(Token = "0x40187DC")]
	[FieldOffset(Offset = "0x40")]
	public GameObject RefreshEnable;

	[Token(Token = "0x40187DD")]
	[FieldOffset(Offset = "0x44")]
	public UIScrollView FriendListScrollView;

	[Token(Token = "0x40187DE")]
	[FieldOffset(Offset = "0x48")]
	public UIEasyList FriendList;

	[Token(Token = "0x40187DF")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel EmptyLabel;

	[Token(Token = "0x40187E0")]
	[FieldOffset(Offset = "0x50")]
	public UIButton CloseBtn;

	[Token(Token = "0x40187E1")]
	[FieldOffset(Offset = "0x54")]
	public UIInput SearchInput;

	[Token(Token = "0x40187E2")]
	[FieldOffset(Offset = "0x58")]
	public UIButton SearchBtn;

	[Token(Token = "0x40187E3")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton Mask;

	[Token(Token = "0x40187E4")]
	[FieldOffset(Offset = "0x60")]
	public UIButton RecruitBtn;

	[Token(Token = "0x40187E5")]
	[FieldOffset(Offset = "0x64")]
	public GameObject RecruitLabel;

	[Token(Token = "0x60171CD")]
	[Address(RVA = "0x1C23FE0", Offset = "0x1C23FE0", VA = "0x1C23FE0")]
	public UITrainingCampSideListView()
	{
	}

	[Token(Token = "0x60171CE")]
	[Address(RVA = "0x1C23FE8", Offset = "0x1C23FE8", VA = "0x1C23FE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171CF")]
	[Address(RVA = "0x1C248C8", Offset = "0x1C248C8", VA = "0x1C248C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
