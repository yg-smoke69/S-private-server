using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002358")]
public class UISceneEditSubscriptionController : UIPopupWindowController, _Attribute, IConvertible
{
	[Token(Token = "0x400DC33")]
	[FieldOffset(Offset = "0x48")]
	private UISceneEditSubscriptionView m_View;

	[Token(Token = "0x400DC34")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelSceneEdit m_Model;

	[Token(Token = "0x400DC35")]
	[FieldOffset(Offset = "0x50")]
	private int m_CurrentSlotIndex;

	[Token(Token = "0x400DC36")]
	[FieldOffset(Offset = "0x54")]
	private string m_Code;

	[Token(Token = "0x400DC37")]
	[FieldOffset(Offset = "0x58")]
	private Action m_OnCloseCB;

	[Token(Token = "0x400DC38")]
	[FieldOffset(Offset = "0x5C")]
	private EUGCScene m_Source;

	[Token(Token = "0x600C504")]
	[Address(RVA = "0x2DAE5A8", Offset = "0x2DAE5A8", VA = "0x2DAE5A8")]
	public UISceneEditSubscriptionController()
	{
	}

	[Token(Token = "0x600C505")]
	[Address(RVA = "0x2DAE5B0", Offset = "0x2DAE5B0", VA = "0x2DAE5B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C506")]
	[Address(RVA = "0x2DAE654", Offset = "0x2DAE654", VA = "0x2DAE654", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C507")]
	[Address(RVA = "0x2DAEA5C", Offset = "0x2DAEA5C", VA = "0x2DAEA5C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C508")]
	[Address(RVA = "0x2DAEBB4", Offset = "0x2DAEBB4", VA = "0x2DAEBB4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C509")]
	[Address(RVA = "0x2DAEC34", Offset = "0x2DAEC34", VA = "0x2DAEC34")]
	private void OnSelectBtnClick()
	{
	}

	[Token(Token = "0x600C50A")]
	[Address(RVA = "0x2DAEDB0", Offset = "0x2DAEDB0", VA = "0x2DAEDB0")]
	private void OnOverwriteBtnClick()
	{
	}

	[Token(Token = "0x600C50B")]
	[Address(RVA = "0x2DAF120", Offset = "0x2DAF120", VA = "0x2DAF120")]
	public void SetCode(string code, EUGCScene source, [Optional] Action onCloseCB)
	{
	}

	[Token(Token = "0x600C50C")]
	[Address(RVA = "0x2DAF1A4", Offset = "0x2DAF1A4", VA = "0x2DAF1A4")]
	private void OnItemSelected(object[] data)
	{
	}

	[Token(Token = "0x600C50D")]
	[Address(RVA = "0x2DAF2F0", Offset = "0x2DAF2F0", VA = "0x2DAF2F0")]
	private void RefreshUIData(SceneEditSlotInfo info)
	{
	}

	[Token(Token = "0x600C50E")]
	[Address(RVA = "0x2DAFB44", Offset = "0x2DAFB44", VA = "0x2DAFB44", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C50F")]
	[Address(RVA = "0x2DAFC3C", Offset = "0x2DAFC3C", VA = "0x2DAFC3C", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C510")]
	[Address(RVA = "0x2DAFCB8", Offset = "0x2DAFCB8", VA = "0x2DAFCB8", Slot = "48")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600C511")]
	[Address(RVA = "0x2DAFF54", Offset = "0x2DAFF54", VA = "0x2DAFF54", Slot = "49")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600C512")]
	[Address(RVA = "0x2DAFFE8", Offset = "0x2DAFFE8", VA = "0x2DAFFE8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C513")]
	[Address(RVA = "0x2DAFFF0", Offset = "0x2DAFFF0", VA = "0x2DAFFF0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600C514")]
	[Address(RVA = "0x2DAFFF8", Offset = "0x2DAFFF8", VA = "0x2DAFFF8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
