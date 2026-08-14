using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003969")]
public class UIRoomObserverItemView : UIBaseView
{
	[Token(Token = "0x4018098")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ObserverItem;

	[Token(Token = "0x4018099")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget UIRoomObserverItem;

	[Token(Token = "0x401809A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Id;

	[Token(Token = "0x401809B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Tag;

	[Token(Token = "0x401809C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ReadyMark;

	[Token(Token = "0x401809D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SelfBg;

	[Token(Token = "0x401809E")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget NameWidget;

	[Token(Token = "0x401809F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Name;

	[Token(Token = "0x40180A0")]
	[FieldOffset(Offset = "0x34")]
	public UISprite MapResState;

	[Token(Token = "0x40180A1")]
	[FieldOffset(Offset = "0x38")]
	public GameObject DownloadingEffect;

	[Token(Token = "0x6016FE2")]
	[Address(RVA = "0x23D7598", Offset = "0x23D7598", VA = "0x23D7598")]
	public UIRoomObserverItemView()
	{
	}

	[Token(Token = "0x6016FE3")]
	[Address(RVA = "0x23D75A0", Offset = "0x23D75A0", VA = "0x23D75A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FE4")]
	[Address(RVA = "0x23D7A78", Offset = "0x23D7A78", VA = "0x23D7A78")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
