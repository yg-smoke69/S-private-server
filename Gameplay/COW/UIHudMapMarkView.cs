using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036A7")]
public class UIHudMapMarkView : UIBaseView
{
	[Token(Token = "0x401600F")]
	[FieldOffset(Offset = "0x14")]
	public TweenAlpha MarkTween;

	[Token(Token = "0x4016010")]
	[FieldOffset(Offset = "0x18")]
	public UISprite MarkIcon;

	[Token(Token = "0x4016011")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite LeaderIcon;

	[Token(Token = "0x4016012")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ArrowUp;

	[Token(Token = "0x4016013")]
	[FieldOffset(Offset = "0x24")]
	public GameObject arrowRight;

	[Token(Token = "0x4016014")]
	[FieldOffset(Offset = "0x28")]
	public GameObject arrowDown;

	[Token(Token = "0x4016015")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject arrowLeft;

	[Token(Token = "0x60167A2")]
	[Address(RVA = "0xFFA6C4", Offset = "0xFFA6C4", VA = "0xFFA6C4")]
	public UIHudMapMarkView()
	{
	}

	[Token(Token = "0x60167A3")]
	[Address(RVA = "0xFFA6CC", Offset = "0xFFA6CC", VA = "0xFFA6CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167A4")]
	[Address(RVA = "0xFFAA84", Offset = "0xFFAA84", VA = "0xFFAA84")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
