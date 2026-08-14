using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A1A")]
public class SimpleAnimationSystemComponent : MonoBehaviour
{
	[Token(Token = "0x4005AE6")]
	[FieldOffset(Offset = "0xC")]
	private Animator m_Animator;

	[Token(Token = "0x6004EF4")]
	[Address(RVA = "0x21C6180", Offset = "0x21C6180", VA = "0x21C6180")]
	public SimpleAnimationSystemComponent()
	{
	}

	[Token(Token = "0x6004EF5")]
	[Address(RVA = "0x21C6188", Offset = "0x21C6188", VA = "0x21C6188")]
	public void Init()
	{
	}

	[Token(Token = "0x6004EF6")]
	[Address(RVA = "0x21C61F0", Offset = "0x21C61F0", VA = "0x21C61F0")]
	public void PlayAnim(string animStatName, float crossTime = 0f, bool isCrossFix = false)
	{
	}

	[Token(Token = "0x6004EF7")]
	[Address(RVA = "0x21C6308", Offset = "0x21C6308", VA = "0x21C6308")]
	public void SetFloatParam(string paramName, float value)
	{
	}

	[Token(Token = "0x6004EF8")]
	[Address(RVA = "0x21C63C8", Offset = "0x21C63C8", VA = "0x21C63C8")]
	public void SetBoolParam(string paramName, bool value)
	{
	}

	[Token(Token = "0x6004EF9")]
	[Address(RVA = "0x21C6488", Offset = "0x21C6488", VA = "0x21C6488")]
	public void SetTrigger(string paramName)
	{
	}
}
