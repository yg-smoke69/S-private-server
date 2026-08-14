using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A8A")]
public class SceneObjectDynamicLoader : MonoBehaviour
{
	[Token(Token = "0x4005CB3")]
	[FieldOffset(Offset = "0xC")]
	public string m_resourceID;

	[Token(Token = "0x4005CB4")]
	[FieldOffset(Offset = "0x10")]
	private GameObject m_gameObject;

	[Token(Token = "0x6005114")]
	[Address(RVA = "0x20DE160", Offset = "0x20DE160", VA = "0x20DE160")]
	public SceneObjectDynamicLoader()
	{
	}

	[Token(Token = "0x6005115")]
	[Address(RVA = "0x20DE168", Offset = "0x20DE168", VA = "0x20DE168")]
	private void Start()
	{
	}

	[Token(Token = "0x6005116")]
	[Address(RVA = "0x20DE24C", Offset = "0x20DE24C", VA = "0x20DE24C")]
	private void LoadResource(string resourIDStr)
	{
	}

	[Token(Token = "0x6005117")]
	[Address(RVA = "0x20DE694", Offset = "0x20DE694", VA = "0x20DE694")]
	private void OnDestroy()
	{
	}
}
