using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200411D")]
public class UIBaseController : MonoBehaviour, _Attribute
{
	[Token(Token = "0x200411E")]
	public class AutoRegisterItem
	{
		[Token(Token = "0x401B5AE")]
		[FieldOffset(Offset = "0x8")]
		public EventID EventID;

		[Token(Token = "0x401B5AF")]
		[FieldOffset(Offset = "0xC")]
		public EventDispatcher.EventHandler Handler;

		[Token(Token = "0x601A9A1")]
		[Address(RVA = "0x2C9272C", Offset = "0x2C9272C", VA = "0x2C9272C")]
		public AutoRegisterItem(EventID id, EventDispatcher.EventHandler handler)
		{
		}
	}

	[Token(Token = "0x401B597")]
	[FieldOffset(Offset = "0xC")]
	private UIBaseController _003CParentController_003Ek__BackingField;

	[Token(Token = "0x401B598")]
	[FieldOffset(Offset = "0x10")]
	private bool _003CIsInit_003Ek__BackingField;

	[Token(Token = "0x401B599")]
	[FieldOffset(Offset = "0x11")]
	private bool _003CIsOpened_003Ek__BackingField;

	[Token(Token = "0x401B59A")]
	[FieldOffset(Offset = "0x12")]
	private bool _003CIsClosed_003Ek__BackingField;

	[Token(Token = "0x401B59B")]
	[FieldOffset(Offset = "0x13")]
	public bool IsRootController;

	[Token(Token = "0x401B59C")]
	[FieldOffset(Offset = "0x14")]
	protected List<UIBaseController> m_ChildControllers;

	[Token(Token = "0x401B59D")]
	[FieldOffset(Offset = "0x18")]
	protected BitArray64 m_UIGroup;

	[Token(Token = "0x401B59E")]
	private const uint VISIBILITY_STATE_GROUP = 1u;

	[Token(Token = "0x401B59F")]
	private const uint VISIBILITY_STATE_SHOWHIDE = 2u;

	[Token(Token = "0x401B5A0")]
	private const uint VISIBILITY_STATE_NAVIGATION = 4u;

	[Token(Token = "0x401B5A1")]
	private const uint VISIBILITY_STATE_EXTRAFLAG = 8u;

	[Token(Token = "0x401B5A2")]
	private const uint VISIBILITY_STATE_GAMEPHASE = 16u;

	[Token(Token = "0x401B5A3")]
	private const uint VISIBILITY_STATE_SETTING = 32u;

	[Token(Token = "0x401B5A4")]
	private const uint VISIBILITY_STATE_InTrap = 64u;

	[Token(Token = "0x401B5A5")]
	private const uint VISIBILITY_STATE_ROOMSETTING = 128u;

	[Token(Token = "0x401B5A6")]
	public const uint VISIBILITY_STATE_CUSTOM4 = 134217728u;

	[Token(Token = "0x401B5A7")]
	public const uint VISIBILITY_STATE_CUSTOM3 = 268435456u;

	[Token(Token = "0x401B5A8")]
	public const uint VISIBILITY_STATE_CUSTOM2 = 536870912u;

	[Token(Token = "0x401B5A9")]
	public const uint VISIBILITY_STATE_CUSTOM1 = 1073741824u;

	[Token(Token = "0x401B5AA")]
	[FieldOffset(Offset = "0x1C")]
	protected BitArrayBoolean m_StoredActiveState;

