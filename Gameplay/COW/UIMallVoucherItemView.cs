using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003879")]
public class UIMallVoucherItemView : UIBaseView
{
	[Token(Token = "0x4017411")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4017412")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget Container;

	[Token(Token = "0x4017413")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel PriceLabel;

	[Token(Token = "0x4017414")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HighLight;

	[Token(Token = "0x4017415")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GemsIcon;

	[Token(Token = "0x4017416")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GoldIcon;

	[Token(Token = "0x6016D16")]
	[Address(RVA = "0x226E700", Offset = "0x226E700", VA = "0x226E700")]
	public UIMallVoucherItemView()
	{
	}

	[Token(Token = "0x6016D17")]
	[Address(RVA = "0x226E708", Offset = "0x226E708", VA = "0x226E708", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D18")]
	[Address(RVA = "0x226EA6C", Offset = "0x226EA6C", VA = "0x226EA6C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
