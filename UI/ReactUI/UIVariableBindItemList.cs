using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CD5")]
public sealed class UIVariableBindItemList : UIEventBind, _Attribute
{
	[Token(Token = "0x4006810")]
	[FieldOffset(Offset = "0x30")]
	private string paramBinds;

	[Token(Token = "0x4006811")]
	[FieldOffset(Offset = "0x34")]
	private string paramCurrentSelected;

	[Token(Token = "0x4006812")]
	[FieldOffset(Offset = "0x38")]
	private GameObject itemTemplate;

	[Token(Token = "0x4006813")]
	[FieldOffset(Offset = "0x3C")]
	private UIVariable m_bindVariable;

	[Token(Token = "0x4006814")]
	[FieldOffset(Offset = "0x40")]
	private UIVariable m_curSelVariable;

	[Token(Token = "0x4006815")]
	[FieldOffset(Offset = "0x44")]
	private string eventOnSelectName;

	[Token(Token = "0x4006816")]
	[FieldOffset(Offset = "0x48")]
	private SignalDelegateList m_delegateList;

	[Token(Token = "0x4006817")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIBindItemListItemController> m_cacheItemControllers;

	[Token(Token = "0x4006818")]
	[FieldOffset(Offset = "0x50")]
	private List<object> m_allItemData;

	[Token(Token = "0x4006819")]
	[FieldOffset(Offset = "0x54")]
	private UIEasyList m_easyList;

	[Token(Token = "0x600617C")]
	[Address(RVA = "0x3164A30", Offset = "0x3164A30", VA = "0x3164A30")]
	public UIVariableBindItemList()
	{
	}

	[Token(Token = "0x600617D")]
	[Address(RVA = "0x3164AEC", Offset = "0x3164AEC", VA = "0x3164AEC", Slot = "6")]
	protected override void BindVariables()
	{
	}

	[Token(Token = "0x600617E")]
	[Address(RVA = "0x3164C88", Offset = "0x3164C88", VA = "0x3164C88", Slot = "7")]
	protected override void UnbindVariables()
	{
	}

	[Token(Token = "0x600617F")]
	[Address(RVA = "0x3164D98", Offset = "0x3164D98", VA = "0x3164D98")]
	private SignalDelegateList GetDelegateList()
	{
		return null;
	}

	[Token(Token = "0x6006180")]
	[Address(RVA = "0x3164DC4", Offset = "0x3164DC4", VA = "0x3164DC4", Slot = "10")]
	protected override void RefreshBind()
	{
	}

	[Token(Token = "0x6006181")]
	[Address(RVA = "0x3164DC8", Offset = "0x3164DC8", VA = "0x3164DC8")]
	private void RefreshList()
	{
	}

	[Token(Token = "0x6006182")]
	[Address(RVA = "0x316509C", Offset = "0x316509C", VA = "0x316509C")]
	private void OnVariableInit()
	{
	}

	[Token(Token = "0x6006183")]
	[Address(RVA = "0x3156600", Offset = "0x3156600", VA = "0x3156600")]
	public void OnSelectItem(int dataIndex)
	{
	}

	[Token(Token = "0x6006184")]
	[Address(RVA = "0x31650A0", Offset = "0x31650A0", VA = "0x31650A0", Slot = "11")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6006185")]
	[Address(RVA = "0x316531C", Offset = "0x316531C", VA = "0x316531C", Slot = "12")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6006186")]
	[Address(RVA = "0x3164DCC", Offset = "0x3164DCC", VA = "0x3164DCC")]
	private void RefreshListInfinite()
	{
	}

	[Token(Token = "0x6006187")]
	[Address(RVA = "0x316545C", Offset = "0x316545C", VA = "0x316545C")]
	private new void Awake()
	{
	}
}
