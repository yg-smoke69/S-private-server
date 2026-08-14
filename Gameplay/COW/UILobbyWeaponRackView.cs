using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003854")]
public class UILobbyWeaponRackView : UIBaseView
{
	[Token(Token = "0x401714D")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Guide;

	[Token(Token = "0x401714E")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition RightTween;

	[Token(Token = "0x401714F")]
	[FieldOffset(Offset = "0x1C")]
	public Transform PopMenuGun;

	[Token(Token = "0x4017150")]
	[FieldOffset(Offset = "0x20")]
	public Transform PopMenuRare;

	[Token(Token = "0x4017151")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4017152")]
	[FieldOffset(Offset = "0x28")]
	public UIEasyList Grid;

	[Token(Token = "0x4017153")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Empty;

	[Token(Token = "0x4017154")]
	[FieldOffset(Offset = "0x30")]
	public UIButton GoShopButton;

	[Token(Token = "0x4017155")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid Slots;

	[Token(Token = "0x4017156")]
	[FieldOffset(Offset = "0x38")]
	public GameObject NaviPage;

	[Token(Token = "0x4017157")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton HelpBtn;

	[Token(Token = "0x4017158")]
	[FieldOffset(Offset = "0x40")]
	public UIButton leaveBtn;

	[Token(Token = "0x4017159")]
	[FieldOffset(Offset = "0x44")]
	public UIButton GotoShopCollectionSkin;

	[Token(Token = "0x6016CA7")]
	[Address(RVA = "0x21E48F4", Offset = "0x21E48F4", VA = "0x21E48F4")]
	public UILobbyWeaponRackView()
	{
	}

	[Token(Token = "0x6016CA8")]
	[Address(RVA = "0x21E48FC", Offset = "0x21E48FC", VA = "0x21E48FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CA9")]
	[Address(RVA = "0x21E4EB0", Offset = "0x21E4EB0", VA = "0x21E4EB0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
