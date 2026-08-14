using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003398")]
public class UGCInfectionChangeItemView : UIBaseView
{
	[Token(Token = "0x4013AF4")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Selected;

	[Token(Token = "0x4013AF5")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Icon;

	[Token(Token = "0x4013AF6")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Name;

	[Token(Token = "0x4013AF7")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Background;

	[Token(Token = "0x6015E7E")]
	[Address(RVA = "0x29F1978", Offset = "0x29F1978", VA = "0x29F1978")]
	public UGCInfectionChangeItemView()
	{
	}

	[Token(Token = "0x6015E7F")]
	[Address(RVA = "0x29F1980", Offset = "0x29F1980", VA = "0x29F1980", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E80")]
	[Address(RVA = "0x29F1C3C", Offset = "0x29F1C3C", VA = "0x29F1C3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
