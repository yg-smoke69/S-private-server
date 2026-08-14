using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2004036")]
public class UV2Info : ScriptableObject
{
	[Token(Token = "0x401B021")]
	[FieldOffset(Offset = "0xC")]
	public Mesh[] meshes;

	[Token(Token = "0x401B022")]
	[FieldOffset(Offset = "0x10")]
	public Mesh[] clonedMeshes;

	[Token(Token = "0x601A26A")]
	[Address(RVA = "0x2A63528", Offset = "0x2A63528", VA = "0x2A63528")]
	public UV2Info()
	{
	}
}
