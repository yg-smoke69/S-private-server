using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039B6")]
public class UISPHudBombRoundResultView : UIBaseView
{
	[Token(Token = "0x40183DE")]
	[FieldOffset(Offset = "0x14")]
	public UISprite TeamIcon;

	[Token(Token = "0x40183DF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TeamName;

	[Token(Token = "0x60170C9")]
	[Address(RVA = "0x1D10760", Offset = "0x1D10760", VA = "0x1D10760")]
	public UISPHudBombRoundResultView()
	{
	}

	[Token(Token = "0x60170CA")]
	[Address(RVA = "0x1D10768", Offset = "0x1D10768", VA = "0x1D10768", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170CB")]
	[Address(RVA = "0x1D10970", Offset = "0x1D10970", VA = "0x1D10970")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
