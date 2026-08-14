using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003852")]
public class UILobbyVehicleDisplayView : UIBaseView
{
	[Token(Token = "0x401712C")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition RightTween;

	[Token(Token = "0x401712D")]
	[FieldOffset(Offset = "0x18")]
	public Transform PopMenu;

	[Token(Token = "0x401712E")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x401712F")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList Grid;

	[Token(Token = "0x4017130")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Empty;

	[Token(Token = "0x4017131")]
	[FieldOffset(Offset = "0x28")]
	public UIButton GoShopButton;

	[Token(Token = "0x4017132")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton RemoveButton;

	[Token(Token = "0x4017133")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget GuideRoot;

	[Token(Token = "0x4017134")]
	[FieldOffset(Offset = "0x34")]
	public UIButton AutoRotateToggle;

	[Token(Token = "0x4017135")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ShowOn;

	[Token(Token = "0x4017136")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ShowOff;

	[Token(Token = "0x4017137")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget AutoRotateGuideRoot;

	[Token(Token = "0x4017138")]
	[FieldOffset(Offset = "0x44")]
	public GameObject NaviPage;

	[Token(Token = "0x4017139")]
	[FieldOffset(Offset = "0x48")]
	public UIButton HelpBtn;

	[Token(Token = "0x401713A")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton leaveBtn;

	[Token(Token = "0x401713B")]
	[FieldOffset(Offset = "0x50")]
	public UIButton GotoShopCollectionSkin;

	[Token(Token = "0x6016CA1")]
	[Address(RVA = "0x1CC0E64", Offset = "0x1CC0E64", VA = "0x1CC0E64")]
	public UILobbyVehicleDisplayView()
	{
	}

	[Token(Token = "0x6016CA2")]
	[Address(RVA = "0x1CC0E6C", Offset = "0x1CC0E6C", VA = "0x1CC0E6C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CA3")]
	[Address(RVA = "0x1CC155C", Offset = "0x1CC155C", VA = "0x1CC155C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
