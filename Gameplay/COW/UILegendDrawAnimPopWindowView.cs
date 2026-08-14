using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003822")]
public class UILegendDrawAnimPopWindowView : UIBaseView
{
	[Token(Token = "0x4016E0E")]
	[FieldOffset(Offset = "0x14")]
	public UILegendDrawAnimSetting Setting;

	[Token(Token = "0x4016E0F")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition TweenPosition;

	[Token(Token = "0x4016E10")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList EasyList;

	[Token(Token = "0x4016E11")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ResultVfx;

	[Token(Token = "0x6016C11")]
	[Address(RVA = "0x2546A2C", Offset = "0x2546A2C", VA = "0x2546A2C")]
	public UILegendDrawAnimPopWindowView()
	{
	}

	[Token(Token = "0x6016C12")]
	[Address(RVA = "0x2546A34", Offset = "0x2546A34", VA = "0x2546A34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C13")]
	[Address(RVA = "0x2546CF0", Offset = "0x2546CF0", VA = "0x2546CF0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
