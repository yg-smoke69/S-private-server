using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200391C")]
public class UIProbabilityWndView : UIBaseView
{
	[Token(Token = "0x4017C44")]
	[FieldOffset(Offset = "0x14")]
	public UITable Tabel;

	[Token(Token = "0x4017C45")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Content;

	[Token(Token = "0x6016EFB")]
	[Address(RVA = "0xF03A0C", Offset = "0xF03A0C", VA = "0xF03A0C")]
	public UIProbabilityWndView()
	{
	}

	[Token(Token = "0x6016EFC")]
	[Address(RVA = "0xF03A14", Offset = "0xF03A14", VA = "0xF03A14", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EFD")]
	[Address(RVA = "0xF03C1C", Offset = "0xF03C1C", VA = "0xF03C1C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
