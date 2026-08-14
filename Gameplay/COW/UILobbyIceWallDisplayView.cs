using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003842")]
public class UILobbyIceWallDisplayView : UIBaseView
{
	[Token(Token = "0x4016F9F")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition RightTween;

	[Token(Token = "0x4016FA0")]
	[FieldOffset(Offset = "0x18")]
	public Transform PopMenu;

	[Token(Token = "0x4016FA1")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4016FA2")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList Grid;

	[Token(Token = "0x4016FA3")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Empty;

	[Token(Token = "0x4016FA4")]
	[FieldOffset(Offset = "0x28")]
	public UIButton GoShopButton;

	[Token(Token = "0x4016FA5")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton RemoveButton;

	[Token(Token = "0x4016FA6")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget GuideRoot;

	[Token(Token = "0x4016FA7")]
	[FieldOffset(Offset = "0x34")]
	public UIButton AutoRotateToggle;

	[Token(Token = "0x4016FA8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ShowOn;

	[Token(Token = "0x4016FA9")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ShowOff;

	[Token(Token = "0x4016FAA")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget AutoRotateGuideRoot;

	[Token(Token = "0x4016FAB")]
	[FieldOffset(Offset = "0x44")]
	public GameObject NaviPage;

	[Token(Token = "0x4016FAC")]
	[FieldOffset(Offset = "0x48")]
	public UIButton HelpBtn;

	[Token(Token = "0x4016FAD")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton leaveBtn;

	[Token(Token = "0x4016FAE")]
	[FieldOffset(Offset = "0x50")]
	public UIButton GotoShopCollectionSkin;

	[Token(Token = "0x6016C71")]
	[Address(RVA = "0xDBA138", Offset = "0xDBA138", VA = "0xDBA138")]
	public UILobbyIceWallDisplayView()
	{
	}

	[Token(Token = "0x6016C72")]
	[Address(RVA = "0xDBA140", Offset = "0xDBA140", VA = "0xDBA140", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C73")]
	[Address(RVA = "0xDBA830", Offset = "0xDBA830", VA = "0xDBA830")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
