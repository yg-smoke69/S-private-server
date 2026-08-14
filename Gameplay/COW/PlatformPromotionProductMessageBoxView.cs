using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200338F")]
public class PlatformPromotionProductMessageBoxView : UIBaseView
{
	[Token(Token = "0x4013A9E")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TipLabel;

	[Token(Token = "0x4013A9F")]
	[FieldOffset(Offset = "0x18")]
	public Transform ItemContainer;

	[Token(Token = "0x4013AA0")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton OkButton;

	[Token(Token = "0x6015E63")]
	[Address(RVA = "0x1C06514", Offset = "0x1C06514", VA = "0x1C06514")]
	public PlatformPromotionProductMessageBoxView()
	{
	}

	[Token(Token = "0x6015E64")]
	[Address(RVA = "0x1C0651C", Offset = "0x1C0651C", VA = "0x1C0651C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E65")]
	[Address(RVA = "0x1C0675C", Offset = "0x1C0675C", VA = "0x1C0675C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
