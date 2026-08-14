using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200348A")]
public class UICouponTipsItemView : UIBaseView
{
	[Token(Token = "0x4014738")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ItemContainer;

	[Token(Token = "0x4014739")]
	[FieldOffset(Offset = "0x18")]
	public Transform CountDownContent;

	[Token(Token = "0x6016152")]
	[Address(RVA = "0x1EC3938", Offset = "0x1EC3938", VA = "0x1EC3938")]
	public UICouponTipsItemView()
	{
	}

	[Token(Token = "0x6016153")]
	[Address(RVA = "0x1EC3940", Offset = "0x1EC3940", VA = "0x1EC3940", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016154")]
	[Address(RVA = "0x1EC3B14", Offset = "0x1EC3B14", VA = "0x1EC3B14")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
