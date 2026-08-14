using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20003E9")]
public class PropAnimComponent : MonoBehaviour
{
	[Token(Token = "0x40039A8")]
	[FieldOffset(Offset = "0xC")]
	public Animation OwnedAnimation;

	[Token(Token = "0x40039A9")]
	[FieldOffset(Offset = "0x10")]
	public List<AnimationClip> AnimationClips;

	[Token(Token = "0x6001263")]
	[Address(RVA = "0x196A214", Offset = "0x196A214", VA = "0x196A214")]
	public PropAnimComponent()
	{
	}

	[Token(Token = "0x6001264")]
	[Address(RVA = "0x196A21C", Offset = "0x196A21C", VA = "0x196A21C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001265")]
	[Address(RVA = "0x196A440", Offset = "0x196A440", VA = "0x196A440")]
	public void PlayAnim(int index, bool need_queue = false)
	{
	}

	[Token(Token = "0x6001266")]
	[Address(RVA = "0x196A604", Offset = "0x196A604", VA = "0x196A604")]
	public void StopAnim()
	{
	}
}
