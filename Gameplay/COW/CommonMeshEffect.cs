using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A56")]
internal class CommonMeshEffect : ReusableObject
{
	[Token(Token = "0x4005BB5")]
	[FieldOffset(Offset = "0x18")]
	public float DelayDestoryTime;

	[Token(Token = "0x4005BB6")]
	[FieldOffset(Offset = "0x1C")]
	private float m_GivenDelayDestoryTime;

	[Token(Token = "0x4005BB7")]
	[FieldOffset(Offset = "0x20")]
	private float m_StartTime;

	[Token(Token = "0x4005BB8")]
	[FieldOffset(Offset = "0x24")]
	private Animation[] m_Animations;

	[Token(Token = "0x4005BB9")]
	[FieldOffset(Offset = "0x28")]
	private Animator[] m_Animators;

	[Token(Token = "0x6005023")]
	[Address(RVA = "0x1737FFC", Offset = "0x1737FFC", VA = "0x1737FFC")]
	public CommonMeshEffect()
	{
	}

	[Token(Token = "0x6005024")]
	[Address(RVA = "0x173800C", Offset = "0x173800C", VA = "0x173800C")]
	private void Start()
	{
	}

	[Token(Token = "0x6005025")]
	[Address(RVA = "0x17380EC", Offset = "0x17380EC", VA = "0x17380EC", Slot = "4")]
	public override void Prepare()
	{
	}

	[Token(Token = "0x6005026")]
	[Address(RVA = "0x1738230", Offset = "0x1738230", VA = "0x1738230")]
	public void SetDelayDestoryTime(float t)
	{
	}

	[Token(Token = "0x6005027")]
	[Address(RVA = "0x1738294", Offset = "0x1738294", VA = "0x1738294")]
	private void Update()
	{
	}

	[Token(Token = "0x6005028")]
	[Address(RVA = "0x1738334", Offset = "0x1738334", VA = "0x1738334", Slot = "5")]
	protected override void DoRecycle()
	{
	}

	[Token(Token = "0x6005029")]
	[Address(RVA = "0x17383A0", Offset = "0x17383A0", VA = "0x17383A0")]
	public void _003C_003EiFixBaseProxy_Prepare()
	{
	}

	[Token(Token = "0x600502A")]
	[Address(RVA = "0x17383A8", Offset = "0x17383A8", VA = "0x17383A8")]
	public void _003C_003EiFixBaseProxy_DoRecycle()
	{
	}
}
