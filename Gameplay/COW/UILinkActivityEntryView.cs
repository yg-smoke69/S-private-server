using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003829")]
public class UILinkActivityEntryView : UIBaseView
{
	[Token(Token = "0x4016E4F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Btn;

	[Token(Token = "0x4016E50")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Sprite;

	[Token(Token = "0x4016E51")]
	[FieldOffset(Offset = "0x1C")]
	public TweenPosition TweenPosition;

	[Token(Token = "0x6016C26")]
	[Address(RVA = "0x2553C08", Offset = "0x2553C08", VA = "0x2553C08")]
	public UILinkActivityEntryView()
	{
	}

	[Token(Token = "0x6016C27")]
	[Address(RVA = "0x2553C10", Offset = "0x2553C10", VA = "0x2553C10", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C28")]
	[Address(RVA = "0x2553E78", Offset = "0x2553E78", VA = "0x2553E78")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
