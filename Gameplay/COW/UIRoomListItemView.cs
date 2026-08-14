using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003965")]
public class UIRoomListItemView : UIBaseView
{
	[Token(Token = "0x4018057")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIButtonUIRoomListItem;

	[Token(Token = "0x4018058")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget UIWidgetUIRoomListItem;

	[Token(Token = "0x4018059")]
	[FieldOffset(Offset = "0x1C")]
	public TweenPosition TweenPositionUIRoomListItem;

	[Token(Token = "0x401805A")]
	[FieldOffset(Offset = "0x20")]
	public TweenAlpha TweenAlphaUIRoomListItem;

	[Token(Token = "0x401805B")]
	[FieldOffset(Offset = "0x24")]
	public UISprite WeatherSprite;

	[Token(Token = "0x401805C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel MapName;

	[Token(Token = "0x401805D")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Icon;

	[Token(Token = "0x401805E")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Map;

	[Token(Token = "0x401805F")]
	[FieldOffset(Offset = "0x34")]
	public UINetworkTexture CDNMap;

	[Token(Token = "0x4018060")]
	[FieldOffset(Offset = "0x38")]
	public UITable Flags;

	[Token(Token = "0x4018061")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ID;

	[Token(Token = "0x4018062")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Lock;

	[Token(Token = "0x4018063")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Emulator;

	[Token(Token = "0x4018064")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Status;

	[Token(Token = "0x4018065")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel Name;

	[Token(Token = "0x4018066")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Effect_Glow;

	[Token(Token = "0x4018067")]
	[FieldOffset(Offset = "0x54")]
	public GameObject Sole;

	[Token(Token = "0x4018068")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Duo;

	[Token(Token = "0x4018069")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject Triple;

	[Token(Token = "0x401806A")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Quad;

	[Token(Token = "0x401806B")]
	[FieldOffset(Offset = "0x64")]
	public GameObject MulitRoot;

	[Token(Token = "0x401806C")]
	[FieldOffset(Offset = "0x68")]
	public GameObject IconHead;

	[Token(Token = "0x401806D")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel Count;

	[Token(Token = "0x401806E")]
	[FieldOffset(Offset = "0x70")]
	public UILabel Players;

	[Token(Token = "0x401806F")]
	[FieldOffset(Offset = "0x74")]
	public UILabel ModeName;

	[Token(Token = "0x4018070")]
	[FieldOffset(Offset = "0x78")]
	public UISprite LanguageSprite;

	[Token(Token = "0x4018071")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel DropList;

	[Token(Token = "0x4018072")]
	[FieldOffset(Offset = "0x80")]
	public GameObject Penta;

	[Token(Token = "0x4018073")]
	[FieldOffset(Offset = "0x84")]
	public Animation InAnim;

	[Token(Token = "0x6016FD6")]
	[Address(RVA = "0x23D17D4", Offset = "0x23D17D4", VA = "0x23D17D4")]
	public UIRoomListItemView()
	{
	}

	[Token(Token = "0x6016FD7")]
	[Address(RVA = "0x23D17DC", Offset = "0x23D17DC", VA = "0x23D17DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FD8")]
	[Address(RVA = "0x23D238C", Offset = "0x23D238C", VA = "0x23D238C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
