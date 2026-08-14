using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037A8")]
public class UIHUDUGC_RoundStartBanner_YellowView : UIBaseView
{
	[Token(Token = "0x401689D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel RoundNum;

	[Token(Token = "0x401689E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Final;

	[Token(Token = "0x401689F")]
	[FieldOffset(Offset = "0x1C")]
	public Transform BG;

	[Token(Token = "0x6016AA3")]
	[Address(RVA = "0x29185AC", Offset = "0x29185AC", VA = "0x29185AC")]
	public UIHUDUGC_RoundStartBanner_YellowView()
	{
	}

	[Token(Token = "0x6016AA4")]
	[Address(RVA = "0x29185B4", Offset = "0x29185B4", VA = "0x29185B4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AA5")]
	[Address(RVA = "0x29187F4", Offset = "0x29187F4", VA = "0x29187F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
