using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039FE")]
public class UITopButtonGotoTokenView : UIBaseView
{
	[Token(Token = "0x401870B")]
	[FieldOffset(Offset = "0x14")]
	public UISprite TokenIcon;

	[Token(Token = "0x401870C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TokenAmountLabel;

	[Token(Token = "0x401870D")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton GotoBtn;

	[Token(Token = "0x401870E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GotoIcon;

	[Token(Token = "0x60171A0")]
	[Address(RVA = "0x2AE8A00", Offset = "0x2AE8A00", VA = "0x2AE8A00")]
	public UITopButtonGotoTokenView()
	{
	}

	[Token(Token = "0x60171A1")]
	[Address(RVA = "0x2AE8A08", Offset = "0x2AE8A08", VA = "0x2AE8A08", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171A2")]
	[Address(RVA = "0x2AE8CC4", Offset = "0x2AE8CC4", VA = "0x2AE8CC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
