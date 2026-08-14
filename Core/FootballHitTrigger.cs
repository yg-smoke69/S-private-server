using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007B6")]
public class FootballHitTrigger : MonoBehaviour
{
	[Token(Token = "0x4004F89")]
	[FieldOffset(Offset = "0xC")]
	private SphereCollider m_HitTrigger;

	[Token(Token = "0x4004F8A")]
	[FieldOffset(Offset = "0x10")]
	private Vector3 m_CurMoveVelocity;

	[Token(Token = "0x4004F8B")]
	[FieldOffset(Offset = "0x1C")]
	private Transform m_CachTransform;

	[Token(Token = "0x6003122")]
	[Address(RVA = "0x26AF998", Offset = "0x26AF998", VA = "0x26AF998")]
	public FootballHitTrigger()
	{
	}

	[Token(Token = "0x6003123")]
	[Address(RVA = "0x26AFA3C", Offset = "0x26AFA3C", VA = "0x26AFA3C")]
	public void InitTrigger(float triggerRadius)
	{
	}

	[Token(Token = "0x6003124")]
	[Address(RVA = "0x26AFB38", Offset = "0x26AFB38", VA = "0x26AFB38")]
	public void UpdateRadius(float triggerRadius)
	{
	}

	[Token(Token = "0x6003125")]
	[Address(RVA = "0x26AFB80", Offset = "0x26AFB80", VA = "0x26AFB80")]
	public void UpdateMoveVelocity(Vector3 velocity)
	{
	}

	[Token(Token = "0x6003126")]
	[Address(RVA = "0x26AFB8C", Offset = "0x26AFB8C", VA = "0x26AFB8C")]
	private void OnTriggerEnter(Collider other)
	{
	}
}
