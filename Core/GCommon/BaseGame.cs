using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EBF")]
public abstract class BaseGame
{
	[Token(Token = "0x2003EC0")]
	private sealed class _003COnPreprocessFinished_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401A7F9")]
		[FieldOffset(Offset = "0x8")]
		internal object _0024current;

		[Token(Token = "0x401A7FA")]
		[FieldOffset(Offset = "0xC")]
		internal bool _0024disposing;

		[Token(Token = "0x401A7FB")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x17001BDE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60198AB")]
			[Address(RVA = "0x307CC00", Offset = "0x307CC00", VA = "0x307CC00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BDF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60198AC")]
			[Address(RVA = "0x307CC08", Offset = "0x307CC08", VA = "0x307CC08", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60198A9")]
		[Address(RVA = "0x307C8C0", Offset = "0x307C8C0", VA = "0x307C8C0")]
		public _003COnPreprocessFinished_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60198AA")]
		[Address(RVA = "0x307CBA0", Offset = "0x307CBA0", VA = "0x307CBA0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60198AD")]
		[Address(RVA = "0x307CC10", Offset = "0x307CC10", VA = "0x307CC10", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60198AE")]
		[Address(RVA = "0x307CC24", Offset = "0x307CC24", VA = "0x307CC24", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401A7E7")]
	[FieldOffset(Offset = "0x0")]
	internal static Dictionary<uint, IEntityTicker> sTickedEntities;

	[Token(Token = "0x401A7E8")]
	[FieldOffset(Offset = "0x4")]
	internal static Dictionary<uint, Entity> sAllEntities;

	[Token(Token = "0x401A7E9")]
	[FieldOffset(Offset = "0x8")]
	protected UIBaseScene m_UIScene;

	[Token(Token = "0x401A7EA")]
	[FieldOffset(Offset = "0xC")]
	protected TimeService m_GameTimer;

	[Token(Token = "0x401A7EB")]
	[FieldOffset(Offset = "0x10")]
	protected TimeService m_SimulationTimer;

	[Token(Token = "0x401A7EC")]
	[FieldOffset(Offset = "0x14")]
	protected EventDispatcher m_GameEventDispatcher;

	[Token(Token = "0x401A7ED")]
	[FieldOffset(Offset = "0x18")]
	protected BaseGameContext m_GameContext;

	[Token(Token = "0x401A7EE")]
	[FieldOffset(Offset = "0x1C")]
	protected LoadingProcessManager m_LoadingProcessManager;

	[Token(Token = "0x401A7EF")]
	[FieldOffset(Offset = "0x20")]
	protected UniqueIDGenerator m_UniqueIDGen;

	[Token(Token = "0x401A7F0")]
	[FieldOffset(Offset = "0x24")]
	protected Dictionary<uint, TimerAction> m_TimerActions;

	[Token(Token = "0x401A7F1")]
	[FieldOffset(Offset = "0x28")]
	protected List<uint> m_ExpiredTimerActions;

	[Token(Token = "0x401A7F2")]
	[FieldOffset(Offset = "0x2C")]
	protected Dictionary<uint, Action> m_TimerActionsToBeCalled;

	[Token(Token = "0x401A7F3")]
	[FieldOffset(Offset = "0x30")]
	protected ConditionActionManager m_conditionActionManager;

	[Token(Token = "0x401A7F4")]
	[FieldOffset(Offset = "0x34")]
	private bool m_HasInited;

	[Token(Token = "0x401A7F5")]
	[FieldOffset(Offset = "0x35")]
	private bool m_HasLoadingFailed;

	[Token(Token = "0x401A7F6")]
	[FieldOffset(Offset = "0x36")]
	private bool m_HasFixedUpdated;

	[Token(Token = "0x401A7F7")]
	[FieldOffset(Offset = "0x37")]
	private bool m_SceneLoaded;

	[Token(Token = "0x401A7F8")]
	[FieldOffset(Offset = "0x38")]
	protected bool m_IsPaused;

	[Token(Token = "0x17001BD9")]
	public UIBaseScene UIScene
	{
		[Token(Token = "0x6019867")]
		[Address(RVA = "0x307A604", Offset = "0x307A604", VA = "0x307A604")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDA")]
	public TimeService GameTimer
	{
		[Token(Token = "0x6019868")]
		[Address(RVA = "0x307A60C", Offset = "0x307A60C", VA = "0x307A60C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDB")]
	public TimeService SimulationTimer
	{
		[Token(Token = "0x6019869")]
		[Address(RVA = "0x307A614", Offset = "0x307A614", VA = "0x307A614")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDC")]
	public EventDispatcher GameEventDispatcher
	{
		[Token(Token = "0x601986A")]
		[Address(RVA = "0x307A61C", Offset = "0x307A61C", VA = "0x307A61C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDD")]
	public BaseGameContext GameContext
	{
		[Token(Token = "0x601986B")]
		[Address(RVA = "0x307A624", Offset = "0x307A624", VA = "0x307A624")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019863")]
	[Address(RVA = "0x307A00C", Offset = "0x307A00C", VA = "0x307A00C")]
	protected BaseGame()
	{
	}

	[Token(Token = "0x6019864")]
	[Address(RVA = "0x307A014", Offset = "0x307A014", VA = "0x307A014")]
	internal static void RegisterEntity(Entity entity)
	{
	}

	[Token(Token = "0x6019865")]
	[Address(RVA = "0x307A294", Offset = "0x307A294", VA = "0x307A294")]
	internal static void UnregisterEntity(Entity entity)
	{
	}

	[Token(Token = "0x6019866")]
	[Address(RVA = "0x307A530", Offset = "0x307A530", VA = "0x307A530")]
	public Entity GetEntityByUniqueID(uint id)
	{
		return null;
	}

	[Token(Token = "0x601986C")]
	[Address(RVA = "0x307A62C", Offset = "0x307A62C", VA = "0x307A62C")]
	public void Init([Optional] BaseGameContext gameContext)
	{
	}

	[Token(Token = "0x601986D")]
	[Address(RVA = "0x307AB00", Offset = "0x307AB00", VA = "0x307AB00")]
	public void SceneLoaded()
	{
	}

	[Token(Token = "0x601986E")]
	[Address(RVA = "0x307AB10", Offset = "0x307AB10", VA = "0x307AB10")]
	private void InitSceneIfNeed()
	{
	}

	[Token(Token = "0x601986F")]
	[Address(RVA = "0x307AB5C", Offset = "0x307AB5C", VA = "0x307AB5C")]
	public void SceneStart()
	{
	}

	[Token(Token = "0x6019870")]
	[Address(RVA = "0x307AB60", Offset = "0x307AB60", VA = "0x307AB60")]
	public void PreloadLoaded()
	{
	}

	[Token(Token = "0x6019871")]
	[Address(RVA = "0x307AB70", Offset = "0x307AB70", VA = "0x307AB70", Slot = "4")]
	public virtual uint GetPreloadCountPerFrame()
	{
		return default(uint);
	}

	[Token(Token = "0x6019872")]
	[Address(RVA = "0x307AB78", Offset = "0x307AB78", VA = "0x307AB78")]
	public void RunOneFrame()
	{
	}

	[Token(Token = "0x6019873")]
	[Address(RVA = "0x307B8EC", Offset = "0x307B8EC", VA = "0x307B8EC")]
	public void FixedRunOneFrame()
	{
	}

	[Token(Token = "0x6019874")]
	[Address(RVA = "0x307BCA4", Offset = "0x307BCA4", VA = "0x307BCA4")]
	public void UnInit()
	{
	}

	[Token(Token = "0x6019875")]
	[Address(RVA = "0x307C014", Offset = "0x307C014", VA = "0x307C014")]
	public uint DelayCall(float delayTime, Action action, bool isRepeated = false)
	{
		return default(uint);
	}

	[Token(Token = "0x6019876")]
	[Address(RVA = "0x307C220", Offset = "0x307C220", VA = "0x307C220")]
	public void ChangeDelayCallTime(uint id, float deltaTime)
	{
	}

	[Token(Token = "0x6019877")]
	[Address(RVA = "0x307C2EC", Offset = "0x307C2EC", VA = "0x307C2EC")]
	public uint CancelAndDelayCall(uint id, float delayTime, Action action, bool isRepeated = false)
	{
		return default(uint);
	}

	[Token(Token = "0x6019878")]
	[Address(RVA = "0x307C330", Offset = "0x307C330", VA = "0x307C330")]
	public void CancelDelayCall(uint id)
	{
	}

	[Token(Token = "0x6019879")]
	[Address(RVA = "0x307C478", Offset = "0x307C478", VA = "0x307C478")]
	public bool ExistDelayCall(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601987A")]
	[Address(RVA = "0x307C514", Offset = "0x307C514", VA = "0x307C514")]
	public ConditionAction AddConditionAction(ConditionAction.ActionHandler callback)
	{
		return null;
	}

	[Token(Token = "0x601987B")]
	[Address(RVA = "0x307C614", Offset = "0x307C614", VA = "0x307C614")]
	public void CancelConditionAction(int guid)
	{
	}

	[Token(Token = "0x601987C")]
	[Address(RVA = "0x307C77C", Offset = "0x307C77C", VA = "0x307C77C")]
	public void MoveFrontDelayCall(uint id)
	{
	}

	[Token(Token = "0x601987D")]
	[Address(RVA = "0x307C838", Offset = "0x307C838", VA = "0x307C838")]
	public bool HasInited()
	{
		return default(bool);
	}

	[Token(Token = "0x601987E")]
	[Address(RVA = "0x307C840", Offset = "0x307C840", VA = "0x307C840")]
	public bool HasLoadingFailed()
	{
		return default(bool);
	}

	[Token(Token = "0x601987F")]
	[Address(RVA = "0x307C848", Offset = "0x307C848", VA = "0x307C848", Slot = "5")]
	public virtual void OnStartLoadScene()
	{
	}

	[Token(Token = "0x6019880")]
	[Address(RVA = "0x307C84C", Offset = "0x307C84C", VA = "0x307C84C", Slot = "6")]
	public virtual bool NeedPreloadBeforeLoadScene()
	{
		return default(bool);
	}

	[Token(Token = "0x6019881")]
	[Address(RVA = "0x307C854", Offset = "0x307C854", VA = "0x307C854", Slot = "7")]
	public virtual IEnumerator OnPreprocessFinished()
	{
		return null;
	}

	[Token(Token = "0x6019882")]
	[Address(RVA = "0x307C8C8", Offset = "0x307C8C8", VA = "0x307C8C8", Slot = "8")]
	protected virtual void OnAwake()
	{
	}

	[Token(Token = "0x6019883")]
	[Address(RVA = "0x307C8CC", Offset = "0x307C8CC", VA = "0x307C8CC", Slot = "9")]
	protected virtual void OnSceneLoaded()
	{
	}

	[Token(Token = "0x6019884")]
	[Address(RVA = "0x307C8D0", Offset = "0x307C8D0", VA = "0x307C8D0", Slot = "10")]
	protected virtual void OnPreloadLoaded()
	{
	}

	[Token(Token = "0x6019885")]
	[Address(RVA = "0x307C8D4", Offset = "0x307C8D4", VA = "0x307C8D4", Slot = "11")]
	protected virtual void OnUnInit()
	{
	}

	[Token(Token = "0x6019886")]
	[Address(RVA = "0x307C8D8", Offset = "0x307C8D8", VA = "0x307C8D8", Slot = "12")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6019887")]
	[Address(RVA = "0x307C8DC", Offset = "0x307C8DC", VA = "0x307C8DC", Slot = "13")]
	protected virtual void OnUpdate()
	{
	}

	[Token(Token = "0x6019888")]
	[Address(RVA = "0x307C8E0", Offset = "0x307C8E0", VA = "0x307C8E0", Slot = "14")]
	protected virtual void OnInputUpdate()
	{
	}

	[Token(Token = "0x6019889")]
	[Address(RVA = "0x307C8E4", Offset = "0x307C8E4", VA = "0x307C8E4", Slot = "15")]
	protected virtual void OnFixedUpdate()
	{
	}

	[Token(Token = "0x601988A")]
	[Address(RVA = "0x307C8E8", Offset = "0x307C8E8", VA = "0x307C8E8", Slot = "16")]
	protected virtual void OnNetworkFixedUpdate()
	{
	}

	[Token(Token = "0x601988B")]
	[Address(RVA = "0x307C8EC", Offset = "0x307C8EC", VA = "0x307C8EC", Slot = "17")]
	protected virtual bool SkipFixedUpdate()
	{
		return default(bool);
	}

	[Token(Token = "0x601988C")]
	public abstract ResourceID[] GetResourceID();

	[Token(Token = "0x601988D")]
	public abstract Type GetUISceneType();

	[Token(Token = "0x601988E")]
	[Address(RVA = "0x307C8F4", Offset = "0x307C8F4", VA = "0x307C8F4", Slot = "20")]
	public virtual ResourceID[] GetPreloadResourceID()
	{
		return null;
	}

	[Token(Token = "0x601988F")]
	[Address(RVA = "0x307C8FC", Offset = "0x307C8FC", VA = "0x307C8FC", Slot = "21")]
	public virtual ResourceID[] GetAudioPreloadResourceID()
	{
		return null;
	}

	[Token(Token = "0x6019890")]
	[Address(RVA = "0x307C904", Offset = "0x307C904", VA = "0x307C904", Slot = "22")]
	public virtual IEnumerator PreloadUmas()
	{
		return null;
	}

	[Token(Token = "0x6019891")]
	[Address(RVA = "0x307C90C", Offset = "0x307C90C", VA = "0x307C90C", Slot = "23")]
	public virtual LoadingProcess[] GetLoadingProcesses()
	{
		return null;
	}

	[Token(Token = "0x6019892")]
	[Address(RVA = "0x307C914", Offset = "0x307C914", VA = "0x307C914", Slot = "24")]
	public virtual void OnLoadingFailed(int expectionProcessIndex)
	{
	}

	[Token(Token = "0x6019893")]
	[Address(RVA = "0x307C918", Offset = "0x307C918", VA = "0x307C918", Slot = "25")]
	public virtual void OnLoadingSceneFailed()
	{
	}

	[Token(Token = "0x6019894")]
	[Address(RVA = "0x307C91C", Offset = "0x307C91C", VA = "0x307C91C", Slot = "26")]
	public virtual int GetGameType()
	{
		return default(int);
	}

	[Token(Token = "0x6019895")]
	[Address(RVA = "0x307C924", Offset = "0x307C924", VA = "0x307C924", Slot = "27")]
	public virtual int GetSubGameType()
	{
		return default(int);
	}

	[Token(Token = "0x6019896")]
	[Address(RVA = "0x307C92C", Offset = "0x307C92C", VA = "0x307C92C", Slot = "28")]
	public virtual bool NotUsingAB()
	{
		return default(bool);
	}

	[Token(Token = "0x6019897")]
	[Address(RVA = "0x307C934", Offset = "0x307C934", VA = "0x307C934", Slot = "29")]
	public virtual void SetSceneABInfo(AssetBundle ab, bool useAB, string abPath, string streamPath)
	{
	}

	[Token(Token = "0x6019898")]
	[Address(RVA = "0x307C938", Offset = "0x307C938", VA = "0x307C938", Slot = "30")]
	public virtual AssetBundle GetStreamSceneAB()
	{
		return null;
	}

	[Token(Token = "0x6019899")]
	[Address(RVA = "0x307C940", Offset = "0x307C940", VA = "0x307C940", Slot = "31")]
	public virtual byte[] GetStreamSceneABTexRefInfo()
	{
		return null;
	}

	[Token(Token = "0x601989A")]
	[Address(RVA = "0x307C948", Offset = "0x307C948", VA = "0x307C948", Slot = "32")]
	public virtual string GetSceneStreamABPath()
	{
		return null;
	}

	[Token(Token = "0x601989B")]
	[Address(RVA = "0x307C9D4", Offset = "0x307C9D4", VA = "0x307C9D4", Slot = "33")]
	public virtual string GetSceneName()
	{
		return null;
	}

	[Token(Token = "0x601989C")]
	[Address(RVA = "0x307CA60", Offset = "0x307CA60", VA = "0x307CA60", Slot = "34")]
	public virtual bool ShouldClearPreloadAssets(Type nextGameType)
	{
		return default(bool);
	}

	[Token(Token = "0x601989D")]
	[Address(RVA = "0x307CA68", Offset = "0x307CA68", VA = "0x307CA68", Slot = "35")]
	public virtual void PauseGame(bool v)
	{
	}

	[Token(Token = "0x601989E")]
	[Address(RVA = "0x307CA6C", Offset = "0x307CA6C", VA = "0x307CA6C", Slot = "36")]
	public virtual bool IsGamePaused()
	{
		return default(bool);
	}

	[Token(Token = "0x601989F")]
	[Address(RVA = "0x307CA74", Offset = "0x307CA74", VA = "0x307CA74", Slot = "37")]
	public virtual bool NeedAimAssist()
	{
		return default(bool);
	}

	[Token(Token = "0x60198A0")]
	[Address(RVA = "0x307CA7C", Offset = "0x307CA7C", VA = "0x307CA7C", Slot = "38")]
	public virtual void OnMatchStart()
	{
	}

	[Token(Token = "0x60198A1")]
	[Address(RVA = "0x307CA80", Offset = "0x307CA80", VA = "0x307CA80", Slot = "39")]
	public virtual void OnMatchEnd()
	{
	}

	[Token(Token = "0x60198A2")]
	[Address(RVA = "0x307CA84", Offset = "0x307CA84", VA = "0x307CA84", Slot = "40")]
	public virtual void LocalPlayerSelectEquipSet(uint index)
	{
	}

	[Token(Token = "0x60198A3")]
	[Address(RVA = "0x307CA88", Offset = "0x307CA88", VA = "0x307CA88", Slot = "41")]
	public virtual void OnLoadingMaskClosed()
	{
	}

	[Token(Token = "0x60198A4")]
	[Address(RVA = "0x307CA8C", Offset = "0x307CA8C", VA = "0x307CA8C", Slot = "42")]
	public virtual bool CanShowGodEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x60198A5")]
	[Address(RVA = "0x307CA94", Offset = "0x307CA94", VA = "0x307CA94", Slot = "43")]
	public virtual bool EnableGlassBG()
	{
		return default(bool);
	}

	[Token(Token = "0x60198A6")]
	[Address(RVA = "0x307CA9C", Offset = "0x307CA9C", VA = "0x307CA9C", Slot = "44")]
	public virtual bool IsGameNeedCheckObserverMatchEnd()
	{
		return default(bool);
	}

	[Token(Token = "0x60198A8")]
	[Address(RVA = "0x307CB70", Offset = "0x307CB70", VA = "0x307CB70")]
	private void _003CInit_003Em__0(bool result, int exceptionProcessIndex)
	{
	}
}
