using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003804")]
public class UIInviteGroupBoxView : UIBaseView
{
	[Token(Token = "0x4016C1C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Mask;

	[Token(Token = "0x4016C1D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ClickFilter;

	[Token(Token = "0x4016C1E")]
	[FieldOffset(Offset = "0x1C")]
	public Transform CenterParent;

	[Token(Token = "0x4016C1F")]
	[FieldOffset(Offset = "0x20")]
	public TweenPosition Pivot;

	[Token(Token = "0x4016C20")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RecentTitle;

	[Token(Token = "0x4016C21")]
	[FieldOffset(Offset = "0x28")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4016C22")]
	[FieldOffset(Offset = "0x2C")]
	public UIEasyList List;

	[Token(Token = "0x4016C23")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid RightGrid;

	[Token(Token = "0x4016C24")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButtonGroup RightGroup;

	[Token(Token = "0x4016C25")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButton FriendTab;

	[Token(Token = "0x4016C26")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton ClanTab;

	[Token(Token = "0x4016C27")]
	[FieldOffset(Offset = "0x40")]
	public UIToggleButton RecentTab;

	[Token(Token = "0x4016C28")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BottomBG;

	[Token(Token = "0x4016C29")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BottomGrid;

	[Token(Token = "0x4016C2A")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton QuickEnter;

	[Token(Token = "0x4016C2B")]
	[FieldOffset(Offset = "0x50")]
	public UIButton Community;

	[Token(Token = "0x4016C2C")]
	[FieldOffset(Offset = "0x54")]
	public UILabel CommunityLabel;

	[Token(Token = "0x4016C2D")]
	[FieldOffset(Offset = "0x58")]
	public UIButton AddFriend;

	[Token(Token = "0x4016C2E")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton CloseBtn;

	[Token(Token = "0x4016C2F")]
	[FieldOffset(Offset = "0x60")]
	public GameObject SearchObj;

	[Token(Token = "0x4016C30")]
	[FieldOffset(Offset = "0x64")]
	public UIInput SearchInput;

	[Token(Token = "0x4016C31")]
	[FieldOffset(Offset = "0x68")]
	public TweenAlpha SearchTweenLabel;

	[Token(Token = "0x4016C32")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton SearchBtn;

	[Token(Token = "0x4016C33")]
	[FieldOffset(Offset = "0x70")]
	public UISprite SearchBtnSprite;

	[Token(Token = "0x4016C34")]
	[FieldOffset(Offset = "0x74")]
	public GameObject SearchClearSprite;

	[Token(Token = "0x4016C35")]
	[FieldOffset(Offset = "0x78")]
	public UIButton RefreshBtn;

	[Token(Token = "0x4016C36")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject RefreshNormalObj;

	[Token(Token = "0x4016C37")]
	[FieldOffset(Offset = "0x80")]
	public GameObject RefreshGreyObj;

	[Token(Token = "0x4016C38")]
	[FieldOffset(Offset = "0x84")]
	public UICountDownLabel RefreshCDLabel;

	[Token(Token = "0x4016C39")]
	[FieldOffset(Offset = "0x88")]
	public UIButton AddClan;

	[Token(Token = "0x4016C3A")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject EmptyClanObj;

	[Token(Token = "0x4016C3B")]
	[FieldOffset(Offset = "0x90")]
	public GameObject EmptyRecentObj;

	[Token(Token = "0x6016BB7")]
	[Address(RVA = "0x1AD8C5C", Offset = "0x1AD8C5C", VA = "0x1AD8C5C")]
	public UIInviteGroupBoxView()
	{
	}

	[Token(Token = "0x6016BB8")]
	[Address(RVA = "0x1AD8C64", Offset = "0x1AD8C64", VA = "0x1AD8C64", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BB9")]
	[Address(RVA = "0x1AD9900", Offset = "0x1AD9900", VA = "0x1AD9900")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
