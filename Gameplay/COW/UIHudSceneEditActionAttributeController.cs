using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200231F")]
public class UIHudSceneEditActionAttributeController : UIBaseController
{
	[Token(Token = "0x400DAF6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudSceneEditActionAttributeView m_View;

	[Token(Token = "0x400DAF7")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIBaseController> m_AttributeItemUI;

	[Token(Token = "0x400DAF8")]
	[FieldOffset(Offset = "0x30")]
	private float mAttributeHeight;

	[Token(Token = "0x400DAF9")]
	[FieldOffset(Offset = "0x34")]
	private SceneEditPrefabConfigData mConfigData;

	[Token(Token = "0x400DAFA")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsInfoPanelShow;

	[Token(Token = "0x400DAFB")]
	[FieldOffset(Offset = "0x39")]
	private bool m_IsLastPlayerShowAttributeTab;

	[Token(Token = "0x400DAFC")]
	[FieldOffset(Offset = "0x3A")]
	private bool m_IsAttributeTabEnabel;

	[Token(Token = "0x400DAFD")]
	[FieldOffset(Offset = "0x3B")]
	private bool m_IsTipTabEnable;

	[Token(Token = "0x400DAFE")]
	[FieldOffset(Offset = "0x3C")]
	private int m_DefaultTabHeight;

	[Token(Token = "0x400DAFF")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsGraphEnabled;

	[Token(Token = "0x400DB00")]
	[FieldOffset(Offset = "0x44")]
	private string m_LogicEntityId;

	[Token(Token = "0x170010B6")]
	private bool m_IsOnlyOneTab
	{
		[Token(Token = "0x600C2A9")]
		[Address(RVA = "0x1C4CC7C", Offset = "0x1C4CC7C", VA = "0x1C4CC7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600C2A7")]
	[Address(RVA = "0x1C4CB08", Offset = "0x1C4CB08", VA = "0x1C4CB08")]
	public UIHudSceneEditActionAttributeController()
	{
	}

	[Token(Token = "0x600C2A8")]
	[Address(RVA = "0x1C4CBD8", Offset = "0x1C4CBD8", VA = "0x1C4CBD8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C2AA")]
	[Address(RVA = "0x1C4CCF8", Offset = "0x1C4CCF8", VA = "0x1C4CCF8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C2AB")]
	[Address(RVA = "0x1C4D420", Offset = "0x1C4D420", VA = "0x1C4D420")]
	private void OnColorMaskClick(object[] data)
	{
	}

	[Token(Token = "0x600C2AC")]
	[Address(RVA = "0x1C4DB3C", Offset = "0x1C4DB3C", VA = "0x1C4DB3C")]
	private void OnResMgrPanelFolder(object[] data)
	{
	}

	[Token(Token = "0x600C2AD")]
	[Address(RVA = "0x1C4E11C", Offset = "0x1C4E11C", VA = "0x1C4E11C")]
	private void OnClickAttributeColorBtn()
	{
	}

	[Token(Token = "0x600C2AE")]
	[Address(RVA = "0x1C4E2CC", Offset = "0x1C4E2CC", VA = "0x1C4E2CC")]
	private void OnClickAttributeSettingBtn()
	{
	}

	[Token(Token = "0x600C2AF")]
	[Address(RVA = "0x1C4E484", Offset = "0x1C4E484", VA = "0x1C4E484")]
	private bool HasCustomAttribute()
	{
		return default(bool);
	}

	[Token(Token = "0x600C2B0")]
	[Address(RVA = "0x1C4E580", Offset = "0x1C4E580", VA = "0x1C4E580")]
	public void RefreshItemInfo(List<ItemEditAttributeUIData> uiDatas, SceneEditPrefabConfigData itemPrefabConfigData, List<ItemFunctionUIData> funcDataList)
	{
	}

	[Token(Token = "0x600C2B1")]
	[Address(RVA = "0x1C4D49C", Offset = "0x1C4D49C", VA = "0x1C4D49C")]
	private void RefreshColorView()
	{
	}

	[Token(Token = "0x600C2B2")]
	[Address(RVA = "0x1C50034", Offset = "0x1C50034", VA = "0x1C50034")]
	private void RefeshTab()
	{
	}

	[Token(Token = "0x600C2B3")]
	[Address(RVA = "0x1C502C0", Offset = "0x1C502C0", VA = "0x1C502C0")]
	private void SetTabState(bool isSelect, UISprite tabBag, UISprite tabIcon, UIButton tabBtn, GameObject infoPanelRoot)
	{
	}

	[Token(Token = "0x600C2B4")]
	[Address(RVA = "0x1C504E4", Offset = "0x1C504E4", VA = "0x1C504E4")]
	private void OnEditNameClick()
	{
	}

	[Token(Token = "0x600C2B5")]
	[Address(RVA = "0x1C50574", Offset = "0x1C50574", VA = "0x1C50574")]
	private void OnNameReset()
	{
	}

	[Token(Token = "0x600C2B6")]
	[Address(RVA = "0x1C50864", Offset = "0x1C50864", VA = "0x1C50864")]
	private void OnNameSubmit()
	{
	}

	[Token(Token = "0x600C2B7")]
	[Address(RVA = "0x1C50B68", Offset = "0x1C50B68", VA = "0x1C50B68")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600C2B8")]
	[Address(RVA = "0x1C4FE00", Offset = "0x1C4FE00", VA = "0x1C4FE00")]
	private string GetCoordinateString(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x600C2B9")]
	[Address(RVA = "0x1C50DF4", Offset = "0x1C50DF4", VA = "0x1C50DF4")]
	private void OnTipTabClick()
	{
	}

	[Token(Token = "0x600C2BA")]
	[Address(RVA = "0x1C50E6C", Offset = "0x1C50E6C", VA = "0x1C50E6C")]
	private void OnAttributeTabBtnClick()
	{
	}

	[Token(Token = "0x600C2BB")]
	[Address(RVA = "0x1C4DCC0", Offset = "0x1C4DCC0", VA = "0x1C4DCC0")]
	private void OnCloseInfoPanel()
	{
	}

	[Token(Token = "0x600C2BC")]
	[Address(RVA = "0x1C4F4FC", Offset = "0x1C4F4FC", VA = "0x1C4F4FC")]
	public void CreateAttributeItemUI(ItemEditAttributeUIData uiData)
	{
	}

	[Token(Token = "0x600C2BD")]
	[Address(RVA = "0x1C4FC30", Offset = "0x1C4FC30", VA = "0x1C4FC30")]
	public void CreateFuncAttributeUI(ItemFunctionUIData uidata)
	{
	}

	[Token(Token = "0x600C2BE")]
	[Address(RVA = "0x1C50EE4", Offset = "0x1C50EE4", VA = "0x1C50EE4")]
	public void OnOpenGraphButtonClick()
	{
	}

	[Token(Token = "0x600C2BF")]
	[Address(RVA = "0x1C51378", Offset = "0x1C51378", VA = "0x1C51378")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600C2C0")]
	[Address(RVA = "0x1C513C0", Offset = "0x1C513C0", VA = "0x1C513C0")]
	private void _003COnUIInit_003Em__1()
	{
	}

	[Token(Token = "0x600C2C1")]
	[Address(RVA = "0x1C51400", Offset = "0x1C51400", VA = "0x1C51400")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
