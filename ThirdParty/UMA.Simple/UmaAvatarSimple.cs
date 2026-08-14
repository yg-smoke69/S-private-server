using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMACharacterSystem;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C83")]
public class UmaAvatarSimple : UMAAvatarBase, _Attribute, IConvertible, IComparable<int>
{
	[Token(Token = "0x4019B6A")]
	[FieldOffset(Offset = "0x48")]
	private UMAContextSimple m_ContextSimple;

	[Token(Token = "0x4019B6B")]
	[FieldOffset(Offset = "0x4C")]
	private UmaRecipeSimpleLibrary m_RecipeLibrary;

	[Token(Token = "0x4019B6C")]
	[FieldOffset(Offset = "0x50")]
	private RaceData m_RaceData;

	[Token(Token = "0x4019B6D")]
	[FieldOffset(Offset = "0x54")]
	private UmaRecipeSimple[] m_Recipes;

	[Token(Token = "0x4019B6E")]
	[FieldOffset(Offset = "0x58")]
	private int m_VisibleSlots;

	[Token(Token = "0x4019B6F")]
	[FieldOffset(Offset = "0x5C")]
	private int m_ChangedSlots;

	[Token(Token = "0x4019B70")]
	[FieldOffset(Offset = "0x60")]
	private ChangeRaceOptions defaultChangeRaceOptions;

	[Token(Token = "0x4019B71")]
	[FieldOffset(Offset = "0x64")]
	public string m_RaceName;

	[Token(Token = "0x4019B72")]
	[FieldOffset(Offset = "0x0")]
	private static int m_DebugIdGen;

	[Token(Token = "0x4019B73")]
	[FieldOffset(Offset = "0x68")]
	public bool LogDebug;

	[Token(Token = "0x4019B74")]
	[FieldOffset(Offset = "0x6C")]
	public int m_DebugId;

	[Token(Token = "0x4019B75")]
	[FieldOffset(Offset = "0x70")]
	public bool PreAsyncLoading;

	[Token(Token = "0x4019B76")]
	[FieldOffset(Offset = "0x71")]
	private bool IsVisible;

	[Token(Token = "0x4019B77")]
	[FieldOffset(Offset = "0x4")]
	private static int[] s_SharedWardrobeSuppressBits;

	[Token(Token = "0x4019B78")]
	[FieldOffset(Offset = "0x8")]
	private static int[] s_SharedWardrobeBeSuppressBits;

	[Token(Token = "0x4019B79")]
	[FieldOffset(Offset = "0xC")]
	private static List<OverlayData>[] s_SharedOverlayData;

	[Token(Token = "0x4019B7A")]
	[FieldOffset(Offset = "0x10")]
	private static List<KeyValuePair<SlotData, AdditiveInfo>> s_SharedAdditiveSlots;

	[Token(Token = "0x4019B7B")]
	[FieldOffset(Offset = "0x72")]
	public bool AsyncLoadingBaseSlots;

	[Token(Token = "0x4019B7C")]
	[FieldOffset(Offset = "0x73")]
	public bool BuildAfterWardrobeSlotsLoaded;

	[Token(Token = "0x4019B7D")]
	[FieldOffset(Offset = "0x74")]
	public int NoAsyncLoadingWardrobeSlots;

	[Token(Token = "0x4019B7E")]
	[FieldOffset(Offset = "0x78")]
	private int m_LoadingWardrobeSlots;

	[Token(Token = "0x4019B7F")]
	[FieldOffset(Offset = "0x7C")]
	private int m_LoadedWardrobeSlots;

	[Token(Token = "0x4019B80")]
	[FieldOffset(Offset = "0x80")]
	private LinkedList<uint>[] m_LoadingWardrobeTickes;

	[Token(Token = "0x4019B81")]
	[FieldOffset(Offset = "0x84")]
	private LinkedList<uint> m_LoadingBaseTickes;

	[Token(Token = "0x4019B82")]
	[FieldOffset(Offset = "0x88")]
	private Sample m_SampleBuild;

	[Token(Token = "0x4019B83")]
	[FieldOffset(Offset = "0x8C")]
	private Sample m_SampleLoad;

	[Token(Token = "0x4019B84")]
	[FieldOffset(Offset = "0x90")]
	private Sample m_SampleUpdate;

	[Token(Token = "0x4019B85")]
	[FieldOffset(Offset = "0x14")]
	private static Sample s_SampleBuild;

