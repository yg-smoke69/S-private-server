using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003452")]
public class UIClanMainPageView : UIBaseView
{
	[Token(Token = "0x40144B3")]
	[FieldOffset(Offset = "0x14")]
	public UILabel MemberCnt;

	[Token(Token = "0x40144B4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel MemberMaxCnt;

	[Token(Token = "0x40144B5")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton SettingBtn;

	[Token(Token = "0x40144B6")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SettingBtnSprite;

	[Token(Token = "0x40144B7")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamIcon;

	[Token(Token = "0x40144B8")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelClanName;

	[Token(Token = "0x40144B9")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite CurLevelIcon;

	[Token(Token = "0x40144BA")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LevelLabel;

	[Token(Token = "0x40144BB")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BuffBtn;

	[Token(Token = "0x40144BC")]
	[FieldOffset(Offset = "0x38")]
	public UILabel TotalProgress;

	[Token(Token = "0x40144BD")]
	[FieldOffset(Offset = "0x3C")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x40144BE")]
	[FieldOffset(Offset = "0x40")]
	public UILabel ClanId;

	[Token(Token = "0x40144BF")]
	[FieldOffset(Offset = "0x44")]
	public UILabel LabelClanSlogan;

	[Token(Token = "0x40144C0")]
	[FieldOffset(Offset = "0x48")]
	public UILabel LabelClanAnnouncement;

	[Token(Token = "0x40144C1")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton ApplyDeputyCptBtn;

	[Token(Token = "0x40144C2")]
	[FieldOffset(Offset = "0x50")]
	public Transform ChatContainer;

	[Token(Token = "0x40144C3")]
	[FieldOffset(Offset = "0x54")]
	public UIButton LeaderboardBtn;

	[Token(Token = "0x40144C4")]
	[FieldOffset(Offset = "0x58")]
	public UIButton ClanLogBtn;

	[Token(Token = "0x40144C5")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton ClanWarBtn;

	[Token(Token = "0x40144C6")]
	[FieldOffset(Offset = "0x60")]
	public UILabel ClanWarStageLabel;

	[Token(Token = "0x40144C7")]
	[FieldOffset(Offset = "0x64")]
	public UILabel ClanWarTime;

	[Token(Token = "0x40144C8")]
	[FieldOffset(Offset = "0x68")]
	public UIButton InviteBtn;

	[Token(Token = "0x40144C9")]
	[FieldOffset(Offset = "0x6C")]
	public Transform ProfileContainer;

	[Token(Token = "0x40144CA")]
	[FieldOffset(Offset = "0x70")]
	public GameObject RedPacketContainer;

	[Token(Token = "0x40144CB")]
	[FieldOffset(Offset = "0x74")]
	public UIButton RedPacketBtn;

	[Token(Token = "0x40144CC")]
	[FieldOffset(Offset = "0x78")]
	public UIButton SignInBtn;

	[Token(Token = "0x60160AA")]
	[Address(RVA = "0x2B3A190", Offset = "0x2B3A190", VA = "0x2B3A190")]
	public UIClanMainPageView()
	{
	}

	[Token(Token = "0x60160AB")]
	[Address(RVA = "0x2B3A198", Offset = "0x2B3A198", VA = "0x2B3A198", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160AC")]
	[Address(RVA = "0x2B3AC44", Offset = "0x2B3AC44", VA = "0x2B3AC44")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
