using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200074B")]
public class ChessNumIcon : MonoBehaviour
{
	[Token(Token = "0x4004CDE")]
	[FieldOffset(Offset = "0xC")]
	public Transform ShowRoot;

	[Token(Token = "0x4004CDF")]
	[FieldOffset(Offset = "0x10")]
	public GameObject NumberMesh;

	[Token(Token = "0x4004CE0")]
	[FieldOffset(Offset = "0x14")]
	public List<Texture> NumberTextureConfigs;

	[Token(Token = "0x6002DF9")]
	[Address(RVA = "0x230D42C", Offset = "0x230D42C", VA = "0x230D42C")]
	public ChessNumIcon()
	{
	}

	[Token(Token = "0x6002DFA")]
	[Address(RVA = "0x230D4B8", Offset = "0x230D4B8", VA = "0x230D4B8")]
	public void Init()
	{
	}

	[Token(Token = "0x6002DFB")]
	[Address(RVA = "0x230D4C0", Offset = "0x230D4C0", VA = "0x230D4C0")]
	public void ChangeShowRoot(bool show)
	{
	}

	[Token(Token = "0x6002DFC")]
	[Address(RVA = "0x230D59C", Offset = "0x230D59C", VA = "0x230D59C")]
	public void ChangeNumber(uint chessType, uint showNumber)
	{
	}

	[Token(Token = "0x6002DFD")]
	[Address(RVA = "0x230D6AC", Offset = "0x230D6AC", VA = "0x230D6AC")]
	private void Update()
	{
	}
}
