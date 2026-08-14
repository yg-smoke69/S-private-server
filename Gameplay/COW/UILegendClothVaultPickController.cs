using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002905")]
public class UILegendClothVaultPickController : UINavigationController, _Attribute
{
	[Token(Token = "0x400FC9C")]
	[FieldOffset(Offset = "0x68")]
	private UILegendClothVaultPickView m_View;

	[Token(Token = "0x400FC9D")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelInventory m_UIModelInventory;

	[Token(Token = "0x400FC9E")]
	[FieldOffset(Offset = "0x70")]
	private List<UILegendClothVaultPickItemController> listPickItems;

	[Token(Token = "0x400FC9F")]
	private const int COUNT_GRID_CENTER_CHILDREN = 3;

	[Token(Token = "0x400FCA0")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60103F7")]
	[Address(RVA = "0x253F044", Offset = "0x253F044", VA = "0x253F044")]
	public UILegendClothVaultPickController()
	{
	}

	[Token(Token = "0x60103F8")]
	[Address(RVA = "0x253F0C8", Offset = "0x253F0C8", VA = "0x253F0C8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60103F9")]
	[Address(RVA = "0x253F16C", Offset = "0x253F16C", VA = "0x253F16C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60103FA")]
	[Address(RVA = "0x253F338", Offset = "0x253F338", VA = "0x253F338", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x60103FB")]
	[Address(RVA = "0x253F5C0", Offset = "0x253F5C0", VA = "0x253F5C0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60103FC")]
	[Address(RVA = "0x253F648", Offset = "0x253F648", VA = "0x253F648", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60103FD")]
	[Address(RVA = "0x253F714", Offset = "0x253F714", VA = "0x253F714", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60103FE")]
	[Address(RVA = "0x253F7A8", Offset = "0x253F7A8", VA = "0x253F7A8")]
	private void OnCloseBtn()
	{
	}

	[Token(Token = "0x60103FF")]
	[Address(RVA = "0x253F560", Offset = "0x253F560", VA = "0x253F560")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6010400")]
	[Address(RVA = "0x253F8B4", Offset = "0x253F8B4", VA = "0x253F8B4")]
	private void RefreshClothPickList()
	{
	}

	[Token(Token = "0x6010401")]
	[Address(RVA = "0x2540610", Offset = "0x2540610", VA = "0x2540610")]
	private static int _003CRefreshClothPickList_003Em__0(uint x, uint y)
	{
		return default(int);
	}

	[Token(Token = "0x6010402")]
	[Address(RVA = "0x2540740", Offset = "0x2540740", VA = "0x2540740")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010403")]
	[Address(RVA = "0x2540748", Offset = "0x2540748", VA = "0x2540748")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6010404")]
	[Address(RVA = "0x2540750", Offset = "0x2540750", VA = "0x2540750")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
