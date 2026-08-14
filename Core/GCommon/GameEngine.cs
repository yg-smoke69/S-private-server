using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GCommon;

[Token(Token = "0x2003EC2")]
internal class GameEngine : MonoBehaviour
{
	[Token(Token = "0x2003EC3")]
	private sealed class _003CCleanAssets_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401A80F")]
		[FieldOffset(Offset = "0x8")]
		internal bool shouldCleanPreloadResources;

		[Token(Token = "0x401A810")]
		[FieldOffset(Offset = "0xC")]
		internal AsyncOperation _003CcleanupState_003E__0;

		[Token(Token = "0x401A811")]
		[FieldOffset(Offset = "0x10")]
		internal bool _003CbCanDisableIngameGC_003E__0;

		[Token(Token = "0x401A812")]
		[FieldOffset(Offset = "0x11")]
		internal bool _003CbDisableIngameGCSwitch_003E__0;

		[Token(Token = "0x401A813")]
		[FieldOffset(Offset = "0x14")]
		internal int _003CgcCount_003E__0;

		[Token(Token = "0x401A814")]
		[FieldOffset(Offset = "0x18")]
		internal GameEngine _0024this;

		[Token(Token = "0x401A815")]
		[FieldOffset(Offset = "0x1C")]
		internal object _0024current;

		[Token(Token = "0x401A816")]
		[FieldOffset(Offset = "0x20")]
		internal bool _0024disposing;

