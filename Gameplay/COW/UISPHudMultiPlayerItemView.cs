using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039C4")]
public class UISPHudMultiPlayerItemView : UIBaseView
{
	[Token(Token = "0x4018489")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Arrow;

	[Token(Token = "0x401848A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TeamNo;

	[Token(Token = "0x401848B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TeamName;

	[Token(Token = "0x401848C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PlayerInfo;

	[Token(Token = "0x401848D")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid PlayerGrid;

	[Token(Token = "0x60170F3")]
	[Address(RVA = "0x1D22E54", Offset = "0x1D22E54", VA = "0x1D22E54")]
	public UISPHudMultiPlayerItemView()
	{
	}

	[Token(Token = "0x60170F4")]
	[Address(RVA = "0x1D22E5C", Offset = "0x1D22E5C", VA = "0x1D22E5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170F5")]
	[Address(RVA = "0x1D23178", Offset = "0x1D23178", VA = "0x1D23178")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
