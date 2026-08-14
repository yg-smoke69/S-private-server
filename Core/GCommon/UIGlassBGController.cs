using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x20022A7")]
public class UIGlassBGController : MonoBehaviour
{
	[Token(Token = "0x400D8E5")]
	[FieldOffset(Offset = "0xC")]
	public UITexture Glass;

	[Token(Token = "0x400D8E6")]
	[FieldOffset(Offset = "0x10")]
	public UISprite Black;

	[Token(Token = "0x600BE8C")]
	[Address(RVA = "0x2CA3A18", Offset = "0x2CA3A18", VA = "0x2CA3A18")]
	public UIGlassBGController()
	{
	}

	[Token(Token = "0x600BE8D")]
	[Address(RVA = "0x2CA3A20", Offset = "0x2CA3A20", VA = "0x2CA3A20")]
	private void Start()
	{
	}

	[Token(Token = "0x600BE8E")]
	[Address(RVA = "0x2CA3CC4", Offset = "0x2CA3CC4", VA = "0x2CA3CC4")]
	public void SetDepth(int depth)
	{
	}

	[Token(Token = "0x600BE8F")]
	[Address(RVA = "0x2CA3D94", Offset = "0x2CA3D94", VA = "0x2CA3D94")]
	public void SetBlackAlpha(float alpha)
	{
	}
}
