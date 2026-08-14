using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A72")]
public class PCWaitingRoomEPRank : MonoBehaviour
{
	[Token(Token = "0x4005C3A")]
	[FieldOffset(Offset = "0xC")]
	public Camera m_RTCamera;

	[Token(Token = "0x4005C3B")]
	[FieldOffset(Offset = "0x10")]
	public UITexture m_PCRenderTexture;

	[Token(Token = "0x4005C3C")]
	[FieldOffset(Offset = "0x14")]
	private RenderTexture m_PCBiliboardRT;

	[Token(Token = "0x600509C")]
	[Address(RVA = "0x1C76D38", Offset = "0x1C76D38", VA = "0x1C76D38")]
	public PCWaitingRoomEPRank()
	{
	}

	[Token(Token = "0x600509D")]
	[Address(RVA = "0x1C76D40", Offset = "0x1C76D40", VA = "0x1C76D40")]
	public void InitRenderInfo(Transform TextureRoot)
	{
	}

	[Token(Token = "0x600509E")]
	[Address(RVA = "0x1C77228", Offset = "0x1C77228", VA = "0x1C77228")]
	private void OnDestroy()
	{
	}
}
