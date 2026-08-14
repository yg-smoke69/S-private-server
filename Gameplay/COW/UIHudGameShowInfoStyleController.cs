using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002761")]
public class UIHudGameShowInfoStyleController : UIBaseController
{
	[Token(Token = "0x400F325")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGameShowInfoStyleView m_View;

	[Token(Token = "0x400F326")]
	[FieldOffset(Offset = "0x2C")]
	private Animation m_Animation;

	[Token(Token = "0x600F09D")]
	[Address(RVA = "0x188DDE0", Offset = "0x188DDE0", VA = "0x188DDE0")]
	public UIHudGameShowInfoStyleController()
	{
	}

	[Token(Token = "0x600F09E")]
	[Address(RVA = "0x188DE64", Offset = "0x188DE64", VA = "0x188DE64", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F09F")]
	[Address(RVA = "0x188D7A8", Offset = "0x188D7A8", VA = "0x188D7A8")]
	public void SetViewData(string introTxt, string introBigTxt, string detailTxt)
	{
	}

	[Token(Token = "0x600F0A0")]
	[Address(RVA = "0x188DF3C", Offset = "0x188DF3C", VA = "0x188DF3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
