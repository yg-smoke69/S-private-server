using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003868")]
public class UIMallADsItemView : UIBaseView
{
	[Token(Token = "0x401729D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIMallADsItem;

	[Token(Token = "0x401729E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Default;

	[Token(Token = "0x401729F")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x6016CE3")]
	[Address(RVA = "0x23962F0", Offset = "0x23962F0", VA = "0x23962F0")]
	public UIMallADsItemView()
	{
	}

	[Token(Token = "0x6016CE4")]
	[Address(RVA = "0x23962F8", Offset = "0x23962F8", VA = "0x23962F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CE5")]
	[Address(RVA = "0x2396554", Offset = "0x2396554", VA = "0x2396554")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
