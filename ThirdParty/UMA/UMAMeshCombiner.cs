using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CE6")]
public abstract class UMAMeshCombiner : MonoBehaviour
{
	[Token(Token = "0x6018601")]
	[Address(RVA = "0x35E00E8", Offset = "0x35E00E8", VA = "0x35E00E8")]
	protected UMAMeshCombiner()
	{
	}

	[Token(Token = "0x6018602")]
	public abstract void UpdateUMAMesh(bool updatedAtlas, UMAData umaData, int atlasResolution);

	[Token(Token = "0x6018603")]
	[Address(RVA = "0x35E00F0", Offset = "0x35E00F0", VA = "0x35E00F0", Slot = "5")]
	public virtual void Preprocess(UMAData umaData)
	{
	}
}
