using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200338C")]
public class LuckyWheelShareInfoView : UIBaseView
{
	[Token(Token = "0x4013A8E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton TimeBtn;

	[Token(Token = "0x4013A8F")]
	[FieldOffset(Offset = "0x18")]
	public UILabel TimeLabel;

	[Token(Token = "0x4013A90")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Title;

	[Token(Token = "0x4013A91")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture TitileCDN;

	[Token(Token = "0x4013A92")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Price;

	[Token(Token = "0x4013A93")]
	[FieldOffset(Offset = "0x28")]
	public UILabel OriginalPrice;

	[Token(Token = "0x6015E5B")]
	[Address(RVA = "0x152FDE0", Offset = "0x152FDE0", VA = "0x152FDE0")]
	public LuckyWheelShareInfoView()
	{
	}

	[Token(Token = "0x6015E5C")]
	[Address(RVA = "0x152FDE8", Offset = "0x152FDE8", VA = "0x152FDE8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E5D")]
	[Address(RVA = "0x1530164", Offset = "0x1530164", VA = "0x1530164")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
