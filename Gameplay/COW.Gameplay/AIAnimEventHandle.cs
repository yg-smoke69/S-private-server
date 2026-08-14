using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay;

[Token(Token = "0x20003CC")]
internal class AIAnimEventHandle : MonoBehaviour
{
	[Token(Token = "0x4003899")]
	[FieldOffset(Offset = "0xC")]
	private Transform m_CacheTransform;

	[Token(Token = "0x400389A")]
	[FieldOffset(Offset = "0x10")]
	private NetworkAIPawn m_Owner;

	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x24A1A90", Offset = "0x24A1A90", VA = "0x24A1A90")]
	public AIAnimEventHandle()
	{
	}

	[Token(Token = "0x60010FA")]
	[Address(RVA = "0x24A1A98", Offset = "0x24A1A98", VA = "0x24A1A98")]
	public void Register(NetworkAIPawn owner)
	{
	}

	[Token(Token = "0x60010FB")]
	[Address(RVA = "0x24A1AA0", Offset = "0x24A1AA0", VA = "0x24A1AA0")]
	private void Start()
	{
	}

	[Token(Token = "0x60010FC")]
	[Address(RVA = "0x24A1ABC", Offset = "0x24A1ABC", VA = "0x24A1ABC")]
	private void PlayEventEffect(AnimationEvent evt)
	{
	}

	[Token(Token = "0x60010FD")]
	[Address(RVA = "0x24A1F7C", Offset = "0x24A1F7C", VA = "0x24A1F7C")]
	private void PlayEventSound(AnimationEvent evt)
	{
	}

	[Token(Token = "0x60010FE")]
	[Address(RVA = "0x24A23A4", Offset = "0x24A23A4", VA = "0x24A23A4")]
	private void PlayEventShadowEffect(AnimationEvent evt)
	{
	}

	[Token(Token = "0x60010FF")]
	[Address(RVA = "0x24A2514", Offset = "0x24A2514", VA = "0x24A2514")]
	private void EventSetModelVisibleState(AnimationEvent evt)
	{
	}

	[Token(Token = "0x6001100")]
	[Address(RVA = "0x24A25F8", Offset = "0x24A25F8", VA = "0x24A25F8")]
	private void EventSetColliderActiveState(AnimationEvent evt)
	{
	}
}
