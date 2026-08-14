using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003661")]
public class UIHudGameShowInfoStyleView : UIBaseView
{
	[Token(Token = "0x4015D27")]
	[FieldOffset(Offset = "0x14")]
	public UILabel IntroKey;

	[Token(Token = "0x4015D28")]
	[FieldOffset(Offset = "0x18")]
	public UILabel IntroKeyBig;

	[Token(Token = "0x4015D29")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel IntroDetail;

	[Token(Token = "0x60166D0")]
	[Address(RVA = "0x188DF44", Offset = "0x188DF44", VA = "0x188DF44")]
	public UIHudGameShowInfoStyleView()
	{
	}

	[Token(Token = "0x60166D1")]
	[Address(RVA = "0x188DF4C", Offset = "0x188DF4C", VA = "0x188DF4C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166D2")]
	[Address(RVA = "0x188E1B4", Offset = "0x188E1B4", VA = "0x188E1B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
