using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003870")]
public class UIMallGiftReceiverCallsignView : UIBaseView
{
	[Token(Token = "0x4017363")]
	[FieldOffset(Offset = "0x14")]
	public UILabel name;

	[Token(Token = "0x4017364")]
	[FieldOffset(Offset = "0x18")]
	public UISprite bg;

	[Token(Token = "0x4017365")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject fakeBg;

	[Token(Token = "0x6016CFB")]
	[Address(RVA = "0x225CAD8", Offset = "0x225CAD8", VA = "0x225CAD8")]
	public UIMallGiftReceiverCallsignView()
	{
	}

	[Token(Token = "0x6016CFC")]
	[Address(RVA = "0x225CAE0", Offset = "0x225CAE0", VA = "0x225CAE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CFD")]
	[Address(RVA = "0x225CD3C", Offset = "0x225CD3C", VA = "0x225CD3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
