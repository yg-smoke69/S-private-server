using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039EC")]
public class UIStandardGuideMaskView : UIBaseView
{
	[Token(Token = "0x401862C")]
	[FieldOffset(Offset = "0x14")]
	public UITexture GuideMaskBg;

	[Token(Token = "0x401862D")]
	[FieldOffset(Offset = "0x18")]
	public Transform LeftCollider;

	[Token(Token = "0x401862E")]
	[FieldOffset(Offset = "0x1C")]
	public Transform RightCollider;

	[Token(Token = "0x401862F")]
	[FieldOffset(Offset = "0x20")]
	public Transform DownCollider;

	[Token(Token = "0x4018630")]
	[FieldOffset(Offset = "0x24")]
	public Transform UpCollider;

	[Token(Token = "0x601716A")]
	[Address(RVA = "0x2067130", Offset = "0x2067130", VA = "0x2067130")]
	public UIStandardGuideMaskView()
	{
	}

	[Token(Token = "0x601716B")]
	[Address(RVA = "0x2067138", Offset = "0x2067138", VA = "0x2067138", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601716C")]
	[Address(RVA = "0x20673C0", Offset = "0x20673C0", VA = "0x20673C0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
