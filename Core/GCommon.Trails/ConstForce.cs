using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.Trails;

[Token(Token = "0x2003EB2")]
public class ConstForce : MonoBehaviour
{
	[Token(Token = "0x401A79D")]
	[FieldOffset(Offset = "0xC")]
	public List<SmokePlume> trails;

	[Token(Token = "0x401A79E")]
	[FieldOffset(Offset = "0x10")]
	public float speed;

	[Token(Token = "0x60197FF")]
	[Address(RVA = "0x323EF30", Offset = "0x323EF30", VA = "0x323EF30")]
	public ConstForce()
	{
	}

	[Token(Token = "0x6019800")]
	[Address(RVA = "0x323EFBC", Offset = "0x323EFBC", VA = "0x323EFBC")]
	private void Start()
	{
	}

	[Token(Token = "0x6019801")]
	[Address(RVA = "0x323EFC0", Offset = "0x323EFC0", VA = "0x323EFC0")]
	private void Update()
	{
	}
}
