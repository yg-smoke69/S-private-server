using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DDC")]
public class EventClothEffectDataManager : SingletonModule<EventClothEffectDataManager>
{
	[Token(Token = "0x2002DDD")]
	public enum EBehaviorClientType
	{
		[Token(Token = "0x40119AB")]
		SafeZone = 9
	}

	[Token(Token = "0x2002DDE")]
	private sealed class _003CLoadCSVData_003Ec__AnonStorey0
	{
		[Token(Token = "0x40119AC")]
		[FieldOffset(Offset = "0x8")]
		internal EventClothEffectsData data;

		[Token(Token = "0x60133AF")]
		[Address(RVA = "0x253ABEC", Offset = "0x253ABEC", VA = "0x253ABEC")]
		public _003CLoadCSVData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60133B0")]
		[Address(RVA = "0x253B254", Offset = "0x253B254", VA = "0x253B254")]
		internal bool _003C_003Em__0(EventTriggerData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40119A7")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, EventClothEffectsData> m_DictStateIdToData;

	[Token(Token = "0x40119A8")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, LinkedList<EventClothEffectsData>> m_DictClothesIdToData;

	[Token(Token = "0x40119A9")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, List<uint>> m_StateIdListDict;

	[Token(Token = "0x60133A8")]
	[Address(RVA = "0x2539FE4", Offset = "0x2539FE4", VA = "0x2539FE4")]
	public EventClothEffectDataManager()
	{
	}

	[Token(Token = "0x60133A9")]
	[Address(RVA = "0x253A110", Offset = "0x253A110", VA = "0x253A110", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60133AA")]
	[Address(RVA = "0x253A170", Offset = "0x253A170", VA = "0x253A170")]
	public void LoadCSVData()
	{
	}

	[Token(Token = "0x60133AB")]
	[Address(RVA = "0x253ABF4", Offset = "0x253ABF4", VA = "0x253ABF4")]
	public bool CheckClothHasEvent(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60133AC")]
	[Address(RVA = "0x253ACC0", Offset = "0x253ACC0", VA = "0x253ACC0", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60133AD")]
	[Address(RVA = "0x253ADD8", Offset = "0x253ADD8", VA = "0x253ADD8")]
	public bool IsClientClothEffects(EBehaviorClientType behaviorType, uint stateId)
	{
		return default(bool);
	}

	[Token(Token = "0x60133AE")]
	[Address(RVA = "0x253AEF4", Offset = "0x253AEF4", VA = "0x253AEF4")]
	public void GetEventClothEffectsDataByClothes(uint clothesId, List<EventClothEffectsData> list, bool partialClone = false)
	{
	}
}
