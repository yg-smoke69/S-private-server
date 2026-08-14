using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200364E")]
public class UIHudEventDropNumView : UIBaseView
{
	[Token(Token = "0x4015C90")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIHudEventDropNum;

	[Token(Token = "0x4015C91")]
	[FieldOffset(Offset = "0x18")]
	public UILabel NumLabel;

	[Token(Token = "0x4015C92")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ItemIcon;

	[Token(Token = "0x6016697")]
	[Address(RVA = "0x1B9A2A4", Offset = "0x1B9A2A4", VA = "0x1B9A2A4")]
	public UIHudEventDropNumView()
	{
	}

	[Token(Token = "0x6016698")]
	[Address(RVA = "0x1B9A2AC", Offset = "0x1B9A2AC", VA = "0x1B9A2AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016699")]
	[Address(RVA = "0x1B9A508", Offset = "0x1B9A508", VA = "0x1B9A508")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
