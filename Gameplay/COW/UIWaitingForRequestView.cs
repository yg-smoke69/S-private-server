using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A6D")]
public class UIWaitingForRequestView : UIBaseView
{
	[Token(Token = "0x4018C57")]
	[FieldOffset(Offset = "0x14")]
	public BoxCollider MaskCollider;

	[Token(Token = "0x4018C58")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Root;

	[Token(Token = "0x60172ED")]
	[Address(RVA = "0x101C63C", Offset = "0x101C63C", VA = "0x101C63C")]
	public UIWaitingForRequestView()
	{
	}

	[Token(Token = "0x60172EE")]
	[Address(RVA = "0x101C644", Offset = "0x101C644", VA = "0x101C644", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172EF")]
	[Address(RVA = "0x101C840", Offset = "0x101C840", VA = "0x101C840")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
