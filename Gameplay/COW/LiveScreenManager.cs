using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000D4E")]
public class LiveScreenManager : MonoBehaviour
{
	[Token(Token = "0x4006B32")]
	[FieldOffset(Offset = "0xC")]
	public GameObject m_LiveCamera;

	[Token(Token = "0x4006B33")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_LiveScreen;

	[Token(Token = "0x4006B34")]
	[FieldOffset(Offset = "0x14")]
	private RenderTexture m_CameraTargetTxture;

	[Token(Token = "0x60065FB")]
	[Address(RVA = "0xEC8C6C", Offset = "0xEC8C6C", VA = "0xEC8C6C")]
	public LiveScreenManager()
	{
	}

	[Token(Token = "0x60065FC")]
	[Address(RVA = "0xEC8C74", Offset = "0xEC8C74", VA = "0xEC8C74")]
	protected void OnEnable()
	{
	}

	[Token(Token = "0x60065FD")]
	[Address(RVA = "0xEC9004", Offset = "0xEC9004", VA = "0xEC9004")]
	protected void OnDisable()
	{
	}
}
