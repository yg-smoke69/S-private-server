using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003492")]
public class UICupMatchAccomplishedView : UIBaseView
{
	[Token(Token = "0x40147EC")]
	[FieldOffset(Offset = "0x14")]
	public UINetworkTexture CupCDNTexture;

	[Token(Token = "0x40147ED")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelSquad;

	[Token(Token = "0x40147EE")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelCup;

	[Token(Token = "0x40147EF")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelTier;

	[Token(Token = "0x40147F0")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnShare;

	[Token(Token = "0x40147F1")]
	[FieldOffset(Offset = "0x28")]
	public Transform ProfileContainer1;

	[Token(Token = "0x40147F2")]
	[FieldOffset(Offset = "0x2C")]
	public Transform ProfileContainer2;

	[Token(Token = "0x40147F3")]
	[FieldOffset(Offset = "0x30")]
	public Transform ProfileContainer3;

	[Token(Token = "0x40147F4")]
	[FieldOffset(Offset = "0x34")]
	public Transform ProfileContainer4;

	[Token(Token = "0x601616A")]
	[Address(RVA = "0x273C8C8", Offset = "0x273C8C8", VA = "0x273C8C8")]
	public UICupMatchAccomplishedView()
	{
	}

	[Token(Token = "0x601616B")]
	[Address(RVA = "0x273C8D0", Offset = "0x273C8D0", VA = "0x273C8D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601616C")]
	[Address(RVA = "0x273CCD8", Offset = "0x273CCD8", VA = "0x273CCD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
