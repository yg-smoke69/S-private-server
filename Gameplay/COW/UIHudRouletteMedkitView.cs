using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003717")]
public class UIHudRouletteMedkitView : UIBaseView
{
	[Token(Token = "0x4016407")]
	[FieldOffset(Offset = "0x14")]
	public GameObject CenterCloseSelect;

	[Token(Token = "0x4016408")]
	[FieldOffset(Offset = "0x18")]
	public GameObject MovePoint;

	[Token(Token = "0x4016409")]
	[FieldOffset(Offset = "0x1C")]
	public UIHudMedkitItem UIHudRouletteItem1;

	[Token(Token = "0x401640A")]
	[FieldOffset(Offset = "0x20")]
	public UIHudMedkitItem UIHudRouletteItem2;

	[Token(Token = "0x401640B")]
	[FieldOffset(Offset = "0x24")]
	public UIHudMedkitItem UIHudRouletteItem3;

	[Token(Token = "0x60168F0")]
	[Address(RVA = "0x1C400E0", Offset = "0x1C400E0", VA = "0x1C400E0")]
	public UIHudRouletteMedkitView()
	{
	}

	[Token(Token = "0x60168F1")]
	[Address(RVA = "0x1C400E8", Offset = "0x1C400E8", VA = "0x1C400E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60168F2")]
	[Address(RVA = "0x1C403F8", Offset = "0x1C403F8", VA = "0x1C403F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