	[Token(Token = "0x4019B86")]
	[FieldOffset(Offset = "0x18")]
	private static Sample s_SampleLoad;

	[Token(Token = "0x4019B87")]
	[FieldOffset(Offset = "0x1C")]
	private static Sample s_SampleUpdate;

	[Token(Token = "0x4019B88")]
	[FieldOffset(Offset = "0x94")]
	private int m_BuildCnt;

	[Token(Token = "0x4019B89")]
	[FieldOffset(Offset = "0x98")]
	private int m_SkipBuildForHideCnt;

	[Token(Token = "0x4019B8A")]
	[FieldOffset(Offset = "0x9C")]
	private int m_SkipBuildForNoChangeCnt;

	[Token(Token = "0x4019B8B")]
	[FieldOffset(Offset = "0xA0")]
	private int m_BuildAfterVisibleCnt;

	[Token(Token = "0x4019B8C")]
	[FieldOffset(Offset = "0x20")]
	private static int s_BuildCnt;

	[Token(Token = "0x4019B8D")]
	[FieldOffset(Offset = "0x24")]
	private static int s_SkipBuildForHideCnt;

	[Token(Token = "0x4019B8E")]
	[FieldOffset(Offset = "0x28")]
	private static int s_SkipBuildForNoChangeCnt;

	[Token(Token = "0x4019B8F")]
	[FieldOffset(Offset = "0x2C")]
	private static int s_BuildAfterVisibleCnt;

	[Token(Token = "0x60182F7")]
	[Address(RVA = "0x2D6D254", Offset = "0x2D6D254", VA = "0x2D6D254")]
	public UmaAvatarSimple()
	{
	}

