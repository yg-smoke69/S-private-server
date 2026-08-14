using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200346B")]
public class UICloseFriendView : UIBaseView
{
	[Token(Token = "0x40145FE")]
	[FieldOffset(Offset = "0x14")]
	public UILabel RelationshipTitle;

	[Token(Token = "0x40145FF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton DescTipsBtn;

	[Token(Token = "0x4014600")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject CloseFriendOwn;

	[Token(Token = "0x4014601")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CheckboxForNotifyBoxContent;

	[Token(Token = "0x4014602")]
	[FieldOffset(Offset = "0x24")]
	public UIToggle CheckboxForNotify;

	[Token(Token = "0x4014603")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BreakTipsShowBtn;

	[Token(Token = "0x4014604")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BreakTipsLabel;

	[Token(Token = "0x4014605")]
	[FieldOffset(Offset = "0x30")]
	public UICountDownLabel BreakTipsCountdownLabel;

	[Token(Token = "0x4014606")]
	[FieldOffset(Offset = "0x34")]
	public UIButton CallBackBtn;

	[Token(Token = "0x4014607")]
	[FieldOffset(Offset = "0x38")]
	public UIButton ClickMask;

	[Token(Token = "0x4014608")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton RelationshipSettingBtn;

	[Token(Token = "0x4014609")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BreakRequestBtn;

	[Token(Token = "0x401460A")]
	[FieldOffset(Offset = "0x44")]
	public UIButton ClickMask_2;

	[Token(Token = "0x401460B")]
	[FieldOffset(Offset = "0x48")]
	public UIEffectSprite myHeadPic;

	[Token(Token = "0x401460C")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel myNickName;

	[Token(Token = "0x401460D")]
	[FieldOffset(Offset = "0x50")]
	public UIEffectSprite CloseFriendPic;

	[Token(Token = "0x401460E")]
	[FieldOffset(Offset = "0x54")]
	public UILabel CloseFriendNickName;

	[Token(Token = "0x401460F")]
	[FieldOffset(Offset = "0x58")]
	public GameObject RelationshipVfx;

	[Token(Token = "0x4014610")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel Exp;

	[Token(Token = "0x4014611")]
	[FieldOffset(Offset = "0x60")]
	public UILabel levellabel;

	[Token(Token = "0x4014612")]
	[FieldOffset(Offset = "0x64")]
	public UISprite RelationshipIcon;

	[Token(Token = "0x4014613")]
	[FieldOffset(Offset = "0x68")]
	public UIButton AnniversaryBtn;

	[Token(Token = "0x4014614")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject AnniversaryTips;

	[Token(Token = "0x4014615")]
	[FieldOffset(Offset = "0x70")]
	public UILabel AnniversaryLabel;

	[Token(Token = "0x4014616")]
	[FieldOffset(Offset = "0x74")]
	public GameObject RewardListAll;

	[Token(Token = "0x4014617")]
	[FieldOffset(Offset = "0x78")]
	public UIScrollView DragScrollView;

	[Token(Token = "0x4014618")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject RewardList;

	[Token(Token = "0x4014619")]
	[FieldOffset(Offset = "0x80")]
	public UIProgressBar RewardProgressBar;

	[Token(Token = "0x401461A")]
	[FieldOffset(Offset = "0x84")]
	public GameObject dragPanel;

	[Token(Token = "0x401461B")]
	[FieldOffset(Offset = "0x88")]
	public UIButton SendGiftBtn;

	[Token(Token = "0x401461C")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton RequestChatBtn;

	[Token(Token = "0x401461D")]
	[FieldOffset(Offset = "0x90")]
	public UIButton RequestTeamBtn;

	[Token(Token = "0x401461E")]
	[FieldOffset(Offset = "0x94")]
	public GameObject CloseFriendStateNone;

	[Token(Token = "0x401461F")]
	[FieldOffset(Offset = "0x98")]
	public UINetworkTexture CDNTexture;

	[Token(Token = "0x4014620")]
	[FieldOffset(Offset = "0x9C")]
	public UIEffectSprite PlayerHeadPic;

	[Token(Token = "0x4014621")]
	[FieldOffset(Offset = "0xA0")]
	public UIButton SelectFriendBtn;

	[Token(Token = "0x4014622")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel SelectFriendName;

	[Token(Token = "0x4014623")]
	[FieldOffset(Offset = "0xA8")]
	public UICountDownLabel LabelWaitForReply;

	[Token(Token = "0x4014624")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject InviteBtnGroup;

	[Token(Token = "0x4014625")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject BtnSprite_unchoose;

	[Token(Token = "0x4014626")]
	[FieldOffset(Offset = "0xB4")]
	public UIButton UnSelectInviteBtn;

	[Token(Token = "0x4014627")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject BtnSprite;

	[Token(Token = "0x4014628")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton InviteBtn;

	[Token(Token = "0x4014629")]
	[FieldOffset(Offset = "0xC0")]
	public UISprite InviteItemIcon;

	[Token(Token = "0x401462A")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel InviteItemCount;

	[Token(Token = "0x401462B")]
	[FieldOffset(Offset = "0xC8")]
	public UIButton InvitationListBtn;

	[Token(Token = "0x401462C")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject tipsNum;

	[Token(Token = "0x60160F5")]
	[Address(RVA = "0x2917344", Offset = "0x2917344", VA = "0x2917344")]
	public UICloseFriendView()
	{
	}

	[Token(Token = "0x60160F6")]
	[Address(RVA = "0x291734C", Offset = "0x291734C", VA = "0x291734C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160F7")]
	[Address(RVA = "0x29185A4", Offset = "0x29185A4", VA = "0x29185A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
