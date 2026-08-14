using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000716")]
public class RoundColliderManager : MonoBehaviour
{
	[Token(Token = "0x4004C16")]
	[FieldOffset(Offset = "0xC")]
	public List<RoundDynamicCollider> colliders;

	[Token(Token = "0x6002CED")]
	[Address(RVA = "0x316CF98", Offset = "0x316CF98", VA = "0x316CF98")]
	public RoundColliderManager()
	{
	}

	[Token(Token = "0x6002CEE")]
	[Address(RVA = "0x316D024", Offset = "0x316D024", VA = "0x316D024")]
	public void Start()
	{
	}

	[Token(Token = "0x6002CEF")]
	[Address(RVA = "0x316D1A8", Offset = "0x316D1A8", VA = "0x316D1A8")]
	public void AwakeRoundColliders(int roundID)
	{
	}
}
