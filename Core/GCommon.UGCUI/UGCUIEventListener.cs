using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon.UGCUI;

[Token(Token = "0x20040FD")]
public class UGCUIEventListener : MonoBehaviour
{
	[Token(Token = "0x20040FE")]
	public delegate void VoidDelegate(GameObject go);

	[Token(Token = "0x20040FF")]
	public delegate void BoolDelegate(GameObject go, bool state);

	[Token(Token = "0x2004100")]
	public delegate void FloatDelegate(GameObject go, float delta);

	[Token(Token = "0x2004101")]
	public delegate void VectorDelegate(GameObject go, Vector2 delta);

	[Token(Token = "0x2004102")]
	public delegate void ObjectDelegate(GameObject go, GameObject obj);

	[Token(Token = "0x2004103")]
	public delegate void KeyCodeDelegate(GameObject go, KeyCode key);

	[Token(Token = "0x401B4EB")]
	[FieldOffset(Offset = "0x0")]
	private static UIEventMutex m_Mutex;

	[Token(Token = "0x401B4EC")]
	[FieldOffset(Offset = "0xC")]
	private VoidDelegate m_OnSubmit;

	[Token(Token = "0x401B4ED")]
	[FieldOffset(Offset = "0x10")]
	private VoidDelegate m_OnClick;

	[Token(Token = "0x401B4EE")]
	[FieldOffset(Offset = "0x14")]
	private VoidDelegate m_OnDoubleClick;

	[Token(Token = "0x401B4EF")]
	[FieldOffset(Offset = "0x18")]
	private BoolDelegate m_OnHover;

	[Token(Token = "0x401B4F0")]
	[FieldOffset(Offset = "0x1C")]
	private BoolDelegate m_OnPress;

	[Token(Token = "0x401B4F1")]
	[FieldOffset(Offset = "0x20")]
	private BoolDelegate m_OnSelect;

	[Token(Token = "0x401B4F2")]
	[FieldOffset(Offset = "0x24")]
	private FloatDelegate m_OnScroll;

	[Token(Token = "0x401B4F3")]
	[FieldOffset(Offset = "0x28")]
	private VoidDelegate m_OnDragStart;

	[Token(Token = "0x401B4F4")]
	[FieldOffset(Offset = "0x2C")]
	private VectorDelegate m_OnDrag;

	[Token(Token = "0x401B4F5")]
	[FieldOffset(Offset = "0x30")]
	private VoidDelegate m_OnDragOver;

	[Token(Token = "0x401B4F6")]
	[FieldOffset(Offset = "0x34")]
	private VoidDelegate m_OnDragOut;

	[Token(Token = "0x401B4F7")]
	[FieldOffset(Offset = "0x38")]
	private VoidDelegate m_OnDragEnd;

	[Token(Token = "0x401B4F8")]
	[FieldOffset(Offset = "0x3C")]
	private ObjectDelegate m_OnDrop;

	[Token(Token = "0x401B4F9")]
	[FieldOffset(Offset = "0x40")]
	private KeyCodeDelegate m_OnKey;

	[Token(Token = "0x401B4FA")]
	[FieldOffset(Offset = "0x44")]
	private BoolDelegate m_OnTooltip;

	[Token(Token = "0x401B4FB")]
	[FieldOffset(Offset = "0x48")]
	private bool m_MutexEnabled;

	[Token(Token = "0x401B4FC")]
	[FieldOffset(Offset = "0x4C")]
	private int m_InstanceID;

	[Token(Token = "0x401B4FD")]
	private const uint DEFAULT_AUTORELEASEMUTEXTIME = 100u;

