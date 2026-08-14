using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003F26")]
public class ChangePCTextureHelper : MonoBehaviour
{
	[Token(Token = "0x401AA15")]
	[FieldOffset(Offset = "0xC")]
	public string[] MaterialNameArray;

	[Token(Token = "0x401AA16")]
	[FieldOffset(Offset = "0x10")]
	public string[] TextureNameArray;

	[Token(Token = "0x401AA17")]
	[FieldOffset(Offset = "0x14")]
	public int width;

	[Token(Token = "0x401AA18")]
	[FieldOffset(Offset = "0x18")]
	public int height;

	[Token(Token = "0x6019B54")]
	[Address(RVA = "0x30805D0", Offset = "0x30805D0", VA = "0x30805D0")]
	public ChangePCTextureHelper()
	{
	}
}
