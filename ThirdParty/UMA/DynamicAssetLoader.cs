using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003C49")]
public class DynamicAssetLoader : MonoBehaviour
{
	[Token(Token = "0x4019A52")]
	[FieldOffset(Offset = "0x0")]
	private static DynamicAssetLoader _instance;

	[Token(Token = "0x4019A53")]
	[FieldOffset(Offset = "0xC")]
	public bool isInitialized;

	[Token(Token = "0x4019A54")]
	[FieldOffset(Offset = "0x10")]
	public RaceData placeholderRace;

	[Token(Token = "0x4019A55")]
	[FieldOffset(Offset = "0x14")]
	public UMATextRecipe placeholderWardrobeRecipe;

	[Token(Token = "0x4019A56")]
	[FieldOffset(Offset = "0x18")]
	public SlotDataAsset placeholderSlot;

	[Token(Token = "0x4019A57")]
	[FieldOffset(Offset = "0x1C")]
	public OverlayDataAsset placeholderOverlay;

	[Token(Token = "0x4019A58")]
	[FieldOffset(Offset = "0x20")]
	public bool debugOnFail;

	[Token(Token = "0x1700197B")]
	public static DynamicAssetLoader Instance
	{
		[Token(Token = "0x60180EB")]
		[Address(RVA = "0x224C244", Offset = "0x224C244", VA = "0x224C244")]
		get
		{
			return null;
		}
		[Token(Token = "0x60180EC")]
		[Address(RVA = "0x224C4A8", Offset = "0x224C4A8", VA = "0x224C4A8")]
		set
		{
		}
	}

	[Token(Token = "0x60180EA")]
	[Address(RVA = "0x224C234", Offset = "0x224C234", VA = "0x224C234")]
	public DynamicAssetLoader()
	{
	}

	[Token(Token = "0x60180ED")]
	[Address(RVA = "0x224C50C", Offset = "0x224C50C", VA = "0x224C50C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60180EE")]
	[Address(RVA = "0x224C6AC", Offset = "0x224C6AC", VA = "0x224C6AC")]
	private void Start()
	{
	}

	[Token(Token = "0x60180EF")]
	[Address(RVA = "0x224C6BC", Offset = "0x224C6BC", VA = "0x224C6BC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60180F0")]
	[Address(RVA = "0x224C544", Offset = "0x224C544", VA = "0x224C544")]
	private void StartCO()
	{
	}

	[Token(Token = "0x60180F1")]
	[Address(RVA = "0x224C31C", Offset = "0x224C31C", VA = "0x224C31C")]
	public static DynamicAssetLoader FindInstance()
	{
		return null;
	}

	[Token(Token = "0x60180F2")]
	public virtual bool AddAssets<T>(ref Dictionary<string, List<string>> assetBundlesUsedDict, bool searchResources, bool searchBundles, bool downloadAssetsEnabled, string bundlesToSearch = "", string resourcesFolderPath = "", [Optional] int? assetNameHash, string assetName = "", [Optional] Action<T[]> callback, bool forceDownloadAll = false) where T : Object
	{
		return default(bool);
	}

	[Token(Token = "0x60180F3")]
	public bool AddAssets<T>(bool searchResources, bool searchBundles, bool downloadAssetsEnabled, string bundlesToSearch = "", string resourcesFolderPath = "", [Optional] int? assetNameHash, string assetName = "", [Optional] Action<T[]> callback, bool forceDownloadAll = false) where T : Object
	{
		return default(bool);
	}

	[Token(Token = "0x60180F4")]
	public bool AddAssetsFromResourcesIndex<T>(ref List<T> assetsToReturn, string[] resourcesFolderPathArray, [Optional] int? assetNameHash, string assetName = "") where T : Object
	{
		return default(bool);
	}

	[Token(Token = "0x60180F5")]
	[Address(RVA = "0x224C780", Offset = "0x224C780", VA = "0x224C780")]
	private string[] SearchStringToArray(string searchString = "")
	{
		return null;
	}

	[Token(Token = "0x60180F6")]
	[Address(RVA = "0x224CA48", Offset = "0x224CA48", VA = "0x224CA48", Slot = "5")]
	public virtual void AddWardrobeRecipes(Action<UMAWardrobeRecipe[]> callback)
	{
	}
}
