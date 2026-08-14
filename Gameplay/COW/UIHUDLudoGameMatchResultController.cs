using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002196")]
internal class UIHUDLudoGameMatchResultController : UIHudSingleFightMatchResultController
{
	[Token(Token = "0x400D275")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<TeammateStats> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600B247")]
	[Address(RVA = "0x167E420", Offset = "0x167E420", VA = "0x167E420")]
	public UIHUDLudoGameMatchResultController()
	{
	}

	[Token(Token = "0x600B248")]
	[Address(RVA = "0x167E428", Offset = "0x167E428", VA = "0x167E428")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B249")]
	[Address(RVA = "0x167E4D0", Offset = "0x167E4D0", VA = "0x167E4D0", Slot = "56")]
	protected override bool IsNeedShowAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x600B24A")]
	[Address(RVA = "0x167E528", Offset = "0x167E528", VA = "0x167E528", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600B24B")]
	[Address(RVA = "0x167E648", Offset = "0x167E648", VA = "0x167E648", Slot = "45")]
	protected override int[] GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600B24C")]
	[Address(RVA = "0x167E754", Offset = "0x167E754", VA = "0x167E754", Slot = "63")]
	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B24D")]
	[Address(RVA = "0x167E958", Offset = "0x167E958", VA = "0x167E958")]
	public new void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B24E")]
	[Address(RVA = "0x167E9D4", Offset = "0x167E9D4", VA = "0x167E9D4", Slot = "59")]
	protected override void UpdateInfoTitles()
	{
	}

	[Token(Token = "0x600B24F")]
	[Address(RVA = "0x167EA7C", Offset = "0x167EA7C", VA = "0x167EA7C", Slot = "61")]
	protected override UIHudSingleFightMatchResultItemController OpenItemController(TeammateStats data, bool single)
	{
		return null;
	}

	[Token(Token = "0x600B250")]
	[Address(RVA = "0x167EB6C", Offset = "0x167EB6C", VA = "0x167EB6C", Slot = "62")]
	protected override List<TeammateStats> ProcesssStatesList(List<TeammateStats> orgList, ulong localAccountID)
	{
		return null;
	}

	[Token(Token = "0x600B251")]
	[Address(RVA = "0x167EF7C", Offset = "0x167EF7C", VA = "0x167EF7C")]
	private static int _003CProcesssStatesList_003Em__0(TeammateStats a, TeammateStats b)
	{
		return default(int);
	}

	[Token(Token = "0x600B252")]
	[Address(RVA = "0x167EFC4", Offset = "0x167EFC4", VA = "0x167EFC4")]
	public bool _003C_003EiFixBaseProxy_IsNeedShowAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x600B253")]
	[Address(RVA = "0x167EFCC", Offset = "0x167EFCC", VA = "0x167EFCC")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600B254")]
	[Address(RVA = "0x167EFD4", Offset = "0x167EFD4", VA = "0x167EFD4")]
	public new int[] _003C_003EiFixBaseProxy_GetInfoTypes()
	{
		return null;
	}

	[Token(Token = "0x600B255")]
	[Address(RVA = "0x167EFDC", Offset = "0x167EFDC", VA = "0x167EFDC")]
	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}

	[Token(Token = "0x600B256")]
	[Address(RVA = "0x167EFE4", Offset = "0x167EFE4", VA = "0x167EFE4")]
	public void _003C_003EiFixBaseProxy_UpdateInfoTitles()
	{
	}

	[Token(Token = "0x600B257")]
	[Address(RVA = "0x167EFEC", Offset = "0x167EFEC", VA = "0x167EFEC")]
	public UIHudSingleFightMatchResultItemController _003C_003EiFixBaseProxy_OpenItemController(TeammateStats P0, bool P1)
	{
		return null;
	}

	[Token(Token = "0x600B258")]
	[Address(RVA = "0x167EFF4", Offset = "0x167EFF4", VA = "0x167EFF4")]
	public List<TeammateStats> _003C_003EiFixBaseProxy_ProcesssStatesList(List<TeammateStats> P0, ulong P1)
	{
		return null;
	}
}
