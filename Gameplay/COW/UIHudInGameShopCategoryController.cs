using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200277F")]
internal class UIHudInGameShopCategoryController : UIBaseController
{
	[Token(Token = "0x400F3E9")]
	[FieldOffset(Offset = "0x28")]
	private UIHudInGameShopCategoryView m_View;

	[Token(Token = "0x400F3EA")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Category;

	[Token(Token = "0x400F3EB")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Transform> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170011CA")]
	public int Category
	{
		[Token(Token = "0x600F259")]
		[Address(RVA = "0x229B0B0", Offset = "0x229B0B0", VA = "0x229B0B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600F258")]
	[Address(RVA = "0x229B02C", Offset = "0x229B02C", VA = "0x229B02C")]
	public UIHudInGameShopCategoryController()
	{
	}

	[Token(Token = "0x600F25A")]
	[Address(RVA = "0x229B108", Offset = "0x229B108", VA = "0x229B108")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F25B")]
	[Address(RVA = "0x229B1B0", Offset = "0x229B1B0", VA = "0x229B1B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F25C")]
	[Address(RVA = "0x229B26C", Offset = "0x229B26C", VA = "0x229B26C")]
	public void SetUIData(uint category, List<MCOMKOKDDHE> itemList)
	{
	}

	[Token(Token = "0x600F25D")]
	[Address(RVA = "0x229B75C", Offset = "0x229B75C", VA = "0x229B75C")]
	private void SetCategoryLabel(uint filter)
	{
	}

	[Token(Token = "0x600F25E")]
	[Address(RVA = "0x229BEDC", Offset = "0x229BEDC", VA = "0x229BEDC")]
	private static int _003CSetUIData_003Em__0(Transform item1, Transform item2)
	{
		return default(int);
	}

	[Token(Token = "0x600F25F")]
	[Address(RVA = "0x229C0E0", Offset = "0x229C0E0", VA = "0x229C0E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
