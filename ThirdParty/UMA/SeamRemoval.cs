using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CB5")]
public class SeamRemoval : MonoBehaviour
{
	[Token(Token = "0x4019C86")]
	[FieldOffset(Offset = "0xC")]
	public bool runScript;

	[Token(Token = "0x4019C87")]
	[FieldOffset(Offset = "0x10")]
	public float threshold;

	[Token(Token = "0x4019C88")]
	[FieldOffset(Offset = "0x14")]
	public Transform separatedMesh;

	[Token(Token = "0x4019C89")]
	[FieldOffset(Offset = "0x18")]
	public Transform unifiedMesh;

	[Token(Token = "0x6018490")]
	[Address(RVA = "0x2D54034", Offset = "0x2D54034", VA = "0x2D54034")]
	public SeamRemoval()
	{
	}

	[Token(Token = "0x6018491")]
	[Address(RVA = "0x2D54048", Offset = "0x2D54048", VA = "0x2D54048")]
	private void Update()
	{
	}

	[Token(Token = "0x6018492")]
	[Address(RVA = "0x2D54230", Offset = "0x2D54230", VA = "0x2D54230")]
	public static Mesh PerformSeamRemoval(SkinnedMeshRenderer originalMesh, SkinnedMeshRenderer referenceMesh, float threshold)
	{
		return null;
	}

	[Token(Token = "0x6018493")]
	[Address(RVA = "0x2D54918", Offset = "0x2D54918", VA = "0x2D54918")]
	public static void calculateMeshTangents(Mesh mesh)
	{
	}
}
