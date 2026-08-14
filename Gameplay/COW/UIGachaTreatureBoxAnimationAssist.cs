using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200267B")]
public class UIGachaTreatureBoxAnimationAssist : MonoBehaviour
{
	[Token(Token = "0x400ED8F")]
	[FieldOffset(Offset = "0xC")]
	public List<GameObject> LotteryObjects;

	[Token(Token = "0x400ED90")]
	[FieldOffset(Offset = "0x10")]
	public List<Material> QualityMaterials;

	[Token(Token = "0x400ED91")]
	[FieldOffset(Offset = "0x14")]
	public List<SkinnedMeshRenderer> SkinnedMeshRenderers;

	[Token(Token = "0x600E6D7")]
	[Address(RVA = "0x2E8F5D4", Offset = "0x2E8F5D4", VA = "0x2E8F5D4")]
	public UIGachaTreatureBoxAnimationAssist()
	{
	}

	[Token(Token = "0x600E6D8")]
	[Address(RVA = "0x2E8F6C8", Offset = "0x2E8F6C8", VA = "0x2E8F6C8")]
	public void SetLotterieView(List<uint> Qualitis)
	{
	}
}
