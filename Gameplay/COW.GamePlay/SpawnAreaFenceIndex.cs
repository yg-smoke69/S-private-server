using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000A95")]
public class SpawnAreaFenceIndex : MonoBehaviour
{
	[Token(Token = "0x4005CDA")]
	[FieldOffset(Offset = "0xC")]
	public int index;

	[Token(Token = "0x4005CDB")]
	[FieldOffset(Offset = "0x10")]
	public GameObject Col;

	[Token(Token = "0x4005CDC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject EffectLow;

	[Token(Token = "0x4005CDD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject EffectHigh;

	[Token(Token = "0x600512E")]
	[Address(RVA = "0x1D7C640", Offset = "0x1D7C640", VA = "0x1D7C640")]
	public SpawnAreaFenceIndex()
	{
	}

	[Token(Token = "0x600512F")]
	[Address(RVA = "0x1D7C648", Offset = "0x1D7C648", VA = "0x1D7C648")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005130")]
	[Address(RVA = "0x1D7C7C0", Offset = "0x1D7C7C0", VA = "0x1D7C7C0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005131")]
	[Address(RVA = "0x1D7C814", Offset = "0x1D7C814", VA = "0x1D7C814")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005132")]
	[Address(RVA = "0x1D7C958", Offset = "0x1D7C958", VA = "0x1D7C958")]
	public void SetColliderAndEffectStatus(bool FHJAOLALPGO)
	{
	}
}
