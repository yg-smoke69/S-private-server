using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AA1")]
public class WaitingDummySpawnRegion : MonoBehaviour
{
	[Token(Token = "0x4005D04")]
	[FieldOffset(Offset = "0xC")]
	public Transform m_Transform;

	[Token(Token = "0x4005D05")]
	[FieldOffset(Offset = "0x10")]
	public float m_Radius;

	[Token(Token = "0x6005168")]
	[Address(RVA = "0x2A6B31C", Offset = "0x2A6B31C", VA = "0x2A6B31C")]
	public WaitingDummySpawnRegion()
	{
	}

	[Token(Token = "0x6005169")]
	[Address(RVA = "0x2A6B32C", Offset = "0x2A6B32C", VA = "0x2A6B32C")]
	private void OnDrawGizmos()
	{
	}
}
