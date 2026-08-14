using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002461")]
public class UIHUDUGC_ObjectEntityAttributeEditItemController : UIEasyListItemController
{
	[Token(Token = "0x2002462")]
	public delegate void EditDel(int index);

	[Token(Token = "0x400E1F5")]
	[FieldOffset(Offset = "0x38")]
	private UIHUDUGC_ObjectEntityAttributeEditItemView m_View;

	[Token(Token = "0x400E1F6")]
	[FieldOffset(Offset = "0x3C")]
	private DJMFJEMEKHM m_Data;

	[Token(Token = "0x400E1F7")]
	[FieldOffset(Offset = "0x40")]
	private CEIJKFCIALJ m_EntityAttributeData;

	[Token(Token = "0x400E1F8")]
	[FieldOffset(Offset = "0x44")]
	private UIPopMenuSmallControler m_AttributeTypeMenu;

	[Token(Token = "0x400E1F9")]
	[FieldOffset(Offset = "0x48")]
	private UIPopMenuSmallControler m_BoolMenu;

	[Token(Token = "0x400E1FA")]
	[FieldOffset(Offset = "0x4C")]
	private List<PopMenuData> m_TypeMenuDataList;

	[Token(Token = "0x400E1FB")]
	[FieldOffset(Offset = "0x50")]
	private List<PopMenuData> m_BoolMenuDataList;

	[Token(Token = "0x400E1FC")]
	[FieldOffset(Offset = "0x54")]
	private OHAAMABDKEN m_TypeMenuIndex;

	[Token(Token = "0x400E1FD")]
	[FieldOffset(Offset = "0x58")]
	private bool m_CurrentBoolValue;

	[Token(Token = "0x400E1FE")]
	[FieldOffset(Offset = "0x5C")]
	private string m_CurrentValue;

	[Token(Token = "0x400E1FF")]
	[FieldOffset(Offset = "0x60")]
	public EditDel m_Redefine;

	[Token(Token = "0x400E200")]
	[FieldOffset(Offset = "0x64")]
	private int m_BaseDepth;

	[Token(Token = "0x400E201")]
	private const int m_OffsetDepth = 20;

	[Token(Token = "0x400E202")]
	[FieldOffset(Offset = "0x68")]
	private int m_Index;

	[Token(Token = "0x400E203")]
	private const string INPUT_NAME_EMPTY_TIP_KEY = "T_34_M_WS_ENTERNAME";

	[Token(Token = "0x400E204")]
	private const string TRUE_KEY = "T_34_M_WS_TRUE";

	[Token(Token = "0x400E205")]
	private const string FALSE_KEY = "T_34_M_WS_FALSE";

	[Token(Token = "0x600CEF7")]
	[Address(RVA = "0x2E1DD44", Offset = "0x2E1DD44", VA = "0x2E1DD44")]
	public UIHUDUGC_ObjectEntityAttributeEditItemController()
	{
	}

	[Token(Token = "0x600CEF8")]
	[Address(RVA = "0x2E1DDF0", Offset = "0x2E1DDF0", VA = "0x2E1DDF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CEF9")]
	[Address(RVA = "0x2E1DE94", Offset = "0x2E1DE94", VA = "0x2E1DE94", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CEFA")]
	[Address(RVA = "0x2E1D96C", Offset = "0x2E1D96C", VA = "0x2E1D96C")]
	public void SetData(CEIJKFCIALJ data)
	{
	}

	[Token(Token = "0x600CEFB")]
	[Address(RVA = "0x2E1D9CC", Offset = "0x2E1D9CC", VA = "0x2E1D9CC")]
	public void SetBaseDepth(int depth)
	{
	}

	[Token(Token = "0x600CEFC")]
	[Address(RVA = "0x2E1E198", Offset = "0x2E1E198", VA = "0x2E1E198")]
	private void OnValueInputSubmit()
	{
	}

	[Token(Token = "0x600CEFD")]
	[Address(RVA = "0x2E1E394", Offset = "0x2E1E394", VA = "0x2E1E394")]
	private void OnNameInputSubmit()
	{
	}

	[Token(Token = "0x600CEFE")]
	[Address(RVA = "0x2E1E9F8", Offset = "0x2E1E9F8", VA = "0x2E1E9F8")]
	private void GenerateMenuData()
	{
	}

	[Token(Token = "0x600CEFF")]
	[Address(RVA = "0x2E1EB0C", Offset = "0x2E1EB0C", VA = "0x2E1EB0C")]
	private void AddValueType(OHAAMABDKEN type)
	{
	}

	[Token(Token = "0x600CF00")]
	[Address(RVA = "0x2E1EEB4", Offset = "0x2E1EEB4", VA = "0x2E1EEB4")]
	private void GenerateBoolMenuData()
	{
	}

	[Token(Token = "0x600CF01")]
	[Address(RVA = "0x2E1F310", Offset = "0x2E1F310", VA = "0x2E1F310")]
	private void OnMenuSelected(object obj)
	{
	}

	[Token(Token = "0x600CF02")]
	[Address(RVA = "0x2E1F7D4", Offset = "0x2E1F7D4", VA = "0x2E1F7D4")]
	private void OnBoolMenuSelected(object obj)
	{
	}

	[Token(Token = "0x600CF03")]
	[Address(RVA = "0x2E1F594", Offset = "0x2E1F594", VA = "0x2E1F594")]
	private void RefreshBoolView()
	{
	}

	[Token(Token = "0x600CF04")]
	[Address(RVA = "0x2E1F8E4", Offset = "0x2E1F8E4", VA = "0x2E1F8E4")]
	private void OnClickDel()
	{
	}

	[Token(Token = "0x600CF05")]
	[Address(RVA = "0x2E1FBBC", Offset = "0x2E1FBBC", VA = "0x2E1FBBC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600CF06")]
	[Address(RVA = "0x2E1ED8C", Offset = "0x2E1ED8C", VA = "0x2E1ED8C")]
	private string GetKeyByValueType(OHAAMABDKEN type)
	{
		return null;
	}

	[Token(Token = "0x600CF07")]
	[Address(RVA = "0x2E1F708", Offset = "0x2E1F708", VA = "0x2E1F708")]
	private void SetInputVaild()
	{
	}

	[Token(Token = "0x600CF08")]
	[Address(RVA = "0x2E20438", Offset = "0x2E20438", VA = "0x2E20438")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
