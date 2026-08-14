using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006CD")]
public class LevelTriggerHumanTire : MonoBehaviour
{
	[Token(Token = "0x4004AD6")]
	[FieldOffset(Offset = "0xC")]
	public GameObject effect;

	[Token(Token = "0x4004AD7")]
	[FieldOffset(Offset = "0x10")]
	public float HSpeed;

	[Token(Token = "0x4004AD8")]
	[FieldOffset(Offset = "0x14")]
	public float VSpeed;

	[Token(Token = "0x4004AD9")]
	[FieldOffset(Offset = "0x18")]
	public CapsuleCollider collider;

	[Token(Token = "0x4004ADA")]
	[FieldOffset(Offset = "0x20")]
	private IHAAMHPPLMG ACBDIDHNNOF;

	[Token(Token = "0x1700034C")]
	public IHAAMHPPLMG CMEKDNHLCGK
	{
		[Token(Token = "0x6002B8C")]
		[Address(RVA = "0x242BED8", Offset = "0x242BED8", VA = "0x242BED8")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x6002B8D")]
		[Address(RVA = "0x242BF4C", Offset = "0x242BF4C", VA = "0x242BF4C")]
		set
		{
		}
	}

	[Token(Token = "0x6002B8B")]
	[Address(RVA = "0x242BED0", Offset = "0x242BED0", VA = "0x242BED0")]
	public LevelTriggerHumanTire()
	{
	}

	[Token(Token = "0x6002B8E")]
	[Address(RVA = "0x242BFF8", Offset = "0x242BFF8", VA = "0x242BFF8")]
	public void PlayEffect()
	{
	}

	[Token(Token = "0x6002B8F")]
	[Address(RVA = "0x242C11C", Offset = "0x242C11C", VA = "0x242C11C")]
	public void StopEffect()
	{
	}

	[Token(Token = "0x6002B90")]
	[Address(RVA = "0x242C21C", Offset = "0x242C21C", VA = "0x242C21C")]
	public void PlayOneShot()
	{
	}

	[Token(Token = "0x6002B91")]
	[Address(RVA = "0x242C350", Offset = "0x242C350", VA = "0x242C350")]
	public float GetColliderHeight()
	{
		return default(float);
	}

	[Token(Token = "0x6002B92")]
	[Address(RVA = "0x242C450", Offset = "0x242C450", VA = "0x242C450")]
	private void OnEnable()
	{
	}
}
