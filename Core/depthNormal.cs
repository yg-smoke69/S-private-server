using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000004")]
public class depthNormal : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0xC")]
	public DepthTextureMode depthTextureMode;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x337149C", Offset = "0x337149C", VA = "0x337149C")]
	public depthNormal()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x33714AC", Offset = "0x33714AC", VA = "0x33714AC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3371538", Offset = "0x3371538", VA = "0x3371538")]
	private void OnDisable()
	{
	}
}
