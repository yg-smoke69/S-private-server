using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F9C")]
public class PBRGlobalParameterController : MonoBehaviour
{
	[Token(Token = "0x401ACBF")]
	[FieldOffset(Offset = "0xC")]
	public float aoLevelMin;

	[Token(Token = "0x401ACC0")]
	[FieldOffset(Offset = "0x10")]
	public float aoLevelMax;

	[Token(Token = "0x401ACC1")]
	[FieldOffset(Offset = "0x14")]
	public float aoStrength;

	[Token(Token = "0x401ACC2")]
	[FieldOffset(Offset = "0x18")]
	public float shadowmaskStrength;

	[Token(Token = "0x6019E16")]
	[Address(RVA = "0x1C76C54", Offset = "0x1C76C54", VA = "0x1C76C54")]
	public PBRGlobalParameterController()
	{
	}

	[Token(Token = "0x6019E17")]
	[Address(RVA = "0x1C76C74", Offset = "0x1C76C74", VA = "0x1C76C74")]
	private void Awake()
	{
	}

	[Token(Token = "0x6019E18")]
	[Address(RVA = "0x1C76D34", Offset = "0x1C76D34", VA = "0x1C76D34")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6019E19")]
	[Address(RVA = "0x1C76C78", Offset = "0x1C76C78", VA = "0x1C76C78")]
	private void ApplyParameters()
	{
	}
}
