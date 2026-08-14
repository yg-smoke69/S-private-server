using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E71")]
public class AvatarWardrobeDataManager : SingletonModule<AvatarWardrobeDataManager>
{
	[Token(Token = "0x2001E72")]
	public enum EPlayerIdentity
	{
		[Token(Token = "0x400BF84")]
		LocalPlayer,
		[Token(Token = "0x400BF85")]
		Teammate,
		[Token(Token = "0x400BF86")]
		Enemy
	}

	[Token(Token = "0x400BF71")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, AvatarWardrobeData> m_dictIdToWardrobeData;

	[Token(Token = "0x400BF72")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, LegendClothData> m_dictIdToLegendClothData;

	[Token(Token = "0x400BF73")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, List<AvatarWardrobeData>> m_dictTypeToWardrobeData;

	[Token(Token = "0x400BF74")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, ClothesHairUpData> m_dictIdToHairUpData;

	[Token(Token = "0x400BF75")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<uint, ClothEffectData> m_dictIdToClothEffectData;

	[Token(Token = "0x400BF76")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, MaterialRefData> m_dictIdToMaterialRefData;

	[Token(Token = "0x400BF77")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, MaterialDataList> m_dictIdToBackpackMaterialRefData;

	[Token(Token = "0x400BF78")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, List<AvatarWardrobeData>> m_dictWardrobeSets;

	[Token(Token = "0x400BF79")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, ClothesUpData> m_dictIdToClothUpData;

	[Token(Token = "0x400BF7A")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, EpicClothesTextData> m_dictIdToEpicClothesData;

	[Token(Token = "0x400BF7B")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<string, AvatarHDRecipeData> m_dictHDRecipeData;

	[Token(Token = "0x400BF7C")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<string, List<AvatarRecipeMappingData>> m_dictResipeMappingTargetData;

	[Token(Token = "0x400BF7D")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<string, List<AvatarRecipeMappingData>> m_dictResipeMappingConditionData;

	[Token(Token = "0x400BF7E")]
	[FieldOffset(Offset = "0x40")]
	public UIHudTestRecipeController.EUseQuality TestRecipeUseQuality;

	[Token(Token = "0x400BF7F")]
	public const uint EPICDEFAULTCLOTHID = 203000619u;

	[Token(Token = "0x400BF80")]
	public const uint EPICHACKDEFAULTCLOTHID = 203001180u;

	[Token(Token = "0x400BF81")]
	private const uint EPICMAXLEVELCLOTHID = 203000621u;

	[Token(Token = "0x400BF82")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<LegendClothData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600923D")]
	[Address(RVA = "0x2366298", Offset = "0x2366298", VA = "0x2366298")]
	public AvatarWardrobeDataManager()
	{
	}

	[Token(Token = "0x600923E")]
	[Address(RVA = "0x2366594", Offset = "0x2366594", VA = "0x2366594", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x600923F")]
	[Address(RVA = "0x236672C", Offset = "0x236672C", VA = "0x236672C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6009240")]
	[Address(RVA = "0x2367B88", Offset = "0x2367B88", VA = "0x2367B88")]
	public uint FindHairByLevel(uint id, int level)
	{
		return default(uint);
	}

	[Token(Token = "0x6009241")]
	[Address(RVA = "0x2367980", Offset = "0x2367980", VA = "0x2367980")]
	private void AddRecipeMapping(string key, AvatarRecipeMappingData wData, ref Dictionary<string, List<AvatarRecipeMappingData>> map)
	{
	}

	[Token(Token = "0x6009242")]
	[Address(RVA = "0x2367D18", Offset = "0x2367D18", VA = "0x2367D18")]
	public Dictionary<uint, AvatarWardrobeData> FindAllAvatarWardrobeData()
	{
		return null;
	}

	[Token(Token = "0x6009243")]
	[Address(RVA = "0x2367D70", Offset = "0x2367D70", VA = "0x2367D70")]
	public Dictionary<uint, LegendClothData> GetLegendData()
	{
		return null;
	}

	[Token(Token = "0x6009244")]
	[Address(RVA = "0x2367DC8", Offset = "0x2367DC8", VA = "0x2367DC8")]
	public bool IsClothItemLegend(uint clothId)
	{
		return default(bool);
	}

	[Token(Token = "0x6009245")]
	[Address(RVA = "0x2367F40", Offset = "0x2367F40", VA = "0x2367F40")]
	public bool IsClothItemLegend(AvatarWardrobeData data)
	{
		return default(bool);
	}

	[Token(Token = "0x6009246")]
	[Address(RVA = "0x2367FCC", Offset = "0x2367FCC", VA = "0x2367FCC")]
	public bool IsSetLegend(uint setId)
	{
		return default(bool);
	}

	[Token(Token = "0x6009247")]
	[Address(RVA = "0x2368094", Offset = "0x2368094", VA = "0x2368094")]
	public uint GetLegendLevelByClothId(uint clothId)
	{
		return default(uint);
	}

	[Token(Token = "0x6009248")]
	[Address(RVA = "0x236820C", Offset = "0x236820C", VA = "0x236820C")]
	public uint GetLegendTypeByClothId(uint clothId)
	{
		return default(uint);
	}

	[Token(Token = "0x6009249")]
	[Address(RVA = "0x236811C", Offset = "0x236811C", VA = "0x236811C")]
	public uint GetLegendLevelBySet(uint setId)
	{
		return default(uint);
	}

	[Token(Token = "0x600924A")]
	[Address(RVA = "0x2368294", Offset = "0x2368294", VA = "0x2368294")]
	public uint GetLegendTypeBySet(uint setId)
	{
		return default(uint);
	}

	[Token(Token = "0x600924B")]
	[Address(RVA = "0x2368384", Offset = "0x2368384", VA = "0x2368384")]
	public uint GetLegendGroupAnimIdBySet(uint setId)
	{
		return default(uint);
	}

	[Token(Token = "0x600924C")]
	[Address(RVA = "0x2368474", Offset = "0x2368474", VA = "0x2368474")]
	public bool HaveOwnedLegendClothByLegendId(uint legendId)
	{
		return default(bool);
	}

	[Token(Token = "0x600924D")]
	[Address(RVA = "0x236850C", Offset = "0x236850C", VA = "0x236850C")]
	public LegendClothData GetLegendClothLockLevel(uint legendId, out int unlockLevelMax)
	{
		return null;
	}

	[Token(Token = "0x600924E")]
	[Address(RVA = "0x2368E58", Offset = "0x2368E58", VA = "0x2368E58")]
	public ResourceID GetLegendClothColorIconByLegendIdAndLevel(uint legendId, uint level)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600924F")]
	[Address(RVA = "0x2368F6C", Offset = "0x2368F6C", VA = "0x2368F6C")]
	public LegendClothData GetLegendClothDataByLegendIdAndLevel(uint legendId, uint level)
	{
		return null;
	}

	[Token(Token = "0x6009250")]
	[Address(RVA = "0x2368A74", Offset = "0x2368A74", VA = "0x2368A74")]
	public List<LegendClothData> GetSortedLegendClothDataByLegendId(uint legendId)
	{
		return null;
	}

	[Token(Token = "0x6009251")]
	[Address(RVA = "0x2369088", Offset = "0x2369088", VA = "0x2369088")]
	public List<AvatarWardrobeData> GetLegendAvatarWardrobeData(uint legendId, uint level = 1u)
	{
		return null;
	}

	[Token(Token = "0x6009252")]
	[Address(RVA = "0x236927C", Offset = "0x236927C", VA = "0x236927C")]
	public AvatarWardrobeData GetLegendAvatarWardrobeData(uint legendId, uint level, UIModelAvatarBase.EWardrobeType wardrobeType)
	{
		return null;
	}

	[Token(Token = "0x6009253")]
	[Address(RVA = "0x2367E50", Offset = "0x2367E50", VA = "0x2367E50")]
	public AvatarWardrobeData FindAvatarWardrobeDataById(uint InId)
	{
		return null;
	}

	[Token(Token = "0x6009254")]
	[Address(RVA = "0x2369448", Offset = "0x2369448", VA = "0x2369448")]
	public List<AvatarWardrobeData> FindAvatarWardrobeListByType(uint wType)
	{
		return null;
	}

	[Token(Token = "0x6009255")]
	[Address(RVA = "0x2369538", Offset = "0x2369538", VA = "0x2369538")]
	public List<AvatarRecipeMappingData> FindRecipeMappingForTarget(string recipe)
	{
		return null;
	}

	[Token(Token = "0x6009256")]
	[Address(RVA = "0x2369620", Offset = "0x2369620", VA = "0x2369620")]
	public List<AvatarRecipeMappingData> FindRecipeMappingForCondition(string recipe)
	{
		return null;
	}

	[Token(Token = "0x6009257")]
	[Address(RVA = "0x2369708", Offset = "0x2369708", VA = "0x2369708")]
	public ClothEffectData FindClothEffectDataByQuality(uint quality)
	{
		return null;
	}

	[Token(Token = "0x6009258")]
	[Address(RVA = "0x23697F8", Offset = "0x23697F8", VA = "0x23697F8")]
	public ResourceID FindMatRefIDByClothID(uint clothID, bool female = false, bool inGame = false)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009259")]
	[Address(RVA = "0x2369964", Offset = "0x2369964", VA = "0x2369964")]
	public ResourceID FindMatRefIDByBackpackID(uint clothID, int level, bool female = false)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600925A")]
	[Address(RVA = "0x2369B30", Offset = "0x2369B30", VA = "0x2369B30")]
	public bool ShowClothEffect(EPlayerIdentity pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600925B")]
	[Address(RVA = "0x2368D70", Offset = "0x2368D70", VA = "0x2368D70")]
	public List<AvatarWardrobeData> GetWardrobeSet(uint setID)
	{
		return null;
	}

	[Token(Token = "0x600925C")]
	[Address(RVA = "0x2369C9C", Offset = "0x2369C9C", VA = "0x2369C9C")]
	public bool HasAnimationInCloth(uint clothID)
	{
		return default(bool);
	}

	[Token(Token = "0x600925D")]
	[Address(RVA = "0x2369D14", Offset = "0x2369D14", VA = "0x2369D14")]
	public bool HasAnimationInCloth(AvatarWardrobeData wData)
	{
		return default(bool);
	}

	[Token(Token = "0x600925E")]
	private V FincData<K, V>(Dictionary<K, V> dic, K k) where V : class
	{
		return null;
	}

	[Token(Token = "0x600925F")]
	[Address(RVA = "0x2369E78", Offset = "0x2369E78", VA = "0x2369E78")]
	public ClothesUpData FindClothesUpDataByUniqueID(uint id)
	{
		return null;
	}

	[Token(Token = "0x6009260")]
	[Address(RVA = "0x2369F34", Offset = "0x2369F34", VA = "0x2369F34")]
	public ClothesUpData FindFirstClothesUpDataByClothesID(uint clothesID)
	{
		return null;
	}

	[Token(Token = "0x6009261")]
	[Address(RVA = "0x2369FA4", Offset = "0x2369FA4", VA = "0x2369FA4")]
	public ClothesUpData FindClothesUpDataByClothesAndIndex(uint clothesID, uint index)
	{
		return null;
	}

	[Token(Token = "0x6009262")]
	[Address(RVA = "0x236A1B0", Offset = "0x236A1B0", VA = "0x236A1B0")]
	public ClothesUpData FindEpicClothesUpDataByLevel(uint clothesID, int targetLevel)
	{
		return null;
	}

	[Token(Token = "0x6009263")]
	[Address(RVA = "0x236A26C", Offset = "0x236A26C", VA = "0x236A26C")]
	public EpicClothesTextData FindEpicClothesTextData(uint id)
	{
		return null;
	}

	[Token(Token = "0x6009264")]
	[Address(RVA = "0x236A328", Offset = "0x236A328", VA = "0x236A328")]
	public bool IsEpicClothes(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6009265")]
	[Address(RVA = "0x236A3F4", Offset = "0x236A3F4", VA = "0x236A3F4")]
	public string GetHDRecipe(string defaultRecipe)
	{
		return null;
	}

	[Token(Token = "0x6009266")]
	[Address(RVA = "0x236A53C", Offset = "0x236A53C", VA = "0x236A53C")]
	public string GetLobbyRecipe(uint dataID, uint avatarId, bool isFemale)
	{
		return null;
	}

	[Token(Token = "0x6009267")]
	[Address(RVA = "0x236A5D8", Offset = "0x236A5D8", VA = "0x236A5D8")]
	public string GetLobbyRecipe(AvatarWardrobeData wData, uint avatarId, bool isFemale)
	{
		return null;
	}

	[Token(Token = "0x6009268")]
	[Address(RVA = "0x236ABA0", Offset = "0x236ABA0", VA = "0x236ABA0")]
	public bool CheckHasTeamIdById(uint Id)
	{
		return default(bool);
	}

	[Token(Token = "0x6009269")]
	[Address(RVA = "0x236AC28", Offset = "0x236AC28", VA = "0x236AC28")]
	public uint GetTeamIdById(uint Id)
	{
		return default(uint);
	}

	[Token(Token = "0x600926A")]
	[Address(RVA = "0x236ACA4", Offset = "0x236ACA4", VA = "0x236ACA4")]
	private static int _003CGetSortedLegendClothDataByLegendId_003Em__0(LegendClothData a, LegendClothData b)
	{
		return default(int);
	}
}
