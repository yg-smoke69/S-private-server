using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200232D")]
internal class UIHudSceneEditFuncAttributeSettingController : UIPopupWindowController
{
	[Token(Token = "0x400DB35")]
	[FieldOffset(Offset = "0x48")]
	private UIHudSceneEditFuncAttributeSettingView m_View;

	[Token(Token = "0x400DB36")]
	[FieldOffset(Offset = "0x4C")]
	private LLIBMMFAGDN m_Data;

	[Token(Token = "0x400DB37")]
	[FieldOffset(Offset = "0x50")]
	private SceneEditObjectAttrBase curAttr;

	[Token(Token = "0x600C31B")]
	[Address(RVA = "0x1C5C910", Offset = "0x1C5C910", VA = "0x1C5C910")]
	public UIHudSceneEditFuncAttributeSettingController()
	{
	}

	[Token(Token = "0x600C31C")]
	[Address(RVA = "0x1C5C918", Offset = "0x1C5C918", VA = "0x1C5C918", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C31D")]
	[Address(RVA = "0x1C5CB08", Offset = "0x1C5CB08", VA = "0x1C5CB08", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600C31E")]
	[Address(RVA = "0x1C5CC3C", Offset = "0x1C5CC3C", VA = "0x1C5CC3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C31F")]
	[Address(RVA = "0x1C5CCE0", Offset = "0x1C5CCE0", VA = "0x1C5CCE0")]
	public void SetUGCAttributeSettingUIData(LLIBMMFAGDN data)
	{
	}

	[Token(Token = "0x600C320")]
	[Address(RVA = "0x1C5CEF8", Offset = "0x1C5CEF8", VA = "0x1C5CEF8")]
	private void BuildChildComponent(Transform container, IModeEditComponentData data)
	{
	}

	[Token(Token = "0x600C321")]
	[Address(RVA = "0x1C5D124", Offset = "0x1C5D124", VA = "0x1C5D124")]
	private void UpdateDepths(Transform subObject, int depth)
	{
	}

	[Token(Token = "0x600C322")]
	[Address(RVA = "0x1C5D40C", Offset = "0x1C5D40C", VA = "0x1C5D40C")]
	private void OnBtnResetClick()
	{
	}

	[Token(Token = "0x600C323")]
	[Address(RVA = "0x1C5D510", Offset = "0x1C5D510", VA = "0x1C5D510", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C324")]
	[Address(RVA = "0x1C5D654", Offset = "0x1C5D654", VA = "0x1C5D654")]
	private void OnEnterGetter(object[] data)
	{
	}

	[Token(Token = "0x600C325")]
	[Address(RVA = "0x1C5D750", Offset = "0x1C5D750", VA = "0x1C5D750")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C326")]
	[Address(RVA = "0x1C5D758", Offset = "0x1C5D758", VA = "0x1C5D758")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600C327")]
	[Address(RVA = "0x1C5D760", Offset = "0x1C5D760", VA = "0x1C5D760")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
