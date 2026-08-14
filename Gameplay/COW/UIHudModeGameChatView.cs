using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036B5")]
public class UIHudModeGameChatView : UIBaseView
{
	[Token(Token = "0x40160D6")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ChatPanelContainer;

	[Token(Token = "0x40160D7")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ChatPanelContainerBg;

	[Token(Token = "0x40160D8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NoChatLabel;

	[Token(Token = "0x40160D9")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ChatPanel;

	[Token(Token = "0x40160DA")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ChatItemTemplate;

	[Token(Token = "0x40160DB")]
	[FieldOffset(Offset = "0x28")]
	public UIButton QuickViewBtn;

	[Token(Token = "0x40160DC")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ChatContainer;

	[Token(Token = "0x40160DD")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BeforeInput;

	[Token(Token = "0x40160DE")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AfterInput;

	[Token(Token = "0x40160DF")]
	[FieldOffset(Offset = "0x38")]
	public UILabel InputLabel;

	[Token(Token = "0x40160E0")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton SendBtn;

	[Token(Token = "0x40160E1")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SendBtnSprite;

	[Token(Token = "0x40160E2")]
	[FieldOffset(Offset = "0x44")]
	public GameObject CDContainer;

	[Token(Token = "0x40160E3")]
	[FieldOffset(Offset = "0x48")]
	public UILabel CDLabel;

	[Token(Token = "0x40160E4")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton HideQuickViewBtn;

	[Token(Token = "0x40160E5")]
	[FieldOffset(Offset = "0x50")]
	public Transform Arrow;

	[Token(Token = "0x60167CC")]
	[Address(RVA = "0x1F47174", Offset = "0x1F47174", VA = "0x1F47174")]
	public UIHudModeGameChatView()
	{
	}

	[Token(Token = "0x60167CD")]
	[Address(RVA = "0x1F4717C", Offset = "0x1F4717C", VA = "0x1F4717C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167CE")]
	[Address(RVA = "0x1F4783C", Offset = "0x1F4783C", VA = "0x1F4783C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
