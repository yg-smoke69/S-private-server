using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002B25")]
public class UISPHudAirdropItemController : UIBaseController
{
	[Token(Token = "0x40108AF")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudAirdropItemView m_View;

	[Token(Token = "0x40108B0")]
	[FieldOffset(Offset = "0x2C")]
	private List<UISprite> m_Items;

	[Token(Token = "0x40108B1")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_AirdropPos;

	[Token(Token = "0x40108B2")]
	[FieldOffset(Offset = "0x3C")]
	private int m_Index;

	[Token(Token = "0x6011BD7")]
	[Address(RVA = "0x14351FC", Offset = "0x14351FC", VA = "0x14351FC")]
	public UISPHudAirdropItemController()
	{
	}

	[Token(Token = "0x6011BD8")]
	[Address(RVA = "0x14352B4", Offset = "0x14352B4", VA = "0x14352B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011BD9")]
	[Address(RVA = "0x143535C", Offset = "0x143535C", VA = "0x143535C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011BDA")]
	[Address(RVA = "0x1435678", Offset = "0x1435678", VA = "0x1435678")]
	public void SetData(int idx, List<MNGBAPBBJDC> pickups, Vector3 position)
	{
	}

	[Token(Token = "0x6011BDB")]
	[Address(RVA = "0x1435CD8", Offset = "0x1435CD8", VA = "0x1435CD8")]
	private void OnAirdropClick()
	{
	}

	[Token(Token = "0x6011BDC")]
	[Address(RVA = "0x1435F24", Offset = "0x1435F24", VA = "0x1435F24")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6011BDD")]
	[Address(RVA = "0x1435FDC", Offset = "0x1435FDC", VA = "0x1435FDC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
