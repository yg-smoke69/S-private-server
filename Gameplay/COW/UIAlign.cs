using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D85")]
public class UIAlign : MonoBehaviour
{
	[Token(Token = "0x2002D86")]
	public enum EAlign
	{
		[Token(Token = "0x4011769")]
		Bottom
	}

	[Token(Token = "0x4011767")]
	[FieldOffset(Offset = "0xC")]
	public EAlign m_Align;

	[Token(Token = "0x60130DF")]
	[Address(RVA = "0x1F32384", Offset = "0x1F32384", VA = "0x1F32384")]
	public UIAlign()
	{
	}

	[Token(Token = "0x60130E0")]
	[Address(RVA = "0x1F3238C", Offset = "0x1F3238C", VA = "0x1F3238C")]
	public void Refresh(float width, float height)
	{
	}
}
