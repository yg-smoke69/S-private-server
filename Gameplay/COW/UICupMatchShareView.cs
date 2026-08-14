using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034A1")]
public class UICupMatchShareView : UIBaseView
{
	[Token(Token = "0x40148AB")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture CupCDNTexture;

	[Token(Token = "0x40148AC")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelSquad;

	[Token(Token = "0x40148AD")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelCup;

	[Token(Token = "0x40148AE")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelTier;

	[Token(Token = "0x40148AF")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelDate;

	[Token(Token = "0x6016197")]
	[Address(RVA = "0x2AB6668", Offset = "0x2AB6668", VA = "0x2AB6668")]
	public UICupMatchShareView()
	{
	}

	[Token(Token = "0x6016198")]
	[Address(RVA = "0x2AB6670", Offset = "0x2AB6670", VA = "0x2AB6670", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016199")]
	[Address(RVA = "0x2AB6998", Offset = "0x2AB6998", VA = "0x2AB6998")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
