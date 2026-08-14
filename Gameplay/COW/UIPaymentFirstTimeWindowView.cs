using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038E9")]
public class UIPaymentFirstTimeWindowView : UIBaseView
{
	[Token(Token = "0x4017A19")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4017A1A")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTextureExt BackgroundTexture;

	[Token(Token = "0x4017A1B")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton GotoButton;

	[Token(Token = "0x6016E64")]
	[Address(RVA = "0x2889930", Offset = "0x2889930", VA = "0x2889930")]
	public UIPaymentFirstTimeWindowView()
	{
	}

	[Token(Token = "0x6016E65")]
	[Address(RVA = "0x2889938", Offset = "0x2889938", VA = "0x2889938", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E66")]
	[Address(RVA = "0x2889BA0", Offset = "0x2889BA0", VA = "0x2889BA0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
