using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UMACharacterSystem;

[Token(Token = "0x2003C58")]
public class DynamicCharacterSystem : DynamicCharacterSystemBase
{
	[Token(Token = "0x4019AA1")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<string, UMATextRecipe> RecipeIndex;

	[Token(Token = "0x4019AA2")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<string, Dictionary<string, List<UMATextRecipe>>> Recipes;

	[Token(Token = "0x4019AA3")]
	[FieldOffset(Offset = "0x14")]
	public Dictionary<string, string> CharacterRecipes;

	[Token(Token = "0x4019AA4")]
	[FieldOffset(Offset = "0x18")]
	public bool initializeOnAwake;

	[NonSerialized]
	[Token(Token = "0x4019AA5")]
	[FieldOffset(Offset = "0x19")]
	public bool initialized;

	[Token(Token = "0x4019AA6")]
	[FieldOffset(Offset = "0x1A")]
	private bool isInitializing;

	[Token(Token = "0x4019AA7")]
	[FieldOffset(Offset = "0x1B")]
	public bool dynamicallyAddFromResources;

	[Token(Token = "0x4019AA8")]
	[FieldOffset(Offset = "0x1C")]
	public string resourcesCharactersFolder;

	[Token(Token = "0x4019AA9")]
	[FieldOffset(Offset = "0x20")]
	public string resourcesRecipesFolder;

	[Token(Token = "0x4019AAA")]
	[FieldOffset(Offset = "0x24")]
	public bool dynamicallyAddFromAssetBundles;

	[Token(Token = "0x4019AAB")]
	[FieldOffset(Offset = "0x28")]
	public string assetBundlesForCharactersToSearch;

	[Token(Token = "0x4019AAC")]
	[FieldOffset(Offset = "0x2C")]
	public string assetBundlesForRecipesToSearch;

	[Token(Token = "0x4019AAD")]
	[FieldOffset(Offset = "0x30")]
	public bool addAllRecipesFromDownloadedBundles;

	[Token(Token = "0x4019AAE")]
	[FieldOffset(Offset = "0x34")]
	public UMAContext context;

	[Token(Token = "0x4019AAF")]
	[FieldOffset(Offset = "0x38")]
	public Dictionary<string, List<string>> assetBundlesUsedDict;

	[NonSerialized]
	[Token(Token = "0x4019AB0")]
	[FieldOffset(Offset = "0x3C")]
	public bool downloadAssetsEnabled;

	[Token(Token = "0x6018164")]
	[Address(RVA = "0x35FD59C", Offset = "0x35FD59C", VA = "0x35FD59C")]
	public DynamicCharacterSystem()
	{
	}

	[Token(Token = "0x6018165")]
	[Address(RVA = "0x35FD728", Offset = "0x35FD728", VA = "0x35FD728", Slot = "4")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6018166")]
	[Address(RVA = "0x35FD754", Offset = "0x35FD754", VA = "0x35FD754", Slot = "6")]
	public override void Start()
	{
	}

	[Token(Token = "0x6018167")]
	[Address(RVA = "0x35FD770", Offset = "0x35FD770", VA = "0x35FD770", Slot = "9")]
	public override void Init()
	{
	}

	[Token(Token = "0x6018168")]
	[Address(RVA = "0x35FE084", Offset = "0x35FE084", VA = "0x35FE084")]
	public void EnsureRaceKey(string race)
	{
	}

	[Token(Token = "0x6018169")]
	[Address(RVA = "0x35FE170", Offset = "0x35FE170", VA = "0x35FE170")]
	public void RefreshRaceKeys()
	{
	}

	[Token(Token = "0x601816A")]
	[Address(RVA = "0x35FF818", Offset = "0x35FF818", VA = "0x35FF818", Slot = "7")]
	public override void Refresh(bool forceUpdateRaceLibrary = true, string bundleToGather = "")
	{
	}

	[Token(Token = "0x601816B")]
	[Address(RVA = "0x35FDDC0", Offset = "0x35FDDC0", VA = "0x35FDDC0")]
	private void GatherCharacterRecipes(string filename = "", string bundleToGather = "")
	{
	}

	[Token(Token = "0x601816C")]
	[Address(RVA = "0x35FDDC4", Offset = "0x35FDDC4", VA = "0x35FDDC4")]
	private void GatherRecipeFiles(string filename = "", string bundleToGather = "")
	{
	}

	[Token(Token = "0x601816D")]
	[Address(RVA = "0x35FFCF0", Offset = "0x35FFCF0", VA = "0x35FFCF0")]
	public void AddRecipesFromAB(UMATextRecipe[] uparts)
	{
	}

	[Token(Token = "0x601816E")]
	[Address(RVA = "0x35FFD90", Offset = "0x35FFD90", VA = "0x35FFD90")]
	public void AddRecipe(UMATextRecipe upart)
	{
	}

	[Token(Token = "0x601816F")]
	[Address(RVA = "0x35FEAFC", Offset = "0x35FEAFC", VA = "0x35FEAFC")]
	public void AddRecipes(UMATextRecipe[] uparts, string filename = "")
	{
	}

	[Token(Token = "0x6018170")]
	[Address(RVA = "0x35F7404", Offset = "0x35F7404", VA = "0x35F7404")]
	public UMATextRecipe GetRecipe(string filename, bool dynamicallyAdd = true)
	{
		return null;
	}

	[Token(Token = "0x6018171")]
	[Address(RVA = "0x35FFEF0", Offset = "0x35FFEF0", VA = "0x35FFEF0")]
	public string GetOriginatingAssetBundle(string recipeName)
	{
		return null;
	}

	[Token(Token = "0x6018172")]
	[Address(RVA = "0x36002C0", Offset = "0x36002C0", VA = "0x36002C0", Slot = "11")]
	public override List<string> GetRecipeNamesForRaceSlot(string race, string slot)
	{
		return null;
	}

	[Token(Token = "0x6018173")]
	[Address(RVA = "0x36005DC", Offset = "0x36005DC", VA = "0x36005DC", Slot = "12")]
	public override List<UMARecipeBase> GetRecipesForRaceSlot(string race, string slot)
	{
		return null;
	}

	[Token(Token = "0x6018174")]
	[Address(RVA = "0x36008E0", Offset = "0x36008E0", VA = "0x36008E0", Slot = "13")]
	public override bool CheckRecipeAvailability(string recipeName)
	{
		return default(bool);
	}

	[Token(Token = "0x6018175")]
	[Address(RVA = "0x3600AB0", Offset = "0x3600AB0", VA = "0x3600AB0", Slot = "10")]
	public override UMARecipeBase GetBaseRecipe(string filename, bool dynamicallyAdd = true)
	{
		return null;
	}
}
