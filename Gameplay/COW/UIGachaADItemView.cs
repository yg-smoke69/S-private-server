using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003564")]
public class UIGachaADItemView : UIBaseView
{
	[Token(Token = "0x4015259")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIGachaADItem;

	[Token(Token = "0x401525A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Default;

	[Token(Token = "0x401525B")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x60163DC")]
	[Address(RVA = "0x265AE18", Offset = "0x265AE18", VA = "0x265AE18")]
	public UIGachaADItemView()
	{
	}

	[Token(Token = "0x60163DD")]
	[Address(RVA = "0x265AE20", Offset = "0x265AE20", VA = "0x265AE20", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163DE")]
	[Address(RVA = "0x265B07C", Offset = "0x265B07C", VA = "0x265B07C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
