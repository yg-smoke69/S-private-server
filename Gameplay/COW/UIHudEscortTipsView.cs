using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200364B")]
public class UIHudEscortTipsView : UIBaseView
{
	[Token(Token = "0x4015C77")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Content;

	[Token(Token = "0x4015C78")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BG;

	[Token(Token = "0x4015C79")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Message;

	[Token(Token = "0x601668E")]
	[Address(RVA = "0x1B954C8", Offset = "0x1B954C8", VA = "0x1B954C8")]
	public UIHudEscortTipsView()
	{
	}

	[Token(Token = "0x601668F")]
	[Address(RVA = "0x1B954D0", Offset = "0x1B954D0", VA = "0x1B954D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016690")]
	[Address(RVA = "0x1B9572C", Offset = "0x1B9572C", VA = "0x1B9572C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
