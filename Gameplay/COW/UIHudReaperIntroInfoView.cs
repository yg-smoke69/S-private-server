using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003700")]
public class UIHudReaperIntroInfoView : UIBaseView
{
	[Token(Token = "0x401636D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel IntroDetail;

	[Token(Token = "0x60168AB")]
	[Address(RVA = "0x1FDC0D4", Offset = "0x1FDC0D4", VA = "0x1FDC0D4")]
	public UIHudReaperIntroInfoView()
	{
	}

	[Token(Token = "0x60168AC")]
	[Address(RVA = "0x1FDC0DC", Offset = "0x1FDC0DC", VA = "0x1FDC0DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168AD")]
	[Address(RVA = "0x1FDC284", Offset = "0x1FDC284", VA = "0x1FDC284")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
