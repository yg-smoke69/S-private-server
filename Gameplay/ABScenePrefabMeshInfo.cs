using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2003D2A")]
public class ABScenePrefabMeshInfo
{
	[Token(Token = "0x4019F10")]
	[FieldOffset(Offset = "0x8")]
	public int m_prefabID;

	[Token(Token = "0x4019F11")]
	[FieldOffset(Offset = "0xC")]
	public List<int> m_meshIDList;

	[Token(Token = "0x6018791")]
	[Address(RVA = "0x35BBD24", Offset = "0x35BBD24", VA = "0x35BBD24")]
	public ABScenePrefabMeshInfo(int prefabID, List<int> meshIDList)
	{
	}
}
