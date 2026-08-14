using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002311")]
internal class UIRuleTableContainerController : UIBaseController
{
	[Token(Token = "0x400DAB1")]
	[FieldOffset(Offset = "0x28")]
	private UIRuleTableContainerView m_View;

	[Token(Token = "0x400DAB2")]
	[FieldOffset(Offset = "0x2C")]
	public CTableContainerData Data;

	[Token(Token = "0x400DAB3")]
	[FieldOffset(Offset = "0x30")]
	public Action DimensionsChanged;

	[Token(Token = "0x400DAB4")]
	[FieldOffset(Offset = "0x34")]
	public int OriginalHeight;

	[Token(Token = "0x400DAB5")]
	[FieldOffset(Offset = "0x38")]
	public int SelfPaddingY;

	[Token(Token = "0x400DAB6")]
	[FieldOffset(Offset = "0x3C")]
	public bool AutoBgExtension;

	[Token(Token = "0x400DAB7")]
	[FieldOffset(Offset = "0x40")]
	public int CustomBgExtension;

	[Token(Token = "0x400DAB8")]
	[FieldOffset(Offset = "0x44")]
	public bool ShouldRepostion;

	[Token(Token = "0x400DAB9")]
	[FieldOffset(Offset = "0x48")]
	protected UIModeEditGeneralComponentHelper m_GeneralHelper;

	[Token(Token = "0x400DABA")]
	[FieldOffset(Offset = "0x4C")]
	protected List<Transform> m_Components;

	[Token(Token = "0x400DABB")]
	[FieldOffset(Offset = "0x50")]
	protected float m_Width;

	[Token(Token = "0x400DABC")]
	[FieldOffset(Offset = "0x54")]
	protected float m_ChildWidth;

	[Token(Token = "0x400DABD")]
	[FieldOffset(Offset = "0x58")]
	protected float m_ExtendedHeight;

	[Token(Token = "0x600C1F4")]
	[Address(RVA = "0x14210E0", Offset = "0x14210E0", VA = "0x14210E0")]
	public UIRuleTableContainerController()
	{
	}

	[Token(Token = "0x600C1F5")]
	[Address(RVA = "0x1423790", Offset = "0x1423790", VA = "0x1423790")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C1F6")]
	[Address(RVA = "0x14212C4", Offset = "0x14212C4", VA = "0x14212C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C1F7")]
	[Address(RVA = "0x1421458", Offset = "0x1421458", VA = "0x1421458", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C1F8")]
	[Address(RVA = "0x142151C", Offset = "0x142151C", VA = "0x142151C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600C1F9")]
	[Address(RVA = "0x14215E0", Offset = "0x14215E0", VA = "0x14215E0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C1FA")]
	[Address(RVA = "0x1421714", Offset = "0x1421714", VA = "0x1421714")]
	public void SetViewData(CTableContainerData data, float width, float height)
	{
	}

	[Token(Token = "0x600C1FB")]
	[Address(RVA = "0x1422AFC", Offset = "0x1422AFC", VA = "0x1422AFC", Slot = "31")]
	protected virtual UIBaseController BuildChildComponent(Transform container, IModeEditComponentData data)
	{
		return null;
	}

	[Token(Token = "0x600C1FC")]
	[Address(RVA = "0x1424878", Offset = "0x1424878", VA = "0x1424878")]
	public void AddBGChanged(OnDimensionsChanged callback)
	{
	}

	[Token(Token = "0x600C1FD")]
	[Address(RVA = "0x1423D20", Offset = "0x1423D20", VA = "0x1423D20")]
	public void AddDimensionsChanged(Action callback)
	{
	}

	[Token(Token = "0x600C1FE")]
	[Address(RVA = "0x14249F0", Offset = "0x14249F0", VA = "0x14249F0")]
	protected void Reposition()
	{
	}

	[Token(Token = "0x600C1FF")]
	[Address(RVA = "0x1423838", Offset = "0x1423838", VA = "0x1423838")]
	public void RecalculateHeight()
	{
	}

	[Token(Token = "0x600C200")]
	[Address(RVA = "0x1424A4C", Offset = "0x1424A4C", VA = "0x1424A4C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600C201")]
	[Address(RVA = "0x1424B14", Offset = "0x1424B14", VA = "0x1424B14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C202")]
	[Address(RVA = "0x1424B1C", Offset = "0x1424B1C", VA = "0x1424B1C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C203")]
	[Address(RVA = "0x1424B24", Offset = "0x1424B24", VA = "0x1424B24")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600C204")]
	[Address(RVA = "0x1424B2C", Offset = "0x1424B2C", VA = "0x1424B2C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
