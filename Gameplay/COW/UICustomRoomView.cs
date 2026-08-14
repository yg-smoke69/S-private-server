using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034AE")]
public class UICustomRoomView : UIBaseView
{
	[Token(Token = "0x4014945")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget LeftContainer;

	[Token(Token = "0x4014946")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Map;

	[Token(Token = "0x4014947")]
	[FieldOffset(Offset = "0x1C")]
	public UIPanel MapExtraInfoPanel;

	[Token(Token = "0x4014948")]
	[FieldOffset(Offset = "0x20")]
	public UISprite weatherBg;

	[Token(Token = "0x4014949")]
	[FieldOffset(Offset = "0x24")]
	public UISprite WeatherIcon;

	[Token(Token = "0x401494A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel MapName;

	[Token(Token = "0x401494B")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton WSBtnFullPreview;

	[Token(Token = "0x401494C")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTexture MapTexture;

	[Token(Token = "0x401494D")]
	[FieldOffset(Offset = "0x34")]
	public GameObject WSMapContainer;

	[Token(Token = "0x401494E")]
	[FieldOffset(Offset = "0x38")]
	public UILabel RoomMode;

	[Token(Token = "0x401494F")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel PlayerNum;

	[Token(Token = "0x4014950")]
	[FieldOffset(Offset = "0x40")]
	public UILabel GameMode;

	[Token(Token = "0x4014951")]
	[FieldOffset(Offset = "0x44")]
	public UIButton tipsbutton;

	[Token(Token = "0x4014952")]
	[FieldOffset(Offset = "0x48")]
	public GameObject WorkShopGo;

	[Token(Token = "0x4014953")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel SubscriptionCount;

	[Token(Token = "0x4014954")]
	[FieldOffset(Offset = "0x50")]
	public UILabel LikeCount;

	[Token(Token = "0x4014955")]
	[FieldOffset(Offset = "0x54")]
	public GameObject WorkShopTag;

	[Token(Token = "0x4014956")]
	[FieldOffset(Offset = "0x58")]
	public UIGrid Tags;

	[Token(Token = "0x4014957")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel WorkShopDesc1;

	[Token(Token = "0x4014958")]
	[FieldOffset(Offset = "0x60")]
	public UITable WorkShopInfoTable;

	[Token(Token = "0x4014959")]
	[FieldOffset(Offset = "0x64")]
	public UILabel WorkShopDesc2;

	[Token(Token = "0x401495A")]
	[FieldOffset(Offset = "0x68")]
	public UILabel AuthorName;

	[Token(Token = "0x401495B")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton AuthorBtn;

	[Token(Token = "0x401495C")]
	[FieldOffset(Offset = "0x70")]
	public GameObject WorkShopCode;

	[Token(Token = "0x401495D")]
	[FieldOffset(Offset = "0x74")]
	public UILabel CodeNum;

	[Token(Token = "0x401495E")]
	[FieldOffset(Offset = "0x78")]
	public UIButton CopyCodeBtn;

	[Token(Token = "0x401495F")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel RoundInfoTxt;

	[Token(Token = "0x4014960")]
	[FieldOffset(Offset = "0x80")]
	public UILabel TeamInfoTxt;

	[Token(Token = "0x4014961")]
	[FieldOffset(Offset = "0x84")]
	public GameObject RoomSettingDragCollider;

	[Token(Token = "0x4014962")]
	[FieldOffset(Offset = "0x88")]
	public UIScrollView RoomSettingtScrollView;

	[Token(Token = "0x4014963")]
	[FieldOffset(Offset = "0x8C")]
	public UIPanel RoomSettingtPanel;

	[Token(Token = "0x4014964")]
	[FieldOffset(Offset = "0x90")]
	public UIGrid SettingGrid;

	[Token(Token = "0x4014965")]
	[FieldOffset(Offset = "0x94")]
	public UIButton InfoPanelOpenBtn;

	[Token(Token = "0x4014966")]
	[FieldOffset(Offset = "0x98")]
	public UIButton InfoPanelCloseBtn;

	[Token(Token = "0x4014967")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel RoomId;

	[Token(Token = "0x4014968")]
	[FieldOffset(Offset = "0xA0")]
	public UIGrid Flags;

	[Token(Token = "0x4014969")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject Lock;

	[Token(Token = "0x401496A")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject Emulator;

	[Token(Token = "0x401496B")]
	[FieldOffset(Offset = "0xAC")]
	public UIGrid TopBtnGrid;

	[Token(Token = "0x401496C")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton SubscriptionBtn;

	[Token(Token = "0x401496D")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject SubscriptionIdle;

	[Token(Token = "0x401496E")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject SubscriptionSuccess;

	[Token(Token = "0x401496F")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton CustomizeBtn;

	[Token(Token = "0x4014970")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel CustomizeTxt;

	[Token(Token = "0x4014971")]
	[FieldOffset(Offset = "0xC4")]
	public UIButton LookOverBtn;

	[Token(Token = "0x4014972")]
	[FieldOffset(Offset = "0xC8")]
	public UIButton OtherBtn;

	[Token(Token = "0x4014973")]
	[FieldOffset(Offset = "0xCC")]
	public UIButton WorkShopShareBtn;

	[Token(Token = "0x4014974")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite InfoPanelBG;

	[Token(Token = "0x4014975")]
	[FieldOffset(Offset = "0xD4")]
	public Transform InfoPanelTop;

	[Token(Token = "0x4014976")]
	[FieldOffset(Offset = "0xD8")]
	public Transform InfoPanelBottom1;

	[Token(Token = "0x4014977")]
	[FieldOffset(Offset = "0xDC")]
	public Transform InfoPanelBottom2;

	[Token(Token = "0x4014978")]
	[FieldOffset(Offset = "0xE0")]
	public Transform BGBottom1;

	[Token(Token = "0x4014979")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject BGBottom2;

	[Token(Token = "0x401497A")]
	[FieldOffset(Offset = "0xE8")]
	public Transform BGTop;

	[Token(Token = "0x401497B")]
	[FieldOffset(Offset = "0xEC")]
	public UISprite LanguageSprite;

	[Token(Token = "0x401497C")]
	[FieldOffset(Offset = "0xF0")]
	public UIWidget RightContainer;

	[Token(Token = "0x401497D")]
	[FieldOffset(Offset = "0xF4")]
	public UILabel RoomName;

	[Token(Token = "0x401497E")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject Effect_Glow;

	[Token(Token = "0x401497F")]
	[FieldOffset(Offset = "0xFC")]
	public UILabel RoomStatus;

	[Token(Token = "0x4014980")]
	[FieldOffset(Offset = "0x100")]
	public UIButton ToggleDisplayTypeBtn;

	[Token(Token = "0x4014981")]
	[FieldOffset(Offset = "0x104")]
	public UILabel DisplayTypeLabel;

	[Token(Token = "0x4014982")]
	[FieldOffset(Offset = "0x108")]
	public UIButton InviteBtn;

	[Token(Token = "0x4014983")]
	[FieldOffset(Offset = "0x10C")]
	public UIButton ClearBtn;

	[Token(Token = "0x4014984")]
	[FieldOffset(Offset = "0x110")]
	public UIButton SearchBtn;

	[Token(Token = "0x4014985")]
	[FieldOffset(Offset = "0x114")]
	public UISprite SearchBtnSprite;

	[Token(Token = "0x4014986")]
	[FieldOffset(Offset = "0x118")]
	public UIInput SearchInput;

	[Token(Token = "0x4014987")]
	[FieldOffset(Offset = "0x11C")]
	public UIButton Start;

	[Token(Token = "0x4014988")]
	[FieldOffset(Offset = "0x120")]
	public UICountDownLabel CountDownTxt;

	[Token(Token = "0x4014989")]
	[FieldOffset(Offset = "0x124")]
	public UIButton Ready;

	[Token(Token = "0x401498A")]
	[FieldOffset(Offset = "0x128")]
	public UILabel ReadyLabel;

	[Token(Token = "0x401498B")]
	[FieldOffset(Offset = "0x12C")]
	public GameObject Waiting;

	[Token(Token = "0x401498C")]
	[FieldOffset(Offset = "0x130")]
	public UILabel WatingLabel;

	[Token(Token = "0x401498D")]
	[FieldOffset(Offset = "0x134")]
	public GameObject RoomCardTips;

	[Token(Token = "0x401498E")]
	[FieldOffset(Offset = "0x138")]
	public GameObject RoomCardGo;

	[Token(Token = "0x401498F")]
	[FieldOffset(Offset = "0x13C")]
	public UIButton RoomCardBtn;

	[Token(Token = "0x4014990")]
	[FieldOffset(Offset = "0x140")]
	public GameObject LoadoutGo;

	[Token(Token = "0x4014991")]
	[FieldOffset(Offset = "0x144")]
	public GameObject ObserverListGo;

	[Token(Token = "0x4014992")]
	[FieldOffset(Offset = "0x148")]
	public UIScrollView ObserverListScrollView;

	[Token(Token = "0x4014993")]
	[FieldOffset(Offset = "0x14C")]
	public UIGrid ObserverListGrid;

	[Token(Token = "0x4014994")]
	[FieldOffset(Offset = "0x150")]
	public UIButton OBHideBtn;

	[Token(Token = "0x4014995")]
	[FieldOffset(Offset = "0x154")]
	public UIButton OBShowBtn;

	[Token(Token = "0x4014996")]
	[FieldOffset(Offset = "0x158")]
	public UILabel OBTitle;

	[Token(Token = "0x4014997")]
	[FieldOffset(Offset = "0x15C")]
	public UILabel OBCount;

	[Token(Token = "0x4014998")]
	[FieldOffset(Offset = "0x160")]
	public UIScrollView PlayerListScrollView;

	[Token(Token = "0x4014999")]
	[FieldOffset(Offset = "0x164")]
	public UIEasyList PlayerListGrid;

	[Token(Token = "0x401499A")]
	[FieldOffset(Offset = "0x168")]
	public UIButton BackBtn;

	[Token(Token = "0x401499B")]
	[FieldOffset(Offset = "0x16C")]
	public GameObject ChatContainer;

	[Token(Token = "0x401499C")]
	[FieldOffset(Offset = "0x170")]
	public UIScrollView RoomChatScrollView;

	[Token(Token = "0x401499D")]
	[FieldOffset(Offset = "0x174")]
	public UIPanel RoomChatPanel;

	[Token(Token = "0x401499E")]
	[FieldOffset(Offset = "0x178")]
	public UITable MessageTable;

	[Token(Token = "0x401499F")]
	[FieldOffset(Offset = "0x17C")]
	public UIWidget DragCollider;

	[Token(Token = "0x40149A0")]
	[FieldOffset(Offset = "0x180")]
	public UIButton ChatDragColliderBtn;

	[Token(Token = "0x40149A1")]
	[FieldOffset(Offset = "0x184")]
	public UISprite ChatBG;

	[Token(Token = "0x40149A2")]
	[FieldOffset(Offset = "0x188")]
	public GameObject NoMessage;

	[Token(Token = "0x40149A3")]
	[FieldOffset(Offset = "0x18C")]
	public UISlider ProgressBar;

	[Token(Token = "0x40149A4")]
	[FieldOffset(Offset = "0x190")]
	public GameObject ChatStyle1;

	[Token(Token = "0x40149A5")]
	[FieldOffset(Offset = "0x194")]
	public UIButton ChatBtn;

	[Token(Token = "0x40149A6")]
	[FieldOffset(Offset = "0x198")]
	public GameObject ChatStyle2;

	[Token(Token = "0x40149A7")]
	[FieldOffset(Offset = "0x19C")]
	public UIButton ChatBtn2;

	[Token(Token = "0x40149A8")]
	[FieldOffset(Offset = "0x1A0")]
	public GameObject VoiceChatBtn;

	[Token(Token = "0x40149A9")]
	[FieldOffset(Offset = "0x1A4")]
	public UIButton MicToggle;

	[Token(Token = "0x40149AA")]
	[FieldOffset(Offset = "0x1A8")]
	public UISprite MicSprite;

	[Token(Token = "0x40149AB")]
	[FieldOffset(Offset = "0x1AC")]
	public UISprite MicMask;

	[Token(Token = "0x40149AC")]
	[FieldOffset(Offset = "0x1B0")]
	public UISprite MicBan;

	[Token(Token = "0x40149AD")]
	[FieldOffset(Offset = "0x1B4")]
	public UIButton SpeakerToggle;

	[Token(Token = "0x40149AE")]
	[FieldOffset(Offset = "0x1B8")]
	public UISprite SpeakerSprite;

	[Token(Token = "0x40149AF")]
	[FieldOffset(Offset = "0x1BC")]
	public UISprite SpeakerMask;

	[Token(Token = "0x40149B0")]
	[FieldOffset(Offset = "0x1C0")]
	public GameObject SystemHint;

	[Token(Token = "0x40149B1")]
	[FieldOffset(Offset = "0x1C4")]
	public UILabel SystemHintLabel;

	[Token(Token = "0x40149B2")]
	[FieldOffset(Offset = "0x1C8")]
	public Transform DownloadContainer;

	[Token(Token = "0x40149B3")]
	[FieldOffset(Offset = "0x1CC")]
	public GameObject DownloadBg;

	[Token(Token = "0x40149B4")]
	[FieldOffset(Offset = "0x1D0")]
	public UISprite InfoPanelBG2;

	[Token(Token = "0x60161BE")]
	[Address(RVA = "0x11ECAB8", Offset = "0x11ECAB8", VA = "0x11ECAB8")]
	public UICustomRoomView()
	{
	}

	[Token(Token = "0x60161BF")]
	[Address(RVA = "0x11ECAC0", Offset = "0x11ECAC0", VA = "0x11ECAC0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161C0")]
	[Address(RVA = "0x11EF408", Offset = "0x11EF408", VA = "0x11EF408")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
