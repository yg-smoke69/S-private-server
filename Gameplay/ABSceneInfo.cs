using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D30")]
public class ABSceneInfo
{
	[Token(Token = "0x4019F1E")]
	[FieldOffset(Offset = "0x8")]
	public bool m_hasLMOrCollider;

	[Token(Token = "0x4019F1F")]
	[FieldOffset(Offset = "0xC")]
	public List<ABSceneGOInfo> m_sceneGOInfoList;

	[Token(Token = "0x4019F20")]
	[FieldOffset(Offset = "0x10")]
	public List<int> m_sharedSceneGOInfoList;

	[Token(Token = "0x4019F21")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_rootGO;

	[Token(Token = "0x601879E")]
	[Address(RVA = "0x35BBBF4", Offset = "0x35BBBF4", VA = "0x35BBBF4")]
	public ABSceneInfo()
	{
	}
}
