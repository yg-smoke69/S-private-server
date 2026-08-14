using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031A1")]
public class UIModelNewPlayerUpGrades : UIBaseModel
{
	[Token(Token = "0x4012DD1")]
	[FieldOffset(Offset = "0xC")]
	public bool hasMentor;

	[Token(Token = "0x4012DD2")]
	public const uint PropID_NewPlayerCliamRewardLisUpdate = 2u;

	[Token(Token = "0x4012DD3")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, NewPlayerTargetChaInfo> m_NewPlayerTargetChaDic;

	[Token(Token = "0x4012DD4")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, NewPlayerTargetMatchGameInfo> m_NewPlayerTargetMatchGameDic;

	[Token(Token = "0x4012DD5")]
	[FieldOffset(Offset = "0x18")]
	private List<NewPlayerTargetTrainingCampInfo> m_NewPlayerTargetTrainCampList;

	[Token(Token = "0x4012DD6")]
	[FieldOffset(Offset = "0x1C")]
	private uint[] m_ChaBaseLevelArr;

	[Token(Token = "0x4012DD7")]
	[FieldOffset(Offset = "0x20")]
	private uint[] m_MatchGameBaseLevelArr;

	[Token(Token = "0x4012DD8")]
	[FieldOffset(Offset = "0x24")]
	private NewPlayerTargetMatchGameInfo[] matchGameInfoArrays;

	[Token(Token = "0x4012DD9")]
	[FieldOffset(Offset = "0x28")]
	private UIModelProfile m_ModelProfile;

	[Token(Token = "0x4012DDA")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	[Token(Token = "0x4012DDB")]
	[FieldOffset(Offset = "0x30")]
	private bool m_RankGameTypeToGuideAfterRankedFlg;

	[Token(Token = "0x4012DDC")]
	[FieldOffset(Offset = "0x34")]
	public uint maxBaseChaLevel;

	[Token(Token = "0x4012DDD")]
	[FieldOffset(Offset = "0x38")]
	private int RankModePreferenceCount;

	[Token(Token = "0x4012DDE")]
	[FieldOffset(Offset = "0x3C")]
	private float ModePreference;

	[Token(Token = "0x4012DDF")]
	[FieldOffset(Offset = "0x40")]
	public int unbindShowLevel;

	[Token(Token = "0x4012DE0")]
	[FieldOffset(Offset = "0x44")]
	public int bindShowLevel;

	[Token(Token = "0x170015F7")]
	public Dictionary<uint, NewPlayerTargetChaInfo> NewPlayerTargetChaDic
	{
		[Token(Token = "0x6014DAB")]
		[Address(RVA = "0x178288C", Offset = "0x178288C", VA = "0x178288C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F8")]
	public Dictionary<uint, NewPlayerTargetMatchGameInfo> NewPlayerTargetMatchGameDic
	{
		[Token(Token = "0x6014DAC")]
		[Address(RVA = "0x17828E4", Offset = "0x17828E4", VA = "0x17828E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015F9")]
	public List<NewPlayerTargetTrainingCampInfo> NewPlayerTargetTrainCampList
	{
		[Token(Token = "0x6014DAD")]
		[Address(RVA = "0x178293C", Offset = "0x178293C", VA = "0x178293C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6014DAA")]
	[Address(RVA = "0x1782590", Offset = "0x1782590", VA = "0x1782590")]
	public UIModelNewPlayerUpGrades()
	{
	}

	[Token(Token = "0x6014DAE")]
	[Address(RVA = "0x1782994", Offset = "0x1782994", VA = "0x1782994", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014DAF")]
	[Address(RVA = "0x17829EC", Offset = "0x17829EC", VA = "0x17829EC", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014DB0")]
	[Address(RVA = "0x1782B1C", Offset = "0x1782B1C", VA = "0x1782B1C")]
	public void InitBRAndCSData()
	{
	}

	[Token(Token = "0x6014DB1")]
	[Address(RVA = "0x1782DE0", Offset = "0x1782DE0", VA = "0x1782DE0")]
	public bool CheckSpecGotoGuide(ENewbieGuideType guideType)
	{
		return default(bool);
	}

	[Token(Token = "0x6014DB2")]
	[Address(RVA = "0x1782E68", Offset = "0x1782E68", VA = "0x1782E68")]
	private NewPlayerTargetMatchGameInfo GetMatchGameInfo()
	{
		return null;
	}

	[Token(Token = "0x6014DB3")]
	[Address(RVA = "0x178308C", Offset = "0x178308C", VA = "0x178308C")]
	public void CheckGoToMatchState(object[] args)
	{
	}

	[Token(Token = "0x6014DB4")]
	[Address(RVA = "0x17845DC", Offset = "0x17845DC", VA = "0x17845DC")]
	public void MatchGameGuide()
	{
	}

	[Token(Token = "0x6014DB5")]
	[Address(RVA = "0x17833D4", Offset = "0x17833D4", VA = "0x17833D4")]
	private void TrainIslandCase(uint matchTrainState, uint maxLevel)
	{
	}

	[Token(Token = "0x6014DB6")]
	[Address(RVA = "0x1783A58", Offset = "0x1783A58", VA = "0x1783A58")]
	private void RankGameCase(uint matchRankState, uint maxLevel, RankState rankState)
	{
	}

	[Token(Token = "0x6014DB7")]
	[Address(RVA = "0x1784910", Offset = "0x1784910", VA = "0x1784910")]
	public ENewbieGuideType RankGameTypeToGuide()
	{
		return default(ENewbieGuideType);
	}

	[Token(Token = "0x6014DB8")]
	[Address(RVA = "0x1784CFC", Offset = "0x1784CFC", VA = "0x1784CFC")]
	private ENewbieGuideType RankGameTypeToGuideBeforeRanked()
	{
		return default(ENewbieGuideType);
	}

	[Token(Token = "0x6014DB9")]
	[Address(RVA = "0x1784C74", Offset = "0x1784C74", VA = "0x1784C74")]
	private ENewbieGuideType RankGameTypeToGuideAfterRanked(uint brTimes, uint csTimes)
	{
		return default(ENewbieGuideType);
	}

	[Token(Token = "0x6014DBA")]
	[Address(RVA = "0x178504C", Offset = "0x178504C", VA = "0x178504C")]
	private ENewbieGuideType BRorCSGame(uint brTimes, uint csTimes)
	{
		return default(ENewbieGuideType);
	}

	[Token(Token = "0x6014DBB")]
	[Address(RVA = "0x1783894", Offset = "0x1783894", VA = "0x1783894")]
	public void MentorGuide()
	{
	}

	[Token(Token = "0x6014DBC")]
	[Address(RVA = "0x1785130", Offset = "0x1785130", VA = "0x1785130")]
	public void GetUpGradesInfos()
	{
	}

	[Token(Token = "0x6014DBD")]
	[Address(RVA = "0x1785528", Offset = "0x1785528", VA = "0x1785528")]
	private void GetCharacterInfos(NewPlayerTargetData data, bool lastItem)
	{
	}

	[Token(Token = "0x6014DBE")]
	[Address(RVA = "0x17856AC", Offset = "0x17856AC", VA = "0x17856AC")]
	private void GetMatchGameInfos(NewPlayerTargetData data, int index)
	{
	}

	[Token(Token = "0x6014DBF")]
	[Address(RVA = "0x1785890", Offset = "0x1785890", VA = "0x1785890")]
	private void SetMatchGameInfos()
	{
	}

	[Token(Token = "0x6014DC0")]
	[Address(RVA = "0x17857B4", Offset = "0x17857B4", VA = "0x17857B4")]
	private void GetTrainingCampInfos(NewPlayerTargetData data)
	{
	}

	[Token(Token = "0x6014DC1")]
	[Address(RVA = "0x1785CA8", Offset = "0x1785CA8", VA = "0x1785CA8")]
	public uint GetCurChaBaseKey(uint userLevel)
	{
		return default(uint);
	}

	[Token(Token = "0x6014DC2")]
	[Address(RVA = "0x178301C", Offset = "0x178301C", VA = "0x178301C")]
	public uint GetCurMatchGameBaseKey(uint userLevel)
	{
		return default(uint);
	}

	[Token(Token = "0x6014DC3")]
	[Address(RVA = "0x1785D18", Offset = "0x1785D18", VA = "0x1785D18")]
	private uint BinarySearchBaseKey(uint userLevel, uint[] levelList)
	{
		return default(uint);
	}

	[Token(Token = "0x6014DC4")]
	[Address(RVA = "0x1784814", Offset = "0x1784814", VA = "0x1784814")]
	public bool IsUserGuest()
	{
		return default(bool);
	}

	[Token(Token = "0x6014DC5")]
	[Address(RVA = "0x1785E28", Offset = "0x1785E28", VA = "0x1785E28", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6014DC6")]
	[Address(RVA = "0x1785F58", Offset = "0x1785F58", VA = "0x1785F58")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	[Token(Token = "0x6014DC7")]
	[Address(RVA = "0x1785F60", Offset = "0x1785F60", VA = "0x1785F60")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}
}
