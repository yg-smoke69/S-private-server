using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20006A5")]
public class LevelStropShelf : MonoBehaviour
{
	[Token(Token = "0x40048EF")]
	[FieldOffset(Offset = "0xC")]
	public int StropShelfId;

	[Token(Token = "0x40048F0")]
	[FieldOffset(Offset = "0x10")]
	public LevelStropShelfMesh MeshTF;

	[Token(Token = "0x40048F1")]
	[FieldOffset(Offset = "0x14")]
	public bool MeshVisible;

	[Token(Token = "0x6002AB3")]
	[Address(RVA = "0x20D4818", Offset = "0x20D4818", VA = "0x20D4818")]
	public LevelStropShelf()
	{
	}
}
