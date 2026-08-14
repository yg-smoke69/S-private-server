using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002978")]
public class UIManualGrownItemController : UIBaseController
{
	[Token(Token = "0x400FF7E")]
	[FieldOffset(Offset = "0x28")]
	private UIManualGrownItemView m_View;

	[Token(Token = "0x400FF7F")]
	[FieldOffset(Offset = "0x2C")]
	private BaseItemInfo m_Data;

	[Token(Token = "0x400FF80")]
	[FieldOffset(Offset = "0x30")]
	private List<UISprite> m_IconList;

	[Token(Token = "0x400FF81")]
	[FieldOffset(Offset = "0x34")]
	private readonly uint DISABLE_COLOR;

	[Token(Token = "0x6010A2E")]
	[Address(RVA = "0x2C24A70", Offset = "0x2C24A70", VA = "0x2C24A70")]
	public UIManualGrownItemController()
	{
	}

	[Token(Token = "0x6010A2F")]
	[Address(RVA = "0x2C24B34", Offset = "0x2C24B34", VA = "0x2C24B34")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010A30")]
	[Address(RVA = "0x2C24BD8", Offset = "0x2C24BD8", VA = "0x2C24BD8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010A31")]
	[Address(RVA = "0x2C25434", Offset = "0x2C25434", VA = "0x2C25434", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010A32")]
	[Address(RVA = "0x2C25498", Offset = "0x2C25498", VA = "0x2C25498", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010A33")]
	[Address(RVA = "0x2C254FC", Offset = "0x2C254FC", VA = "0x2C254FC")]
	public void SetData(BaseItemInfo data)
	{
	}

	[Token(Token = "0x6010A34")]
	[Address(RVA = "0x2C2555C", Offset = "0x2C2555C", VA = "0x2C2555C")]
	public void RefreshView(UIManualGrownItemGroupController.State state)
	{
	}

	[Token(Token = "0x6010A35")]
	[Address(RVA = "0x2C25618", Offset = "0x2C25618", VA = "0x2C25618")]
	private void DoShowView(UIManualGrownItemGroupController.State state)
	{
	}

	[Token(Token = "0x6010A36")]
	[Address(RVA = "0x2C24D3C", Offset = "0x2C24D3C", VA = "0x2C24D3C")]
	private void InitIconList()
	{
	}

	[Token(Token = "0x6010A37")]
	[Address(RVA = "0x2C25834", Offset = "0x2C25834", VA = "0x2C25834")]
	private void SetIconColor(Color color)
	{
	}

	[Token(Token = "0x6010A38")]
	[Address(RVA = "0x2C25A58", Offset = "0x2C25A58", VA = "0x2C25A58")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x6010A39")]
	[Address(RVA = "0x2C25BA0", Offset = "0x2C25BA0", VA = "0x2C25BA0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010A3A")]
	[Address(RVA = "0x2C25BA8", Offset = "0x2C25BA8", VA = "0x2C25BA8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010A3B")]
	[Address(RVA = "0x2C25BB0", Offset = "0x2C25BB0", VA = "0x2C25BB0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