		[Token(Token = "0x401A817")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x17001BE5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60198CF")]
			[Address(RVA = "0x32B2854", Offset = "0x32B2854", VA = "0x32B2854", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BE6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60198D0")]
			[Address(RVA = "0x32B285C", Offset = "0x32B285C", VA = "0x32B285C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60198CD")]
		[Address(RVA = "0x32B2178", Offset = "0x32B2178", VA = "0x32B2178")]
		public _003CCleanAssets_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60198CE")]
		[Address(RVA = "0x32B2228", Offset = "0x32B2228", VA = "0x32B2228", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60198D1")]
		[Address(RVA = "0x32B2864", Offset = "0x32B2864", VA = "0x32B2864", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60198D2")]
		[Address(RVA = "0x32B2878", Offset = "0x32B2878", VA = "0x32B2878", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003EC4")]
	private sealed class _003CLoadLoadingScene_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401A818")]
		[FieldOffset(Offset = "0x8")]
		internal AsyncOperation _003CsceneLoadState_003E__0;

		[Token(Token = "0x401A819")]
		[FieldOffset(Offset = "0xC")]
		internal GameEngine _0024this;

		[Token(Token = "0x401A81A")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x401A81B")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x401A81C")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17001BE7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60198D5")]
			[Address(RVA = "0x32B41BC", Offset = "0x32B41BC", VA = "0x32B41BC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BE8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60198D6")]
			[Address(RVA = "0x32B41C4", Offset = "0x32B41C4", VA = "0x32B41C4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60198D3")]
		[Address(RVA = "0x32B2180", Offset = "0x32B2180", VA = "0x32B2180")]
		public _003CLoadLoadingScene_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x60198D4")]
		[Address(RVA = "0x32B3A74", Offset = "0x32B3A74", VA = "0x32B3A74", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60198D7")]
		[Address(RVA = "0x32B41CC", Offset = "0x32B41CC", VA = "0x32B41CC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60198D8")]
		[Address(RVA = "0x32B41E0", Offset = "0x32B41E0", VA = "0x32B41E0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003EC5")]
	private sealed class _003CLoadPreloadResource_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401A81D")]
		[FieldOffset(Offset = "0x8")]
		internal BaseGame game;

		[Token(Token = "0x401A81E")]
		[FieldOffset(Offset = "0xC")]
		internal float _003Ctime_003E__0;

		[Token(Token = "0x401A81F")]
		[FieldOffset(Offset = "0x10")]
		internal ResourceID[] _003CpreloadedResource_003E__0;

		[Token(Token = "0x401A820")]
		[FieldOffset(Offset = "0x14")]
		internal ResourceID[] _003Caudio_preloadedResource_003E__0;

		[Token(Token = "0x401A821")]
		[FieldOffset(Offset = "0x18")]
		internal int _003Cpreload_count_003E__0;

		[Token(Token = "0x401A822")]
		[FieldOffset(Offset = "0x1C")]
		internal int _003CloadedCount_003E__0;

		[Token(Token = "0x401A823")]
		[FieldOffset(Offset = "0x20")]
		internal uint _003CcntPerFrame_003E__1;

		[Token(Token = "0x401A824")]
		[FieldOffset(Offset = "0x24")]
		internal ResourceID[] _0024locvar0;

		[Token(Token = "0x401A825")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024locvar1;

		[Token(Token = "0x401A826")]
		[FieldOffset(Offset = "0x2C")]
		internal ResourceID _003CresID_003E__2;

		[Token(Token = "0x401A827")]
		[FieldOffset(Offset = "0x30")]
		internal bool _003CloadOk_003E__3;

		[Token(Token = "0x401A828")]
		[FieldOffset(Offset = "0x34")]
		internal AudioEngine_Wwise _003Cwwise_engine_003E__4;

		[Token(Token = "0x401A829")]
		[FieldOffset(Offset = "0x38")]
		internal bool _003Cused_wwise_sound_003E__4;

		[Token(Token = "0x401A82A")]
		[FieldOffset(Offset = "0x3C")]
		internal ResourceID[] _0024locvar2;

		[Token(Token = "0x401A82B")]
		[FieldOffset(Offset = "0x40")]
		internal int _0024locvar3;

		[Token(Token = "0x401A82C")]
		[FieldOffset(Offset = "0x44")]
		internal ResourceID _003CresID_003E__5;

		[Token(Token = "0x401A82D")]
		[FieldOffset(Offset = "0x48")]
		internal EAudioEngineType _003Caudio_engine_type_003E__6;

		[Token(Token = "0x401A82E")]
		[FieldOffset(Offset = "0x4C")]
		internal ResourceID _003Cconverted_id_003E__6;

		[Token(Token = "0x401A82F")]
		[FieldOffset(Offset = "0x50")]
		internal bool _003CloadOk_003E__6;

		[Token(Token = "0x401A830")]
		[FieldOffset(Offset = "0x54")]
		internal IEnumerator _003Cenumrator_003E__0;

		[Token(Token = "0x401A831")]
		[FieldOffset(Offset = "0x58")]
		internal GameEngine _0024this;

		[Token(Token = "0x401A832")]
		[FieldOffset(Offset = "0x5C")]
		internal object _0024current;

		[Token(Token = "0x401A833")]
		[FieldOffset(Offset = "0x60")]
		internal bool _0024disposing;

		[Token(Token = "0x401A834")]
		[FieldOffset(Offset = "0x64")]
		internal int _0024PC;

		[Token(Token = "0x17001BE9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60198DB")]
			[Address(RVA = "0x32B4B60", Offset = "0x32B4B60", VA = "0x32B4B60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BEA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60198DC")]
			[Address(RVA = "0x32B4B68", Offset = "0x32B4B68", VA = "0x32B4B68", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60198D9")]
		[Address(RVA = "0x32B2188", Offset = "0x32B2188", VA = "0x32B2188")]
		public _003CLoadPreloadResource_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x60198DA")]
		[Address(RVA = "0x32B4268", Offset = "0x32B4268", VA = "0x32B4268", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60198DD")]
		[Address(RVA = "0x32B4B70", Offset = "0x32B4B70", VA = "0x32B4B70", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60198DE")]
		[Address(RVA = "0x32B4B84", Offset = "0x32B4B84", VA = "0x32B4B84", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2003EC6")]
	private sealed class _003CLoadGameProcess_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401A835")]
		[FieldOffset(Offset = "0x8")]
		internal BaseGame game;

		[Token(Token = "0x401A836")]
		[FieldOffset(Offset = "0xC")]
		internal ResourceID[] _003CsceneList_003E__0;

		[Token(Token = "0x401A837")]
		[FieldOffset(Offset = "0x10")]
		internal string _003CsceneAbPath_003E__0;

		[Token(Token = "0x401A838")]
		[FieldOffset(Offset = "0x14")]
		internal string _003CsceneStreamAbPath_003E__0;

		[Token(Token = "0x401A839")]
		[FieldOffset(Offset = "0x18")]
		internal AssetBundle _003CsceneAB_003E__0;

		[Token(Token = "0x401A83A")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _003CuseAb_003E__0;

		[Token(Token = "0x401A83B")]
		[FieldOffset(Offset = "0x20")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x401A83C")]
		[FieldOffset(Offset = "0x24")]
		internal LoadSceneMode _003Cmode_003E__2;

		[Token(Token = "0x401A83D")]
		[FieldOffset(Offset = "0x28")]
		internal AsyncOperation _003CsceneLoadState_003E__2;

		[Token(Token = "0x401A83E")]
		[FieldOffset(Offset = "0x2C")]
		internal GameEngine _0024this;

		[Token(Token = "0x401A83F")]
		[FieldOffset(Offset = "0x30")]
		internal object _0024current;

		[Token(Token = "0x401A840")]
		[FieldOffset(Offset = "0x34")]
		internal bool _0024disposing;

		[Token(Token = "0x401A841")]
		[FieldOffset(Offset = "0x38")]
		internal int _0024PC;

		[Token(Token = "0x17001BEB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60198E1")]
			[Address(RVA = "0x32B39C8", Offset = "0x32B39C8", VA = "0x32B39C8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BEC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60198E2")]
			[Address(RVA = "0x32B39D0", Offset = "0x32B39D0", VA = "0x32B39D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60198DF")]
		[Address(RVA = "0x32B2190", Offset = "0x32B2190", VA = "0x32B2190")]
		public _003CLoadGameProcess_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x60198E0")]
		[Address(RVA = "0x32B2900", Offset = "0x32B2900", VA = "0x32B2900", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60198E3")]
		[Address(RVA = "0x32B39D8", Offset = "0x32B39D8", VA = "0x32B39D8", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60198E4")]
		[Address(RVA = "0x32B39EC", Offset = "0x32B39EC", VA = "0x32B39EC", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401A7FE")]
	[FieldOffset(Offset = "0x0")]
	public static GameEngine instance;

	[Token(Token = "0x401A7FF")]
	[FieldOffset(Offset = "0x4")]
	public static ObjectPool<TimerAction> GlobalTimerActionPool;

	[Token(Token = "0x401A800")]
	[FieldOffset(Offset = "0xC")]
	private BaseGame m_CurrentGame;

	[Token(Token = "0x401A801")]
	[FieldOffset(Offset = "0x10")]
	private TimeService m_EngineTimer;

	[Token(Token = "0x401A802")]
	[FieldOffset(Offset = "0x14")]
	private ResourceID m_LoadingSceneResourceID;

	[Token(Token = "0x401A803")]
	[FieldOffset(Offset = "0x18")]
	private Type m_PendingGameType;

	[Token(Token = "0x401A804")]
	[FieldOffset(Offset = "0x1C")]
	private BaseGameContext m_PendingGameContext;

	[Token(Token = "0x401A805")]
	[FieldOffset(Offset = "0x20")]
	private float m_LoadingPreloadedResourceProgress;

	[Token(Token = "0x401A806")]
	[FieldOffset(Offset = "0x24")]
	private bool m_LoadingInProcess;

	[Token(Token = "0x401A807")]
	[FieldOffset(Offset = "0x25")]
	private bool m_UseAdditiveLoading;

	[Token(Token = "0x401A808")]
	[FieldOffset(Offset = "0x28")]
	private Action m_OnLoadAndRunFinished;

	[Token(Token = "0x401A809")]
	[FieldOffset(Offset = "0x2C")]
	private UniqueIDGenerator m_UniqueIDGen;

	[Token(Token = "0x401A80A")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, TimerAction> m_TimerActions;

	[Token(Token = "0x401A80B")]
	[FieldOffset(Offset = "0x34")]
	private List<uint> m_ExpiredTimerActions;

	[Token(Token = "0x401A80C")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, Action> m_TimerActionsToBeCalled;

	[Token(Token = "0x401A80D")]
	[FieldOffset(Offset = "0x8")]
	public static Action<string, string> BugReportSetKeyValue;

	[Token(Token = "0x401A80E")]
	[FieldOffset(Offset = "0x3C")]
	private float m_LoadingPendingGameProgress;

	[Token(Token = "0x17001BE1")]
	public float LoadingPreloadedResourceProgress
	{
		[Token(Token = "0x60198B7")]
		[Address(RVA = "0x32AFF5C", Offset = "0x32AFF5C", VA = "0x32AFF5C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001BE2")]
	public float LoadingPendingGameProgress
	{
		[Token(Token = "0x60198B8")]
		[Address(RVA = "0x32AFF64", Offset = "0x32AFF64", VA = "0x32AFF64")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001BE3")]
	public TimeService EngineTimer
	{
		[Token(Token = "0x60198B9")]
		[Address(RVA = "0x32AFF6C", Offset = "0x32AFF6C", VA = "0x32AFF6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BE4")]
	public Type PendingGameType
	{
		[Token(Token = "0x60198BA")]
		[Address(RVA = "0x32AFF74", Offset = "0x32AFF74", VA = "0x32AFF74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60198B6")]
	[Address(RVA = "0x32AFDFC", Offset = "0x32AFDFC", VA = "0x32AFDFC")]
	public GameEngine()
	{
	}

	[Token(Token = "0x60198BB")]
	[Address(RVA = "0x32AFF7C", Offset = "0x32AFF7C", VA = "0x32AFF7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60198BC")]
	[Address(RVA = "0x32B004C", Offset = "0x32B004C", VA = "0x32B004C")]
	public BaseGame GetCurrentGame()
	{
		return null;
	}

	[Token(Token = "0x60198BD")]
	[Address(RVA = "0x32B0054", Offset = "0x32B0054", VA = "0x32B0054")]
	public void SetLoadingSceneResourceID(ResourceID id)
	{
	}

	[Token(Token = "0x60198BE")]
	[Address(RVA = "0x32B005C", Offset = "0x32B005C", VA = "0x32B005C")]
	public uint DelayCall(float delayTime, Action action, bool isRepeated = false)
	{
		return default(uint);
	}

	[Token(Token = "0x60198BF")]
	[Address(RVA = "0x32B0214", Offset = "0x32B0214", VA = "0x32B0214")]
	public void CancelDelayCall(uint id)
	{
	}

	[Token(Token = "0x60198C0")]
	[Address(RVA = "0x32B0354", Offset = "0x32B0354", VA = "0x32B0354")]
	public void RunOneFrame()
	{
	}

	[Token(Token = "0x60198C1")]
	[Address(RVA = "0x32B16AC", Offset = "0x32B16AC", VA = "0x32B16AC")]
	public void FixedRunOneFrame()
	{
	}

	[Token(Token = "0x60198C2")]
	[Address(RVA = "0x32B16C0", Offset = "0x32B16C0", VA = "0x32B16C0")]
	public float GetEngineTime()
	{
		return default(float);
	}

	[Token(Token = "0x60198C3")]
	[Address(RVA = "0x32B16EC", Offset = "0x32B16EC", VA = "0x32B16EC")]
	public bool LoadAndRun(Type gameType, [Optional] BaseGameContext sharedData, bool useAdditiveLoading = false, [Optional] Action OnFinished)
	{
		return default(bool);
	}

	[Token(Token = "0x60198C4")]
	[Address(RVA = "0x32B1C90", Offset = "0x32B1C90", VA = "0x32B1C90")]
	private void AfterCleanAssets()
	{
	}

	[Token(Token = "0x60198C5")]
	[Address(RVA = "0x32B1DE8", Offset = "0x32B1DE8", VA = "0x32B1DE8")]
	public void LoadPendingGame()
	{
	}

	[Token(Token = "0x60198C6")]
	[Address(RVA = "0x32B20A4", Offset = "0x32B20A4", VA = "0x32B20A4")]
	public void LoadPreloadResource()
	{
	}

	[Token(Token = "0x60198C7")]
	public void LoadAndRun<T>([Optional] BaseGameContext sharedData, bool useAdditiveLoading = false, [Optional] Action onFinished) where T : BaseGame, new()
	{
	}

	[Token(Token = "0x60198C8")]
	[Address(RVA = "0x32B1BF0", Offset = "0x32B1BF0", VA = "0x32B1BF0")]
	private IEnumerator CleanAssets(bool shouldCleanPreloadResources)
	{
		return null;
	}

	[Token(Token = "0x60198C9")]
	[Address(RVA = "0x32B1D64", Offset = "0x32B1D64", VA = "0x32B1D64")]
	private IEnumerator LoadLoadingScene()
	{
		return null;
	}

	[Token(Token = "0x60198CA")]
	[Address(RVA = "0x32B20D8", Offset = "0x32B20D8", VA = "0x32B20D8")]
	private IEnumerator LoadPreloadResource(BaseGame game)
	{
		return null;
	}

	[Token(Token = "0x60198CB")]
	[Address(RVA = "0x32B2004", Offset = "0x32B2004", VA = "0x32B2004")]
	private IEnumerator LoadGameProcess(BaseGame game)
	{
		return null;
	}
}
