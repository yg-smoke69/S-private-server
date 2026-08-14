using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA;

[Token(Token = "0x2003C5A")]
public class DynamicRaceLibrary : RaceLibrary
{
	[Token(Token = "0x4019AB7")]
	[FieldOffset(Offset = "0x14")]
	public bool dynamicallyAddFromResources;

	[Token(Token = "0x4019AB8")]
	[FieldOffset(Offset = "0x18")]
	public string resourcesFolderPath;

	[Token(Token = "0x4019AB9")]
	[FieldOffset(Offset = "0x1C")]
	public bool dynamicallyAddFromAssetBundles;

	[Token(Token = "0x4019ABA")]
	[FieldOffset(Offset = "0x20")]
	public string assetBundleNamesToSearch;

	[Token(Token = "0x4019ABB")]
	[FieldOffset(Offset = "0x24")]
	public Dictionary<string, List<string>> assetBundlesUsedDict;

	[NonSerialized]
	[Token(Token = "0x4019ABC")]
	[FieldOffset(Offset = "0x28")]
	private bool allStartingAssetsAdded;

	[NonSerialized]
	[Token(Token = "0x4019ABD")]
	[FieldOffset(Offset = "0x29")]
	public bool downloadAssetsEnabled;

	[Token(Token = "0x6018182")]
	[Address(RVA = "0x32009A8", Offset = "0x32009A8", VA = "0x32009A8")]
	public DynamicRaceLibrary()
	{
	}

	[Token(Token = "0x6018183")]
	[Address(RVA = "0x3200A94", Offset = "0x3200A94", VA = "0x3200A94")]
	public void Awake()
	{
	}

	[Token(Token = "0x6018184")]
	[Address(RVA = "0x3200A98", Offset = "0x3200A98", VA = "0x3200A98")]
	public void Start()
	{
	}

	[Token(Token = "0x6018185")]
	[Address(RVA = "0x3200B20", Offset = "0x3200B20", VA = "0x3200B20")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6018186")]
	[Address(RVA = "0x3200B24", Offset = "0x3200B24", VA = "0x3200B24")]
	public void ClearEditorAddedAssets()
	{
	}

	[Token(Token = "0x6018187")]
	[Address(RVA = "0x3200B28", Offset = "0x3200B28", VA = "0x3200B28")]
	public void UpdateDynamicRaceLibrary(bool downloadAssets, [Optional] int? raceHash)
	{
	}

	[Token(Token = "0x6018188")]
	[Address(RVA = "0x3200DA0", Offset = "0x3200DA0", VA = "0x3200DA0")]
	public void UpdateDynamicRaceLibrary(string raceName)
	{
	}

	[Token(Token = "0x6018189")]
	[Address(RVA = "0x3200F00", Offset = "0x3200F00", VA = "0x3200F00")]
	private void AddRaces(RaceData[] races)
	{
	}

	[Token(Token = "0x601818A")]
	[Address(RVA = "0x32011F8", Offset = "0x32011F8", VA = "0x32011F8", Slot = "4")]
	public override void AddRace(RaceData race)
	{
	}

	[Token(Token = "0x601818B")]
	[Address(RVA = "0x32014AC", Offset = "0x32014AC", VA = "0x32014AC", Slot = "5")]
	public override RaceData GetRace(string raceName)
	{
		return null;
	}

	[Token(Token = "0x601818C")]
	[Address(RVA = "0x32014B4", Offset = "0x32014B4", VA = "0x32014B4")]
	public RaceData GetRace(string raceName, bool allowUpdate = true)
	{
		return null;
	}

	[Token(Token = "0x601818D")]
	[Address(RVA = "0x32015F8", Offset = "0x32015F8", VA = "0x32015F8", Slot = "6")]
	public override RaceData GetRace(int nameHash)
	{
		return null;
	}

	[Token(Token = "0x601818E")]
	[Address(RVA = "0x3201600", Offset = "0x3201600", VA = "0x3201600")]
	public RaceData GetRace(int nameHash, bool allowUpdate = true)
	{
		return null;
	}

	[Token(Token = "0x601818F")]
	[Address(RVA = "0x3201768", Offset = "0x3201768", VA = "0x3201768")]
	public RaceData[] GetAllRacesBase()
	{
		return null;
	}

	[Token(Token = "0x6018190")]
	[Address(RVA = "0x3201770", Offset = "0x3201770", VA = "0x3201770", Slot = "7")]
	public override RaceData[] GetAllRaces()
	{
		return null;
	}

	[Token(Token = "0x6018191")]
	[Address(RVA = "0x32017A4", Offset = "0x32017A4", VA = "0x32017A4")]
	public string GetOriginatingAssetBundle(string raceName)
	{
		return null;
	}
}
