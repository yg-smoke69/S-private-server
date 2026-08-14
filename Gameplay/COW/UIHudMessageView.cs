using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036B3")]
public class UIHudMessageView : UIBaseView
{
	[Token(Token = "0x4016098")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget MaskContainer;

	[Token(Token = "0x4016099")]
	[FieldOffset(Offset = "0x18")]
	public GameObject QuickChatContent;

	[Token(Token = "0x401609A")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView QuickChatList;

	[Token(Token = "0x401609B")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid QuickChatListGrid;

	[Token(Token = "0x401609C")]
	[FieldOffset(Offset = "0x24")]
	public UIToggle QuickChatBlockToggle;

	[Token(Token = "0x401609D")]
	[FieldOffset(Offset = "0x28")]
	public UISprite QuickChatSprite;

	[Token(Token = "0x401609E")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget QuickChatSoundBlock;

	[Token(Token = "0x401609F")]
	[FieldOffset(Offset = "0x30")]
	public UIToggle QuickChatSoundBlockToggle;

	[Token(Token = "0x40160A0")]
	[FieldOffset(Offset = "0x34")]
	public UISprite QuickChatSoundBanSprite;

	[Token(Token = "0x40160A1")]
	[FieldOffset(Offset = "0x38")]
	public UISprite QuickChatSoundSprite;

	[Token(Token = "0x40160A2")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite QuickChatSoundBG;

	[Token(Token = "0x40160A3")]
	[FieldOffset(Offset = "0x40")]
	public UILabel QuickChatSoundBlockLabel;

	[Token(Token = "0x40160A4")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ReservationContent;

	[Token(Token = "0x40160A5")]
	[FieldOffset(Offset = "0x48")]
	public UIGrid ReservationList;

	[Token(Token = "0x40160A6")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel ReservationOffHint;

	[Token(Token = "0x40160A7")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ReservationBlock;

	[Token(Token = "0x40160A8")]
	[FieldOffset(Offset = "0x54")]
	public UIToggle ReservationBlockToggle;

	[Token(Token = "0x40160A9")]
	[FieldOffset(Offset = "0x58")]
	public GameObject StickerContent;

	[Token(Token = "0x40160AA")]
	[FieldOffset(Offset = "0x5C")]
	public UIScrollView ScrollViewSticker;

	[Token(Token = "0x40160AB")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid StickerGrid;

	[Token(Token = "0x40160AC")]
	[FieldOffset(Offset = "0x64")]
	public StickerSpriteView StickerInstance;

	[Token(Token = "0x40160AD")]
	[FieldOffset(Offset = "0x68")]
	public GameObject TrainingModeMessageContent;

	[Token(Token = "0x40160AE")]
	[FieldOffset(Offset = "0x6C")]
	public UIInput MessageInput;

	[Token(Token = "0x40160AF")]
	[FieldOffset(Offset = "0x70")]
	public UIButton SendBtn;

	[Token(Token = "0x40160B0")]
	[FieldOffset(Offset = "0x74")]
	public UIToggleButtonGroup ToggleBtnGroup;

	[Token(Token = "0x40160B1")]
	[FieldOffset(Offset = "0x78")]
	public UIGrid BtnGrid;

	[Token(Token = "0x40160B2")]
	[FieldOffset(Offset = "0x7C")]
	public UIToggleButton StickerToggle;

	[Token(Token = "0x40160B3")]
	[FieldOffset(Offset = "0x80")]
	public UISprite StickerChosen;

	[Token(Token = "0x40160B4")]
	[FieldOffset(Offset = "0x84")]
	public UISprite StickerNormal;

	[Token(Token = "0x40160B5")]
	[FieldOffset(Offset = "0x88")]
	public UIToggleButton QuickChatToggle;

	[Token(Token = "0x40160B6")]
	[FieldOffset(Offset = "0x8C")]
	public UIToggleButton ReservationToggle;

	[Token(Token = "0x40160B7")]
	[FieldOffset(Offset = "0x90")]
	public GameObject ReservationToggleSprite;

	[Token(Token = "0x40160B8")]
	[FieldOffset(Offset = "0x94")]
	public GameObject ReservationToggleSpriteBanned;

	[Token(Token = "0x40160B9")]
	[FieldOffset(Offset = "0x98")]
	public GameObject UnreadTip;

	[Token(Token = "0x40160BA")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite QuickChatToggleIconSelect;

	[Token(Token = "0x40160BB")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite QuickChatToggleIconUnSelect;

	[Token(Token = "0x60167C6")]
	[Address(RVA = "0x19CA3E0", Offset = "0x19CA3E0", VA = "0x19CA3E0")]
	public UIHudMessageView()
	{
	}

	[Token(Token = "0x60167C7")]
	[Address(RVA = "0x19CA3E8", Offset = "0x19CA3E8", VA = "0x19CA3E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167C8")]
	[Address(RVA = "0x19CB250", Offset = "0x19CB250", VA = "0x19CB250")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
