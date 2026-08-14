using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002475")]
public class UIHUDUGC_SceneObjectEntityAttributeEditItemController : UIEasyListItemController
{
	[Token(Token = "0x400E23A")]
	[FieldOffset(Offset = "0x38")]
	private UIHUDUGC_SceneObjectEntityAttributeEditItemView m_View;

	[Token(Token = "0x400E23B")]
	[FieldOffset(Offset = "0x3C")]
	private GALLODIEHAA m_Data;

	[Token(Token = "0x400E23C")]
	[FieldOffset(Offset = "0x40")]
	private List<PopMenuData> m_BoolMenuDataList;

	[Token(Token = "0x400E23D")]
	[FieldOffset(Offset = "0x44")]
	private UIPopMenuSmallControler m_BoolMenu;

	[Token(Token = "0x400E23E")]
	[FieldOffset(Offset = "0x48")]
	private bool m_CurrentBoolValue;

	[Token(Token = "0x400E23F")]
	[FieldOffset(Offset = "0x4C")]
	private int m_Index;

	[Token(Token = "0x400E240")]
	[FieldOffset(Offset = "0x50")]
	private FONLAPPBCOO m_Type;

	[Token(Token = "0x400E241")]
	[FieldOffset(Offset = "0x54")]
	private int m_BaseDepth;

	[Token(Token = "0x400E242")]
	private const string TRUE_KEY = "T_34_M_WS_TRUE";

	[Token(Token = "0x400E243")]
	private const string FALSE_KEY = "T_34_M_WS_FALSE";

	[Token(Token = "0x600CFBB")]
	[Address(RVA = "0x291CA60", Offset = "0x291CA60", VA = "0x291CA60")]
	public UIHUDUGC_SceneObjectEntityAttributeEditItemController()
	{
	}

	[Token(Token = "0x600CFBC")]
	[Address(RVA = "0x291CAEC", Offset = "0x291CAEC", VA = "0x291CAEC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CFBD")]
	[Address(RVA = "0x291CC0C", Offset = "0x291CC0C", VA = "0x291CC0C")]
	private void OnValueSubmit()
	{
	}

	[Token(Token = "0x600CFBE")]
	[Address(RVA = "0x291CDD4", Offset = "0x291CDD4", VA = "0x291CDD4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CFBF")]
	[Address(RVA = "0x291CE78", Offset = "0x291CE78", VA = "0x291CE78", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600CFC0")]
	[Address(RVA = "0x291C0B8", Offset = "0x291C0B8", VA = "0x291C0B8")]
	public void SetEntityType(FONLAPPBCOO type)
	{
	}

	[Token(Token = "0x600CFC1")]
	[Address(RVA = "0x291D7D4", Offset = "0x291D7D4", VA = "0x291D7D4")]
	private void GenerateBoolMenuData()
	{
	}

	[Token(Token = "0x600CFC2")]
	[Address(RVA = "0x291DC30", Offset = "0x291DC30", VA = "0x291DC30")]
	private void OnBoolMenuSelected(object obj)
	{
	}

	[Token(Token = "0x600CFC3")]
	[Address(RVA = "0x291C058", Offset = "0x291C058", VA = "0x291C058")]
	public void SetBaseDepth(int depth)
	{
	}

	[Token(Token = "0x600CFC4")]
	[Address(RVA = "0x291CFEC", Offset = "0x291CFEC", VA = "0x291CFEC")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600CFC5")]
	[Address(RVA = "0x291DD7C", Offset = "0x291DD7C", VA = "0x291DD7C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
