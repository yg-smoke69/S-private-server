using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000AE9")]
internal class SceneEditTireLine : MonoBehaviour
{
	[Token(Token = "0x4005ECB")]
	[FieldOffset(Offset = "0xC")]
	public LineRenderer m_LineRenderer;

	[Token(Token = "0x6005401")]
	[Address(RVA = "0x20DC548", Offset = "0x20DC548", VA = "0x20DC548")]
	public SceneEditTireLine()
	{
	}

	[Token(Token = "0x6005402")]
	[Address(RVA = "0x20DC550", Offset = "0x20DC550", VA = "0x20DC550")]
	public void SetPoint(int index, Vector3 position)
	{
	}

	[Token(Token = "0x6005403")]
	[Address(RVA = "0x20DC604", Offset = "0x20DC604", VA = "0x20DC604")]
	public void SetVertexCount(int count)
	{
	}

	[Token(Token = "0x6005404")]
	[Address(RVA = "0x20DC688", Offset = "0x20DC688", VA = "0x20DC688")]
	public Vector3 GetPoint(int index)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6005405")]
	[Address(RVA = "0x20DC728", Offset = "0x20DC728", VA = "0x20DC728")]
	public int GetVertexCount()
	{
		return default(int);
	}
}
