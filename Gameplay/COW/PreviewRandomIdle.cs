using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A39")]
public class PreviewRandomIdle : MonoBehaviour
{
	[Token(Token = "0x4005B47")]
	[FieldOffset(Offset = "0xC")]
	public List<Animator> m_PlayerAnimatorList;

	[Token(Token = "0x4005B48")]
	[FieldOffset(Offset = "0x10")]
	public AnimationClip IdleAnim;

	[Token(Token = "0x4005B49")]
	[FieldOffset(Offset = "0x14")]
	private float ActionTime;

	[Token(Token = "0x4005B4A")]
	[FieldOffset(Offset = "0x18")]
	private float RealTime;

	[Token(Token = "0x4005B4B")]
	[FieldOffset(Offset = "0x1C")]
	private bool StartIdle;

	[Token(Token = "0x6004F87")]
	[Address(RVA = "0x195CE50", Offset = "0x195CE50", VA = "0x195CE50")]
	public PreviewRandomIdle()
	{
	}

	[Token(Token = "0x6004F88")]
	[Address(RVA = "0x195CE58", Offset = "0x195CE58", VA = "0x195CE58")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004F89")]
	[Address(RVA = "0x195CF60", Offset = "0x195CF60", VA = "0x195CF60")]
	private void Update()
	{
	}

	[Token(Token = "0x6004F8A")]
	[Address(RVA = "0x195D1FC", Offset = "0x195D1FC", VA = "0x195D1FC")]
	public void StartRecordIdle()
	{
	}

	[Token(Token = "0x6004F8B")]
	[Address(RVA = "0x195D264", Offset = "0x195D264", VA = "0x195D264")]
	public void ResetRecord()
	{
	}

	[Token(Token = "0x6004F8C")]
	[Address(RVA = "0x195D014", Offset = "0x195D014", VA = "0x195D014")]
	private void UpdatePlayerAnimator()
	{
	}
}
