using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003428")]
public class UIChangeServerView : UIBaseView
{
	[Token(Token = "0x40142C0")]
	[FieldOffset(Offset = "0x14")]
	public UISprite bg;

	[Token(Token = "0x40142C1")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha BgTweenAlpha;

	[Token(Token = "0x40142C2")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton close;

	[Token(Token = "0x40142C3")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid ServerListGrid;

	[Token(Token = "0x40142C4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Instance;

	[Token(Token = "0x40142C5")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ServerRegion;

	[Token(Token = "0x40142C6")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnConfirm;

	[Token(Token = "0x601602C")]
	[Address(RVA = "0x2629838", Offset = "0x2629838", VA = "0x2629838")]
	public UIChangeServerView()
	{
	}

	[Token(Token = "0x601602D")]
	[Address(RVA = "0x2629840", Offset = "0x2629840", VA = "0x2629840", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601602E")]
	[Address(RVA = "0x2629C1C", Offset = "0x2629C1C", VA = "0x2629C1C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
