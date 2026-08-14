using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003446")]
public class UIClanBannerView : UIBaseView
{
	[Token(Token = "0x40143FC")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Mask;

	[Token(Token = "0x40143FD")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Close;

	[Token(Token = "0x40143FE")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList EasyList;

	[Token(Token = "0x6016086")]
	[Address(RVA = "0x2F23FB8", Offset = "0x2F23FB8", VA = "0x2F23FB8")]
	public UIClanBannerView()
	{
	}

	[Token(Token = "0x6016087")]
	[Address(RVA = "0x2F23FC0", Offset = "0x2F23FC0", VA = "0x2F23FC0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016088")]
	[Address(RVA = "0x2F24228", Offset = "0x2F24228", VA = "0x2F24228")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
