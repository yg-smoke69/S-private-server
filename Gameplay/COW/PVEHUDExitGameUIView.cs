using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003392")]
public class PVEHUDExitGameUIView : UIBaseView
{
	[Token(Token = "0x4013AAC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ExitBtn;

	[Token(Token = "0x4013AAD")]
	[FieldOffset(Offset = "0x18")]
	public UILabel CountdownLabel;

	[Token(Token = "0x6015E6C")]
	[Address(RVA = "0x28CE0E4", Offset = "0x28CE0E4", VA = "0x28CE0E4")]
	public PVEHUDExitGameUIView()
	{
	}

	[Token(Token = "0x6015E6D")]
	[Address(RVA = "0x28CE0EC", Offset = "0x28CE0EC", VA = "0x28CE0EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E6E")]
	[Address(RVA = "0x28CE2F4", Offset = "0x28CE2F4", VA = "0x28CE2F4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
