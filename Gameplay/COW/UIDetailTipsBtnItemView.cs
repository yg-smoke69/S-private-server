using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034BF")]
public class UIDetailTipsBtnItemView : UIBaseView
{
	[Token(Token = "0x4014A0B")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIDetailTipsBtnItem;

	[Token(Token = "0x4014A0C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x4014A0D")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject arrow;

	[Token(Token = "0x60161F1")]
	[Address(RVA = "0x2D83394", Offset = "0x2D83394", VA = "0x2D83394")]
	public UIDetailTipsBtnItemView()
	{
	}

	[Token(Token = "0x60161F2")]
	[Address(RVA = "0x2D8339C", Offset = "0x2D8339C", VA = "0x2D8339C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161F3")]
	[Address(RVA = "0x2D835F8", Offset = "0x2D835F8", VA = "0x2D835F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
