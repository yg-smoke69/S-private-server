using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x2000818")]
internal class MobileReplayManager : SingletonModule<MobileReplayManager>
{
	[Token(Token = "0x2000819")]
	private sealed class _003CGetReplayInfoByMatchID_003Ec__AnonStorey0
	{
		[Token(Token = "0x4005101")]
		[FieldOffset(Offset = "0x8")]
		internal ulong matchID;

		[Token(Token = "0x60033AC")]
		[Address(RVA = "0x227EBA4", Offset = "0x227EBA4", VA = "0x227EBA4")]
		public _003CGetReplayInfoByMatchID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60033AD")]
		[Address(RVA = "0x2281070", Offset = "0x2281070", VA = "0x2281070")]
		internal bool _003C_003Em__0(MobileReplayInfo v)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40050E1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string DATA_PATH;

	[Token(Token = "0x40050E2")]
	private const int MS_TO_TICK = 10000;

	[Token(Token = "0x40050E3")]
	private const float S_TO_MS = 1000f;

	[Token(Token = "0x40050E4")]
	[FieldOffset(Offset = "0xC")]
	private BinaryWriter m_ReplayBinaryWriter;

	[Token(Token = "0x40050E5")]
	[FieldOffset(Offset = "0x10")]
	private ReplayData m_ReplayData;

	[Token(Token = "0x40050E6")]
	[FieldOffset(Offset = "0x14")]
	private MobileReplayInfo m_CurReplayInfo;

	[Token(Token = "0x40050E7")]
	[FieldOffset(Offset = "0x18")]
	private long m_GameTotalTimeMS;

	[Token(Token = "0x40050E8")]
	[FieldOffset(Offset = "0x20")]
	private EReplayState m_CurState;

	[Token(Token = "0x40050E9")]
	[FieldOffset(Offset = "0x28")]
	private long m_StartTimeMS;

	[Token(Token = "0x40050EA")]
	[FieldOffset(Offset = "0x30")]
	private string m_MatchDateTime;

	[Token(Token = "0x40050EB")]
	[FieldOffset(Offset = "0x34")]
	private Action m_ReplayJumpCallBack;

	[Token(Token = "0x40050EC")]
	[FieldOffset(Offset = "0x38")]
	private long m_ReplayTimeMS;

