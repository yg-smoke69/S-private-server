using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003803")]
public class UIInviteGroupBoxItemView : UIBaseView
{
	[Token(Token = "0x4016C1A")]
	[FieldOffset(Offset = "0x14")]
	public Transform ProfileObj;

	[Token(Token = "0x4016C1B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton AddBtn;

	[Token(Token = "0x6016BB4")]
	[Address(RVA = "0x1AD8AE4", Offset = "0x1AD8AE4", VA = "0x1AD8AE4")]
	public UIInviteGroupBoxItemView()
	{
	}

	[Token(Token = "0x6016BB5")]
	[Address(RVA = "0x1AD8AEC", Offset = "0x1AD8AEC", VA = "0x1AD8AEC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BB6")]
	[Address(RVA = "0x1AD8C54", Offset = "0x1AD8C54", VA = "0x1AD8C54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
