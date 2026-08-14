using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003840")]
public class UILobbyIAPWeekCardView : UIBaseView
{
	[Token(Token = "0x4016F92")]
	[FieldOffset(Offset = "0x14")]
	public UIButton IAPBundleButton;

	[Token(Token = "0x4016F93")]
	[FieldOffset(Offset = "0x18")]
	public UICountDownLabel CountdownLabel;

	[Token(Token = "0x6016C6B")]
	[Address(RVA = "0xDB443C", Offset = "0xDB443C", VA = "0xDB443C")]
	public UILobbyIAPWeekCardView()
	{
	}

	[Token(Token = "0x6016C6C")]
	[Address(RVA = "0xDB4444", Offset = "0xDB4444", VA = "0xDB4444", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C6D")]
	[Address(RVA = "0xDB464C", Offset = "0xDB464C", VA = "0xDB464C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
