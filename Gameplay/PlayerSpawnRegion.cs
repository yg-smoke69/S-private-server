using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A75")]
public class PlayerSpawnRegion : MonoBehaviour
{
	[Token(Token = "0x4005C45")]
	[FieldOffset(Offset = "0xC")]
	public Transform m_Transform;

	[Token(Token = "0x4005C46")]
	[FieldOffset(Offset = "0x10")]
	public float m_Radius;

	[Token(Token = "0x4005C47")]
	[FieldOffset(Offset = "0x14")]
	public float m_Theta;

	[Token(Token = "0x4005C48")]
	[FieldOffset(Offset = "0x18")]
	public Color m_Color;

	[Token(Token = "0x60050A4")]
	[Address(RVA = "0x1E1DE08", Offset = "0x1E1DE08", VA = "0x1E1DE08")]
	public PlayerSpawnRegion()
	{
	}
}
