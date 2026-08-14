using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20022EA")]
internal class UIHUDRushingPetsMatchResultController : UIHudSingleFightMatchResultController
{
	[Token(Token = "0x400D9FB")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<TeammateStats> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600C05B")]
	[Address(RVA = "0x220DC18", Offset = "0x220DC18", VA = "0x220DC18")]
	public UIHUDRushingPetsMatchResultController()
	{
	}

	[Token(Token = "0x600C05C")]
	[Address(RVA = "0x220DC20", Offset = "0x220DC20", VA = "0x220DC20")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C05D")]
	[Address(RVA = "0x220DCC8", Offset = "0x220DCC8", VA = "0x220DCC8", Slot = "56")]
	protected override bool IsNeedShowAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x600C05E")]
	[Address(RVA = "0x220DD20", Offset = "0x220DD20", VA = "0x220DD20", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C05F")]
	[Address(RVA = "0x220DE40", Offset = "0x220DE40", VA = "0x220DE40", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600C060")]
	[Address(RVA = "0x220DFF8", Offset = "0x220DFF8", VA = "0x220DFF8", Slot = "63")]
	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C061")]
	[Address(RVA = "0x220E1FC", Offset = "0x220E1FC", VA = "0x220E1FC")]
	public new void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C062")]
	[Address(RVA = "0x220E278", Offset = "0x220E278", VA = "0x220E278", Slot = "59")]
	protected override void UpdateInfoTitles()
	{
	}

	[Token(Token = "0x600C063")]
	[Address(RVA = "0x220E2F8", Offset = "0x220E2F8", VA = "0x220E2F8", Slot = "61")]
	protected override UIHudSingleFightMatchResultItemController OpenItemController(TeammateStats data, bool single)
	{
		return null;
	}

	[Token(Token = "0x600C064")]
	[Address(RVA = "0x220E3E8", Offset = "0x220E3E8", VA = "0x220E3E8", Slot = "62")]
	protected override List<TeammateStats> ProcesssStatesList(List<TeammateStats> orgList, ulong localAccountID)
	{
		return null;
	}

	[Token(Token = "0x600C065")]
	[Address(RVA = "0x220E7F8", Offset = "0x220E7F8", VA = "0x220E7F8")]
	private static int _003CProcesssStatesList_003Em__0(TeammateStats a, TeammateStats b)
	{
		return default(int);
	}

	[Token(Token = "0x600C066")]
	[Address(RVA = "0x220E840", Offset = "0x220E840", VA = "0x220E840")]
	public bool _003C_003EiFixBaseProxy_IsNeedShowAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x600C067")]
	[Address(RVA = "0x220E848", Offset = "0x220E848", VA = "0x220E848")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C068")]
	[Address(RVA = "0x220E850", Offset = "0x220E850", VA = "0x220E850")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600C069")]
	[Address(RVA = "0x220E858", Offset = "0x220E858", VA = "0x220E858")]
	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}

	[Token(Token = "0x600C06A")]
	[Address(RVA = "0x220E860", Offset = "0x220E860", VA = "0x220E860")]
	public void _003C_003EiFixBaseProxy_UpdateInfoTitles()
	{
	}

	[Token(Token = "0x600C06B")]
	[Address(RVA = "0x220E868", Offset = "0x220E868", VA = "0x220E868")]
	public UIHudSingleFightMatchResultItemController _003C_003EiFixBaseProxy_OpenItemController(TeammateStats P0, bool P1)
	{
		return null;
	}

	[Token(Token = "0x600C06C")]
	[Address(RVA = "0x220E870", Offset = "0x220E870", VA = "0x220E870")]
	public List<TeammateStats> _003C_003EiFixBaseProxy_ProcesssStatesList(List<TeammateStats> P0, ulong P1)
	{
		return null;
	}
}
