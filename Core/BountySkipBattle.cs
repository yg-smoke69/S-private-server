using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B0C")]
public class BountySkipBattle : MonoBehaviour
{
	[Token(Token = "0x4005F65")]
	[FieldOffset(Offset = "0xC")]
	public UIButton SkipBtn;

	[Token(Token = "0x4005F66")]
	[FieldOffset(Offset = "0x10")]
	public GameObject TipLabel;

	[Token(Token = "0x4005F67")]
	[FieldOffset(Offset = "0x14")]
	public float DelayHideTip;

	[Token(Token = "0x4005F68")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsTrigged;

	[Token(Token = "0x4005F69")]
	[FieldOffset(Offset = "0x1C")]
	private uint m_DelayHandle;

	[Token(Token = "0x60054DB")]
	[Address(RVA = "0x2ED76AC", Offset = "0x2ED76AC", VA = "0x2ED76AC")]
	public BountySkipBattle()
	{
	}

	[Token(Token = "0x60054DC")]
	[Address(RVA = "0x2ED76C0", Offset = "0x2ED76C0", VA = "0x2ED76C0")]
	private void Start()
	{
	}

	[Token(Token = "0x60054DD")]
	[Address(RVA = "0x2ED7798", Offset = "0x2ED7798", VA = "0x2ED7798")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60054DE")]
	[Address(RVA = "0x2ED77D0", Offset = "0x2ED77D0", VA = "0x2ED77D0")]
	public void OnHUDTouch()
	{
	}

	[Token(Token = "0x60054DF")]
	[Address(RVA = "0x2ED79B0", Offset = "0x2ED79B0", VA = "0x2ED79B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60054E0")]
	[Address(RVA = "0x2ED7A64", Offset = "0x2ED7A64", VA = "0x2ED7A64")]
	private void _003COnHUDTouch_003Em__0()
	{
	}
}
