using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003383")]
public class HUDPVEMissionItemView : UIBaseView
{
	[Token(Token = "0x40139EF")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Container;

	[Token(Token = "0x40139F0")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ContentLabel;

	[Token(Token = "0x6015E40")]
	[Address(RVA = "0x1909E14", Offset = "0x1909E14", VA = "0x1909E14")]
	public HUDPVEMissionItemView()
	{
	}

	[Token(Token = "0x6015E41")]
	[Address(RVA = "0x1909E1C", Offset = "0x1909E1C", VA = "0x1909E1C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E42")]
	[Address(RVA = "0x190A024", Offset = "0x190A024", VA = "0x190A024")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
