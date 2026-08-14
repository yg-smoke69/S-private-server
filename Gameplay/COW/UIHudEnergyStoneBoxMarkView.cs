using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003642")]
public class UIHudEnergyStoneBoxMarkView : UIBaseView
{
	[Token(Token = "0x4015C40")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ArrowUp;

	[Token(Token = "0x4015C41")]
	[FieldOffset(Offset = "0x18")]
	public GameObject arrowRight;

	[Token(Token = "0x4015C42")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject arrowDown;

	[Token(Token = "0x4015C43")]
	[FieldOffset(Offset = "0x20")]
	public GameObject arrowLeft;

	[Token(Token = "0x4015C44")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Distance;

	[Token(Token = "0x6016673")]
	[Address(RVA = "0x1CE3DE0", Offset = "0x1CE3DE0", VA = "0x1CE3DE0")]
	public UIHudEnergyStoneBoxMarkView()
	{
	}

	[Token(Token = "0x6016674")]
	[Address(RVA = "0x1CE3DE8", Offset = "0x1CE3DE8", VA = "0x1CE3DE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016675")]
	[Address(RVA = "0x1CE40E0", Offset = "0x1CE40E0", VA = "0x1CE40E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
