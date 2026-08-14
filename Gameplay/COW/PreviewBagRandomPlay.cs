using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A28")]
public class PreviewBagRandomPlay : MonoBehaviour
{
	[Token(Token = "0x4005B11")]
	[FieldOffset(Offset = "0xC")]
	private Animator m_BagAnimtor;

	[Token(Token = "0x4005B12")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsPlayIdle;

	[Token(Token = "0x4005B13")]
	[FieldOffset(Offset = "0x11")]
	private bool m_IsPlaySpeical;

	[Token(Token = "0x4005B14")]
	[FieldOffset(Offset = "0x14")]
	private float IdleTime;

	[Token(Token = "0x4005B15")]
	[FieldOffset(Offset = "0x18")]
	private float SpeicalTime;

	[Token(Token = "0x4005B16")]
	[FieldOffset(Offset = "0x1C")]
	private float m_IdleTime;

	[Token(Token = "0x4005B17")]
	[FieldOffset(Offset = "0x20")]
	private float m_SpeicalTime;

	[Token(Token = "0x6004F4D")]
	[Address(RVA = "0x1C18320", Offset = "0x1C18320", VA = "0x1C18320")]
	public PreviewBagRandomPlay()
	{
	}

	[Token(Token = "0x6004F4E")]
	[Address(RVA = "0x1C18328", Offset = "0x1C18328", VA = "0x1C18328")]
	public void SetTime(float time1, float time2)
	{
	}

	[Token(Token = "0x6004F4F")]
	[Address(RVA = "0x1C1860C", Offset = "0x1C1860C", VA = "0x1C1860C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004F50")]
	[Address(RVA = "0x1C186CC", Offset = "0x1C186CC", VA = "0x1C186CC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004F51")]
	[Address(RVA = "0x1C18438", Offset = "0x1C18438", VA = "0x1C18438")]
	private void PlayAnim(string animanme)
	{
	}

	[Token(Token = "0x6004F52")]
	[Address(RVA = "0x1C18738", Offset = "0x1C18738", VA = "0x1C18738")]
	private void Update()
	{
	}
}
