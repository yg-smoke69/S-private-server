using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038BC")]
public class UIMysteryMallShareView : UIBaseView
{
	[Token(Token = "0x40177B9")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelLuckNum;

	[Token(Token = "0x40177BA")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture CndBgTexture;

	[Token(Token = "0x40177BB")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnShare;

	[Token(Token = "0x40177BC")]
	[FieldOffset(Offset = "0x20")]
	public Animator ShareIconAnimator;

	[Token(Token = "0x6016DDF")]
	[Address(RVA = "0x1B2D0F0", Offset = "0x1B2D0F0", VA = "0x1B2D0F0")]
	public UIMysteryMallShareView()
	{
	}

	[Token(Token = "0x6016DE0")]
	[Address(RVA = "0x1B2D0F8", Offset = "0x1B2D0F8", VA = "0x1B2D0F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DE1")]
	[Address(RVA = "0x1B2D3C0", Offset = "0x1B2D3C0", VA = "0x1B2D3C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
