using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200362D")]
public class UIHudCupMatchIntroView : UIBaseView
{
	[Token(Token = "0x4015B5E")]
	[FieldOffset(Offset = "0x14")]
	public UILabel CupTitle;

	[Token(Token = "0x4015B5F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4015B60")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture CupIcon;

	[Token(Token = "0x4015B61")]
	[FieldOffset(Offset = "0x20")]
	public GameObject DefaultIcon;

	[Token(Token = "0x6016634")]
	[Address(RVA = "0x137862C", Offset = "0x137862C", VA = "0x137862C")]
	public UIHudCupMatchIntroView()
	{
	}

	[Token(Token = "0x6016635")]
	[Address(RVA = "0x1378634", Offset = "0x1378634", VA = "0x1378634", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016636")]
	[Address(RVA = "0x13788F0", Offset = "0x13788F0", VA = "0x13788F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
