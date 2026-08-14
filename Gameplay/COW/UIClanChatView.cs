using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003448")]
public class UIClanChatView : UIBaseView
{
	[Token(Token = "0x401440E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject EmptyNode;

	[Token(Token = "0x401440F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ContentNode;

	[Token(Token = "0x4014410")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView MessageList;

	[Token(Token = "0x4014411")]
	[FieldOffset(Offset = "0x20")]
	public UITable MessageListTable;

	[Token(Token = "0x4014412")]
	[FieldOffset(Offset = "0x24")]
	public GameObject MutedNode;

	[Token(Token = "0x4014413")]
	[FieldOffset(Offset = "0x28")]
	public UIButton MutedHintBtn;

	[Token(Token = "0x4014414")]
	[FieldOffset(Offset = "0x2C")]
	public Transform MutedCountDown;

	[Token(Token = "0x4014415")]
	[FieldOffset(Offset = "0x30")]
	public GameObject SendMessageContainer;

	[Token(Token = "0x4014416")]
	[FieldOffset(Offset = "0x34")]
	public UIInput InputContainer;

	[Token(Token = "0x4014417")]
	[FieldOffset(Offset = "0x38")]
	public UIButton EnterBtn;

	[Token(Token = "0x4014418")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton OpenStickerBtn;

	[Token(Token = "0x4014419")]
	[FieldOffset(Offset = "0x40")]
	public GameObject NewMessage;

	[Token(Token = "0x401441A")]
	[FieldOffset(Offset = "0x44")]
	public UIButton NewMessageBtn;

	[Token(Token = "0x401441B")]
	[FieldOffset(Offset = "0x48")]
	public UILabel NewMessageLabel;

	[Token(Token = "0x401441C")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject IngameHint;

	[Token(Token = "0x401441D")]
	[FieldOffset(Offset = "0x50")]
	public UILabel WhisperStatusHint;

	[Token(Token = "0x401441E")]
	[FieldOffset(Offset = "0x54")]
	public GameObject StickerNode;

	[Token(Token = "0x401441F")]
	[FieldOffset(Offset = "0x58")]
	public UIButton CloseStickerBtn;

	[Token(Token = "0x4014420")]
	[FieldOffset(Offset = "0x5C")]
	public UIToggleButtonGroup StickerToggleBtnGroup;

	[Token(Token = "0x4014421")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid StickerTabGrid;

	[Token(Token = "0x4014422")]
	[FieldOffset(Offset = "0x64")]
	public StickerTabView StickerTabItemInstance;

	[Token(Token = "0x4014423")]
	[FieldOffset(Offset = "0x68")]
	public UIScrollView StickerSpriteList;

	[Token(Token = "0x4014424")]
	[FieldOffset(Offset = "0x6C")]
	public UITable StickerSpriteTable;

	[Token(Token = "0x4014425")]
	[FieldOffset(Offset = "0x70")]
	public StickerSpriteView StickerSpriteInstance;

	[Token(Token = "0x4014426")]
	[FieldOffset(Offset = "0x74")]
	public GameObject OwnedObject;

	[Token(Token = "0x4014427")]
	[FieldOffset(Offset = "0x78")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x4014428")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject DiamondGO;

	[Token(Token = "0x4014429")]
	[FieldOffset(Offset = "0x80")]
	public UILabel StickerPriceDiamond;

	[Token(Token = "0x401442A")]
	[FieldOffset(Offset = "0x84")]
	public GameObject CoinGO;

	[Token(Token = "0x401442B")]
	[FieldOffset(Offset = "0x88")]
	public UILabel StickerPriceCoin;

	[Token(Token = "0x601608C")]
	[Address(RVA = "0x2F28748", Offset = "0x2F28748", VA = "0x2F28748")]
	public UIClanChatView()
	{
	}

	[Token(Token = "0x601608D")]
	[Address(RVA = "0x2F28750", Offset = "0x2F28750", VA = "0x2F28750", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601608E")]
	[Address(RVA = "0x2F29338", Offset = "0x2F29338", VA = "0x2F29338")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
