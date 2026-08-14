using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D5E")]
public class DiscolorationMono : MonoBehaviour
{
	[Token(Token = "0x4011666")]
	[FieldOffset(Offset = "0xC")]
	public Animation m_anim;

	[Token(Token = "0x4011667")]
	[FieldOffset(Offset = "0x10")]
	public UITexture m_texture;

	[Token(Token = "0x6012FA8")]
	[Address(RVA = "0x1C940E8", Offset = "0x1C940E8", VA = "0x1C940E8")]
	public DiscolorationMono()
	{
	}

	[Token(Token = "0x6012FA9")]
	[Address(RVA = "0x1C940F0", Offset = "0x1C940F0", VA = "0x1C940F0")]
	public void SetDiscolorUI(int x, int y, int z, ResourceID id)
	{
	}

	[Token(Token = "0x6012FAA")]
	[Address(RVA = "0x1C94404", Offset = "0x1C94404", VA = "0x1C94404")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6012FAB")]
	[Address(RVA = "0x1C94500", Offset = "0x1C94500", VA = "0x1C94500")]
	private void OnDisable()
	{
	}
}
