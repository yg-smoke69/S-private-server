using Il2CppDummyDll;
using UMA;
using UnityEngine;

[Token(Token = "0x2003CB3")]
public abstract class OverlayLibraryBase : MonoBehaviour
{
	[Token(Token = "0x6018480")]
	[Address(RVA = "0x1C75FAC", Offset = "0x1C75FAC", VA = "0x1C75FAC")]
	protected OverlayLibraryBase()
	{
	}

	[Token(Token = "0x6018481")]
	public abstract void AddOverlayAsset(OverlayDataAsset overlay);

	[Token(Token = "0x6018482")]
	public abstract OverlayData InstantiateOverlay(string name);

	[Token(Token = "0x6018483")]
	public abstract OverlayData InstantiateOverlay(int nameHash);

	[Token(Token = "0x6018484")]
	public abstract OverlayData InstantiateOverlay(string name, Color color);

	[Token(Token = "0x6018485")]
	public abstract OverlayData InstantiateOverlay(int nameHash, Color color);

	[Token(Token = "0x6018486")]
	public abstract OverlayDataAsset[] GetAllOverlayAssets();

	[Token(Token = "0x6018487")]
	public abstract void UpdateDictionary();

	[Token(Token = "0x6018488")]
	public abstract void ValidateDictionary();
}