	[Token(Token = "0x40050ED")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Started;

	[Token(Token = "0x40050EE")]
	[FieldOffset(Offset = "0x44")]
	private Queue<ReplayData> m_ReplayDataQueue;

	[Token(Token = "0x40050EF")]
	[FieldOffset(Offset = "0x48")]
	private List<MobileReplayInfo> m_ReplayInfos;

	[Token(Token = "0x40050F0")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_IsHighlight;

	[Token(Token = "0x40050F1")]
	[FieldOffset(Offset = "0x4D")]
	private bool m_HasSendAnimEvent;

	[Token(Token = "0x40050F2")]
	private const float DELAY_HIGHLIGHT_START = 1.5f;

	[Token(Token = "0x40050F3")]
	[FieldOffset(Offset = "0x4E")]
	private bool m_HasMatchEnd;

	[Token(Token = "0x40050F4")]
	[FieldOffset(Offset = "0x4F")]
	private bool m_ReplayPaused;

	[Token(Token = "0x40050F5")]
	[FieldOffset(Offset = "0x50")]
	private int m_CurSpeed;

	[Token(Token = "0x40050F6")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsJumping;

	[Token(Token = "0x40050F7")]
	[FieldOffset(Offset = "0x58")]
	private long m_DestTimeMS;

	[Token(Token = "0x40050F8")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<int, float> m_LevelSpeedDic;

	[Token(Token = "0x40050F9")]
	[FieldOffset(Offset = "0x64")]
	private int m_HighlightEventIndex;

	[Token(Token = "0x40050FA")]
	[FieldOffset(Offset = "0x68")]
	private bool m_HasSaved;

	[Token(Token = "0x40050FB")]
	[FieldOffset(Offset = "0x69")]
	private bool m_HasEventLogSend;

	[Token(Token = "0x40050FC")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<uint, float> m_EventTimeDic;

	[Token(Token = "0x40050FD")]
	[FieldOffset(Offset = "0x70")]
	private MobileReplayHighlightEvent m_lastHighlightEvent;

	[Token(Token = "0x40050FE")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<MobileReplayInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40050FF")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<MobileReplayInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4005100")]
	[FieldOffset(Offset = "0xC")]
	private static Predicate<MobileReplayInfo> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x170003C3")]
	public bool IsJumping
	{
		[Token(Token = "0x600338A")]
		[Address(RVA = "0x227F548", Offset = "0x227F548", VA = "0x227F548")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003363")]
	[Address(RVA = "0x22788FC", Offset = "0x22788FC", VA = "0x22788FC")]
	public MobileReplayManager()
	{
	}

	[Token(Token = "0x6003364")]
	[Address(RVA = "0x2278B54", Offset = "0x2278B54", VA = "0x2278B54", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6003365")]
	[Address(RVA = "0x227958C", Offset = "0x227958C", VA = "0x227958C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6003366")]
	[Address(RVA = "0x2279668", Offset = "0x2279668", VA = "0x2279668")]
	public ulong ReplayAuthorID()
	{
		return default(ulong);
	}

	[Token(Token = "0x6003367")]
	[Address(RVA = "0x22796DC", Offset = "0x22796DC", VA = "0x22796DC")]
	public void OnStarted()
	{
	}

	[Token(Token = "0x6003368")]
	[Address(RVA = "0x227A378", Offset = "0x227A378", VA = "0x227A378")]
	public void OnEnded()
	{
	}

	[Token(Token = "0x6003369")]
	[Address(RVA = "0x227ADFC", Offset = "0x227ADFC", VA = "0x227ADFC")]
	private void SetReplayInfo()
	{
	}

	[Token(Token = "0x600336A")]
	[Address(RVA = "0x2279C70", Offset = "0x2279C70", VA = "0x2279C70")]
	private void OnRecordStarted()
	{
	}

	[Token(Token = "0x600336B")]
	[Address(RVA = "0x2278088", Offset = "0x2278088", VA = "0x2278088")]
	public void OnMatchEnd()
	{
	}

	[Token(Token = "0x600336C")]
	[Address(RVA = "0x227A418", Offset = "0x227A418", VA = "0x227A418")]
	public void OnRecordEnded()
	{
	}

	[Token(Token = "0x600336D")]
	[Address(RVA = "0x2277EEC", Offset = "0x2277EEC", VA = "0x2277EEC")]
	public void RecordPackets(Queue<UDPMsgPacket> queue)
	{
	}

	[Token(Token = "0x600336E")]
	[Address(RVA = "0x227BB38", Offset = "0x227BB38", VA = "0x227BB38")]
	public float CurTimeSec()
	{
		return default(float);
	}

	[Token(Token = "0x600336F")]
	[Address(RVA = "0x227B1F4", Offset = "0x227B1F4", VA = "0x227B1F4")]
	private long GetNowTimeMS()
	{
		return default(long);
	}

	[Token(Token = "0x6003370")]
	[Address(RVA = "0x227BBBC", Offset = "0x227BBBC", VA = "0x227BBBC")]
	public void OnLocalShowMatchEnd()
	{
	}

	[Token(Token = "0x6003371")]
	[Address(RVA = "0x227BE18", Offset = "0x227BE18", VA = "0x227BE18")]
	private EMobileReplayErrorCode CheckCanSaveReplay()
	{
		return default(EMobileReplayErrorCode);
	}

	[Token(Token = "0x6003372")]
	[Address(RVA = "0x227B2F8", Offset = "0x227B2F8", VA = "0x227B2F8")]
	private void SaveReplay()
	{
	}

	[Token(Token = "0x6003373")]
	[Address(RVA = "0x227C578", Offset = "0x227C578", VA = "0x227C578")]
	public EMobileReplayErrorCode ManualSaveReplay()
	{
		return default(EMobileReplayErrorCode);
	}

	[Token(Token = "0x6003374")]
	[Address(RVA = "0x227C854", Offset = "0x227C854", VA = "0x227C854")]
	public void ChangeToSaved(MobileReplayInfo info, EChangeToSaveChannel channel)
	{
	}

	[Token(Token = "0x6003375")]
	[Address(RVA = "0x227CC6C", Offset = "0x227CC6C", VA = "0x227CC6C")]
	public void SaveReplayInfos(List<MobileReplayInfo> infos)
	{
	}

	[Token(Token = "0x6003376")]
	[Address(RVA = "0x227C1C4", Offset = "0x227C1C4", VA = "0x227C1C4")]
	private void GetTempReplaySpace()
	{
	}

	[Token(Token = "0x6003377")]
	[Address(RVA = "0x227C0A0", Offset = "0x227C0A0", VA = "0x227C0A0")]
	private void CheckAndSendEventLog(bool success)
	{
	}

	[Token(Token = "0x6003378")]
	[Address(RVA = "0x227C3B0", Offset = "0x227C3B0", VA = "0x227C3B0")]
	private void CheckAndSendHighlightEventLog()
	{
	}

	[Token(Token = "0x6003379")]
	[Address(RVA = "0x227C6D8", Offset = "0x227C6D8", VA = "0x227C6D8")]
	private void SendChangeToSaveEventLog(MobileReplayInfo info, EChangeToSaveChannel channel)
	{
	}

	[Token(Token = "0x600337A")]
	[Address(RVA = "0x227A9CC", Offset = "0x227A9CC", VA = "0x227A9CC")]
	private void SendReplayEndEventLog()
	{
	}

	[Token(Token = "0x600337B")]
	[Address(RVA = "0x227D7EC", Offset = "0x227D7EC", VA = "0x227D7EC")]
	private float GetReplatHighlightTotalTime(MobileReplayInfo info)
	{
		return default(float);
	}

	[Token(Token = "0x600337C")]
	[Address(RVA = "0x227A270", Offset = "0x227A270", VA = "0x227A270")]
	private void OnReplayStarted()
	{
	}

	[Token(Token = "0x600337D")]
	[Address(RVA = "0x227ACA8", Offset = "0x227ACA8", VA = "0x227ACA8")]
	private void OnReplayEnded()
	{
	}

	[Token(Token = "0x600337E")]
	[Address(RVA = "0x2277A34", Offset = "0x2277A34", VA = "0x2277A34")]
	public void GetReplayPackets(Queue<UDPMsgPacket> outPackets)
	{
	}

	[Token(Token = "0x600337F")]
	[Address(RVA = "0x227DFC4", Offset = "0x227DFC4", VA = "0x227DFC4")]
	public ulong GetReplayMatchID()
	{
		return default(ulong);
	}

	[Token(Token = "0x6003380")]
	[Address(RVA = "0x227E038", Offset = "0x227E038", VA = "0x227E038")]
	public long GetReplayMemory()
	{
		return default(long);
	}

	[Token(Token = "0x6003381")]
	[Address(RVA = "0x2278F04", Offset = "0x2278F04", VA = "0x2278F04")]
	private void ReadReplayList()
	{
	}

	[Token(Token = "0x6003382")]
	[Address(RVA = "0x227E808", Offset = "0x227E808", VA = "0x227E808")]
	public List<MobileReplayInfo> GetAllReplayList()
	{
		return null;
	}

	[Token(Token = "0x6003383")]
	[Address(RVA = "0x227E878", Offset = "0x227E878", VA = "0x227E878")]
	public List<MobileReplayInfo> GetSavedReplayList()
	{
		return null;
	}

	[Token(Token = "0x6003384")]
	[Address(RVA = "0x227D250", Offset = "0x227D250", VA = "0x227D250")]
	public List<MobileReplayInfo> GetTempReplayList()
	{
		return null;
	}

	[Token(Token = "0x6003385")]
	[Address(RVA = "0x227EA44", Offset = "0x227EA44", VA = "0x227EA44")]
	public MobileReplayInfo GetReplayInfoByMatchID(ulong matchID)
	{
		return null;
	}

	[Token(Token = "0x6003386")]
	[Address(RVA = "0x227D41C", Offset = "0x227D41C", VA = "0x227D41C")]
	public void DelReplay(MobileReplayInfo info, bool needRefresh = true)
	{
	}

	[Token(Token = "0x6003387")]
	[Address(RVA = "0x227E234", Offset = "0x227E234", VA = "0x227E234")]
	public void CheckAndDeleteOutOfDateReplays()
	{
	}

	[Token(Token = "0x6003388")]
	[Address(RVA = "0x227EBAC", Offset = "0x227EBAC", VA = "0x227EBAC")]
	public void ResetReplay()
	{
	}

	[Token(Token = "0x6003389")]
	[Address(RVA = "0x227EC08", Offset = "0x227EC08", VA = "0x227EC08")]
	public bool StartReplay(MobileReplayInfo info, bool isHighlight = false, bool needReset = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600338B")]
	[Address(RVA = "0x227F5A0", Offset = "0x227F5A0", VA = "0x227F5A0")]
	public void PauseReplay(bool pause)
	{
	}

	[Token(Token = "0x600338C")]
	[Address(RVA = "0x227F6AC", Offset = "0x227F6AC", VA = "0x227F6AC")]
	public void SetPlaySpeed(bool fast)
	{
	}

	[Token(Token = "0x600338D")]
	[Address(RVA = "0x227FB30", Offset = "0x227FB30", VA = "0x227FB30")]
	public void StartHighlight()
	{
	}

	[Token(Token = "0x600338E")]
	[Address(RVA = "0x227FD64", Offset = "0x227FD64", VA = "0x227FD64")]
	public void GoToTimePoint(float value, [Optional] Action callback, bool isHighlight = false)
	{
	}

	[Token(Token = "0x600338F")]
	[Address(RVA = "0x227DA50", Offset = "0x227DA50", VA = "0x227DA50")]
	public void NextHighlight()
	{
	}

	[Token(Token = "0x6003390")]
	[Address(RVA = "0x227FED0", Offset = "0x227FED0", VA = "0x227FED0")]
	public long CurrentGameTimeMS()
	{
		return default(long);
	}

	[Token(Token = "0x6003391")]
	[Address(RVA = "0x227D9DC", Offset = "0x227D9DC", VA = "0x227D9DC")]
	public float CurrentGameTimeS()
	{
		return default(float);
	}

	[Token(Token = "0x6003392")]
	[Address(RVA = "0x227FF28", Offset = "0x227FF28", VA = "0x227FF28")]
	public long GetTotalGameTime()
	{
		return default(long);
	}

	[Token(Token = "0x6003393")]
	[Address(RVA = "0x227FF80", Offset = "0x227FF80", VA = "0x227FF80")]
	public float CurrentProgress()
	{
		return default(float);
	}

	[Token(Token = "0x6003394")]
	[Address(RVA = "0x227FE48", Offset = "0x227FE48", VA = "0x227FE48")]
	public long GetGameTimeMS(float value)
	{
		return default(long);
	}

	[Token(Token = "0x6003395")]
	[Address(RVA = "0x227FCD4", Offset = "0x227FCD4", VA = "0x227FCD4")]
	public float GetTimeRatio(float time)
	{
		return default(float);
	}

	[Token(Token = "0x6003396")]
	[Address(RVA = "0x2280004", Offset = "0x2280004", VA = "0x2280004")]
	public MobileReplayInfo GetCurReplayInfo()
	{
		return null;
	}

	[Token(Token = "0x6003397")]
	[Address(RVA = "0x228005C", Offset = "0x228005C", VA = "0x228005C")]
	public bool IsHighlight()
	{
		return default(bool);
	}

	[Token(Token = "0x6003398")]
	[Address(RVA = "0x22800B4", Offset = "0x22800B4", VA = "0x22800B4")]
	public void SetState(EReplayState state)
	{
	}

	[Token(Token = "0x6003399")]
	[Address(RVA = "0x2277E88", Offset = "0x2277E88", VA = "0x2277E88")]
	public bool IsRecordState()
	{
		return default(bool);
	}

	[Token(Token = "0x600339A")]
	[Address(RVA = "0x22771CC", Offset = "0x22771CC", VA = "0x22771CC")]
	public bool IsReplayState()
	{
		return default(bool);
	}

	[Token(Token = "0x600339B")]
	[Address(RVA = "0x2280114", Offset = "0x2280114", VA = "0x2280114")]
	public void LogReplayEvent(OLDFDLECCBG type)
	{
	}

	[Token(Token = "0x600339C")]
	[Address(RVA = "0x2280350", Offset = "0x2280350", VA = "0x2280350")]
	private void LogNormalReplayEvent(OLDFDLECCBG type)
	{
	}

	[Token(Token = "0x600339D")]
	[Address(RVA = "0x2280628", Offset = "0x2280628", VA = "0x2280628")]
	private void LogHighlightReplayEvent(OLDFDLECCBG type)
	{
	}

	[Token(Token = "0x600339E")]
	[Address(RVA = "0x2280A00", Offset = "0x2280A00", VA = "0x2280A00")]
	public void LogMatchResultData(MatchStats stats, MatchIncome income)
	{
	}

	[Token(Token = "0x600339F")]
	[Address(RVA = "0x2280B98", Offset = "0x2280B98", VA = "0x2280B98")]
	public List<MobileReplayEvent> GetReplayEventList()
	{
		return null;
	}

	[Token(Token = "0x60033A0")]
	[Address(RVA = "0x2279820", Offset = "0x2279820", VA = "0x2279820")]
	public bool IsMobileReplayEnabled(bool lobbySkipModeCheck = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60033A1")]
	[Address(RVA = "0x227BF44", Offset = "0x227BF44", VA = "0x227BF44")]
	private bool HaveEnoughStorage()
	{
		return default(bool);
	}

	[Token(Token = "0x60033A2")]
	[Address(RVA = "0x2278C84", Offset = "0x2278C84", VA = "0x2278C84")]
	private bool CheckAndCreateDirectory()
	{
		return default(bool);
	}

	[Token(Token = "0x60033A3")]
	[Address(RVA = "0x228096C", Offset = "0x228096C", VA = "0x228096C")]
	public string GetReplayhightKey(uint gamemode, uint type)
	{
		return null;
	}

	[Token(Token = "0x60033A4")]
	[Address(RVA = "0x227D6D4", Offset = "0x227D6D4", VA = "0x227D6D4")]
	public bool HasReplayHighLight(MobileReplayInfo mobileReplayInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x60033A5")]
	[Address(RVA = "0x2280C08", Offset = "0x2280C08", VA = "0x2280C08")]
	public bool IsOverLookMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60033A6")]
	[Address(RVA = "0x2280D0C", Offset = "0x2280D0C", VA = "0x2280D0C")]
	public EHighlightMemoryLevel GetHightLightMemoryLevel()
	{
		return default(EHighlightMemoryLevel);
	}

	[Token(Token = "0x60033A7")]
	[Address(RVA = "0x2280E60", Offset = "0x2280E60", VA = "0x2280E60")]
	public bool IsHightlightStartDelayLong()
	{
		return default(bool);
	}

	[Token(Token = "0x60033A9")]
	[Address(RVA = "0x2280FC0", Offset = "0x2280FC0", VA = "0x2280FC0")]
	private static int _003CReadReplayList_003Em__0(MobileReplayInfo x, MobileReplayInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x60033AA")]
	[Address(RVA = "0x228101C", Offset = "0x228101C", VA = "0x228101C")]
	private static bool _003CGetSavedReplayList_003Em__1(MobileReplayInfo v)
	{
		return default(bool);
	}

	[Token(Token = "0x60033AB")]
	[Address(RVA = "0x2281040", Offset = "0x2281040", VA = "0x2281040")]
	private static bool _003CGetTempReplayList_003Em__2(MobileReplayInfo v)
	{
		return default(bool);
	}
}