	[Token(Token = "0x17001D18")]
	public VoidDelegate OnSubmitDelegate
	{
		[Token(Token = "0x601A86E")]
		[Address(RVA = "0x2C8B010", Offset = "0x2C8B010", VA = "0x2C8B010")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A86F")]
		[Address(RVA = "0x2C8B018", Offset = "0x2C8B018", VA = "0x2C8B018")]
		set
		{
		}
	}

	[Token(Token = "0x17001D19")]
	public VoidDelegate OnClickDelegate
	{
		[Token(Token = "0x601A870")]
		[Address(RVA = "0x2C8B0E8", Offset = "0x2C8B0E8", VA = "0x2C8B0E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A871")]
		[Address(RVA = "0x2C8B0F0", Offset = "0x2C8B0F0", VA = "0x2C8B0F0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D1A")]
	public VoidDelegate OnDoubleClickDelegate
	{
		[Token(Token = "0x601A872")]
		[Address(RVA = "0x2C8B100", Offset = "0x2C8B100", VA = "0x2C8B100")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A873")]
		[Address(RVA = "0x2C8B108", Offset = "0x2C8B108", VA = "0x2C8B108")]
		set
		{
		}
	}

	[Token(Token = "0x17001D1B")]
	public BoolDelegate OnHoverDelegate
	{
		[Token(Token = "0x601A874")]
		[Address(RVA = "0x2C8B118", Offset = "0x2C8B118", VA = "0x2C8B118")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A875")]
		[Address(RVA = "0x2C8B120", Offset = "0x2C8B120", VA = "0x2C8B120")]
		set
		{
		}
	}

	[Token(Token = "0x17001D1C")]
	public BoolDelegate OnPressDelegate
	{
		[Token(Token = "0x601A876")]
		[Address(RVA = "0x2C8B130", Offset = "0x2C8B130", VA = "0x2C8B130")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A877")]
		[Address(RVA = "0x2C8B138", Offset = "0x2C8B138", VA = "0x2C8B138")]
		set
		{
		}
	}

	[Token(Token = "0x17001D1D")]
	public BoolDelegate OnSelectDelegate
	{
		[Token(Token = "0x601A878")]
		[Address(RVA = "0x2C8B148", Offset = "0x2C8B148", VA = "0x2C8B148")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A879")]
		[Address(RVA = "0x2C8B150", Offset = "0x2C8B150", VA = "0x2C8B150")]
		set
		{
		}
	}

	[Token(Token = "0x17001D1E")]
	public FloatDelegate OnScrollDelegate
	{
		[Token(Token = "0x601A87A")]
		[Address(RVA = "0x2C8B160", Offset = "0x2C8B160", VA = "0x2C8B160")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A87B")]
		[Address(RVA = "0x2C8B168", Offset = "0x2C8B168", VA = "0x2C8B168")]
		set
		{
		}
	}

	[Token(Token = "0x17001D1F")]
	public VoidDelegate OnDragStartDelegate
	{
		[Token(Token = "0x601A87C")]
		[Address(RVA = "0x2C8B178", Offset = "0x2C8B178", VA = "0x2C8B178")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A87D")]
		[Address(RVA = "0x2C8B180", Offset = "0x2C8B180", VA = "0x2C8B180")]
		set
		{
		}
	}

	[Token(Token = "0x17001D20")]
	public VectorDelegate OnDragDelegate
	{
		[Token(Token = "0x601A87E")]
		[Address(RVA = "0x2C8B190", Offset = "0x2C8B190", VA = "0x2C8B190")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A87F")]
		[Address(RVA = "0x2C8B198", Offset = "0x2C8B198", VA = "0x2C8B198")]
		set
		{
		}
	}

	[Token(Token = "0x17001D21")]
	public VoidDelegate OnDragOverDelegate
	{
		[Token(Token = "0x601A880")]
		[Address(RVA = "0x2C8B1A8", Offset = "0x2C8B1A8", VA = "0x2C8B1A8")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A881")]
		[Address(RVA = "0x2C8B1B0", Offset = "0x2C8B1B0", VA = "0x2C8B1B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D22")]
	public VoidDelegate OnDragOutDelegate
	{
		[Token(Token = "0x601A882")]
		[Address(RVA = "0x2C8B1C0", Offset = "0x2C8B1C0", VA = "0x2C8B1C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A883")]
		[Address(RVA = "0x2C8B1C8", Offset = "0x2C8B1C8", VA = "0x2C8B1C8")]
		set
		{
		}
	}

	[Token(Token = "0x17001D23")]
	public VoidDelegate OnDragEndDelegate
	{
		[Token(Token = "0x601A884")]
		[Address(RVA = "0x2C8B1D8", Offset = "0x2C8B1D8", VA = "0x2C8B1D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A885")]
		[Address(RVA = "0x2C8B1E0", Offset = "0x2C8B1E0", VA = "0x2C8B1E0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D24")]
	public ObjectDelegate OnDropDelegate
	{
		[Token(Token = "0x601A886")]
		[Address(RVA = "0x2C8B1F0", Offset = "0x2C8B1F0", VA = "0x2C8B1F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A887")]
		[Address(RVA = "0x2C8B1F8", Offset = "0x2C8B1F8", VA = "0x2C8B1F8")]
		set
		{
		}
	}

	[Token(Token = "0x17001D25")]
	public KeyCodeDelegate OnKeyDelegate
	{
		[Token(Token = "0x601A888")]
		[Address(RVA = "0x2C8B208", Offset = "0x2C8B208", VA = "0x2C8B208")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A889")]
		[Address(RVA = "0x2C8B210", Offset = "0x2C8B210", VA = "0x2C8B210")]
		set
		{
		}
	}

	[Token(Token = "0x17001D26")]
	public BoolDelegate OnTooltipDelegate
	{
		[Token(Token = "0x601A88A")]
		[Address(RVA = "0x2C8B220", Offset = "0x2C8B220", VA = "0x2C8B220")]
		get
		{
			return null;
		}
		[Token(Token = "0x601A88B")]
		[Address(RVA = "0x2C8B228", Offset = "0x2C8B228", VA = "0x2C8B228")]
		set
		{
		}
	}

	[Token(Token = "0x17001D27")]
	private bool IsColliderEnabled
	{
		[Token(Token = "0x601A88C")]
		[Address(RVA = "0x2C8B238", Offset = "0x2C8B238", VA = "0x2C8B238")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601A86D")]
	[Address(RVA = "0x2C8B008", Offset = "0x2C8B008", VA = "0x2C8B008")]
	public UGCUIEventListener()
	{
	}

	[Token(Token = "0x601A88D")]
	[Address(RVA = "0x2C8B384", Offset = "0x2C8B384", VA = "0x2C8B384")]
	private void Init()
	{
	}

	[Token(Token = "0x601A88E")]
	[Address(RVA = "0x2C8B3A0", Offset = "0x2C8B3A0", VA = "0x2C8B3A0")]
	private void OnSubmit()
	{
	}

	[Token(Token = "0x601A88F")]
	[Address(RVA = "0x2C8B7A4", Offset = "0x2C8B7A4", VA = "0x2C8B7A4")]
	private void OnClick()
	{
	}

	[Token(Token = "0x601A890")]
	[Address(RVA = "0x2C8B9BC", Offset = "0x2C8B9BC", VA = "0x2C8B9BC")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x601A891")]
	[Address(RVA = "0x2C8BA04", Offset = "0x2C8BA04", VA = "0x2C8BA04")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x601A892")]
	[Address(RVA = "0x2C8BE30", Offset = "0x2C8BE30", VA = "0x2C8BE30")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x601A893")]
	[Address(RVA = "0x2C8BE80", Offset = "0x2C8BE80", VA = "0x2C8BE80")]
	private void OnSelect(bool selected)
	{
	}

	[Token(Token = "0x601A894")]
	[Address(RVA = "0x2C8BED0", Offset = "0x2C8BED0", VA = "0x2C8BED0")]
	private void OnScroll(float delta)
	{
	}

	[Token(Token = "0x601A895")]
	[Address(RVA = "0x2C8C2FC", Offset = "0x2C8C2FC", VA = "0x2C8C2FC")]
	private void OnDragStart()
	{
	}

	[Token(Token = "0x601A896")]
	[Address(RVA = "0x2C8C32C", Offset = "0x2C8C32C", VA = "0x2C8C32C")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x601A897")]
	[Address(RVA = "0x2C8C7A0", Offset = "0x2C8C7A0", VA = "0x2C8C7A0")]
	private void OnDragOver()
	{
	}

	[Token(Token = "0x601A898")]
	[Address(RVA = "0x2C8C7E8", Offset = "0x2C8C7E8", VA = "0x2C8C7E8")]
	private void OnDragOut()
	{
	}

	[Token(Token = "0x601A899")]
	[Address(RVA = "0x2C8C830", Offset = "0x2C8C830", VA = "0x2C8C830")]
	private void OnDragEnd()
	{
	}

	[Token(Token = "0x601A89A")]
	[Address(RVA = "0x2C8C8D0", Offset = "0x2C8C8D0", VA = "0x2C8C8D0")]
	private void OnDrop(GameObject go)
	{
	}

	[Token(Token = "0x601A89B")]
	[Address(RVA = "0x2C8CCFC", Offset = "0x2C8CCFC", VA = "0x2C8CCFC")]
	private void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x601A89C")]
	[Address(RVA = "0x2C8D128", Offset = "0x2C8D128", VA = "0x2C8D128")]
	private void OnTooltip(bool show)
	{
	}

	[Token(Token = "0x601A89D")]
	[Address(RVA = "0x2C8D178", Offset = "0x2C8D178", VA = "0x2C8D178")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601A89E")]
	[Address(RVA = "0x2C8B858", Offset = "0x2C8B858", VA = "0x2C8B858")]
	private void Check(Action action, uint autoReleaseTime = 100u)
	{
	}

	[Token(Token = "0x601A89F")]
	[Address(RVA = "0x2C8B028", Offset = "0x2C8B028", VA = "0x2C8B028")]
	private void ReleaseMutex()
	{
	}

	[Token(Token = "0x601A8A0")]
	[Address(RVA = "0x2C8D238", Offset = "0x2C8D238", VA = "0x2C8D238")]
	public static UGCUIEventListener Get(GameObject go, bool mutex = false)
	{
		return null;
	}

	[Token(Token = "0x601A8A2")]
	[Address(RVA = "0x2C8D3E0", Offset = "0x2C8D3E0", VA = "0x2C8D3E0")]
	private void _003COnClick_003Em__0()
	{
	}

	[Token(Token = "0x601A8A3")]
	[Address(RVA = "0x2C8D41C", Offset = "0x2C8D41C", VA = "0x2C8D41C")]
	private void _003COnDragEnd_003Em__1()
	{
	}
}
