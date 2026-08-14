using System;
using System.Collections.Generic;
using Il2CppDummyDll;

[Serializable]
[Token(Token = "0x2003D26")]
public class StreamerSceneCollectionInfo
{
	[Token(Token = "0x4019EFC")]
	[FieldOffset(Offset = "0x8")]
	public List<uint> TextureIndexList;

	[Token(Token = "0x4019EFD")]
	[FieldOffset(Offset = "0xC")]
	public List<uint> MeshIndexList;

	[Token(Token = "0x6018780")]
	[Address(RVA = "0x21DB5CC", Offset = "0x21DB5CC", VA = "0x21DB5CC")]
	public StreamerSceneCollectionInfo()
	{
	}
}
