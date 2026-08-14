using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039A7")]
public class UISecondRechargeRewardItemView : UIBaseView
{
	[Token(Token = "0x4018333")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnItem;

	[Token(Token = "0x4018334")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SelectSprite;

	[Token(Token = "0x4018335")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Received;

	[Token(Token = "0x601709C")]
	[Address(RVA = "0x1A509E0", Offset = "0x1A509E0", VA = "0x1A509E0")]
	public UISecondRechargeRewardItemView()
	{
	}

	[Token(Token = "0x601709D")]
	[Address(RVA = "0x1A509E8", Offset = "0x1A509E8", VA = "0x1A509E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601709E")]
	[Address(RVA = "0x1A50C38", Offset = "0x1A50C38", VA = "0x1A50C38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
