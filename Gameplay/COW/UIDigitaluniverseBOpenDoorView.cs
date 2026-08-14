using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034D9")]
public class UIDigitaluniverseBOpenDoorView : UIBaseView
{
	[Token(Token = "0x4014BFE")]
	[FieldOffset(Offset = "0x14")]
	public Animation ruchang;

	[Token(Token = "0x4014BFF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject VFX_DigitaluniverseB_Door_Loop;

	[Token(Token = "0x601623D")]
	[Address(RVA = "0x2EFF6F8", Offset = "0x2EFF6F8", VA = "0x2EFF6F8")]
	public UIDigitaluniverseBOpenDoorView()
	{
	}

	[Token(Token = "0x601623E")]
	[Address(RVA = "0x2EFF700", Offset = "0x2EFF700", VA = "0x2EFF700", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601623F")]
	[Address(RVA = "0x2EFF8FC", Offset = "0x2EFF8FC", VA = "0x2EFF8FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
