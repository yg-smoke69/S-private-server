using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200378E")]
public class UIHUDUGC_CheckPointMarkShowView : UIBaseView
{
	[Token(Token = "0x4016828")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ArrowDown;

	[Token(Token = "0x4016829")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget BoundWidget;

	[Token(Token = "0x401682A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Distance;

	[Token(Token = "0x401682B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject EndPoint;

	[Token(Token = "0x6016A55")]
	[Address(RVA = "0x2226ED4", Offset = "0x2226ED4", VA = "0x2226ED4")]
	public UIHUDUGC_CheckPointMarkShowView()
	{
	}

	[Token(Token = "0x6016A56")]
	[Address(RVA = "0x2226EDC", Offset = "0x2226EDC", VA = "0x2226EDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A57")]
	[Address(RVA = "0x222718C", Offset = "0x222718C", VA = "0x222718C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