	[Token(Token = "0x60182F8")]
	[Address(RVA = "0x2D6D278", Offset = "0x2D6D278", VA = "0x2D6D278", Slot = "20")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60182F9")]
	[Address(RVA = "0x2D6DB18", Offset = "0x2D6DB18", VA = "0x2D6DB18", Slot = "32")]
	public void InitAsyncLoading(bool pre)
	{
	}

	[Token(Token = "0x60182FA")]
	[Address(RVA = "0x2D6DF3C", Offset = "0x2D6DF3C", VA = "0x2D6DF3C", Slot = "23")]
	public override void EnableDebugLog(bool enable)
	{
	}

	[Token(Token = "0x60182FB")]
	[Address(RVA = "0x2D6E2D0", Offset = "0x2D6E2D0", VA = "0x2D6E2D0", Slot = "21")]
	public override UMAContextIndividual UseIndividualContextCache(SlotOverlayAssetCache cache)
	{
		return null;
	}

	[Token(Token = "0x60182FC")]
	[Address(RVA = "0x2D6E2EC", Offset = "0x2D6E2EC", VA = "0x2D6E2EC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60182FD")]
	[Address(RVA = "0x2D6F988", Offset = "0x2D6F988", VA = "0x2D6F988")]
	private UmaRecipeSimple GetRecipe(string recipe)
	{
		return default(UmaRecipeSimple);
	}

	[Token(Token = "0x60182FE")]
	[Address(RVA = "0x2D6DE3C", Offset = "0x2D6DE3C", VA = "0x2D6DE3C")]
	private void Log(string s)
	{
	}

	[Token(Token = "0x60182FF")]
	[Address(RVA = "0x2D6D564", Offset = "0x2D6D564", VA = "0x2D6D564")]
	private void LogError(string s)
	{
	}

	[Token(Token = "0x6018300")]
	[Address(RVA = "0x2D6D664", Offset = "0x2D6D664", VA = "0x2D6D664")]
	private void InitSlots()
	{
	}

	[Token(Token = "0x6018301")]
	[Address(RVA = "0x2D6FA38", Offset = "0x2D6FA38", VA = "0x2D6FA38", Slot = "34")]
	public void SetSlot(string recipe)
	{
	}

	[Token(Token = "0x6018302")]
	[Address(RVA = "0x2D6FB28", Offset = "0x2D6FB28", VA = "0x2D6FB28", Slot = "35")]
	public void SetSlot(string recipe, uint id)
	{
	}

	[Token(Token = "0x6018303")]
	[Address(RVA = "0x2D6FA58", Offset = "0x2D6FA58", VA = "0x2D6FA58")]
	private void SetSlot(UmaRecipeSimple r)
	{
	}

	[Token(Token = "0x6018304")]
	[Address(RVA = "0x2D6FB68", Offset = "0x2D6FB68", VA = "0x2D6FB68")]
	private void SetSlot(int slot, UmaRecipeSimple r)
	{
	}

	[Token(Token = "0x6018305")]
	[Address(RVA = "0x2D6FEC0", Offset = "0x2D6FEC0", VA = "0x2D6FEC0", Slot = "36")]
	public void ClearSlot(string ws)
	{
	}

	[Token(Token = "0x6018306")]
	[Address(RVA = "0x2D6FF70", Offset = "0x2D6FF70", VA = "0x2D6FF70", Slot = "37")]
	public void ClearSlots(List<string> slotsToClear)
	{
	}

	[Token(Token = "0x6018307")]
	[Address(RVA = "0x2D700B8", Offset = "0x2D700B8", VA = "0x2D700B8", Slot = "38")]
	public void ClearSlots()
	{
	}

	[Token(Token = "0x6018308")]
	[Address(RVA = "0x2D70164", Offset = "0x2D70164", VA = "0x2D70164", Slot = "39")]
	public bool IsSlotVisible(string slot)
	{
		return default(bool);
	}

	[Token(Token = "0x6018309")]
	[Address(RVA = "0x2D70198", Offset = "0x2D70198", VA = "0x2D70198", Slot = "33")]
	public bool IsAsyncLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x601830A")]
	[Address(RVA = "0x2D701B8", Offset = "0x2D701B8", VA = "0x2D701B8", Slot = "40")]
	public List<uint> GetIds()
	{
		return null;
	}

	[Token(Token = "0x601830B")]
	[Address(RVA = "0x2D6D71C", Offset = "0x2D6D71C", VA = "0x2D6D71C")]
	public void InitRace(string racename)
	{
	}

	[Token(Token = "0x601830C")]
	[Address(RVA = "0x2D70358", Offset = "0x2D70358", VA = "0x2D70358", Slot = "26")]
	public void ChangeRace(string racename, ChangeRaceOptions opt = ChangeRaceOptions.useDefaults)
	{
	}

	[Token(Token = "0x601830D")]
	[Address(RVA = "0x2D705CC", Offset = "0x2D705CC", VA = "0x2D705CC")]
	public void ChangeRace(RaceData race, ChangeRaceOptions opt = ChangeRaceOptions.useDefaults)
	{
	}

	[Token(Token = "0x601830E")]
	[Address(RVA = "0x2D6D6D8", Offset = "0x2D6D6D8", VA = "0x2D6D6D8")]
	private void InitColor()
	{
	}

	[Token(Token = "0x601830F")]
	[Address(RVA = "0x2D7097C", Offset = "0x2D7097C", VA = "0x2D7097C")]
	private void LoadRaceBodyColor(RaceData race)
	{
	}

	[Token(Token = "0x6018310")]
	[Address(RVA = "0x2D70A60", Offset = "0x2D70A60", VA = "0x2D70A60")]
	public void SetSkinColor(Color color, bool updateTexture = true)
	{
	}

	[Token(Token = "0x6018311")]
	[Address(RVA = "0x2D70B7C", Offset = "0x2D70B7C", VA = "0x2D70B7C", Slot = "27")]
	public void SetColor(string name, OverlayColorData colorData, bool updateTexture = true)
	{
	}

	[Token(Token = "0x6018312")]
	[Address(RVA = "0x2D70AEC", Offset = "0x2D70AEC", VA = "0x2D70AEC")]
	public void SetColor(string name, Color color, bool updateTexture = true)
	{
	}

	[Token(Token = "0x6018313")]
	[Address(RVA = "0x2D70BF0", Offset = "0x2D70BF0", VA = "0x2D70BF0")]
	private OverlayColorData GetColor(string name)
	{
		return null;
	}

	[Token(Token = "0x6018314")]
	[Address(RVA = "0x2D70C64", Offset = "0x2D70C64", VA = "0x2D70C64", Slot = "28")]
	public void ForceUpdateColor()
	{
	}

	[Token(Token = "0x6018315")]
	[Address(RVA = "0x2D70C38", Offset = "0x2D70C38", VA = "0x2D70C38")]
	private void UpdateColors()
	{
	}

	[Token(Token = "0x6018316")]
	[Address(RVA = "0x2D70C90", Offset = "0x2D70C90", VA = "0x2D70C90", Slot = "24")]
	public override void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x6018317")]
	[Address(RVA = "0x2D70DC4", Offset = "0x2D70DC4", VA = "0x2D70DC4", Slot = "29")]
	public void BuildCharacterImmediatly()
	{
	}

	[Token(Token = "0x6018318")]
	[Address(RVA = "0x2D70980", Offset = "0x2D70980", VA = "0x2D70980", Slot = "30")]
	public void BuildCharacter()
	{
	}

	[Token(Token = "0x6018319")]
	[Address(RVA = "0x2D7113C", Offset = "0x2D7113C", VA = "0x2D7113C")]
	private void DoBuild(bool onWardrobesLoaded, bool onBaseLoaded, bool immediatly)
	{
	}

	[Token(Token = "0x601831A")]
	[Address(RVA = "0x2D70F88", Offset = "0x2D70F88", VA = "0x2D70F88")]
	private bool InitForBuildInNeed()
	{
		return default(bool);
	}

	[Token(Token = "0x601831B")]
	[Address(RVA = "0x2D724C4", Offset = "0x2D724C4", VA = "0x2D724C4")]
	private bool IsRaceChanged()
	{
		return default(bool);
	}

	[Token(Token = "0x601831C")]
	[Address(RVA = "0x2D7261C", Offset = "0x2D7261C", VA = "0x2D7261C")]
	private int CalcWardrobeSlots()
	{
		return default(int);
	}

	[Token(Token = "0x601831D")]
	[Address(RVA = "0x2D735C4", Offset = "0x2D735C4", VA = "0x2D735C4")]
	private int CalcBaseSlots(int wardrobeSlots)
	{
		return default(int);
	}

	[Token(Token = "0x601831E")]
	[Address(RVA = "0x2D73938", Offset = "0x2D73938", VA = "0x2D73938")]
	private void LoadCharacter(int wardrobeSlots, int baseSlots, bool raceChanged)
	{
	}

	[Token(Token = "0x601831F")]
	[Address(RVA = "0x2D73B84", Offset = "0x2D73B84", VA = "0x2D73B84")]
	private List<SlotData> AddBaseSlots(RaceData racedata, UMAData.UMARecipe umaRecipe, UMATextRecipe baseRecipe, int baseSlots)
	{
		return null;
	}

	[Token(Token = "0x6018320")]
	[Address(RVA = "0x2D746F8", Offset = "0x2D746F8", VA = "0x2D746F8")]
	private void AddWardrobeRecipes(RaceData racedata, UMAData.UMARecipe umaRecipe, List<SlotData> dst, int wardrobeSlots, UMATextRecipe baseRecipe, int baseSlots)
	{
	}

	[Token(Token = "0x6018321")]
	[Address(RVA = "0x2D75218", Offset = "0x2D75218", VA = "0x2D75218")]
	private void UpdateRaceOnLoad(bool raceChanged)
	{
	}

	[Token(Token = "0x6018322")]
	[Address(RVA = "0x2D74468", Offset = "0x2D74468", VA = "0x2D74468")]
	private void FixAdditiveSlotInBaseSlots(List<SlotData> slots)
	{
	}

	[Token(Token = "0x6018323")]
	[Address(RVA = "0x2D752A8", Offset = "0x2D752A8", VA = "0x2D752A8")]
	private void AddAdditiveSlots(List<SlotData> dst, int wardrobeSlots, int baseSlotsEnd, List<KeyValuePair<SlotData, AdditiveInfo>> additiveSlots)
	{
	}

	[Token(Token = "0x6018324")]
	[Address(RVA = "0x2D755EC", Offset = "0x2D755EC", VA = "0x2D755EC")]
	private void AddAdditiveToBaseSlot(List<SlotData> dst, int baseSlotsEnd, SlotData slot, AdditiveInfo additiveInfo)
	{
	}

	[Token(Token = "0x6018325")]
	[Address(RVA = "0x2D701A8", Offset = "0x2D701A8", VA = "0x2D701A8")]
	private bool HasWardrobeSlotsLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x6018326")]
	[Address(RVA = "0x2D72E9C", Offset = "0x2D72E9C", VA = "0x2D72E9C")]
	private void UpdateWardrobeSlotsLoading(ref int wardrobeSlots)
	{
	}

	[Token(Token = "0x6018327")]
	[Address(RVA = "0x2D7573C", Offset = "0x2D7573C", VA = "0x2D7573C")]
	private void CancelWardrobeSlotLoading(int slot)
	{
	}

	[Token(Token = "0x6018328")]
	[Address(RVA = "0x2D75768", Offset = "0x2D75768", VA = "0x2D75768")]
	private void StartWardrobeSlotLoading(int slot)
	{
	}

	[Token(Token = "0x6018329")]
	[Address(RVA = "0x2D75F8C", Offset = "0x2D75F8C", VA = "0x2D75F8C")]
	private LinkedList<uint> EnsureWardrobeTicketsList(int slot)
	{
		return null;
	}

	[Token(Token = "0x601832A")]
	[Address(RVA = "0x2D760E4", Offset = "0x2D760E4", VA = "0x2D760E4")]
	private void OnWardrobeSlotLoaded(Object asset, uint ticket, int slot)
	{
	}

	[Token(Token = "0x601832B")]
	[Address(RVA = "0x2D77970", Offset = "0x2D77970", VA = "0x2D77970")]
	private void MarkSlotLoadFailed(int slot)
	{
	}

	[Token(Token = "0x601832C")]
	[Address(RVA = "0x2D77A3C", Offset = "0x2D77A3C", VA = "0x2D77A3C")]
	private void OnAllWardrobeSlotsLoaded()
	{
	}

	[Token(Token = "0x601832D")]
	[Address(RVA = "0x2D738B4", Offset = "0x2D738B4", VA = "0x2D738B4")]
	private bool HasBaseSlotsLoading()
	{
		return default(bool);
	}

	[Token(Token = "0x601832E")]
	[Address(RVA = "0x2D73664", Offset = "0x2D73664", VA = "0x2D73664")]
	private void UpdateBaseSlotsLoading(int baseSlots, bool raceChanged)
	{
	}

	[Token(Token = "0x601832F")]
	[Address(RVA = "0x2D77B20", Offset = "0x2D77B20", VA = "0x2D77B20")]
	private void StartBaseSlotLoading(string name, bool isSlot)
	{
	}

	[Token(Token = "0x6018330")]
	[Address(RVA = "0x2D77E74", Offset = "0x2D77E74", VA = "0x2D77E74")]
	private void OnBaseSlotLoaded(Object asset, uint ticket)
	{
	}

	[Token(Token = "0x6018331")]
	[Address(RVA = "0x2D7854C", Offset = "0x2D7854C", VA = "0x2D7854C")]
	private void OnAllBaseSlotsLoaded()
	{
	}

	[Token(Token = "0x6018332")]
	[Address(RVA = "0x2D6E3B8", Offset = "0x2D6E3B8", VA = "0x2D6E3B8")]
	private void CancelAllSlotsLoading()
	{
	}

	[Token(Token = "0x6018333")]
	[Address(RVA = "0x2D77A60", Offset = "0x2D77A60", VA = "0x2D77A60")]
	private void CancelBaseSlotsLoading()
	{
	}

	[Token(Token = "0x6018334")]
	[Address(RVA = "0x2D78570", Offset = "0x2D78570", VA = "0x2D78570")]
	private void CancelWardrobeSlotsLoading()
	{
	}

	[Token(Token = "0x6018335")]
	[Address(RVA = "0x2D7857C", Offset = "0x2D7857C", VA = "0x2D7857C")]
	private void CancelSlotsLoading(ref int slots, ICollection<uint>[] slotTickets)
	{
	}

	[Token(Token = "0x6018336")]
	[Address(RVA = "0x2D75E98", Offset = "0x2D75E98", VA = "0x2D75E98")]
	private void CancelSlotLoading(ICollection<uint>[] slotTickets, int slot)
	{
	}

	[Token(Token = "0x6018337")]
	[Address(RVA = "0x2D6D834", Offset = "0x2D6D834", VA = "0x2D6D834")]
	public void InitSamples()
	{
	}

	[Token(Token = "0x6018338")]
	[Address(RVA = "0x2D6E3DC", Offset = "0x2D6E3DC", VA = "0x2D6E3DC")]
	private void MergeSamples()
	{
	}

	[Token(Token = "0x6018339")]
	[Address(RVA = "0x2D6E4FC", Offset = "0x2D6E4FC", VA = "0x2D6E4FC")]
	private void LogSamples()
	{
	}

	[Token(Token = "0x601833A")]
	[Address(RVA = "0x2D785E8", Offset = "0x2D785E8", VA = "0x2D785E8")]
	private void OnUmaDataUpdate(UMAData data)
	{
	}
}
