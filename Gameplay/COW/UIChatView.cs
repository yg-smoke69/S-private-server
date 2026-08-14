using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003436")]
public class UIChatView : UIBaseView
{
	[Token(Token = "0x4014338")]
	[FieldOffset(Offset = "0x14")]
	public UIEasyList ChannelList;

	[Token(Token = "0x4014339")]
	[FieldOffset(Offset = "0x18")]
	public GameObject InputNode;

	[Token(Token = "0x401433A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SendMessageContainer;

	[Token(Token = "0x401433B")]
	[FieldOffset(Offset = "0x20")]
	public UIInput InputContainer;

	[Token(Token = "0x401433C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel InputDefaultLabel;

	[Token(Token = "0x401433D")]
	[FieldOffset(Offset = "0x28")]
	public UIButton EnterBtn;

	[Token(Token = "0x401433E")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid OtherSendBtnGrid;

	[Token(Token = "0x401433F")]
	[FieldOffset(Offset = "0x30")]
	public UIButton OpenStickerBtn;

	[Token(Token = "0x4014340")]
	[FieldOffset(Offset = "0x34")]
	public UIButton LoudSpeakerBtn;

	[Token(Token = "0x4014341")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SpeakerIcon;

	[Token(Token = "0x4014342")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel SpeakerNum;

	[Token(Token = "0x4014343")]
	[FieldOffset(Offset = "0x40")]
	public GameObject MutedNode;

	[Token(Token = "0x4014344")]
	[FieldOffset(Offset = "0x44")]
	public UIButton MutedHintBtn;

	[Token(Token = "0x4014345")]
	[FieldOffset(Offset = "0x48")]
	public Transform MutedCountDown;

	[Token(Token = "0x4014346")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject NewMessage;

	[Token(Token = "0x4014347")]
	[FieldOffset(Offset = "0x50")]
	public UIButton NewMessageBtn;

	[Token(Token = "0x4014348")]
	[FieldOffset(Offset = "0x54")]
	public UILabel NewMessageLabel;

	[Token(Token = "0x4014349")]
	[FieldOffset(Offset = "0x58")]
	public GameObject IngameHint;

	[Token(Token = "0x401434A")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel WhisperStatusHint;

	[Token(Token = "0x401434B")]
	[FieldOffset(Offset = "0x60")]
	public GameObject StickerNode;

	[Token(Token = "0x401434C")]
	[FieldOffset(Offset = "0x64")]
	public UIButton CloseStickerBtn;

	[Token(Token = "0x401434D")]
	[FieldOffset(Offset = "0x68")]
	public UIToggleButtonGroup StickerToggleBtnGroup;

	[Token(Token = "0x401434E")]
	[FieldOffset(Offset = "0x6C")]
	public UIGrid StickerTabGrid;

	[Token(Token = "0x401434F")]
	[FieldOffset(Offset = "0x70")]
	public StickerTabView StickerTabItemInstance;

	[Token(Token = "0x4014350")]
	[FieldOffset(Offset = "0x74")]
	public UIScrollView StickerSpriteList;

	[Token(Token = "0x4014351")]
	[FieldOffset(Offset = "0x78")]
	public UITable StickerSpriteTable;

	[Token(Token = "0x4014352")]
	[FieldOffset(Offset = "0x7C")]
	public StickerSpriteView StickerSpriteInstance;

	[Token(Token = "0x4014353")]
	[FieldOffset(Offset = "0x80")]
	public GameObject PurchaseGameObject;

	[Token(Token = "0x4014354")]
	[FieldOffset(Offset = "0x84")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x4014355")]
	[FieldOffset(Offset = "0x88")]
	public GameObject DiamondGO;

	[Token(Token = "0x4014356")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel StickerPriceDiamond;

	[Token(Token = "0x4014357")]
	[FieldOffset(Offset = "0x90")]
	public GameObject CoinGO;

	[Token(Token = "0x4014358")]
	[FieldOffset(Offset = "0x94")]
	public UILabel StickerPriceCoin;

	[Token(Token = "0x4014359")]
	[FieldOffset(Offset = "0x98")]
	public GameObject GoposGo;

	[Token(Token = "0x401435A")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel StickerPriceGopos;

	[Token(Token = "0x401435B")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject Interaction;

	[Token(Token = "0x401435C")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel InteractionLabel;

	[Token(Token = "0x401435D")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject InteractionBtnContainer;

	[Token(Token = "0x401435E")]
	[FieldOffset(Offset = "0xAC")]
	public UIButton InteractionBtn;

	[Token(Token = "0x401435F")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite InteractionBtnSprite;

	[Token(Token = "0x4014360")]
	[FieldOffset(Offset = "0xB4")]
	public UISprite InteractionBtnIcon;

	[Token(Token = "0x4014361")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite InteractionBtnLight;

	[Token(Token = "0x4014362")]
	[FieldOffset(Offset = "0xBC")]
	public Transform MessageContainer;

	[Token(Token = "0x4014363")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject ContentNode;

	[Token(Token = "0x4014364")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject NormalMessageNode;

	[Token(Token = "0x4014365")]
	[FieldOffset(Offset = "0xC8")]
	public UIScrollView MessageList;

	[Token(Token = "0x4014366")]
	[FieldOffset(Offset = "0xCC")]
	public UITable MessageListTable;

	[Token(Token = "0x4014367")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject EmptyNode;

	[Token(Token = "0x4014368")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject NoMessageHint;

	[Token(Token = "0x6016056")]
	[Address(RVA = "0x207E4B8", Offset = "0x207E4B8", VA = "0x207E4B8")]
	public UIChatView()
	{
	}

	[Token(Token = "0x6016057")]
	[Address(RVA = "0x207E4C0", Offset = "0x207E4C0", VA = "0x207E4C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016058")]
	[Address(RVA = "0x207F758", Offset = "0x207F758", VA = "0x207F758")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
