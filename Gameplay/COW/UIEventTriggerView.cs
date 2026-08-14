using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200352C")]
public class UIEventTriggerView : UIBaseView
{
	[Token(Token = "0x4015000")]
	[FieldOffset(Offset = "0x14")]
	public UISprite triggerImg;

	[Token(Token = "0x4015001")]
	[FieldOffset(Offset = "0x18")]
	public UISprite triggerBG;

	[Token(Token = "0x4015002")]
	[FieldOffset(Offset = "0x1C")]
	public TweenAlpha TweenAlphaBg;

	[Token(Token = "0x4015003")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Distance;

	[Token(Token = "0x6016334")]
	[Address(RVA = "0x19DD480", Offset = "0x19DD480", VA = "0x19DD480")]
	public UIEventTriggerView()
	{
	}

	[Token(Token = "0x6016335")]
	[Address(RVA = "0x19DD488", Offset = "0x19DD488", VA = "0x19DD488", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016336")]
	[Address(RVA = "0x19DD750", Offset = "0x19DD750", VA = "0x19DD750")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
