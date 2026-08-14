using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2004147")]
public class UIExtendAnimation : MonoBehaviour
{
	[Token(Token = "0x401B652")]
	[FieldOffset(Offset = "0xC")]
	public Animation m_animation;

	[Token(Token = "0x401B653")]
	[FieldOffset(Offset = "0x10")]
	public bool ResetAnimOnEnable;

	[Token(Token = "0x601AAD1")]
	[Address(RVA = "0x19EB6D4", Offset = "0x19EB6D4", VA = "0x19EB6D4")]
	public UIExtendAnimation()
	{
	}

	[Token(Token = "0x601AAD2")]
	[Address(RVA = "0x19EB6DC", Offset = "0x19EB6DC", VA = "0x19EB6DC")]
	public void OnEnable()
	{
	}
}
