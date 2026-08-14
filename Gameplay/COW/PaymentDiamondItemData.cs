using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A25")]
public class PaymentDiamondItemData
{
	[Token(Token = "0x4010319")]
	[FieldOffset(Offset = "0x8")]
	public int DiscountFontSize;

	[Token(Token = "0x401031A")]
	[FieldOffset(Offset = "0xC")]
	public int OffFontSize;

	[Token(Token = "0x401031B")]
	[FieldOffset(Offset = "0x10")]
	public Color OutLineColor;

	[Token(Token = "0x401031C")]
	[FieldOffset(Offset = "0x20")]
	public Color BackgroundColor;

	[Token(Token = "0x401031D")]
	[FieldOffset(Offset = "0x30")]
	public Color BackLineColor;

	[Token(Token = "0x401031E")]
	[FieldOffset(Offset = "0x40")]
	public Color PointColor;

	[Token(Token = "0x401031F")]
	[FieldOffset(Offset = "0x50")]
	public Color BackgroundTriangleColor;

	[Token(Token = "0x4010320")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 BackgroundTriangleSize;

	[Token(Token = "0x4010321")]
	[FieldOffset(Offset = "0x68")]
	public int BackgroundTrianglePositionY;

	[Token(Token = "0x4010322")]
	[FieldOffset(Offset = "0x6C")]
	public ResourceID EffectID;

	[Token(Token = "0x4010323")]
	[FieldOffset(Offset = "0x70")]
	public ResourceID SoundID;

	[Token(Token = "0x4010324")]
	[FieldOffset(Offset = "0x74")]
	public int OffNumber;

	[Token(Token = "0x4010325")]
	[FieldOffset(Offset = "0x78")]
	public string PriceText;

	[Token(Token = "0x4010326")]
	[FieldOffset(Offset = "0x7C")]
	public string DiscountPriceText;

	[Token(Token = "0x4010327")]
	[FieldOffset(Offset = "0x80")]
	public int Min;

	[Token(Token = "0x4010328")]
	[FieldOffset(Offset = "0x84")]
	public int Max;

	[Token(Token = "0x4010329")]
	[FieldOffset(Offset = "0x88")]
	public string ProductIdentifier;

	[Token(Token = "0x401032A")]
	[FieldOffset(Offset = "0x8C")]
	public int CurrentIndex;

	[Token(Token = "0x60110B8")]
	[Address(RVA = "0x2DDEAC4", Offset = "0x2DDEAC4", VA = "0x2DDEAC4")]
	public PaymentDiamondItemData()
	{
	}
}
