using Il2CppDummyDll;
using UnityEngine;

namespace COW.Graphics;

[Token(Token = "0x200403C")]
public class VegetationGenerator : MonoBehaviour
{
	[Token(Token = "0x200403D")]
	public enum DDBKGEBAIHM
	{
		[Token(Token = "0x401B03D")]
		Type_Grass_Large,
		[Token(Token = "0x401B03E")]
		Type_Grass_Medium,
		[Token(Token = "0x401B03F")]
		Type_Grass_Small,
		[Token(Token = "0x401B040")]
		Type_Grass_Wheat,
		[Token(Token = "0x401B041")]
		Type_Tree_Pine,
		[Token(Token = "0x401B042")]
		Type_Tree_Green,
		[Token(Token = "0x401B043")]
		Type_Tree_Coco,
		[Token(Token = "0x401B044")]
		Type_Tree_Tropical,
		[Token(Token = "0x401B045")]
		Type_Total
	}

	[Token(Token = "0x401B03B")]
	[FieldOffset(Offset = "0xC")]
	public DDBKGEBAIHM m_type;

	[Token(Token = "0x601A277")]
	[Address(RVA = "0x1D51FA0", Offset = "0x1D51FA0", VA = "0x1D51FA0")]
	public VegetationGenerator()
	{
	}
}
