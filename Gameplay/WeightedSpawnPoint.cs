using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200073A")]
public class WeightedSpawnPoint : MonoBehaviour
{
	[Token(Token = "0x4004CB4")]
	[FieldOffset(Offset = "0xC")]
	public float radius;

	[Token(Token = "0x4004CB5")]
	[FieldOffset(Offset = "0x10")]
	public int weight;

	[Token(Token = "0x4004CB6")]
	[FieldOffset(Offset = "0x14")]
	public bool revive;

	[Token(Token = "0x4004CB7")]
	[FieldOffset(Offset = "0x18")]
	public Transform m_RefPositionTrans;

	[Token(Token = "0x6002DB5")]
	[Address(RVA = "0x2A6CA04", Offset = "0x2A6CA04", VA = "0x2A6CA04")]
	public WeightedSpawnPoint()
	{
	}
}
