using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200391A")]
public class UIPPTOPView : UIBaseView
{
	[Token(Token = "0x4017C39")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnService;

	[Token(Token = "0x4017C3A")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnPrivacy;

	[Token(Token = "0x4017C3B")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnAgree;

	[Token(Token = "0x6016EF5")]
	[Address(RVA = "0x15A2DF4", Offset = "0x15A2DF4", VA = "0x15A2DF4")]
	public UIPPTOPView()
	{
	}

	[Token(Token = "0x6016EF6")]
	[Address(RVA = "0x15A2DFC", Offset = "0x15A2DFC", VA = "0x15A2DFC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EF7")]
	[Address(RVA = "0x15A3064", Offset = "0x15A3064", VA = "0x15A3064")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
