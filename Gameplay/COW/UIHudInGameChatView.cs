using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003675")]
public class UIHudInGameChatView : UIBaseView
{
	[Token(Token = "0x4015DC0")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ChatPanelContainer;

	[Token(Token = "0x4015DC1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ChatPanelContainerBg;

	[Token(Token = "0x4015DC2")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NoChatLabel;

	[Token(Token = "0x4015DC3")]
	[FieldOffset(Offset = "0x20")]
	public UIScrollView ChatPanel;

	[Token(Token = "0x4015DC4")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ChatItemTemplate;

	[Token(Token = "0x4015DC5")]
	[FieldOffset(Offset = "0x28")]
	public UIButton QuickViewBtn;

	[Token(Token = "0x4015DC6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ChatContainer;

	[Token(Token = "0x4015DC7")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BeforeInput;

	[Token(Token = "0x4015DC8")]
	[FieldOffset(Offset = "0x34")]
	public GameObject AfterInput;

	[Token(Token = "0x4015DC9")]
	[FieldOffset(Offset = "0x38")]
	public UILabel InputLabel;

	[Token(Token = "0x4015DCA")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject BulletScreenContainer;

	[Token(Token = "0x4015DCB")]
	[FieldOffset(Offset = "0x40")]
	public UILabel BulletScreenLabel;

	[Token(Token = "0x4015DCC")]
	[FieldOffset(Offset = "0x44")]
	public GameObject NoBulletScreen;

	[Token(Token = "0x4015DCD")]
	[FieldOffset(Offset = "0x48")]
	public UIButton HideQuickViewBtn;

	[Token(Token = "0x4015DCE")]
	[FieldOffset(Offset = "0x4C")]
	public Transform Arrow;

	[Token(Token = "0x4015DCF")]
	[FieldOffset(Offset = "0x50")]
	public UIButton BubbleBtn;

	[Token(Token = "0x4015DD0")]
	[FieldOffset(Offset = "0x54")]
	public UILabel NewMessageLabel;

	[Token(Token = "0x4015DD1")]
	[FieldOffset(Offset = "0x58")]
	public UIButton SendBtn;

	[Token(Token = "0x4015DD2")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject SendBtnSprite;

	[Token(Token = "0x4015DD3")]
	[FieldOffset(Offset = "0x60")]
	public GameObject CDContainer;

	[Token(Token = "0x4015DD4")]
	[FieldOffset(Offset = "0x64")]
	public UILabel CDLabel;

	[Token(Token = "0x601670C")]
	[Address(RVA = "0x2298FF4", Offset = "0x2298FF4", VA = "0x2298FF4")]
	public UIHudInGameChatView()
	{
	}

	[Token(Token = "0x601670D")]
	[Address(RVA = "0x2298FFC", Offset = "0x2298FFC", VA = "0x2298FFC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601670E")]
	[Address(RVA = "0x2299884", Offset = "0x2299884", VA = "0x2299884")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
