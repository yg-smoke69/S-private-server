using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004124")]
public class UIBaseScene
{
	[Token(Token = "0x2004125")]
	public delegate bool EscapeHandle();

	[Token(Token = "0x2004126")]
	public delegate bool EnterHandle();

	[Token(Token = "0x2004127")]
	private sealed class _003CSetPreviousActiveGroup_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B5D7")]
		[FieldOffset(Offset = "0x8")]
		internal ulong requestCurGroup;

		[Token(Token = "0x601AA10")]
		[Address(RVA = "0x2C99E14", Offset = "0x2C99E14", VA = "0x2C99E14")]
		public _003CSetPreviousActiveGroup_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601AA11")]
		[Address(RVA = "0x2C9B2D8", Offset = "0x2C9B2D8", VA = "0x2C9B2D8")]
		internal bool _003C_003Em__0(ulong a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401B5C4")]
	private const int DefaultUIWidth = 1334;

	[Token(Token = "0x401B5C5")]
	private const int DefaultUIHeight = 750;

	[Token(Token = "0x401B5C6")]
	private const string NavigationTransferPanelName = "NavigationTransferPanel";

	[Token(Token = "0x401B5C7")]
	private const string NavigationTransferMaskName = "NavigationTransferMask";

	[Token(Token = "0x401B5C8")]
	[FieldOffset(Offset = "0x0")]
	public static Transform UIRoot;

	[Token(Token = "0x401B5C9")]
	[FieldOffset(Offset = "0x4")]
	public static UICamera HUD_UICamera;

	[Token(Token = "0x401B5CA")]
	[FieldOffset(Offset = "0x8")]
	public static UIBaseScene Instance;

	[Token(Token = "0x401B5CB")]
	[FieldOffset(Offset = "0xC")]
	public static UISprite TransferMask;

	[Token(Token = "0x401B5CC")]
	[FieldOffset(Offset = "0x8")]
	protected List<UIBaseController> m_RootControllers;

	[Token(Token = "0x401B5CD")]
	[FieldOffset(Offset = "0xC")]
	protected List<UIBaseNavigationController> m_NavigationControllers;

	[Token(Token = "0x401B5CE")]
	[FieldOffset(Offset = "0x10")]
	protected List<UIPopupWindowController> m_InGamePopupWindows;

	[Token(Token = "0x401B5CF")]
	[FieldOffset(Offset = "0x14")]
	private List<ulong> m_ActiveGroupStack;

	[Token(Token = "0x401B5D0")]
	[FieldOffset(Offset = "0x18")]
	protected Vector2 m_WindowsSize;

	[Token(Token = "0x401B5D1")]
	[FieldOffset(Offset = "0x20")]
	protected bool isDuringSceneDestroy;

	[Token(Token = "0x401B5D2")]
	[FieldOffset(Offset = "0x24")]
	private UIPopupWindowBGBlur cbBlur;

	[Token(Token = "0x401B5D3")]
	[FieldOffset(Offset = "0x28")]
	private bool mIsInitialzied;

	[Token(Token = "0x401B5D4")]
	[FieldOffset(Offset = "0x29")]
	private bool _003CIsPrePopNavigationCleanAssets_003Ek__BackingField;

	[Token(Token = "0x401B5D5")]
	[FieldOffset(Offset = "0x2C")]
	private List<EscapeHandle> m_EscapeHandles;

	[Token(Token = "0x401B5D6")]
	[FieldOffset(Offset = "0x30")]
	private List<EnterHandle> m_EnterHandles;

	[Token(Token = "0x17001D52")]
	public bool Initialized
	{
		[Token(Token = "0x601A9CD")]
		[Address(RVA = "0x2C96F6C", Offset = "0x2C96F6C", VA = "0x2C96F6C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001D53")]
	public bool IsPrePopNavigationCleanAssets
	{
		[Token(Token = "0x601A9CE")]
		[Address(RVA = "0x2C96F74", Offset = "0x2C96F74", VA = "0x2C96F74")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601A9CF")]
		[Address(RVA = "0x2C96F7C", Offset = "0x2C96F7C", VA = "0x2C96F7C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001D54")]
	public Vector2 WindowsSize
	{
		[Token(Token = "0x601A9D0")]
		[Address(RVA = "0x2C96F84", Offset = "0x2C96F84", VA = "0x2C96F84")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001D55")]
	public UIPopupWindowController CurrentPopupController
	{
		[Token(Token = "0x601A9D1")]
		[Address(RVA = "0x2C96F98", Offset = "0x2C96F98", VA = "0x2C96F98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D56")]
	public Type CurrentNavigationType
	{
		[Token(Token = "0x601A9DA")]
		[Address(RVA = "0x2C98004", Offset = "0x2C98004", VA = "0x2C98004")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601A9CC")]
	[Address(RVA = "0x2C96DDC", Offset = "0x2C96DDC", VA = "0x2C96DDC")]
	public UIBaseScene()
	{
	}

	[Token(Token = "0x601A9D2")]
	[Address(RVA = "0x2C97164", Offset = "0x2C97164", VA = "0x2C97164")]
	public void Init()
	{
	}

	[Token(Token = "0x601A9D3")]
	[Address(RVA = "0x2C97A40", Offset = "0x2C97A40", VA = "0x2C97A40", Slot = "4")]
	public virtual void Destory()
	{
	}

	[Token(Token = "0x601A9D4")]
	[Address(RVA = "0x2C97CA0", Offset = "0x2C97CA0", VA = "0x2C97CA0")]
	public bool IsDuringSceneDestroy()
	{
		return default(bool);
	}

	[Token(Token = "0x601A9D5")]
	public virtual T PushNavigation<T>(UINavigationData navigationData, bool isRoot = false) where T : UIBaseNavigationController
	{
		return null;
	}

	[Token(Token = "0x601A9D6")]
	[Address(RVA = "0x2C97CA8", Offset = "0x2C97CA8", VA = "0x2C97CA8", Slot = "6")]
	public virtual UINavigationData PopNavigation()
	{
		return null;
	}

	[Token(Token = "0x601A9D7")]
	public void CloseNavigation<T>() where T : UIBaseNavigationController
	{
	}

	[Token(Token = "0x601A9D8")]
	public void PopToNavigation<T>() where T : UIBaseNavigationController
	{
	}

	[Token(Token = "0x601A9D9")]
	public bool HasNavigation<T>()
	{
		return default(bool);
	}

	[Token(Token = "0x601A9DB")]
	[Address(RVA = "0x2C981C0", Offset = "0x2C981C0", VA = "0x2C981C0")]
	public UINavigationData GetCurrentUINavigationData()
	{
		return null;
	}

	[Token(Token = "0x601A9DC")]
	[Address(RVA = "0x2C980C0", Offset = "0x2C980C0", VA = "0x2C980C0")]
	public UIBaseNavigationController GetCurrentUINavigationController()
	{
		return null;
	}

	[Token(Token = "0x601A9DD")]
	[Address(RVA = "0x2C98278", Offset = "0x2C98278", VA = "0x2C98278")]
	public List<UIPopupWindowController> GetInGamePopupWindows()
	{
		return null;
	}

	[Token(Token = "0x601A9DE")]
	public virtual T ShowPopupWindow<T>() where T : UIPopupWindowController
	{
		return null;
	}

	[Token(Token = "0x601A9DF")]
	[Address(RVA = "0x2C98280", Offset = "0x2C98280", VA = "0x2C98280")]
	public void CloseAllPopups()
	{
	}

	[Token(Token = "0x601A9E0")]
	public void CloseAllPopups<T>() where T : UIPopupWindowController
	{
	}

	[Token(Token = "0x601A9E1")]
	public T Open3DUI<T>(Transform parent, bool isChildCon = false, bool isQueued = false, [Optional] Type forceType) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x601A9E2")]
	public T Open3DUI<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor, bool isChildCon = false, bool isQueued = false) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x601A9E3")]
	public T OpenUI<T>(Transform parent, bool isChildCon = false, bool noCache = false) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x601A9E4")]
	[Address(RVA = "0x2C9835C", Offset = "0x2C9835C", VA = "0x2C9835C")]
	public UIBaseController OpenUI(Type uiBaseControllerType, Transform parent, bool isChildCon = false, bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x601A9E5")]
	public T OpenUI<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor, bool isChildCon = false, bool noCache = false) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x601A9E6")]
	[Address(RVA = "0x2C98D10", Offset = "0x2C98D10", VA = "0x2C98D10", Slot = "8")]
	public virtual void RemoveRootController(UIBaseController uiController)
	{
	}

	[Token(Token = "0x601A9E7")]
	[Address(RVA = "0x2C98D84", Offset = "0x2C98D84", VA = "0x2C98D84")]
	public Vector3 GetTopLeftTrans()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601A9E8")]
	[Address(RVA = "0x2C98F6C", Offset = "0x2C98F6C", VA = "0x2C98F6C")]
	public Transform GetAnchor(Transform parent, EUIAnchor anchor, bool autoCreate = true)
	{
		return null;
	}

	[Token(Token = "0x601A9E9")]
	[Address(RVA = "0x2C9571C", Offset = "0x2C9571C", VA = "0x2C9571C")]
	public void AddUINavigationController(UIBaseNavigationController navigation)
	{
	}

	[Token(Token = "0x601A9EA")]
	[Address(RVA = "0x2C96D50", Offset = "0x2C96D50", VA = "0x2C96D50")]
	public void RemoveUINavigationController(UIBaseNavigationController navigation)
	{
	}

	[Token(Token = "0x601A9EB")]
	[Address(RVA = "0x2C993D8", Offset = "0x2C993D8", VA = "0x2C993D8")]
	public void RemovePopupWindow(UIPopupWindowController popupWindow)
	{
	}

	[Token(Token = "0x601A9EC")]
	[Address(RVA = "0x2C99464", Offset = "0x2C99464", VA = "0x2C99464")]
	public void AddPopupWindow(UIPopupWindowController popupWindow)
	{
	}

	[Token(Token = "0x601A9ED")]
	private T CreateUI<T>(bool noCache = false) where T : UIBaseController
	{
		return null;
	}

	[Token(Token = "0x601A9EE")]
	[Address(RVA = "0x2C986A4", Offset = "0x2C986A4", VA = "0x2C986A4")]
	private UIBaseController CreateUI(Type uiBaseControllerType, bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x601A9EF")]
	[Address(RVA = "0x2C995E0", Offset = "0x2C995E0", VA = "0x2C995E0")]
	public GameObject InstantiateUIPrefab(ResourceID InPrefabResID, bool noCache = false)
	{
		return null;
	}

	[Token(Token = "0x601A9F0")]
	[Address(RVA = "0x2C998C0", Offset = "0x2C998C0", VA = "0x2C998C0", Slot = "9")]
	protected virtual Transform FindUIRoot()
	{
		return null;
	}

	[Token(Token = "0x601A9F1")]
	[Address(RVA = "0x2C975AC", Offset = "0x2C975AC", VA = "0x2C975AC")]
	private UISprite GetNavigationTransferMask()
	{
		return null;
	}

	[Token(Token = "0x601A9F2")]
	[Address(RVA = "0x2C99940", Offset = "0x2C99940", VA = "0x2C99940")]
	public bool PlayTransferTweenAlpha()
	{
		return default(bool);
	}

	[Token(Token = "0x601A9F3")]
	[Address(RVA = "0x2C99B38", Offset = "0x2C99B38", VA = "0x2C99B38")]
	public void SetPreviousActiveGroup(ulong requestCurGroup = 0uL)
	{
	}

	[Token(Token = "0x601A9F4")]
	[Address(RVA = "0x2C9A000", Offset = "0x2C9A000", VA = "0x2C9A000", Slot = "10")]
	public virtual void SetActiveGroup(ulong InActiveGroup)
	{
	}

	[Token(Token = "0x601A9F5")]
	[Address(RVA = "0x2C99E1C", Offset = "0x2C99E1C", VA = "0x2C99E1C")]
	private void SetActiveGroupInternal(ulong InActiveGroup)
	{
	}

	[Token(Token = "0x601A9F6")]
	[Address(RVA = "0x2C9A15C", Offset = "0x2C9A15C", VA = "0x2C9A15C")]
	public ulong CurActiveGroup()
	{
		return default(ulong);
	}

	[Token(Token = "0x601A9F7")]
	[Address(RVA = "0x2C9A25C", Offset = "0x2C9A25C", VA = "0x2C9A25C")]
	public bool IsGroupActive(ulong flag)
	{
		return default(bool);
	}

	[Token(Token = "0x601A9F8")]
	[Address(RVA = "0x2C9A380", Offset = "0x2C9A380", VA = "0x2C9A380", Slot = "11")]
	protected virtual void OnInit()
	{
	}

	[Token(Token = "0x601A9F9")]
	[Address(RVA = "0x2C9A384", Offset = "0x2C9A384", VA = "0x2C9A384", Slot = "12")]
	protected virtual void OnDestory()
	{
	}

	[Token(Token = "0x601A9FA")]
	[Address(RVA = "0x2C9A388", Offset = "0x2C9A388", VA = "0x2C9A388", Slot = "13")]
	public virtual bool UseUIPreInstancePool()
	{
		return default(bool);
	}

	[Token(Token = "0x601A9FB")]
	[Address(RVA = "0x2C9A390", Offset = "0x2C9A390", VA = "0x2C9A390")]
	public float GetPixelSizeAdjustment()
	{
		return default(float);
	}

	[Token(Token = "0x601A9FC")]
	[Address(RVA = "0x2C9A464", Offset = "0x2C9A464", VA = "0x2C9A464")]
	public void RegisterEscapeHandle(EscapeHandle handle)
	{
	}

	[Token(Token = "0x601A9FD")]
	[Address(RVA = "0x2C9A524", Offset = "0x2C9A524", VA = "0x2C9A524")]
	public void UnRegisterEscapeHandle(EscapeHandle handle)
	{
	}

	[Token(Token = "0x601A9FE")]
	[Address(RVA = "0x2C9A5CC", Offset = "0x2C9A5CC", VA = "0x2C9A5CC")]
	public bool DispatchEscapeHandle()
	{
		return default(bool);
	}

	[Token(Token = "0x601A9FF")]
	[Address(RVA = "0x2C9A8F8", Offset = "0x2C9A8F8", VA = "0x2C9A8F8")]
	public float GetDefaultScreenRatio()
	{
		return default(float);
	}

	[Token(Token = "0x601AA00")]
	[Address(RVA = "0x2C9A904", Offset = "0x2C9A904", VA = "0x2C9A904")]
	public void RegisterEnterHandle(EnterHandle handle)
	{
	}

	[Token(Token = "0x601AA01")]
	[Address(RVA = "0x2C9A9C4", Offset = "0x2C9A9C4", VA = "0x2C9A9C4")]
	public void UnRegisterEnterHandle(EnterHandle handle)
	{
	}

	[Token(Token = "0x601AA02")]
	[Address(RVA = "0x2C9AA6C", Offset = "0x2C9AA6C", VA = "0x2C9AA6C")]
	public bool DispatchEnterHandle()
	{
		return default(bool);
	}

	[Token(Token = "0x601AA03")]
	[Address(RVA = "0x2C9AD9C", Offset = "0x2C9AD9C", VA = "0x2C9AD9C")]
	public void SetBGBlur(UIPopupWindowBGBlur blur)
	{
	}

	[Token(Token = "0x601AA04")]
	[Address(RVA = "0x2C9ADA4", Offset = "0x2C9ADA4", VA = "0x2C9ADA4")]
	public void ExecuteBGBlur(GameObject root)
	{
	}

	[Token(Token = "0x601AA05")]
	[Address(RVA = "0x2C95A78", Offset = "0x2C95A78", VA = "0x2C95A78")]
	public void ExecuteBGBlur(List<GameObject> roots)
	{
	}

	[Token(Token = "0x601AA06")]
	[Address(RVA = "0x2C9B12C", Offset = "0x2C9B12C", VA = "0x2C9B12C")]
	public void ForceExecuteBGBlur()
	{
	}
}