	[Token(Token = "0x401B5AB")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, string> SOpenedUIInfo;

	[Token(Token = "0x401B5AC")]
	[FieldOffset(Offset = "0x20")]
	private List<UIBaseModel> m_RegisterModels;

	[Token(Token = "0x401B5AD")]
	[FieldOffset(Offset = "0x24")]
	private List<AutoRegisterItem> m_RegisterEvents;

	[Token(Token = "0x17001D4C")]
	public UIBaseController ParentController
	{
		[Token(Token = "0x601A967")]
		[Address(RVA = "0x2C9211C", Offset = "0x2C9211C", VA = "0x2C9211C")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A968")]
		[Address(RVA = "0x2C92124", Offset = "0x2C92124", VA = "0x2C92124")]
		private set
		{
		}
	}

	[Token(Token = "0x17001D4D")]
	public bool IsInit
	{
		[Token(Token = "0x601A969")]
		[Address(RVA = "0x2C9212C", Offset = "0x2C9212C", VA = "0x2C9212C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A96A")]
		[Address(RVA = "0x2C92134", Offset = "0x2C92134", VA = "0x2C92134")]
		internal set
		{
		}
	}

	[Token(Token = "0x17001D4E")]
	public bool IsOpened
	{
		[Token(Token = "0x601A96B")]
		[Address(RVA = "0x2C9213C", Offset = "0x2C9213C", VA = "0x2C9213C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A96C")]
		[Address(RVA = "0x2C92144", Offset = "0x2C92144", VA = "0x2C92144")]
		internal set
		{
		}
	}

	[Token(Token = "0x17001D4F")]
	public bool IsClosed
	{
		[Token(Token = "0x601A96D")]
		[Address(RVA = "0x2C9214C", Offset = "0x2C9214C", VA = "0x2C9214C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A96E")]
		[Address(RVA = "0x2C92154", Offset = "0x2C92154", VA = "0x2C92154")]
		internal set
		{
		}
	}

	[Token(Token = "0x601A966")]
	[Address(RVA = "0x2C92114", Offset = "0x2C92114", VA = "0x2C92114")]
	public UIBaseController()
	{
	}

	[Token(Token = "0x601A96F")]
	[Address(RVA = "0x2C9215C", Offset = "0x2C9215C", VA = "0x2C9215C")]
	public static void PrintOpenedUI()
	{
	}

	[Token(Token = "0x601A970")]
	[Address(RVA = "0x2C925E0", Offset = "0x2C925E0", VA = "0x2C925E0")]
	protected void AutoRegisterEvent(EventID eventID, EventDispatcher.EventHandler eventHandler)
	{
	}

	[Token(Token = "0x601A971")]
	[Address(RVA = "0x2C92754", Offset = "0x2C92754", VA = "0x2C92754")]
	private void UnregisterAllEvent()
	{
	}

	[Token(Token = "0x601A972")]
	[Address(RVA = "0x2C92B8C", Offset = "0x2C92B8C", VA = "0x2C92B8C")]
	protected void AutoRegisterModel(UIBaseModel model, IUIModelDataChangeObserver observer)
	{
	}

	[Token(Token = "0x601A973")]
	[Address(RVA = "0x2C92D9C", Offset = "0x2C92D9C", VA = "0x2C92D9C")]
	private void UnregisterAllModel()
	{
	}

	[Token(Token = "0x601A974")]
	[Address(RVA = "0x2C9317C", Offset = "0x2C9317C", VA = "0x2C9317C", Slot = "9")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x601A975")]
	[Address(RVA = "0x2C93494", Offset = "0x2C93494", VA = "0x2C93494")]
	public void Close()
	{
	}

	[Token(Token = "0x601A976")]
	[Address(RVA = "0x2C93D1C", Offset = "0x2C93D1C", VA = "0x2C93D1C")]
	internal void Destroy()
	{
	}

	[Token(Token = "0x601A977")]
	[Address(RVA = "0x2C93F60", Offset = "0x2C93F60", VA = "0x2C93F60")]
	internal void UIOpen()
	{
	}

	[Token(Token = "0x601A978")]
	[Address(RVA = "0x2C93F78", Offset = "0x2C93F78", VA = "0x2C93F78")]
	internal void UIActiveGroupSwitch(ulong activeGroup)
	{
	}

	[Token(Token = "0x601A979")]
	[Address(RVA = "0x2C941B4", Offset = "0x2C941B4", VA = "0x2C941B4")]
	public GameObject GetViewRootObject()
	{
		return null;
	}

	[Token(Token = "0x601A97A")]
	[Address(RVA = "0x2C941BC", Offset = "0x2C941BC", VA = "0x2C941BC")]
	public Transform GetViewRootTransform()
	{
		return null;
	}

	[Token(Token = "0x601A97B")]
	protected virtual T OpenChildControllerWith3DUI<T>(Transform parent, [Optional] Vector3 localPosition, EUIAnchor anchor = EUIAnchor.None) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x601A97C")]
	protected virtual T OpenChildController<T>(Transform parent, [Optional] Vector3 localPosition, EUIAnchor anchor = EUIAnchor.None, bool noCache = false) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x601A97D")]
	[Address(RVA = "0x2C93994", Offset = "0x2C93994", VA = "0x2C93994")]
	public void RemoveChild(UIBaseController controller)
	{
	}

	[Token(Token = "0x601A97E")]
	[Address(RVA = "0x2C941F0", Offset = "0x2C941F0", VA = "0x2C941F0")]
	public void AddChild(UIBaseController controller)
	{
	}

	[Token(Token = "0x601A97F")]
	[Address(RVA = "0x2C94264", Offset = "0x2C94264", VA = "0x2C94264", Slot = "12")]
	protected virtual void OnChildControllerOpenChildController()
	{
	}

	[Token(Token = "0x601A980")]
	protected T CreateView<T>() where T : UIBaseView, new()
	{
		return null;
	}

	[Token(Token = "0x601A981")]
	[Address(RVA = "0x2C94320", Offset = "0x2C94320", VA = "0x2C94320", Slot = "13")]
	protected virtual void OnUIInit()
	{
	}

	[Token(Token = "0x601A982")]
	[Address(RVA = "0x2C94324", Offset = "0x2C94324", VA = "0x2C94324", Slot = "14")]
	protected virtual void OnUIOpen()
	{
	}

	[Token(Token = "0x601A983")]
	[Address(RVA = "0x2C94328", Offset = "0x2C94328", VA = "0x2C94328", Slot = "15")]
	protected virtual void OnUIClose()
	{
	}

	[Token(Token = "0x601A984")]
	[Address(RVA = "0x2C9432C", Offset = "0x2C9432C", VA = "0x2C9432C", Slot = "16")]
	protected virtual void OnUIDestory()
	{
	}

	[Token(Token = "0x601A985")]
	[Address(RVA = "0x2C94330", Offset = "0x2C94330", VA = "0x2C94330", Slot = "17")]
	protected virtual void OnUIDestroy()
	{
	}

	[Token(Token = "0x601A986")]
	[Address(RVA = "0x2C94334", Offset = "0x2C94334", VA = "0x2C94334", Slot = "18")]
	protected virtual void OnUIActiveGroupSwitch(ulong activeGroup)
	{
	}

	[Token(Token = "0x601A987")]
	[Address(RVA = "0x2C94338", Offset = "0x2C94338", VA = "0x2C94338", Slot = "19")]
	protected virtual void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x601A988")]
	[Address(RVA = "0x2C9433C", Offset = "0x2C9433C", VA = "0x2C9433C", Slot = "20")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x601A989")]
	[Address(RVA = "0x2C94408", Offset = "0x2C94408", VA = "0x2C94408", Slot = "21")]
	public virtual void Show()
	{
	}

	[Token(Token = "0x601A98A")]
	[Address(RVA = "0x2C94454", Offset = "0x2C94454", VA = "0x2C94454", Slot = "22")]
	public virtual void Hide()
	{
	}

	[Token(Token = "0x601A98B")]
	[Address(RVA = "0x2C944A0", Offset = "0x2C944A0", VA = "0x2C944A0")]
	public void SetVisibility(bool v)
	{
	}

	[Token(Token = "0x601A98C")]
	[Address(RVA = "0x2C944F0", Offset = "0x2C944F0", VA = "0x2C944F0")]
	public void SetNavigationVisibility(bool v)
	{
	}

	[Token(Token = "0x601A98D")]
	[Address(RVA = "0x2C94540", Offset = "0x2C94540", VA = "0x2C94540")]
	public void SetExtraFlagVisibility(bool v)
	{
	}

	[Token(Token = "0x601A98E")]
	[Address(RVA = "0x2C94590", Offset = "0x2C94590", VA = "0x2C94590")]
	public void SetGamePhaseVisibility(bool v)
	{
	}

	[Token(Token = "0x601A98F")]
	[Address(RVA = "0x2C945E0", Offset = "0x2C945E0", VA = "0x2C945E0")]
	public void SetInTrapVisibility(bool v)
	{
	}

	[Token(Token = "0x601A990")]
	[Address(RVA = "0x2C94630", Offset = "0x2C94630", VA = "0x2C94630")]
	public void SetSettingVisibility(bool v)
	{
	}

	[Token(Token = "0x601A991")]
	[Address(RVA = "0x2C94680", Offset = "0x2C94680", VA = "0x2C94680")]
	public void SetRoomSettingVisibility(bool v)
	{
	}

	[Token(Token = "0x601A992")]
	[Address(RVA = "0x2C946D0", Offset = "0x2C946D0", VA = "0x2C946D0")]
	public void SetActiveState(uint flag, bool v)
	{
	}

	[Token(Token = "0x601A993")]
	[Address(RVA = "0x2C94724", Offset = "0x2C94724", VA = "0x2C94724")]
	public void SwitchGroup(ulong activeGroup)
	{
	}

	[Token(Token = "0x601A994")]
	[Address(RVA = "0x2C9473C", Offset = "0x2C9473C", VA = "0x2C9473C", Slot = "23")]
	public virtual bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x601A995")]
	[Address(RVA = "0x2C948BC", Offset = "0x2C948BC", VA = "0x2C948BC")]
	public UIBaseController SetUIGroup(ulong groupFlags)
	{
		return null;
	}

	[Token(Token = "0x601A996")]
	[Address(RVA = "0x2C9490C", Offset = "0x2C9490C", VA = "0x2C9490C", Slot = "24")]
	protected virtual void RefreshVisibility()
	{
	}

	[Token(Token = "0x601A997")]
	[Address(RVA = "0x2C94A4C", Offset = "0x2C94A4C", VA = "0x2C94A4C")]
	public static void SetGameObjectActive(GameObject go, bool flag, [Optional] Action<bool> changed)
	{
	}

	[Token(Token = "0x601A998")]
	[Address(RVA = "0x2C94B54", Offset = "0x2C94B54", VA = "0x2C94B54", Slot = "25")]
	public virtual void BeforeScreenshot()
	{
	}

	[Token(Token = "0x601A999")]
	[Address(RVA = "0x2C94B58", Offset = "0x2C94B58", VA = "0x2C94B58", Slot = "26")]
	public virtual void AfterScreenshot()
	{
	}

	[Token(Token = "0x601A99A")]
	[Address(RVA = "0x2C94B5C", Offset = "0x2C94B5C", VA = "0x2C94B5C", Slot = "27")]
	public virtual void BeforeSharePreview()
	{
	}

	[Token(Token = "0x601A99B")]
	[Address(RVA = "0x2C94B60", Offset = "0x2C94B60", VA = "0x2C94B60", Slot = "28")]
	public virtual void AfterSharePreview()
	{
	}

	[Token(Token = "0x601A99C")]
	[Address(RVA = "0x2C94B64", Offset = "0x2C94B64", VA = "0x2C94B64", Slot = "29")]
	public virtual void OnShare(bool success, int platform)
	{
	}

	[Token(Token = "0x601A99D")]
	[Address(RVA = "0x2C94B68", Offset = "0x2C94B68", VA = "0x2C94B68", Slot = "30")]
	protected virtual ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601A99E")]
	[Address(RVA = "0x2C93A08", Offset = "0x2C93A08", VA = "0x2C93A08")]
	private bool NeedReturn2Pool()
	{
		return default(bool);
	}

	[Token(Token = "0x601A99F")]
	[Address(RVA = "0x2C93BF8", Offset = "0x2C93BF8", VA = "0x2C93BF8")]
	private void Return2Pool()
	{
	}
}
