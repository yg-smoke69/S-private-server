using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002221")]
public class SetMvpCameraPostEffect : MonoBehaviour
{
	[Token(Token = "0x400D520")]
	[FieldOffset(Offset = "0xC")]
	private Camera m_MVPCamera;

	[Token(Token = "0x600B8D1")]
	[Address(RVA = "0x20E1E70", Offset = "0x20E1E70", VA = "0x20E1E70")]
	public SetMvpCameraPostEffect()
	{
	}

	[Token(Token = "0x600B8D2")]
	[Address(RVA = "0x20E1E78", Offset = "0x20E1E78", VA = "0x20E1E78")]
	private void Awake()
	{
	}
}
