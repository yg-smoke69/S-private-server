using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039FF")]
public class UITopButtonGroupView : UIBaseView
{
	[Token(Token = "0x401870F")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Root;

	[Token(Token = "0x4018710")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Lobby;

	[Token(Token = "0x4018711")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite LobbyLogo;

	[Token(Token = "0x4018712")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BGSprite;

	[Token(Token = "0x4018713")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BGSpriteUnder;

	[Token(Token = "0x4018714")]
	[FieldOffset(Offset = "0x28")]
	public UITable ButtonGrid;

	[Token(Token = "0x4018715")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnArrow;

	[Token(Token = "0x4018716")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ArrowTips;

	[Token(Token = "0x4018717")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ArrowRight;

	[Token(Token = "0x4018718")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ArrowLeft;

	[Token(Token = "0x4018719")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnManual;

	[Token(Token = "0x401871A")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget ManualWidget;

	[Token(Token = "0x401871B")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Tag;

	[Token(Token = "0x401871C")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ManualTips;

	[Token(Token = "0x401871D")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnLeadBoard;

	[Token(Token = "0x401871E")]
	[FieldOffset(Offset = "0x50")]
	public UIButton btnfriend;

	[Token(Token = "0x401871F")]
	[FieldOffset(Offset = "0x54")]
	public GameObject FriendNewsHint;

	[Token(Token = "0x4018720")]
	[FieldOffset(Offset = "0x58")]
	public UIButton btnmail;

	[Token(Token = "0x4018721")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject MailNewsHint;

	[Token(Token = "0x4018722")]
	[FieldOffset(Offset = "0x60")]
	public UIButton btnsetting;

	[Token(Token = "0x4018723")]
	[FieldOffset(Offset = "0x64")]
	public GameObject settingTips;

	[Token(Token = "0x4018724")]
	[FieldOffset(Offset = "0x68")]
	public UISprite MaxSettingGuide;

	[Token(Token = "0x4018725")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject LobbySettingTips;

	[Token(Token = "0x4018726")]
	[FieldOffset(Offset = "0x70")]
	public UISprite MicBan;

	[Token(Token = "0x4018727")]
	[FieldOffset(Offset = "0x74")]
	public UISprite BatteryLevelSprite;

	[Token(Token = "0x4018728")]
	[FieldOffset(Offset = "0x78")]
	public UISprite BatteryChargingSprite;

	[Token(Token = "0x4018729")]
	[FieldOffset(Offset = "0x7C")]
	public UITable NaviPage;

	[Token(Token = "0x401872A")]
	[FieldOffset(Offset = "0x80")]
	public UIButton BtnSettingInNaviPage;

	[Token(Token = "0x401872B")]
	[FieldOffset(Offset = "0x84")]
	public UIButton HelpBtn;

	[Token(Token = "0x401872C")]
	[FieldOffset(Offset = "0x88")]
	public GameObject VoiceBtnGroup;

	[Token(Token = "0x401872D")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton MicToggle;

	[Token(Token = "0x401872E")]
	[FieldOffset(Offset = "0x90")]
	public UISprite MicSprite;

	[Token(Token = "0x401872F")]
	[FieldOffset(Offset = "0x94")]
	public UISprite MicMask;

	[Token(Token = "0x4018730")]
	[FieldOffset(Offset = "0x98")]
	public UIButton SpeakerToggle;

	[Token(Token = "0x4018731")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite SpeakerSprite;

	[Token(Token = "0x4018732")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite SpeakerMask;

	[Token(Token = "0x4018733")]
	[FieldOffset(Offset = "0xA4")]
	public Transform CustomizedCtrlTrans;

	[Token(Token = "0x4018734")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel title;

	[Token(Token = "0x4018735")]
	[FieldOffset(Offset = "0xAC")]
	public UIButton leaveBtn;

	[Token(Token = "0x4018736")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite ButtonBgSprite;

	[Token(Token = "0x4018737")]
	[FieldOffset(Offset = "0xB4")]
	public UISprite ButtonClose;

	[Token(Token = "0x4018738")]
	[FieldOffset(Offset = "0xB8")]
	public Transform TitleLeft;

	[Token(Token = "0x4018739")]
	[FieldOffset(Offset = "0xBC")]
	public UITable ItemTable;

	[Token(Token = "0x401873A")]
	[FieldOffset(Offset = "0xC0")]
	public UISprite NormalExchangeSprite;

	[Token(Token = "0x401873B")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite ExchangeTokenSprite;

	[Token(Token = "0x401873C")]
	[FieldOffset(Offset = "0xC8")]
	public UIButton ExchangeStoreBtn;

	[Token(Token = "0x401873D")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel ExchangeStoreLabel;

	[Token(Token = "0x401873E")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite arrow;

	[Token(Token = "0x401873F")]
	[FieldOffset(Offset = "0xD4")]
	public UISprite Token1;

	[Token(Token = "0x4018740")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel Token1Label;

	[Token(Token = "0x4018741")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject Token1TimeIcon;

	[Token(Token = "0x4018742")]
	[FieldOffset(Offset = "0xE0")]
	public UIButton Token1Btn;

	[Token(Token = "0x4018743")]
	[FieldOffset(Offset = "0xE4")]
	public UISprite Token2;

	[Token(Token = "0x4018744")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel Token2Label;

	[Token(Token = "0x4018745")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject Token2TimeIcon;

	[Token(Token = "0x4018746")]
	[FieldOffset(Offset = "0xF0")]
	public UIButton Token2Btn;

	[Token(Token = "0x4018747")]
	[FieldOffset(Offset = "0xF4")]
	public UIButton RoomCardBtn;

	[Token(Token = "0x4018748")]
	[FieldOffset(Offset = "0xF8")]
	public UIButton CustomizedBtn;

	[Token(Token = "0x4018749")]
	[FieldOffset(Offset = "0xFC")]
	public UILabel CustomizedLabel;

	[Token(Token = "0x401874A")]
	[FieldOffset(Offset = "0x100")]
	public Transform GotoTokenRoot;

	[Token(Token = "0x401874B")]
	[FieldOffset(Offset = "0x104")]
	public UITable GotoTokenTable;

	[Token(Token = "0x60171A3")]
	[Address(RVA = "0x2AF01A8", Offset = "0x2AF01A8", VA = "0x2AF01A8")]
	public UITopButtonGroupView()
	{
	}

	[Token(Token = "0x60171A4")]
	[Address(RVA = "0x2AF01B0", Offset = "0x2AF01B0", VA = "0x2AF01B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171A5")]
	[Address(RVA = "0x2AF18C4", Offset = "0x2AF18C4", VA = "0x2AF18C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
