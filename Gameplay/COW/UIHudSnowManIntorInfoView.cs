using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003758")]
public class UIHudSnowManIntorInfoView : UIBaseView
{
	[Token(Token = "0x4016659")]
	[FieldOffset(Offset = "0x14")]
	public GameObject IntroKey;

	[Token(Token = "0x401665A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel IntroDetail;

	[Token(Token = "0x60169B3")]
	[Address(RVA = "0x1FDCBCC", Offset = "0x1FDCBCC", VA = "0x1FDCBCC")]
	public UIHudSnowManIntorInfoView()
	{
	}

	[Token(Token = "0x60169B4")]
	[Address(RVA = "0x1FDCBD4", Offset = "0x1FDCBD4", VA = "0x1FDCBD4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169B5")]
	[Address(RVA = "0x1FDCDD0", Offset = "0x1FDCDD0", VA = "0x1FDCDD0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
