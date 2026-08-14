using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A55")]
internal class CommonMaterialEffect : ReusableObject
{
	[Token(Token = "0x4005BB4")]
	[FieldOffset(Offset = "0x18")]
	public Material mMaterial;

	[Token(Token = "0x6005021")]
	[Address(RVA = "0x1737E20", Offset = "0x1737E20", VA = "0x1737E20")]
	public CommonMaterialEffect()
	{
	}

	[Token(Token = "0x6005022")]
	[Address(RVA = "0x1737E28", Offset = "0x1737E28", VA = "0x1737E28")]
	private void Start()
	{
	}
}
