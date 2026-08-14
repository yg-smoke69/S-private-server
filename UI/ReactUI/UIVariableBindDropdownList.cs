using System.Collections.Generic;
using COW.Gameplay.UGC.BlockEdit;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CC8")]
public class UIVariableBindDropdownList : UIEventBind
{
	[Token(Token = "0x40067C8")]
	[FieldOffset(Offset = "0x30")]
	private string paramBinds;

	[Token(Token = "0x40067C9")]
	[FieldOffset(Offset = "0x34")]
	private string paramCurrentSelected;

	[Token(Token = "0x40067CA")]
	[FieldOffset(Offset = "0x38")]
	private UIVariable m_bindVariable;

	[Token(Token = "0x40067CB")]
	[FieldOffset(Offset = "0x3C")]
	private UIVariable m_curSelVariable;

	[Token(Token = "0x40067CC")]
	[FieldOffset(Offset = "0x40")]
	private string eventOnSelectName;

	[Token(Token = "0x40067CD")]
	[FieldOffset(Offset = "0x44")]
	private SignalDelegateList m_delegateList;

	[Token(Token = "0x40067CE")]
	[FieldOffset(Offset = "0x48")]
	private List<object> m_allItemData;

	[Token(Token = "0x40067CF")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnShowDropdown;

	[Token(Token = "0x40067D0")]
	[FieldOffset(Offset = "0x50")]
	public GameObject DropdownPanel;

	[Token(Token = "0x40067D1")]
	[FieldOffset(Offset = "0x54")]
	public GameObject CurrentItem;

	[Token(Token = "0x40067D2")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ItemTemplate;

	[Token(Token = "0x40067D3")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite SVBG;

	[Token(Token = "0x40067D4")]
	[FieldOffset(Offset = "0x60")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40067D5")]
	[FieldOffset(Offset = "0x64")]
	public UIGrid ItemGrid;

	[Token(Token = "0x40067D6")]
	[FieldOffset(Offset = "0x68")]
	private bool IsShowing;

	[Token(Token = "0x40067D7")]
	[FieldOffset(Offset = "0x6C")]
	private List<GameObject> m_itemObjects;

	[Token(Token = "0x40067D8")]
	[FieldOffset(Offset = "0x70")]
	private UIClickMask m_ClickMask;

	[Token(Token = "0x40067D9")]
	[FieldOffset(Offset = "0x74")]
	private UIWidget m_Widget;

	[Token(Token = "0x40067DA")]
	[FieldOffset(Offset = "0x78")]
	private ValueData m_ValueData;

	[Token(Token = "0x1700081A")]
	public Transform Transform
	{
		[Token(Token = "0x6006146")]
		[Address(RVA = "0x316068C", Offset = "0x316068C", VA = "0x316068C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700081B")]
	public Vector2 Size
	{
		[Token(Token = "0x6006147")]
		[Address(RVA = "0x3160694", Offset = "0x3160694", VA = "0x3160694")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700081C")]
	public UIWidget Widget
	{
		[Token(Token = "0x6006148")]
		[Address(RVA = "0x31606D0", Offset = "0x31606D0", VA = "0x31606D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700081D")]
	public ValueData ValueData
	{
		[Token(Token = "0x6006149")]
		[Address(RVA = "0x31606D8", Offset = "0x31606D8", VA = "0x31606D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600614A")]
		[Address(RVA = "0x31606E0", Offset = "0x31606E0", VA = "0x31606E0")]
		set
		{
		}
	}

	[Token(Token = "0x600613C")]
	[Address(RVA = "0x315F890", Offset = "0x315F890", VA = "0x315F890")]
	public UIVariableBindDropdownList()
	{
	}

	[Token(Token = "0x600613D")]
	[Address(RVA = "0x315F94C", Offset = "0x315F94C", VA = "0x315F94C", Slot = "6")]
	protected override void BindVariables()
	{
	}

	[Token(Token = "0x600613E")]
	[Address(RVA = "0x315FB10", Offset = "0x315FB10", VA = "0x315FB10", Slot = "7")]
	protected override void UnbindVariables()
	{
	}

	[Token(Token = "0x600613F")]
	[Address(RVA = "0x315FC20", Offset = "0x315FC20", VA = "0x315FC20")]
	private SignalDelegateList GetDelegateList()
	{
		return null;
	}

	[Token(Token = "0x6006140")]
	[Address(RVA = "0x315FC4C", Offset = "0x315FC4C", VA = "0x315FC4C", Slot = "10")]
	protected override void RefreshBind()
	{
	}

	[Token(Token = "0x6006141")]
	[Address(RVA = "0x315FC50", Offset = "0x315FC50", VA = "0x315FC50")]
	private void RefreshList()
	{
	}

	[Token(Token = "0x6006142")]
	[Address(RVA = "0x3156DC8", Offset = "0x3156DC8", VA = "0x3156DC8")]
	public int GetCurrentSelectIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6006143")]
	[Address(RVA = "0x315FE8C", Offset = "0x315FE8C", VA = "0x315FE8C")]
	private void RefreshSelect()
	{
	}

	[Token(Token = "0x6006144")]
	[Address(RVA = "0x31600C0", Offset = "0x31600C0", VA = "0x31600C0")]
	private void OnVariableInit()
	{
	}

	[Token(Token = "0x6006145")]
	[Address(RVA = "0x315FC54", Offset = "0x315FC54", VA = "0x315FC54")]
	private void RefreshListInfinite()
	{
	}

	[Token(Token = "0x600614B")]
	[Address(RVA = "0x31606E8", Offset = "0x31606E8", VA = "0x31606E8")]
	private new void Awake()
	{
	}

	[Token(Token = "0x600614C")]
	[Address(RVA = "0x316088C", Offset = "0x316088C", VA = "0x316088C")]
	private void Start()
	{
	}

	[Token(Token = "0x600614D")]
	[Address(RVA = "0x3160890", Offset = "0x3160890", VA = "0x3160890")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x600614E")]
	[Address(RVA = "0x31600C4", Offset = "0x31600C4", VA = "0x31600C4")]
	public void BuildDropdownUI()
	{
	}

	[Token(Token = "0x600614F")]
	[Address(RVA = "0x31608C0", Offset = "0x31608C0", VA = "0x31608C0")]
	private void ShowOptsData()
	{
	}

	[Token(Token = "0x6006150")]
	[Address(RVA = "0x3160AAC", Offset = "0x3160AAC", VA = "0x3160AAC")]
	private void HideDropDownItems()
	{
	}

	[Token(Token = "0x6006151")]
	[Address(RVA = "0x3156EAC", Offset = "0x3156EAC", VA = "0x3156EAC")]
	public void OnSelectItem(int dataIndex)
	{
	}

	[Token(Token = "0x6006152")]
	[Address(RVA = "0x3160B24", Offset = "0x3160B24", VA = "0x3160B24")]
	private void SetHLItem()
	{
	}

	[Token(Token = "0x6006153")]
	[Address(RVA = "0x3160B7C", Offset = "0x3160B7C", VA = "0x3160B7C")]
	public void SetValue(string value)
	{
	}

	[Token(Token = "0x6006154")]
	[Address(RVA = "0x31608BC", Offset = "0x31608BC", VA = "0x31608BC")]
	private void UpdateWidgetSize()
	{
	}
}
