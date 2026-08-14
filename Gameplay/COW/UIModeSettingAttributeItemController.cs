using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002301")]
public class UIModeSettingAttributeItemController : UIEasyListItemController
{
	[Token(Token = "0x2002302")]
	public delegate void EditDel(DJMFJEMEKHM d);

	[Token(Token = "0x400DA65")]
	[FieldOffset(Offset = "0x38")]
	private UIModeSettingAttributeItemView m_View;

	[Token(Token = "0x400DA66")]
	[FieldOffset(Offset = "0x3C")]
	private DJMFJEMEKHM m_AttributeItemData;

	[Token(Token = "0x400DA67")]
	[FieldOffset(Offset = "0x40")]
	private CEIJKFCIALJ m_EntityAttributeData;

	[Token(Token = "0x400DA68")]
	[FieldOffset(Offset = "0x44")]
	private UIPopMenuSmallControler m_AttributeTypeMenu;

	[Token(Token = "0x400DA69")]
	[FieldOffset(Offset = "0x48")]
	private UIPopMenuSmallControler m_BoolMenu;

	[Token(Token = "0x400DA6A")]
	[FieldOffset(Offset = "0x4C")]
	private List<PopMenuData> m_TypeMenuDataList;

	[Token(Token = "0x400DA6B")]
	[FieldOffset(Offset = "0x50")]
	private List<PopMenuData> m_BoolMenuDataList;

	[Token(Token = "0x400DA6C")]
	[FieldOffset(Offset = "0x54")]
	private OHAAMABDKEN m_CurTypeMenu;

	[Token(Token = "0x400DA6D")]
	[FieldOffset(Offset = "0x58")]
	private bool m_CurrentBoolValue;

	[Token(Token = "0x400DA6E")]
	[FieldOffset(Offset = "0x5C")]
	private string m_CurrentValue;

	[Token(Token = "0x400DA6F")]
	[FieldOffset(Offset = "0x60")]
	private int m_BaseDepth;

	[Token(Token = "0x400DA70")]
	[FieldOffset(Offset = "0x64")]
	private int m_Width;

	[Token(Token = "0x400DA71")]
	private const int m_OffsetDepth = 10;

	[Token(Token = "0x400DA72")]
	[FieldOffset(Offset = "0x68")]
	private int m_Index;

	[Token(Token = "0x400DA73")]
	private const string INPUT_NAME_EMPTY_TIP_KEY = "T_34_M_WS_ENTERNAME";

	[Token(Token = "0x400DA74")]
	private const string TRUE_KEY = "T_34_M_WS_TRUE";

	[Token(Token = "0x400DA75")]
	private const string FALSE_KEY = "T_34_M_WS_FALSE";

	[Token(Token = "0x600C13C")]
	[Address(RVA = "0x1318094", Offset = "0x1318094", VA = "0x1318094")]
	public UIModeSettingAttributeItemController()
	{
	}

	[Token(Token = "0x600C13D")]
	[Address(RVA = "0x1318140", Offset = "0x1318140", VA = "0x1318140", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C13E")]
	[Address(RVA = "0x1318468", Offset = "0x1318468", VA = "0x1318468")]
	private void OnClickDel()
	{
	}

	[Token(Token = "0x600C13F")]
	[Address(RVA = "0x1318740", Offset = "0x1318740", VA = "0x1318740")]
	private void OnNameInputSubmit()
	{
	}

	[Token(Token = "0x600C140")]
	[Address(RVA = "0x1318B58", Offset = "0x1318B58", VA = "0x1318B58")]
	private void OnValueInputSubmit()
	{
	}

	[Token(Token = "0x600C141")]
	[Address(RVA = "0x1318CBC", Offset = "0x1318CBC", VA = "0x1318CBC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600C142")]
	[Address(RVA = "0x131973C", Offset = "0x131973C", VA = "0x131973C")]
	private void GenerateMenuData()
	{
	}

	[Token(Token = "0x600C143")]
	[Address(RVA = "0x1319850", Offset = "0x1319850", VA = "0x1319850")]
	private void AddValueType(OHAAMABDKEN type)
	{
	}

	[Token(Token = "0x600C144")]
	[Address(RVA = "0x1319AD0", Offset = "0x1319AD0", VA = "0x1319AD0")]
	private void GenerateBoolMenuData()
	{
	}

	[Token(Token = "0x600C145")]
	[Address(RVA = "0x1319214", Offset = "0x1319214", VA = "0x1319214")]
	private string GetKeyByValueType(OHAAMABDKEN type)
	{
		return null;
	}

	[Token(Token = "0x600C146")]
	[Address(RVA = "0x1319F2C", Offset = "0x1319F2C", VA = "0x1319F2C")]
	private void OnMenuSelected(object obj)
	{
	}

	[Token(Token = "0x600C147")]
	[Address(RVA = "0x131A114", Offset = "0x131A114", VA = "0x131A114")]
	private void SetInputVaild()
	{
	}

	[Token(Token = "0x600C148")]
	[Address(RVA = "0x131A1E0", Offset = "0x131A1E0", VA = "0x131A1E0")]
	private void OnBoolMenuSelected(object obj)
	{
	}

	[Token(Token = "0x600C149")]
	[Address(RVA = "0x13177D0", Offset = "0x13177D0", VA = "0x13177D0")]
	public void SetEntityAttribute(CEIJKFCIALJ data)
	{
	}

	[Token(Token = "0x600C14A")]
	[Address(RVA = "0x1317830", Offset = "0x1317830", VA = "0x1317830")]
	public void SetDepth(int depth)
	{
	}

	[Token(Token = "0x600C14B")]
	[Address(RVA = "0x1317890", Offset = "0x1317890", VA = "0x1317890")]
	public void SetWidth(int width)
	{
	}

	[Token(Token = "0x600C14C")]
	[Address(RVA = "0x131933C", Offset = "0x131933C", VA = "0x131933C")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600C14D")]
	[Address(RVA = "0x131A2F8", Offset = "0x131A2F8", VA = "0x131A2F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C14E")]
	[Address(RVA = "0x131A3A0", Offset = "0x131A3A0", VA = "0x131A3A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
