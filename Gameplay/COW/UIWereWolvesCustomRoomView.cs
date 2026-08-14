using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A82")]
public class UIWereWolvesCustomRoomView : UIBaseView
{
	[Token(Token = "0x4018DCA")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget LeftContainer;

	[Token(Token = "0x4018DCB")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RoomId;

	[Token(Token = "0x4018DCC")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Flags;

	[Token(Token = "0x4018DCD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Lock;

	[Token(Token = "0x4018DCE")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Map;

	[Token(Token = "0x4018DCF")]
	[FieldOffset(Offset = "0x28")]
	public UISprite weatherBg;

	[Token(Token = "0x4018DD0")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite WeatherIcon;

	[Token(Token = "0x4018DD1")]
	[FieldOffset(Offset = "0x30")]
	public UILabel MapName;

	[Token(Token = "0x4018DD2")]
	[FieldOffset(Offset = "0x34")]
	public UILabel GameModeLabel;

	[Token(Token = "0x4018DD3")]
	[FieldOffset(Offset = "0x38")]
	public UILabel PlayerCountLabel;

	[Token(Token = "0x4018DD4")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel GameTimeLabel;

	[Token(Token = "0x4018DD5")]
	[FieldOffset(Offset = "0x40")]
	public UILabel HuamanCountLabel;

	[Token(Token = "0x4018DD6")]
	[FieldOffset(Offset = "0x44")]
	public UILabel WolfCountLabel;

	[Token(Token = "0x4018DD7")]
	[FieldOffset(Offset = "0x48")]
	public GameObject PredictToolEnabelRoot;

	[Token(Token = "0x4018DD8")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject PredictToolDisableRoot;

	[Token(Token = "0x4018DD9")]
	[FieldOffset(Offset = "0x50")]
	public GameObject TrapEnabelRoot;

	[Token(Token = "0x4018DDA")]
	[FieldOffset(Offset = "0x54")]
	public GameObject TrapDisableRoot;

	[Token(Token = "0x4018DDB")]
	[FieldOffset(Offset = "0x58")]
	public UIButton CustomizeBtn;

	[Token(Token = "0x4018DDC")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel CustomizeTxt;

	[Token(Token = "0x4018DDD")]
	[FieldOffset(Offset = "0x60")]
	public UIButton BtnShare;

	[Token(Token = "0x4018DDE")]
	[FieldOffset(Offset = "0x64")]
	public UIScrollView roomSettingtScrollView;

	[Token(Token = "0x4018DDF")]
	[FieldOffset(Offset = "0x68")]
	public UIGrid SettingGrid;

	[Token(Token = "0x4018DE0")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel HumanTaskLabel;

	[Token(Token = "0x4018DE1")]
	[FieldOffset(Offset = "0x70")]
	public UILabel WolfKillCDLabel;

	[Token(Token = "0x4018DE2")]
	[FieldOffset(Offset = "0x74")]
	public UILabel WolfTaskCD;

	[Token(Token = "0x4018DE3")]
	[FieldOffset(Offset = "0x78")]
	public UILabel WolfTaskDurationLabel;

	[Token(Token = "0x4018DE4")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel VoteCenterCDLabel;

	[Token(Token = "0x4018DE5")]
	[FieldOffset(Offset = "0x80")]
	public GameObject InvitationGO;

	[Token(Token = "0x4018DE6")]
	[FieldOffset(Offset = "0x84")]
	public UIWidget RightContainer;

	[Token(Token = "0x4018DE7")]
	[FieldOffset(Offset = "0x88")]
	public UILabel RoomName;

	[Token(Token = "0x4018DE8")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject Effect_Glow;

	[Token(Token = "0x4018DE9")]
	[FieldOffset(Offset = "0x90")]
	public UILabel RoomStatus;

	[Token(Token = "0x4018DEA")]
	[FieldOffset(Offset = "0x94")]
	public UIButton ToggleDisplayTypeBtn;

	[Token(Token = "0x4018DEB")]
	[FieldOffset(Offset = "0x98")]
	public UILabel DisplayTypeLabel;

	[Token(Token = "0x4018DEC")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject CardStatus;

	[Token(Token = "0x4018DED")]
	[FieldOffset(Offset = "0xA0")]
	public UIButton InviteBtn;

	[Token(Token = "0x4018DEE")]
	[FieldOffset(Offset = "0xA4")]
	public UIButton Start;

	[Token(Token = "0x4018DEF")]
	[FieldOffset(Offset = "0xA8")]
	public UICountDownLabel CountDownTxt;

	[Token(Token = "0x4018DF0")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject Waiting;

	[Token(Token = "0x4018DF1")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel WatingLabel;

	[Token(Token = "0x4018DF2")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject RoomCardTips;

	[Token(Token = "0x4018DF3")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject RoomCard;

	[Token(Token = "0x4018DF4")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton RoomCardBtn;

	[Token(Token = "0x4018DF5")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel Remain;

	[Token(Token = "0x4018DF6")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel RoomCardCount;

	[Token(Token = "0x4018DF7")]
	[FieldOffset(Offset = "0xC8")]
	public UIScrollView PlayerListScrollView;

	[Token(Token = "0x4018DF8")]
	[FieldOffset(Offset = "0xCC")]
	public UIEasyList PlayerListGrid;

	[Token(Token = "0x4018DF9")]
	[FieldOffset(Offset = "0xD0")]
	public UIButton BackBtn;

	[Token(Token = "0x601732C")]
	[Address(RVA = "0x1B83888", Offset = "0x1B83888", VA = "0x1B83888")]
	public UIWereWolvesCustomRoomView()
	{
	}

	[Token(Token = "0x601732D")]
	[Address(RVA = "0x1B83890", Offset = "0x1B83890", VA = "0x1B83890", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601732E")]
	[Address(RVA = "0x1B84B54", Offset = "0x1B84B54", VA = "0x1B84B54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
