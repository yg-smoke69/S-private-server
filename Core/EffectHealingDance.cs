using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000918")]
public class EffectHealingDance : MonoBehaviour
{
	[Token(Token = "0x40054D0")]
	[FieldOffset(Offset = "0xC")]
	private GameObject m_Mesh;

	[Token(Token = "0x40054D1")]
	[FieldOffset(Offset = "0x10")]
	private GameObject m_Others;

	[Token(Token = "0x6003F7A")]
	[Address(RVA = "0x3206A58", Offset = "0x3206A58", VA = "0x3206A58")]
	public EffectHealingDance()
	{
	}

	[Token(Token = "0x6003F7B")]
	[Address(RVA = "0x3206A60", Offset = "0x3206A60", VA = "0x3206A60")]
	public void Init(Transform parent)
	{
	}

	[Token(Token = "0x6003F7C")]
	[Address(RVA = "0x3206BCC", Offset = "0x3206BCC", VA = "0x3206BCC")]
	public void SetData(Vector3 worldPos, float range)
	{
	}

	[Token(Token = "0x6003F7D")]
	[Address(RVA = "0x3206D18", Offset = "0x3206D18", VA = "0x3206D18")]
	public void Clear()
	{
	}
}
