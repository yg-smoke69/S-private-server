using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037EA")]
public class UIHudWorkshopPhotographModeView : UIBaseView
{
	[Token(Token = "0x4016AE5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4016AE6")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnTakePhoto;

	[Token(Token = "0x6016B69")]
	[Address(RVA = "0x2944BE0", Offset = "0x2944BE0", VA = "0x2944BE0")]
	public UIHudWorkshopPhotographModeView()
	{
	}

	[Token(Token = "0x6016B6A")]
	[Address(RVA = "0x2944BE8", Offset = "0x2944BE8", VA = "0x2944BE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B6B")]
	[Address(RVA = "0x2944DF0", Offset = "0x2944DF0", VA = "0x2944DF0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
