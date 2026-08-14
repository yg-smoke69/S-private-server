using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E74")]
public class CSSharedAvatarDataManager : SingletonModule<CSSharedAvatarDataManager>
{
	[Token(Token = "0x2001E75")]
	private sealed class _003CFindAvatarDataByBundleID_003Ec__AnonStorey0
	{
		[Token(Token = "0x400BF8F")]
		[FieldOffset(Offset = "0x8")]
		internal uint bundleID;

		[Token(Token = "0x600928F")]
		[Address(RVA = "0x1825BEC", Offset = "0x1825BEC", VA = "0x1825BEC")]
		public _003CFindAvatarDataByBundleID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6009290")]
		[Address(RVA = "0x1826E84", Offset = "0x1826E84", VA = "0x1826E84")]
		internal bool _003C_003Em__0(CSSharedAvatarData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400BF88")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, CSSharedAvatarData> m_dictIdToAvatarData;

	[Token(Token = "0x400BF89")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, List<CSSharedAvatarData>> m_dictGenderToAvatarData;

	[Token(Token = "0x400BF8A")]
	[FieldOffset(Offset = "0x14")]
	private List<uint> m_DefaultPVEWeapons;

	[Token(Token = "0x400BF8B")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, Dictionary<uint, AvatarAwakenTaskData>> m_dicToAvatarAwakenTaskData;

	[Token(Token = "0x400BF8C")]
	[FieldOffset(Offset = "0x1C")]
	private List<CSSharedAvatarData> m_AvatarDataList;

	[Token(Token = "0x400BF8D")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, List<AvatarFacialExpressionData>> m_dictToFacialExpressionData;

	[Token(Token = "0x400BF8E")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, List<AvatarMatchResultFacialExpressionData>> m_dictToMatchResultFacialExpressionData;

	[Token(Token = "0x6009277")]
	[Address(RVA = "0x18233B0", Offset = "0x18233B0", VA = "0x18233B0")]
	public CSSharedAvatarDataManager()
	{
	}

	[Token(Token = "0x6009278")]
	[Address(RVA = "0x1823544", Offset = "0x1823544", VA = "0x1823544", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6009279")]
	[Address(RVA = "0x18236AC", Offset = "0x18236AC", VA = "0x18236AC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600927A")]
	[Address(RVA = "0x18246B4", Offset = "0x18246B4", VA = "0x18246B4")]
	public CSSharedAvatarData FindCSSharedAvatarDataById(uint InId)
	{
		return null;
	}

	[Token(Token = "0x600927B")]
	[Address(RVA = "0x18247A4", Offset = "0x18247A4", VA = "0x18247A4")]
	public bool IsAvatarCantEquipHeadAdditive(uint avatarId)
	{
		return default(bool);
	}

	[Token(Token = "0x600927C")]
	[Address(RVA = "0x182482C", Offset = "0x182482C", VA = "0x182482C")]
	public List<CSSharedAvatarData> FindCSSharedAvatarListByGender(int gender)
	{
		return null;
	}

	[Token(Token = "0x600927D")]
	[Address(RVA = "0x182491C", Offset = "0x182491C", VA = "0x182491C")]
	public uint FindDefaultAvatarIDByGender(int gender)
	{
		return default(uint);
	}

	[Token(Token = "0x600927E")]
	[Address(RVA = "0x1824AFC", Offset = "0x1824AFC", VA = "0x1824AFC")]
	public uint[] AllPVEWeapons()
	{
		return null;
	}

	[Token(Token = "0x600927F")]
	[Address(RVA = "0x1824E7C", Offset = "0x1824E7C", VA = "0x1824E7C")]
	public CSSharedAvatarData FindAvatarDataByPVEWeapon(uint weaponID)
	{
		return null;
	}

	[Token(Token = "0x6009280")]
	[Address(RVA = "0x18250A0", Offset = "0x18250A0", VA = "0x18250A0")]
	public AvatarAwakenTaskData GetAvatarAwakenTaskData(uint avatarID, uint taskType)
	{
		return null;
	}

	[Token(Token = "0x6009281")]
	[Address(RVA = "0x1825260", Offset = "0x1825260", VA = "0x1825260")]
	public List<AvatarAwakenTaskData> GetAwakenTaskList(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x6009282")]
	[Address(RVA = "0x1825468", Offset = "0x1825468", VA = "0x1825468")]
	public AvatarAwakenComicData GetAwakenComicData(uint avatarID, uint comicID)
	{
		return null;
	}

	[Token(Token = "0x6009283")]
	[Address(RVA = "0x18255A0", Offset = "0x18255A0", VA = "0x18255A0")]
	public List<AvatarAwakenComicData> GetAwakenComicConfigList(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x6009284")]
	[Address(RVA = "0x182597C", Offset = "0x182597C", VA = "0x182597C")]
	public AvatarAwakenTaskRefreshData GetAvatarAwakenTaskRefreshData(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x6009285")]
	[Address(RVA = "0x1825AA8", Offset = "0x1825AA8", VA = "0x1825AA8")]
	public CSSharedAvatarData FindAvatarDataByBundleID(uint bundleID)
	{
		return null;
	}

	[Token(Token = "0x6009286")]
	[Address(RVA = "0x1825BF4", Offset = "0x1825BF4", VA = "0x1825BF4")]
	public bool HasAvatarFacialExpressionData()
	{
		return default(bool);
	}

	[Token(Token = "0x6009287")]
	[Address(RVA = "0x1823FDC", Offset = "0x1823FDC", VA = "0x1823FDC")]
	private void LoadAvatarFacialExpressionData()
	{
	}

	[Token(Token = "0x6009288")]
	[Address(RVA = "0x1825C58", Offset = "0x1825C58", VA = "0x1825C58")]
	private List<AvatarFacialExpressionData> GetAvatarFacialExpressionData(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x6009289")]
	[Address(RVA = "0x1825D3C", Offset = "0x1825D3C", VA = "0x1825D3C")]
	private AvatarFacialExpressionData GetRandomAvatarFacialExpressionData(uint avatarID, UIModelAvatarBase.EWardrobeType type)
	{
		return null;
	}

	[Token(Token = "0x600928A")]
	[Address(RVA = "0x1824350", Offset = "0x1824350", VA = "0x1824350")]
	private void LoadAvatarMatchResultFacialExpressionData()
	{
	}

	[Token(Token = "0x600928B")]
	[Address(RVA = "0x182644C", Offset = "0x182644C", VA = "0x182644C")]
	public AvatarMatchResultFacialExpressionData GetRandomAvatarMatchResultFacialExpressionAnimRes(uint avatarID, bool mvp, uint weapon)
	{
		return null;
	}

	[Token(Token = "0x600928C")]
	[Address(RVA = "0x1826BA8", Offset = "0x1826BA8", VA = "0x1826BA8")]
	private List<AvatarMatchResultFacialExpressionData> GetAvatarMatchResultFacialExpressionData(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x600928D")]
	[Address(RVA = "0x1826C8C", Offset = "0x1826C8C", VA = "0x1826C8C")]
	public bool HasAvatarMatchResultFacialExpressionAnimRes(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x600928E")]
	[Address(RVA = "0x1826D70", Offset = "0x1826D70", VA = "0x1826D70")]
	public ResourceID GetRandomAvatarFacialExpressionAnimRes(uint avatarID, UIModelAvatarBase.EWardrobeType type)
	{
		return default(ResourceID);
	}
}
